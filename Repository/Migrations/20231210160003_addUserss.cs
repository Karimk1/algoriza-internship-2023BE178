using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class addUserss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84c8e961-dfa9-48ec-bedb-c10fda32042b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8de69b24-db99-482f-a967-96806b153c19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94ebe34c-029d-4ce9-b077-8738bf12f9ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b368624c-be34-4253-80f5-eb6932a537cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5c23d84-7258-45b8-bc27-07206a3a0abd");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "84c8e961-dfa9-48ec-bedb-c10fda32042b", null, "Patient", "PATIENT" },
                    { "8de69b24-db99-482f-a967-96806b153c19", null, "doctor", "DOCTOR" },
                    { "94ebe34c-029d-4ce9-b077-8738bf12f9ae", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "b368624c-be34-4253-80f5-eb6932a537cd", 0, "4a65dd44-67a3-4d84-afaa-f9731bd1f9cd", "KarimKamel@gmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEOODcKjLxNU53RqP/FSb2HkUUo8sW4kTrRyqdK1S7PWhynh1JYg5dQuyTcLuMlCSrg==", "012586444825", false, "48598135-9dfc-448e-88c6-379239614328", false, "karimkamel", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "f5c23d84-7258-45b8-bc27-07206a3a0abd", 0, "7d097dce-537a-4c8e-9c30-b49b4140afd5", "Karimahmed@gmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEJMldKwweG8DRVgSgsA8Sfs62UM0SuYzW9Bw4KYKySkXB6E2Pje7vdKpKVqHpga3bg==", "012545455825", false, "d2a22bf7-48b4-49da-8a69-b5ed03e403b1", false, "karimAhmed", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 }
                });
        }
    }
}
