using Core.Models;
using Core.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IDoctorServices
    {
        Task<IEnumerable<object>> GetAllBookings(string id,int skip, int take);
        Task<bool> ConfirmCheckUp(String doctorId,int requestId,RequestType request);
        Task<bool> AddAppointment(string id, List<DayTime> dayTimes);
        Task<bool> UpdateAppointment(string id,double oldTime,double newTime);
        Task<bool> DeleteAppointment(string id,double time);
    }
}
