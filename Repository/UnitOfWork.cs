using Core;
using Core.Models;
using Core.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IRepository<User> Users { get;private set; }
        public IRepository<Doctor> Doctors { get;private set; }
        public IRepository<Appointment> Appointments { get;private set; }
        public IRepository<Coupon> Coupons { get;private set; }
        public IRepository<Requests> Requests { get;private set; }
        public IRepository<Specialize> Specializes { get;private set; }
        public IRepository<Time> Time { get;private set; }

    

        public UnitOfWork(ApplicationDbContext context )
        {
            _context = context;
  
            Users = new Repository<User>(_context);
            Doctors = new Repository<Doctor>(_context);
            Appointments = new Repository<Appointment>(_context);
            Coupons = new Repository<Coupon>(_context);
            Requests = new Repository<Requests>(_context);
            Specializes = new Repository<Specialize>(_context);
            Time = new Repository<Time>(_context);

        }
        
        
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
