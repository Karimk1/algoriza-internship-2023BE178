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
    [Migration("20231204133259_time-up")]
    partial class timeup
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

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("day")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Core.Models.Coupon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Discoundvalue")
                        .HasColumnType("int");

                    b.Property<string>("discoundCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("discoundType")
                        .HasColumnType("int");

                    b.Property<int>("requestNumber")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

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

                    b.Property<int>("SpecializeId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("numberOfRequests")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("SpecializeId");

                    b.HasIndex("UserId");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("Core.Models.Requests", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("couponId")
                        .HasColumnType("int");

                    b.Property<int>("doctorId")
                        .HasColumnType("int");

                    b.Property<int>("finalPrice")
                        .HasColumnType("int");

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

                    b.Property<int>("appointmentid")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<double>("time")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("appointmentid");

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
                            Id = "e1caada1-8b8b-4d26-bb67-d4d799372dd1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2f0a277d-360e-4613-874e-5cb896b89d3f",
                            Email = "KarimKamel@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a0b16e69-d072-43f5-95d1-2f7ba9b4c308",
                            TwoFactorEnabled = false,
                            UserName = "karimkamel",
                            dateOfBirth = new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 1
                        },
                        new
                        {
                            Id = "31c5a935-c2b7-4b63-b215-089c21b40c7b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c884ab99-45ef-4323-829f-abfa58aa66d0",
                            Email = "Karimahmed@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012545455825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e0091e78-9ea7-4e7f-8c0d-85970f9b208b",
                            TwoFactorEnabled = false,
                            UserName = "karimAhmed",
                            dateOfBirth = new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 2
                        },
                        new
                        {
                            Id = "d055ccae-5593-431b-a24a-2e5bacf0a4f6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "64a61d79-efb9-4b89-99bf-9c30647bb952",
                            Email = "Karim@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c7b70c55-89c9-4551-9ac3-4d3f29a63a6d",
                            TwoFactorEnabled = false,
                            UserName = "karim",
                            dateOfBirth = new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 2
                        },
                        new
                        {
                            Id = "7b81df5a-84b5-4fcb-9338-0322d24a0b59",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "64cb0768-2466-48cc-ab2b-8c67201e3329",
                            Email = "SaraKamel@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "39c43574-c0ec-4799-9411-d7c8f6668138",
                            TwoFactorEnabled = false,
                            UserName = "Sarakamel",
                            dateOfBirth = new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 0,
                            role = 0
                        },
                        new
                        {
                            Id = "f9d3df54-7804-424a-81fa-e4715f85b7bb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9f1fe4cf-6e0a-46fe-a9ea-de5b4b0da7d9",
                            Email = "Karimsssail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "386261bb-dd94-4044-8e1e-74fa0e41c4b5",
                            TwoFactorEnabled = false,
                            UserName = "karimssss",
                            dateOfBirth = new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 0
                        },
                        new
                        {
                            Id = "f77e1d6e-5bf1-407b-96cc-15c2ecd618c4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1d759c35-015a-49a3-9969-360c897c93b4",
                            Email = "ahmedsssail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "020422ba-73a2-4beb-95ed-df420925f883",
                            TwoFactorEnabled = false,
                            UserName = "Ahmed",
                            dateOfBirth = new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 0
                        },
                        new
                        {
                            Id = "b04926fa-d1c8-42f4-a7e2-33ba474ccc28",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "23029198-dbf0-4ba9-9d02-6f537b3a1bf1",
                            Email = "Karimssddsail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1ac610eb-9eb6-479d-8273-5dd49314bc11",
                            TwoFactorEnabled = false,
                            UserName = "karimssdddss",
                            dateOfBirth = new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 2
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
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("Core.Models.Doctor", b =>
                {
                    b.HasOne("Core.Models.Specialize", "Specialize")
                        .WithMany()
                        .HasForeignKey("SpecializeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialize");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Models.Requests", b =>
                {
                    b.HasOne("Core.Models.Coupon", "coupon")
                        .WithMany()
                        .HasForeignKey("couponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .WithMany()
                        .HasForeignKey("appointmentid")
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
#pragma warning restore 612, 618
        }
    }
}