using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IPatientServices
    {
        Task<IEnumerable<object>> GetAllDoctors();

        Task<bool> Book(String userId,int timeId, String code = null);

        Task<IEnumerable<object>> GetPationtBooking(string id);
        Task<bool> CancelBooking(int requestId);
    }
}
