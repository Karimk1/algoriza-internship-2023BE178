using Core.Models;
using Core.Models.enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Services.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class ModelBuilderExtension
    {
            public static void Seed(this ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Specialize>().HasData(
                    new Specialize
                    {
                        id = 1,
                        specializeName = "Immunologists"
                    },
                    new Specialize
                    {
                        id = 2,
                        specializeName = "Cardiologists"
                    },
                    new Specialize
                    {
                        id = 3,
                        specializeName = "Dermatologists"
                    },
                    new Specialize
                    {
                        id = 4,
                        specializeName = "Endocrinologists"
                    },
                    new Specialize
                    {
                        id = 5,
                        specializeName = "Gastroenterologists"
                    },
                    new Specialize
                    {
                        id = 6,
                        specializeName = "Hematologists"
                    },
                    new Specialize
                    {
                        id = 7,
                        specializeName = "Internists"
                    },
                    new Specialize
                    {
                        id = 8,
                        specializeName = "Nephrologists"
                    },
                    new Specialize
                    {
                        id = 9,
                        specializeName = "Neurologists"
                    },
                    new Specialize
                    {
                        id = 10,
                        specializeName = "Obstetricians and Gynecologists"
                    },
                    new Specialize
                    {
                        id = 11,
                        specializeName = "Oncologists"
                    },
                    new Specialize
                    {
                        id = 12,
                        specializeName = "Ophthalmologists"
                    },
                    new Specialize
                    {
                        id = 13,
                        specializeName = "Osteopaths"

                    },
                    new Specialize
                    {
                        id = 14,
                        specializeName = "Otolaryngologists"

                    },
                    new Specialize
                    {
                        id = 15,
                        specializeName = "Pediatricians"
                    },
                    new Specialize
                    {
                        id = 16,
                        specializeName = "Psychiatrists"
                    },
                    new Specialize
                    {
                        id = 17,
                        specializeName = "Rheumatologists"
                    },
                    new Specialize
                    {
                        id = 18,
                        specializeName = "Urologists"
                    }
                    );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                    Name = Role.Admin.ToString(),
                    NormalizedName = Role.Admin.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                    Name = Role.Doctor.ToString(),
                    NormalizedName = Role.Doctor.ToString().ToUpper(),
                },
                new IdentityRole
                {
                    Id = "c7b013f0-5201-4317-abd8-c211f91b5320",
                    Name = Role.Patient.ToString(),
                    NormalizedName = Role.Patient.ToString().ToUpper()
                }
                );

            User admin = new User
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "karimkamel",
                Email = "KarimKamel@gmail.com",
                gender = Gender.Male,
                PhoneNumber = "012586444825",
                dateOfBirth = DateTime.Today,
                role = Role.Admin,
                NormalizedUserName = "karimkamel".ToUpper(),
                NormalizedEmail = "KarimKamel@gmail.com".ToUpper()

            };

            User patient = new User
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843d5",
                UserName = "karimAhmed",
                Email = "Karimahmed@gmail.com",
                gender = Gender.Male,
                PhoneNumber = "012545455825",
                dateOfBirth = DateTime.Today,
                role = Role.Patient,
                NormalizedEmail = "Karimahmed@gmail.com".ToUpper(),
                NormalizedUserName = "karimAhmed".ToUpper()

            };
            User userdoctor = new User
            {
                Id = "b74ddd14-6340-4840-95c2-kk14554843d5",
                UserName = "mohamed ahmed",
                Email = "Mohamedahmed@gmail.com",
                gender = Gender.Male,
                PhoneNumber = "012545488825",
                dateOfBirth = DateTime.Today,
                role = Role.Doctor,
                NormalizedEmail = "Mohamedahmed@gmail.com".ToUpper(),
                NormalizedUserName = "mohamedahmed".ToUpper()

            };

            Doctor doctor = new Doctor
            {
                id = 1,
                userId = "b74ddd14-6340-4840-95c2-kk14554843d5",
                numberOfRequests = 0,
                price = 200,
                specializeId = 4,
            };

            PasswordHasher<User> ph = new PasswordHasher<User>();
            admin.PasswordHash = ph.HashPassword(admin, "Admin@123");
            patient.PasswordHash = ph.HashPassword(patient, "Patient@123");
            userdoctor.PasswordHash = ph.HashPassword(userdoctor, "Doctor@123");

            modelBuilder.Entity<User>()
                .HasData(admin,patient,userdoctor);

            modelBuilder.Entity<Doctor>().HasData(doctor);

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                new IdentityUserRole<string>() { 
                    RoleId = "fab4fac1-c546-41de-aebc-a14da6895711",
                    UserId = "b74ddd14-6340-4840-95c2-db12554843e5"
                },
                new IdentityUserRole<string>() { 
                    RoleId = "c7b013f0-5201-4317-abd8-c211f91b5320",
                    UserId = "b74ddd14-6340-4840-95c2-db12554843d5"
                },
                new IdentityUserRole<string>() { 
                    RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330",
                    UserId = "b74ddd14-6340-4840-95c2-kk14554843d5"
                }
                );
        }
        }
    }

