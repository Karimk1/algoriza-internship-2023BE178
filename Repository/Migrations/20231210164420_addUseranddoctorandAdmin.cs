using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class addUseranddoctorandAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4ee6e52-7941-41eb-92fb-563dc807e1a1", "AQAAAAIAAYagAAAAEHQ5o//dUY6gdpqzV+zD1Kw8K3ktHr7DLlk4dNcl226drF0OS/f2FC+7TnM5Lh2eFQ==", "0bccdb02-aa3f-4806-835b-12d95ca10439" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9817042f-b505-49c2-b60a-0fc933e46e0f", "AQAAAAIAAYagAAAAELC4U48Z1EBWUMBjkdXNQIVJeHcR+NjxJcfVaIykRS2ga/ABuzXORamF1SUMi/e8mA==", "24831aa3-2c0f-462d-ad5d-a8e95987fff1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[] { "b74ddd14-6340-4840-95c2-kk14554843d5", 0, "39a8d0f3-4c12-4415-b734-fbc61c9f82a5", "Mohamedahmed@gmail.com", false, false, null, "MOHAMEDAHMED@GMAIL.COM", "MOHAMEDAHMED", "AQAAAAIAAYagAAAAEGSDFPy7rAvA38QVMwpXl6WLuV0kgKnmbQCGcm/B3x/viES7kBqSsdtW5ZSz4uCNYg==", "012545488825", false, "1845fc4f-7bf1-4337-a1a3-8b3f8044779c", false, "mohamed ahmed", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "b74ddd14-6340-4840-95c2-kk14554843d5" });

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "id", "SpecializeId", "UserId", "numberOfRequests", "price" },
                values: new object[] { 1, 4, "b74ddd14-6340-4840-95c2-kk14554843d5", 0, 200.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "b74ddd14-6340-4840-95c2-kk14554843d5" });

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-kk14554843d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49fcd949-a632-4dfa-9367-563f47dff7ab", "AQAAAAIAAYagAAAAEMZ2XhPg1BPIXdM+PZ8yM60GP54kJJS/r9ldWB2wvecZnGFPZqTLlwS+mLqcFd05LQ==", "c240c954-01d4-4034-bb2c-f692334a9563" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8ddd3c4-79ed-4ab2-be19-961ef4f9a9e2", "AQAAAAIAAYagAAAAEM3JU5O84IaC0/RDkiQQatfTcG9FcJpScZOeua11zLtTejj8bfFM245lx/yoiVCUfw==", "5259c13e-cff4-46e1-8013-579e542cdbb7" });
        }
    }
}
