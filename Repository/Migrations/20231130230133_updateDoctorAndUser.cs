using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class updateDoctorAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_doctors_DoctorIdid",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_specializes_specializeid",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DoctorIdid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoctorIdid",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "specializeid",
                table: "doctors",
                newName: "SpecializeId");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_specializeid",
                table: "doctors",
                newName: "IX_doctors_SpecializeId");

            migrationBuilder.AddColumn<string>(
                name: "Doctor",
                table: "doctors",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_doctors_Doctor",
                table: "doctors",
                column: "Doctor");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_AspNetUsers_Doctor",
                table: "doctors",
                column: "Doctor",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_specializes_SpecializeId",
                table: "doctors",
                column: "SpecializeId",
                principalTable: "specializes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_AspNetUsers_Doctor",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_specializes_SpecializeId",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_Doctor",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "doctors");

            migrationBuilder.RenameColumn(
                name: "SpecializeId",
                table: "doctors",
                newName: "specializeid");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_SpecializeId",
                table: "doctors",
                newName: "IX_doctors_specializeid");

            migrationBuilder.AddColumn<int>(
                name: "DoctorIdid",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DoctorIdid",
                table: "AspNetUsers",
                column: "DoctorIdid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_doctors_DoctorIdid",
                table: "AspNetUsers",
                column: "DoctorIdid",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_specializes_specializeid",
                table: "doctors",
                column: "specializeid",
                principalTable: "specializes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
