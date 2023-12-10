using Core;
using Core.Models;
using Core.Models.enums;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DoctorServices : IDoctorServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public DoctorServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<object>> GetAllBookings(String id, int skip, int take)
        {
            var user = await _unitOfWork.Time.GetAll();
            var d = await _unitOfWork.Users.GetAll();
            var w = await _unitOfWork.Appointments.GetAll();
            var doctor = await _unitOfWork.Doctors.Find(a => a.userId == id);
            var Allbookings = await _unitOfWork.Requests.GetAll(a => a.doctorId == doctor.id);
            /*var appointments = await _unitOfWork.Appointments.GetAll();
            var times = await _unitOfWork.time.GetAll();
            var users = await _unitOfWork.Users.GetAll();
            var doctors = await _unitOfWork.Doctors.GetAll();
            var appointmentTime =  from ti in times
                                  join ap in appointments on ti.appointment.id equals ap.id
                                  select new 
                                  {
                                      ti.id,
                                      ti.time,
                                      day = ap.day.ToString()
                                  };



            var q = from b in Allbookings
                    join u in users on b.pationtId equals u.Id
                    join p in appointmentTime on b.time.id equals p.id
                    select new
                    {
                        u.UserName,
                        u.image,
                        u.dateOfBirth,
                        Gender = u.gender.ToString(),
                        u.PhoneNumber,
                        u.Email,
                        p.time,
                        day = p.day.ToString(),
                        requestType = b.requestType.ToString()
                  };
            */
            return Allbookings.Skip(skip).Take(take).Select(a => new
            {
                a.pationt.UserName,
                a.pationt.image,
                a.pationt.dateOfBirth,
                gender = a.pationt.gender.ToString(),
                a.pationt.PhoneNumber,
                a.pationt.Email,
                day = a.time.appointment.day.ToString(),
                a.time.time,
            });
            
        }
        public async Task<bool> ConfirmCheckUp(string doctorId, int requestId, RequestType request) 
        {
            var doctor = await _unitOfWork.Doctors.Find(a => a.userId == doctorId);
            var Request = await _unitOfWork.Requests.Find(a =>a.id == requestId);
            if (Request != null && doctor.id == Request.doctorId)
            {
                Request.requestType = request;
                _unitOfWork.Complete();
                return true;
            }
            return false;
        }

        public async Task<bool> AddAppointment(string id,List<DayTime> dayTimes)
        {
            //Days[] d = new Days[7];
          var user = await _unitOfWork.Users.GetById(id);
          var doctor =  await  _unitOfWork.Doctors.Find(a => a.userId == user.Id);
            if (doctor != null)
            {
                var oldAppointment = await _unitOfWork.Appointments.GetWhere(a => a.doctorId == doctor.id);
                Appointment appoint = null;
                Time time = null;
                foreach (DayTime day in dayTimes)
                {
                    if (!oldAppointment.Any(a => a.day == day.days)){
                        appoint =  new Appointment()
                        {
                            day = day.days,
                            doctorId = doctor.id,
                        };
                        await _unitOfWork.Appointments.Add(appoint);
                        foreach (double t in day.times)
                        {
                            time = new Time()
                            {
                                time = t,
                                status = false,
                                appointment = appoint,
                            };
                            
                            await _unitOfWork.Time.Add(time);
                        }
                    };
                }
                if (appoint != null && time != null)
                {
                _unitOfWork.Complete();
                    return true;
                }
            }
            return false;
        }

        public async Task<bool> UpdateAppointment(string id , Double oldTime , Double newTime)
        {
            //var user = await _unitOfWork.Users.GetById(id);
            //var user = await _unitOfWork.Users.GetAll();
            //var a = await _unitOfWork.Appointments.GetAll();
            var v = await _unitOfWork.Time.GetWhere(a => a.appointment.doctor.userId == id);
            if (v != null)
            {
                var w =  v.Where(a =>  a.time == oldTime);
                if (w != null)
                {
                    var check = false;
                    foreach (var time in w)
                    {
                        if(!time.status)
                        {
                            time.time = newTime;
                            check = true;
                        }
                    }
                    if (check)
                    {
                        _unitOfWork.Complete();
                        return true;
                    }
                }
                //var o =  v.ToList().Find(a => a.time == oldTime);
                //if(o != null && o.status != true)
                //{
                //    o.time = newTime;
                //    _unitOfWork.Complete();
                //    return true;
                //}
            }
            return false;
        }

        public async Task<bool> DeleteAppointment(string id,double time)
        {
            var v = await _unitOfWork.Time.GetWhere(a=> a.appointment.doctor.userId == id);
            if(v != null)
            {
                var t =  v.ToList().Find(a => a.time == time);
                if (t != null && t.status != true)
                {
                    await _unitOfWork.Time.Delete(t);
                    _unitOfWork.Complete();
                    return true;
                }
            }
            return false;
        }

    }
}
