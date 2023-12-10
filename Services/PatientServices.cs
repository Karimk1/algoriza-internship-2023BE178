using Azure.Core;
using Core;
using Core.Models;
using Core.Models.enums;
using Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PatientServices : IPatientServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientServices(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Book(String userId, int timeId,  String code = null)
        {
            var time = await _unitOfWork.Time.Find(a => a.id == timeId);
            var app = await _unitOfWork.Appointments.GetAll();
            var doctor = await _unitOfWork.Doctors.Find(a => a.id == time.appointment.doctorId);
          //  var requests = await _unitOfWork.requests.GetWhere(a => a.doctorId == time.appointment.DoctorId);
            var specialize = await _unitOfWork.Specializes.Find(a => a.id == doctor.specializeId);
            if (time != null && time.status != true) 
            {
                if (code  == null)
                {
                    Requests request = new Requests()
                    {
                        doctorId = doctor.id,
                        timeId = timeId,
                        pationtId = userId,
                        requestType = RequestType.Pending,
                        requestDate = DateTime.Now,
                        finalPrice = doctor.price,
                    };
                    doctor.numberOfRequests = doctor.numberOfRequests+1;
                    specialize.numberOfRequest = specialize.numberOfRequest+1;
                    await _unitOfWork.Requests.Add(request);
                    time.status = true;
                    _unitOfWork.Complete();
                    return true;
                }
                else
                {
                    var oldReq = await _unitOfWork.Requests.GetWhere(a => a.pationtId == userId);
                    var requestNum = oldReq.Where(a=> a.requestType  == RequestType.Complete).Count();

                    var coupon = await _unitOfWork.Coupons.Find(a => a.discoundCode == code);
                    if(requestNum >= 5 && coupon is not null && coupon.active)
                    {
                        var finalprice = 0.0;
                        if (coupon.discoundType == DiscoundType.Value)
                        { 
                            finalprice = doctor.price - coupon.discoundValue;
                        }
                        else
                        {
                            finalprice = doctor.price - (doctor.price * coupon.discoundValue / 100);
                        }
                        Requests request = new Requests()
                        {
                            doctorId = doctor.id,
                            timeId = timeId,
                            pationtId = userId,
                            requestType = RequestType.Pending,
                            requestDate = DateTime.Now,
                            finalPrice = finalprice,
                            couponId = coupon.id
                        };
                        await _unitOfWork.Requests.Add(request);
                        doctor.numberOfRequests++;
                        specialize.numberOfRequest++;
                        coupon.usage++;
                        time.status = true;
                        _unitOfWork.Complete();
                        return true;
                    }
                }
            }
                return false;
        }

        public async Task<bool> CancelBooking(int requestId)
        {
            var request = await _unitOfWork.Requests.Find(a=> a.id == requestId);
            if(request != null && request.requestType == RequestType.Pending)
            {
                var time = await _unitOfWork.Time.Find(a=> a.id == request.timeId);
                time.status = false;
                request.requestType = RequestType.Canceled;
                _unitOfWork.Complete();
                return true;
            }
            return false;
            
        }

        public async Task<IEnumerable<object>> GetAllDoctors()
        {
            var doctors = await _unitOfWork.Doctors.GetAll();
            var users = await _unitOfWork.Users.GetAll();
            //var times = await _unitOfWork.time.GetAll();
            var Appointment = await _unitOfWork.Appointments.GetAllinclude(a => a.times);
            var cc = from a in Appointment
                     select new
                     {
                         a.doctorId,
                         day = a.day.ToString(),
                         time =  a.times.Select(a => a.time),
                         status = a.times.Select(a => a.status),
                     };
            var doctorUser = from d in doctors
                             join u in users on d.userId equals u.Id
                             select new
                             {
                                 d.id,
                                 u.UserName,
                                 u.image,
                                 u.Email,
                                 u.gender,
                                 u.PhoneNumber,
                                 spec = d.specializeId.ToString(),
                                 d.price
                             };
            //var appointmentTime = from t in times
            //                      join a in appointment on t.appointment.id equals a.id
            //                      select new
            //                      {
            //                          t.time,
            //                          a.DoctorId,
            //                          a.day,
            //                      };
            var q = from u in doctorUser
                        //join a in cc on u.id equals a.DoctorId
                    select new
                    {
                        u.image,
                        u.UserName,
                        u.Email,
                        u.PhoneNumber,
                        u.spec,
                        u.price,
                        gender = u.gender.ToString(),
                        appointments = cc.Where(x =>  x.doctorId == u.id ).Select(a => new { a.day, a.time }),
                        //day = a.day.ToString(),
                        //a.time
                    };
            return q;
        }

        public async Task<IEnumerable<object>> GetPationtBooking(String id) 
        {
            var b = await _unitOfWork.Requests.GetWhere(a => a.pationtId == id);
            if(b != null)
            return b.Select(a => new
            {
                a.doctor.user.image,
                a.doctor.user.UserName,
                a.doctor.specialize.specializeName,
                a.time.time,
                day = a.time.appointment.day.ToString(),
                a.doctor.price,
                a.coupon.discoundCode,
                a.finalPrice,
                status = a.requestType.ToString(),
            });
            return b ;
        }  
    }
}
