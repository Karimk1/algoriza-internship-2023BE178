using Core.Models;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users {  get;}
        IRepository<Doctor> Doctors {  get;}
        IRepository<Appointment> Appointments {  get;}
        IRepository<Coupon> Coupons {  get;}
        IRepository<Requests> Requests {  get;}
        IRepository<Specialize> Specializes {  get;}
        IRepository<Time> Time {  get;}

        int Complete();
    }
}
