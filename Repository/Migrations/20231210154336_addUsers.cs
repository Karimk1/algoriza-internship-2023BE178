using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class addUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3de72e36-88cc-483a-9cd3-e63234f3e61d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f744e20-3646-46b1-bb54-e4ca87bf1bec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65b3769c-5c01-4ab5-abd1-78c0a5484ca1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07d83c01-6e64-4ac4-9a23-dd56c53e8e8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b36f4ff-7ba8-4650-8e79-6786bcf60d39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dd5d380-89d5-49c0-b86a-aa0b18361519");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b3d815-4ffc-4fea-b8b7-6a1b8fa622f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a748c5fa-acc8-49d8-8485-162a40083f43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5681c1-5b8e-4249-944e-5c625662b0a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbad37a3-d24a-4c31-a332-2a3e9eaa6717");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3de72e36-88cc-483a-9cd3-e63234f3e61d", null, "Patient", "PATIENT" },
                    { "5f744e20-3646-46b1-bb54-e4ca87bf1bec", null, "doctor", "DOCTOR" },
                    { "65b3769c-5c01-4ab5-abd1-78c0a5484ca1", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "07d83c01-6e64-4ac4-9a23-dd56c53e8e8f", 0, "d838e85e-a40b-486a-8be8-3e7fb1d0b951", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "36c1bb4e-98f0-4910-a92d-9599593ccc42", false, "karimAhmed", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "6b36f4ff-7ba8-4650-8e79-6786bcf60d39", 0, "fa664dae-50dc-48b8-ab6e-ce5333f5abd2", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "fce159c7-7fde-45e7-94b0-1f4a07ea47d0", false, "karimssdddss", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "6dd5d380-89d5-49c0-b86a-aa0b18361519", 0, "ac79092f-a074-4787-b2fb-cb0834d03381", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "e497cf92-34d5-439a-b41e-d92f0796f796", false, "karim", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "84b3d815-4ffc-4fea-b8b7-6a1b8fa622f7", 0, "f063fc06-262f-41fd-b249-f49f9bf010c2", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "fbdf758e-f525-46e4-ad3b-402ea5a3e300", false, "Ahmed", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "a748c5fa-acc8-49d8-8485-162a40083f43", 0, "c714c557-906b-45d5-8d00-8644ef768c7f", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "92df063b-4581-4a4c-98a2-0eb351f6f75a", false, "karimssss", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "aa5681c1-5b8e-4249-944e-5c625662b0a6", 0, "f8ac7a1b-bca3-4d94-8a6f-677aafa0c09c", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "56245c51-562a-434b-9bf8-8ad013f03a5f", false, "karimkamel", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "dbad37a3-d24a-4c31-a332-2a3e9eaa6717", 0, "9dbf9413-d39f-4da0-bd2b-570ae59d7130", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "094f3123-361c-4f0a-a351-471fcf0fb37d", false, "Sarakamel", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 }
                });
        }
    }
}
