using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class updateDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_AspNetUsers_Doctor",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_Doctor",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "doctors");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "doctors",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "doctors",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_doctors_UserId",
                table: "doctors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_AspNetUsers_UserId",
                table: "doctors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_AspNetUsers_UserId",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_UserId",
                table: "doctors");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "doctors",
                newName: "UserID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "doctors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Doctor",
                table: "doctors",
                type: "nvarchar(450)",
                nullable: true);

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
        }
    }
}
