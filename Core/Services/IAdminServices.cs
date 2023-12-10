using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IAdminServices
    {
        Task<int> NumberOfDoctors();
        Task<int> NumberOfPationts();
        Task<IEnumerable<object>> NumberOfRequests();
        Task<IEnumerable<object>> GetAllDoctor(int skip , int take,Expression<Func<object,bool>>? search = null);
        Task<IEnumerable<User>> GetAllUsers();
        Task<IEnumerable<object>> GetAllPationts(int skip , int take);
        Task<IEnumerable<Appointment>> GetAllAppointment();
        Task<IEnumerable<Specialize>> GetAllspecialization();
        Task<IEnumerable<object>> TopSpecialize();
        Task<IEnumerable<object>> TopDoctor();
        Task<DoctorViewModel> GetDoctorById(int id);
        Task<object> GetPationtById(String id);
        Task<AuthModel> AddDoctor(DoctorModel user);
        Task<bool> UpdateDoctor(int id, DoctorModel doctor);
        Task<bool> DeleteDoctor(int id);
        Task<bool> AddCoupon(Coupon coupon);
        Task<bool> UpdateCoupon(int couponId,Coupon coupon);
        Task<bool> DeleteCoupon(int id);
        Task<bool> DeactivateCoupon(int id);


    }
}
