using Core.Models;
using Core.Models.enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Requests>().HasOne(e => e.pationt).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Requests>().HasOne(e => e.doctor).WithMany().OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(builder);
            //builder.Entity<User>().Property(e =>e.EmailConfirmed).IsRequired(false);
           // builder.Entity<User>().Property(e =>e.PhoneNumberConfirmed).IsRequired(false);
            //builder.Entity<User>().Property(e =>e.TwoFactorEnabled).IsRequired(false);
            //builder.Entity<User>().Property(e =>e.TwoFactorEnabled).IsRequired(false);
            //builder.Entity<User>().Property(e => e.LockoutEnabled).IsRequired(false);
            //builder.Entity<User>().Property(e => e.LockoutEnabled).IsRequired(false);
            //builder.Entity<User>().Property(e => e.AccessFailedCount).IsRequired(false);

            builder.Seed();
            
        }

        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Coupon> coupons { get; set; }
        public DbSet<Requests> requests { get; set; }
        public DbSet<Specialize> specializes { get; set; }
        public DbSet<Time> times { get; set; }

        public DbSet<User> users { get; set; }

        
        public IQueryable join()
        {
            var joining = from d in doctors
                          join u in users on d.userId equals u.Id
                          select new
                          {
                              u.UserName,
                              u.Email,
                              u.gender,
                              u.image,
                              d.specialize,
                              d.price
                          };
            return joining;
        }
    }
}
