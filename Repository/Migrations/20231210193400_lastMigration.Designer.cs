﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Services;

#nullable disable

namespace Services.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231210193400_lastMigration")]
    partial class lastMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Models.Appointment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("day")
                        .HasColumnType("int");

                    b.Property<int>("doctorId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("doctorId");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("Core.Models.Coupon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<string>("discoundCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("discoundType")
                        .HasColumnType("int");

                    b.Property<int>("discoundValue")
                        .HasColumnType("int");

                    b.Property<int>("requestNumber")
                        .HasColumnType("int");

                    b.Property<int>("usage")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("coupons");
                });

            modelBuilder.Entity("Core.Models.Doctor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("numberOfRequests")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("specializeId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("specializeId");

                    b.HasIndex("userId");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            id = 1,
                            numberOfRequests = 0,
                            price = 200.0,
                            specializeId = 4,
                            userId = "b74ddd14-6340-4840-95c2-kk14554843d5"
                        });
                });

            modelBuilder.Entity("Core.Models.Requests", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("couponId")
                        .HasColumnType("int");

                    b.Property<int>("doctorId")
                        .HasColumnType("int");

                    b.Property<double>("finalPrice")
                        .HasColumnType("float");

                    b.Property<string>("pationtId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("requestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("requestType")
                        .HasColumnType("int");

                    b.Property<int>("timeId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("couponId");

                    b.HasIndex("doctorId");

                    b.HasIndex("pationtId");

                    b.HasIndex("timeId");

                    b.ToTable("requests");
                });

            modelBuilder.Entity("Core.Models.Specialize", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("numberOfRequest")
                        .HasColumnType("int");

                    b.Property<string>("specializeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("specializes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            numberOfRequest = 0,
                            specializeName = "Immunologists"
                        },
                        new
                        {
                            id = 2,
                            numberOfRequest = 0,
                            specializeName = "Cardiologists"
                        },
                        new
                        {
                            id = 3,
                            numberOfRequest = 0,
                            specializeName = "Dermatologists"
                        },
                        new
                        {
                            id = 4,
                            numberOfRequest = 0,
                            specializeName = "Endocrinologists"
                        },
                        new
                        {
                            id = 5,
                            numberOfRequest = 0,
                            specializeName = "Gastroenterologists"
                        },
                        new
                        {
                            id = 6,
                            numberOfRequest = 0,
                            specializeName = "Hematologists"
                        },
                        new
                        {
                            id = 7,
                            numberOfRequest = 0,
                            specializeName = "Internists"
                        },
                        new
                        {
                            id = 8,
                            numberOfRequest = 0,
                            specializeName = "Nephrologists"
                        },
                        new
                        {
                            id = 9,
                            numberOfRequest = 0,
                            specializeName = "Neurologists"
                        },
                        new
                        {
                            id = 10,
                            numberOfRequest = 0,
                            specializeName = "Obstetricians and Gynecologists"
                        },
                        new
                        {
                            id = 11,
                            numberOfRequest = 0,
                            specializeName = "Oncologists"
                        },
                        new
                        {
                            id = 12,
                            numberOfRequest = 0,
                            specializeName = "Ophthalmologists"
                        },
                        new
                        {
                            id = 13,
                            numberOfRequest = 0,
                            specializeName = "Osteopaths"
                        },
                        new
                        {
                            id = 14,
                            numberOfRequest = 0,
                            specializeName = "Otolaryngologists"
                        },
                        new
                        {
                            id = 15,
                            numberOfRequest = 0,
                            specializeName = "Pediatricians"
                        },
                        new
                        {
                            id = 16,
                            numberOfRequest = 0,
                            specializeName = "Psychiatrists"
                        },
                        new
                        {
                            id = 17,
                            numberOfRequest = 0,
                            specializeName = "Rheumatologists"
                        },
                        new
                        {
                            id = 18,
                            numberOfRequest = 0,
                            specializeName = "Urologists"
                        });
                });

            modelBuilder.Entity("Core.Models.Time", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("appointmentId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<double>("time")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("appointmentId");

                    b.ToTable("times");
                });

            modelBuilder.Entity("Core.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "015c416b-ba21-4492-93ab-0b91cf9fe42a",
                            Email = "KarimKamel@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "KARIMKAMEL@GMAIL.COM",
                            NormalizedUserName = "KARIMKAMEL",
                            PasswordHash = "AQAAAAIAAYagAAAAECrSdmpvSxFv4bX8qXrnVygxoe/y1Gqun4QB8146FZjRZEFN4S12uOAJl0VdgfnJ2w==",
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4ad3a1e9-365b-487c-977b-2419df0d5204",
                            TwoFactorEnabled = false,
                            UserName = "karimkamel",
                            dateOfBirth = new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 1
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843d5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "df65004c-85a9-4fd4-bd9f-21b1e995ab2b",
                            Email = "Karimahmed@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "KARIMAHMED@GMAIL.COM",
                            NormalizedUserName = "KARIMAHMED",
                            PasswordHash = "AQAAAAIAAYagAAAAEAThoHsDez+TP1j+793wdHuYBBghNUWeR2+FNBwTDKUZVBVmeH/2fsbeO9N9XaROHA==",
                            PhoneNumber = "012545455825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "79464fd8-6b7c-4949-b931-22db37dd1f9a",
                            TwoFactorEnabled = false,
                            UserName = "karimAhmed",
                            dateOfBirth = new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 2
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-kk14554843d5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed2c2d39-2fa8-44a6-bf2a-a6f0425b262a",
                            Email = "Mohamedahmed@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MOHAMEDAHMED@GMAIL.COM",
                            NormalizedUserName = "MOHAMEDAHMED",
                            PasswordHash = "AQAAAAIAAYagAAAAEKVToLy0VajDqlYcri2ZlaDw2Sy1srshcZtfwnJhiWlqrx51a5Zq/jqqo9GWOj6PyA==",
                            PhoneNumber = "012545488825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a3612198-5a32-40ba-8d35-32e876a103c2",
                            TwoFactorEnabled = false,
                            UserName = "mohamed ahmed",
                            dateOfBirth = new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                            Name = "Doctor",
                            NormalizedName = "DOCTOR"
                        },
                        new
                        {
                            Id = "c7b013f0-5201-4317-abd8-c211f91b5320",
                            Name = "Patient",
                            NormalizedName = "PATIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db12554843d5",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b5320"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-kk14554843d5",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Core.Models.Appointment", b =>
                {
                    b.HasOne("Core.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("Core.Models.Doctor", b =>
                {
                    b.HasOne("Core.Models.Specialize", "specialize")
                        .WithMany()
                        .HasForeignKey("specializeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("specialize");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Core.Models.Requests", b =>
                {
                    b.HasOne("Core.Models.Coupon", "coupon")
                        .WithMany()
                        .HasForeignKey("couponId");

                    b.HasOne("Core.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Models.User", "pationt")
                        .WithMany()
                        .HasForeignKey("pationtId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Models.Time", "time")
                        .WithMany()
                        .HasForeignKey("timeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("coupon");

                    b.Navigation("doctor");

                    b.Navigation("pationt");

                    b.Navigation("time");
                });

            modelBuilder.Entity("Core.Models.Time", b =>
                {
                    b.HasOne("Core.Models.Appointment", "appointment")
                        .WithMany("times")
                        .HasForeignKey("appointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("appointment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Models.Appointment", b =>
                {
                    b.Navigation("times");
                });
#pragma warning restore 612, 618
        }
    }
}
