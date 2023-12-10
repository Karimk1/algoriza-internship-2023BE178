using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class updatess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_doctors_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_AspNetUsers_UserId",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_specializes_SpecializeId",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_times_Appointments_appointmentid",
                table: "times");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "appointments");

            migrationBuilder.RenameColumn(
                name: "appointmentid",
                table: "times",
                newName: "appointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_times_appointmentid",
                table: "times",
                newName: "IX_times_appointmentId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "doctors",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "SpecializeId",
                table: "doctors",
                newName: "specializeId");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_UserId",
                table: "doctors",
                newName: "IX_doctors_userId");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_SpecializeId",
                table: "doctors",
                newName: "IX_doctors_specializeId");

            migrationBuilder.RenameColumn(
                name: "Discoundvalue",
                table: "coupons",
                newName: "discoundValue");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "coupons",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "appointments",
                newName: "doctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DoctorId",
                table: "appointments",
                newName: "IX_appointments_doctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                table: "appointments",
                column: "id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "Name",
                value: "Doctor");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e1746b7-b1c7-42e8-aaf2-30d64b6759b2", "AQAAAAIAAYagAAAAEEkos6IUWftOZp0ALI7FR+STXZvxWKIcbl7C58Kqhm6fQ9NUdcz2yFlz8yYK/XYqNg==", "55804c36-3d45-4ab7-901a-a411d723669e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21aaf929-4322-446b-958c-92ef953727f4", "AQAAAAIAAYagAAAAEJ8/kPrRrDcdcJtUiecO5dqgBO4dvpKzG/6zQ7gNlwYkSr7Y4SeTcNQxtwF2p+CXAw==", "8130f10a-76f6-4ff7-bf8c-53cc58dd5db5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-kk14554843d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92503652-69dd-4eb0-a4e3-16946cb91fc1", "AQAAAAIAAYagAAAAEHFwCFpggUoszTrxuMjtp0Rxqj/NWd/g6HTzQDR8fO9EypEoWDaRPOb+xl+d5FdmHQ==", "eb67c162-055e-40e6-81a4-4bbcbf4f32b5" });

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_doctors_doctorId",
                table: "appointments",
                column: "doctorId",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_AspNetUsers_userId",
                table: "doctors",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_specializes_specializeId",
                table: "doctors",
                column: "specializeId",
                principalTable: "specializes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_times_appointments_appointmentId",
                table: "times",
                column: "appointmentId",
                principalTable: "appointments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_doctors_doctorId",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_AspNetUsers_userId",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_specializes_specializeId",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_times_appointments_appointmentId",
                table: "times");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                table: "appointments");

            migrationBuilder.RenameTable(
                name: "appointments",
                newName: "Appointments");

            migrationBuilder.RenameColumn(
                name: "appointmentId",
                table: "times",
                newName: "appointmentid");

            migrationBuilder.RenameIndex(
                name: "IX_times_appointmentId",
                table: "times",
                newName: "IX_times_appointmentid");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "doctors",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "specializeId",
                table: "doctors",
                newName: "SpecializeId");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_userId",
                table: "doctors",
                newName: "IX_doctors_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_specializeId",
                table: "doctors",
                newName: "IX_doctors_SpecializeId");

            migrationBuilder.RenameColumn(
                name: "discoundValue",
                table: "coupons",
                newName: "Discoundvalue");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "coupons",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "doctorId",
                table: "Appointments",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_doctorId",
                table: "Appointments",
                newName: "IX_Appointments_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "Name",
                value: "doctor");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-kk14554843d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39a8d0f3-4c12-4415-b734-fbc61c9f82a5", "AQAAAAIAAYagAAAAEGSDFPy7rAvA38QVMwpXl6WLuV0kgKnmbQCGcm/B3x/viES7kBqSsdtW5ZSz4uCNYg==", "1845fc4f-7bf1-4337-a1a3-8b3f8044779c" });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_doctors_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_AspNetUsers_UserId",
                table: "doctors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_specializes_SpecializeId",
                table: "doctors",
                column: "SpecializeId",
                principalTable: "specializes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_times_Appointments_appointmentid",
                table: "times",
                column: "appointmentid",
                principalTable: "Appointments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
