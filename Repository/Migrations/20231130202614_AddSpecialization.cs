using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class AddSpecialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "specializes",
                columns: new[] { "id", "numberOfRequest", "specializeName" },
                values: new object[,]
                {
                    { 1, 0, "Immunologists" },
                    { 2, 0, "Cardiologists" },
                    { 3, 0, "Dermatologists" },
                    { 4, 0, "Endocrinologists" },
                    { 5, 0, "Gastroenterologists" },
                    { 6, 0, "Hematologists" },
                    { 7, 0, "Internists" },
                    { 8, 0, "Nephrologists" },
                    { 9, 0, "Neurologists" },
                    { 10, 0, "Obstetricians and Gynecologists" },
                    { 11, 0, "Oncologists" },
                    { 12, 0, "Ophthalmologists" },
                    { 13, 0, "Osteopaths" },
                    { 14, 0, "Otolaryngologists" },
                    { 15, 0, "Pediatricians" },
                    { 16, 0, "Psychiatrists" },
                    { 17, 0, "Rheumatologists" },
                    { 18, 0, "Urologists" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "specializes",
                keyColumn: "id",
                keyValue: 18);
        }
    }
}
