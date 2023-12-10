using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class addUsersss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e25cece-a1ee-4918-8ffa-f470f88effff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a488ec1b-0e10-48c7-8a22-bf096a0d7de5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfbf1c04-5052-483e-9dac-58be9dd63f2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bcfdf80-1a97-48c7-9702-83cc2d176edd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea131ac-ee7d-4760-9ead-d4b9cc7501d2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c7b013f0-5201-4317-abd8-c211f91b5320", null, "Patient", "PATIENT" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", null, "doctor", "DOCTOR" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "b74ddd14-6340-4840-95c2-db12554843d5", 0, "49fcd949-a632-4dfa-9367-563f47dff7ab", "Karimahmed@gmail.com", false, false, null, "KARIMAHMED@GMAIL.COM", "KARIMAHMED", "AQAAAAIAAYagAAAAEMZ2XhPg1BPIXdM+PZ8yM60GP54kJJS/r9ldWB2wvecZnGFPZqTLlwS+mLqcFd05LQ==", "012545455825", false, "c240c954-01d4-4034-bb2c-f692334a9563", false, "karimAhmed", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "e8ddd3c4-79ed-4ab2-be19-961ef4f9a9e2", "KarimKamel@gmail.com", false, false, null, "KARIMKAMEL@GMAIL.COM", "KARIMKAMEL", "AQAAAAIAAYagAAAAEM3JU5O84IaC0/RDkiQQatfTcG9FcJpScZOeua11zLtTejj8bfFM245lx/yoiVCUfw==", "012586444825", false, "5259c13e-cff4-46e1-8013-579e542cdbb7", false, "karimkamel", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c7b013f0-5201-4317-abd8-c211f91b5320", "b74ddd14-6340-4840-95c2-db12554843d5" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db12554843e5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7b013f0-5201-4317-abd8-c211f91b5320", "b74ddd14-6340-4840-95c2-db12554843d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db12554843e5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b5320");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9e25cece-a1ee-4918-8ffa-f470f88effff", null, "Patient", "PATIENT" },
                    { "a488ec1b-0e10-48c7-8a22-bf096a0d7de5", null, "doctor", "DOCTOR" },
                    { "cfbf1c04-5052-483e-9dac-58be9dd63f2d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "6bcfdf80-1a97-48c7-9702-83cc2d176edd", 0, "bfa716a0-7a6c-4a0d-afb5-d02f9c8fe90a", "KarimKamel@gmail.com", false, false, null, "KARIMKAMEL@GMAIL.COM", "KARIMKAMEL", "AQAAAAIAAYagAAAAEC5+H9a+h06GJJJS2QtOKby8ThWHzUsZURlVkfjwibx2P+fdWCYsLbAYjjM+/Ic5xA==", "012586444825", false, "52d420be-9f91-4ff2-b843-a0da37da7fb7", false, "karimkamel", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "7ea131ac-ee7d-4760-9ead-d4b9cc7501d2", 0, "7066144d-3286-4f33-ad16-1aaa2557b21e", "Karimahmed@gmail.com", false, false, null, "KARIMAHMED@GMAIL.COM", "KARIMAHMED", "AQAAAAIAAYagAAAAEMXluTeAUTn5KUyxbVQkKqFabdSdw4CAU1zMW8MiYlt1Qg2iXriKbnPkwk3HpiSKOQ==", "012545455825", false, "f196060d-456e-4c0f-b816-9def8a2e7355", false, "karimAhmed", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 }
                });
        }
    }
}
