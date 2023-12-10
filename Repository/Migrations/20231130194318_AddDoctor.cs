using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_doctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_specializes_specializeid",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_requests_AspNetUsers_doctorId",
                table: "requests");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_specializeid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "numberOfRequests",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "price",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "specializeid",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "doctorId",
                table: "requests",
                newName: "doctorid");

            migrationBuilder.RenameIndex(
                name: "IX_requests_doctorId",
                table: "requests",
                newName: "IX_requests_doctorid");

            migrationBuilder.RenameColumn(
                name: "doctorId",
                table: "Appointments",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_doctorId",
                table: "Appointments",
                newName: "IX_Appointments_DoctorId");

            migrationBuilder.AlterColumn<int>(
                name: "doctorid",
                table: "requests",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "role",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "dateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorIdid",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Appointments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specializeid = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    numberOfRequests = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.id);
                    table.ForeignKey(
                        name: "FK_doctors_specializes_specializeid",
                        column: x => x.specializeid,
                        principalTable: "specializes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DoctorIdid",
                table: "AspNetUsers",
                column: "DoctorIdid");

            migrationBuilder.CreateIndex(
                name: "IX_doctors_specializeid",
                table: "doctors",
                column: "specializeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_doctors_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_doctors_DoctorIdid",
                table: "AspNetUsers",
                column: "DoctorIdid",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_requests_doctors_doctorid",
                table: "requests",
                column: "doctorid",
                principalTable: "doctors",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_doctors_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_doctors_DoctorIdid",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_requests_doctors_doctorid",
                table: "requests");

            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DoctorIdid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoctorIdid",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "doctorid",
                table: "requests",
                newName: "doctorId");

            migrationBuilder.RenameIndex(
                name: "IX_requests_doctorid",
                table: "requests",
                newName: "IX_requests_doctorId");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Appointments",
                newName: "doctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                newName: "IX_Appointments_doctorId");

            migrationBuilder.AlterColumn<string>(
                name: "doctorId",
                table: "requests",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "role",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "dateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "numberOfRequests",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "AspNetUsers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "specializeid",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "doctorId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_specializeid",
                table: "AspNetUsers",
                column: "specializeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_doctorId",
                table: "Appointments",
                column: "doctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_specializes_specializeid",
                table: "AspNetUsers",
                column: "specializeid",
                principalTable: "specializes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_requests_AspNetUsers_doctorId",
                table: "requests",
                column: "doctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
