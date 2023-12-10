using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class addTabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gender",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
                name: "role",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "specializeid",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    day = table.Column<int>(type: "int", nullable: false),
                    doctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Time = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_doctorId",
                        column: x => x.doctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "coupons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discoundCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    discoundType = table.Column<int>(type: "int", nullable: false),
                    Discoundvalue = table.Column<int>(type: "int", nullable: false),
                    requestNumber = table.Column<int>(type: "int", nullable: false),
                    usage = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coupons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "specializes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specializeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfRequest = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specializes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "times",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    appointmentid = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    time = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_times", x => x.id);
                    table.ForeignKey(
                        name: "FK_times_Appointments_appointmentid",
                        column: x => x.appointmentid,
                        principalTable: "Appointments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "requests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pationtId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    requestType = table.Column<int>(type: "int", nullable: false),
                    requestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    timeid = table.Column<int>(type: "int", nullable: false),
                    couponid = table.Column<int>(type: "int", nullable: false),
                    finalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_requests", x => x.id);
                    table.ForeignKey(
                        name: "FK_requests_AspNetUsers_doctorId",
                        column: x => x.doctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_requests_AspNetUsers_pationtId",
                        column: x => x.pationtId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_requests_coupons_couponid",
                        column: x => x.couponid,
                        principalTable: "coupons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_requests_times_timeid",
                        column: x => x.timeid,
                        principalTable: "times",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_specializeid",
                table: "AspNetUsers",
                column: "specializeid");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_doctorId",
                table: "Appointments",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_requests_couponid",
                table: "requests",
                column: "couponid");

            migrationBuilder.CreateIndex(
                name: "IX_requests_doctorId",
                table: "requests",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_requests_pationtId",
                table: "requests",
                column: "pationtId");

            migrationBuilder.CreateIndex(
                name: "IX_requests_timeid",
                table: "requests",
                column: "timeid");

            migrationBuilder.CreateIndex(
                name: "IX_times_appointmentid",
                table: "times",
                column: "appointmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_specializes_specializeid",
                table: "AspNetUsers",
                column: "specializeid",
                principalTable: "specializes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_specializes_specializeid",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "requests");

            migrationBuilder.DropTable(
                name: "specializes");

            migrationBuilder.DropTable(
                name: "coupons");

            migrationBuilder.DropTable(
                name: "times");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_specializeid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "dateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "image",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "numberOfRequests",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "price",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "role",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "specializeid",
                table: "AspNetUsers");
        }
    }
}
