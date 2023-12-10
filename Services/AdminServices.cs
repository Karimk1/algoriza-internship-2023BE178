using Core;
using Core.Models;
using Core.Models.enums;
using Core.Repository;
using Core.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AdminServices : IAdminServices
    {
        
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;
        private readonly IHostingEnvironment _hostingEnvironment;
        public AdminServices(IUnitOfWork unitOfWork, UserManager<User> userManager, IHostingEnvironment hostingEnvironment )
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<IEnumerable<object>> GetAllDoctor(int skip, int take, Expression<Func<object,bool>> search = null)
        {
            var doctor = await _unitOfWork.Doctors.GetAll();
            var user = await _unitOfWork.Users.GetAll();
            var specialize = await _unitOfWork.Specializes.GetAll();

            //var s =  from d in doctor
            //        join u in user on d.UserId equals u.Id
            //        join j in specialize on d.SpecializeId equals j.id
            //        select new
            //        {
            //            u.image,
            //             u.UserName,
            //             u.Email,
            //             u.PhoneNumber,
            //             j.specializeName,
            //            gender = u.gender.ToString(),
            //        };



            //Console.WriteLine("siiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii");
            //Console.WriteLine(s.ToList());
            if(doctor == null)
            {
                return Enumerable.Empty<object>();
            } 

            return doctor.Skip(skip).Take(take).Select(a => new
            {
                a.user.image,
                a.user.UserName,
                a.user.Email,
                a.user.PhoneNumber,
                a.specialize.specializeName,
                gender = a.user.gender.ToString()
            }); ;
        }
        public async Task<IEnumerable<Appointment>> GetAllAppointment()
        {
            return await _unitOfWork.Appointments.GetAll();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            return _unitOfWork.Users.GetAll();
        }

        

        public async Task<IEnumerable<Specialize>> GetAllspecialization()
        {
            return await _unitOfWork.Specializes.GetAll();
        }

        public async Task<int> NumberOfDoctors()
        {
            return await _unitOfWork.Doctors.Count();
        }
        
        public async Task<int> NumberOfPationts()
        {
            return await _unitOfWork.Users.Count(a=> a.role == Role.Patient);
        }
        public async Task<IEnumerable<object>> NumberOfRequests()
        {
            var requests = await _unitOfWork.Requests.GetAll();
            var count =  requests.GroupBy(a => a.requestType.ToString()).Select(b => new
            {
                type = b.Key,
                count = b.Count()
            });
            
            return count;
        }
        public async Task<IEnumerable<object>> TopSpecialize()
        {
            var specialization = await _unitOfWork.Specializes.GetAll(null, a => a.numberOfRequest, 5, null);

            return specialization.Select(a => new
            {
                a.specializeName,
                a.numberOfRequest,
            });
        }
        public async Task<IEnumerable<object>> TopDoctor()
        {
            var doctor = await _unitOfWork.Doctors.GetAll(null , a => a.numberOfRequests, 10, null);
            var user = await _unitOfWork.Users.GetAll();
            var specialize = await _unitOfWork.Specializes.GetAll();

            //var s = from d in doctor
            //        join u in user on d.UserId equals u.Id
            //        join j in specialize on d.SpecializeId equals j.id
            //        select new 
            //        {
            //            name = u.UserName,
            //            email = u.Email,
            //            phone = u.PhoneNumber,
            //            specialize = j.specializeName,
            //            gender = u.gender
            //        };
            //await _unitOfWork.Doctors.GetAll(new[] { "User", "Specialize" }, a => a.numberOfRequests, 10, null);
            return doctor.Select(a => new 
            {
                a.user.image,
                a.user.UserName,
                a.specialize.specializeName,
                a.numberOfRequests,
            });

        }
        public async Task<DoctorViewModel> GetDoctorById(int id)
        {
            var doctor = await _unitOfWork.Doctors.GetById(id);
            var specialize = await _unitOfWork.Specializes.Find(a=>a.id == doctor.specializeId);
            var User = await _unitOfWork.Users.Find(a => a.Id == doctor.userId);
            if(doctor != null)
            { 
                return new DoctorViewModel
                {
                    image = doctor.user.image,
                    name = doctor.user.UserName,
                    email = doctor.user.Email,
                    phone = doctor.user.PhoneNumber,
                    specialize = doctor.specialize.specializeName,
                    gander = doctor.user.gender.ToString(),
                    dateOfBirth = doctor.user.dateOfBirth.ToShortDateString(),
                };                   
            }
            return null;
        }

        public async Task<IEnumerable<object>> GetAllPationts(int skip , int take)
        {
            var pationts = await _unitOfWork.Users.GetAll(a => a.role == Role.Patient);
            return pationts.Skip(skip).Take(take).Select(a => new
            {
                a.image,
                a.UserName,
                a.Email,
                a.PhoneNumber,
                gender = a.gender.ToString(),
                dateOfBirth = a.dateOfBirth.ToShortDateString()
            } );
        }

        public async Task<object> GetPationtById(String id)
        {
            var user = await _unitOfWork.Users.GetById(id);

            if (user != null && user.role == Role.Patient)
            {
                var requests = await _unitOfWork.Requests.GetWhere(a => a.pationtId == id);

                return new
                {
                    image = user.image,
                    name = user.UserName,
                    email = user.Email,
                    phone = user.PhoneNumber,
                    gender = user.gender.ToString(),
                    dateOfBirth = user.dateOfBirth.ToShortDateString(),
                    request = requests.Select(a => new { day = a.time.appointment.day.ToString(),a.time.time})
                };
            }
            else
            {
                throw new Exception("Wrong id");
            }
        }

        public async Task<AuthModel> AddDoctor(DoctorModel model)
        {

            if (await _userManager.FindByEmailAsync(model.email) is not null)
                return new AuthModel { Massage = "Email is already used" };
            if (await _userManager.FindByNameAsync(model.firstname + " " + model.lastname) is not null)
                return new AuthModel { Massage = "UserName is already used" };

            String uniqeFileName = null;
            if (model.image != null)
            {
               // byte[] imageBytes = Convert.FromBase64String(model.image.FileName);
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                uniqeFileName = Guid.NewGuid().ToString() + "_" + model.image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqeFileName);
                model.image.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            var user = new User
            {
                image = uniqeFileName,
                UserName = model.firstname,
                Email = model.email,
                gender = model.gender,
                dateOfBirth = model.dateOfbirth,
                PhoneNumber = model.phone,
                role = Role.Doctor,
            };
            var result = await _userManager.CreateAsync(user, password: model.password);
            if (!result.Succeeded)
            {
                var errors = String.Empty;
                foreach (var error in result.Errors)
                {
                    errors += $"{error.Description} , ";
                }
                return new AuthModel { Massage = errors };
            }
            await _userManager.AddToRoleAsync(user, "Doctor");

            //var jwtSecurityToken = await CreateJwtToken(user);
            // var addInUser = await _unitOfWork.Users.Add(user);


            Doctor doctor = new Doctor()
            {
                specializeId = model.specialize,
                numberOfRequests = 0,
                price = model.price,
                userId = user.Id,
            };
            var addInDoctor = await _unitOfWork.Doctors.Add(doctor);
            if (addInDoctor == null) 
            {
                return new AuthModel { Massage = "somethink wrong" };
            }

            _unitOfWork.Complete();
            
            return new AuthModel
            {
                Email = user.Email,
                Username = user.UserName,
                IsAuthenticated = true,
                Roles = new List<string> { "Doctor" },
            };
        }
        public async Task<bool> UpdateDoctor(int id , DoctorModel model)
        {
            var doctor = await _unitOfWork.Doctors.GetById(id);
            var user = await _unitOfWork.Users.Find(a => a.Id == doctor.userId);
            String uniqeFileName = null;
            if (doctor != null)
            {
                if (model.image != null)
                {
                    //byte[] imageBytes = Convert.FromBase64String(model.image.FileName);
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    uniqeFileName = Guid.NewGuid().ToString() + "_" + model.image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqeFileName);
                    model.image.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                doctor.user.UserName =  model.firstname+ " " + model.lastname;
                doctor.price = model.price;
                doctor.specializeId = model.specialize;
                doctor.user.dateOfBirth = model.dateOfbirth;
                doctor.user.image = uniqeFileName;
                doctor.user.Email = model.email;
                doctor.user.gender = model.gender;
                doctor.user.PhoneNumber = model.phone;

                var updatedd = await _unitOfWork.Doctors.Update(doctor);
                var useru = await _unitOfWork.Users.Update(user);
                if (updatedd != null && useru != null) 
                {
                    _unitOfWork.Complete();
                    return true;
                }   
            }
            return false;
           
        }

        public async Task<bool> DeleteDoctor(int id)
        {
            var doctor = await _unitOfWork.Doctors.Find(a => a.id == id);
            var requests = await _unitOfWork.Requests.GetWhere(b => b.doctorId == id);
            var pending = requests.Any(a => a.requestType == RequestType.Pending);
            
            if(doctor != null && !pending)
            {
                var user = await _unitOfWork.Users.Find(a => a.Id == doctor.userId);
                var deleted = await _unitOfWork.Doctors.Delete(doctor);
                var deleteu = await _unitOfWork.Users.Delete(user);
                _unitOfWork.Complete();
                return true;
            }
            return false;
        }

        public async Task<bool> AddCoupon(Coupon coupon)
        {
            var c = await _unitOfWork.Coupons.Add(coupon);
            if(c != null)
            {
                _unitOfWork.Complete();
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateCoupon(int couponId ,Coupon coupon)
        {
            var couponToUpdate = await _unitOfWork.Coupons.GetById(couponId);
            if(couponToUpdate != null && couponToUpdate.usage == 0) 
            {
              
                couponToUpdate.discoundCode = coupon.discoundCode;
                couponToUpdate.discoundValue = coupon.discoundValue;
                couponToUpdate.discoundType = coupon.discoundType;
                couponToUpdate.requestNumber = coupon.requestNumber;
                var update = await _unitOfWork.Coupons.Update(couponToUpdate);
                if(update != null)
                {
                    _unitOfWork.Complete();
                    return true;
                }
            }
            return false;
        }

        public async Task<bool> DeleteCoupon(int id)
        {
            var c = await _unitOfWork.Coupons.Find(a => a.id == id);
            if(c != null && (c.usage == 0 || !c.active) )
            {
                await _unitOfWork.Coupons.Delete(c);
                _unitOfWork.Complete();
                return true;
            }
            return false;
        }

        public async Task<bool> DeactivateCoupon(int id)
        {
            var c = await _unitOfWork.Coupons.Find(a => a.id == id);
            if( c != null)
            {
                if(c.active == true)
                {
                    c.active = false;
                    _unitOfWork.Complete();
                    return true;
                }
            }
            return false;
        }
    }
}
