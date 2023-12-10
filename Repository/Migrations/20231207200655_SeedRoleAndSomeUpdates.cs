using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoleAndSomeUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1823c094-d58f-4d26-a2b0-24ddaf9e1c31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44f8c785-01f8-464a-ae6f-02d7e6825900");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8defce4a-8c49-4f4c-b3b8-139beff6f363");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97ba2cff-c119-45b8-b1a6-e3298ac5c0d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acf2bf23-996a-465e-b5ca-c88606b32dff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be8a36a0-d272-4f79-ab49-b2633a56e910");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e59c86d8-6e17-4ace-a5fe-14e4d343fbf8");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "coupons",
                newName: "Active");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "coupons",
                newName: "status");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "1823c094-d58f-4d26-a2b0-24ddaf9e1c31", 0, "c61bbdf5-b34b-4261-8037-7b5e605d8a6a", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "828995dc-a436-4aac-b75c-56468c0bb622", false, "karim", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "44f8c785-01f8-464a-ae6f-02d7e6825900", 0, "3029e195-03ea-443f-87a9-6430a69adc58", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "c2262314-1aee-4f0d-9256-09035dd43204", false, "Ahmed", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "8defce4a-8c49-4f4c-b3b8-139beff6f363", 0, "8aa7e5b7-9a17-414a-b369-a5c0c7cc415b", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "6e52836b-2191-47c3-9e4d-a08d695ccaf0", false, "karimssdddss", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "97ba2cff-c119-45b8-b1a6-e3298ac5c0d6", 0, "2a50738e-e2ca-4e39-b746-49c17e776881", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "f8779e67-56e7-44f0-9127-2ef58581cce4", false, "Sarakamel", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "acf2bf23-996a-465e-b5ca-c88606b32dff", 0, "fce33048-7eeb-418a-aaf8-6f0592d24ad1", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "ad279cad-af2e-4081-9f54-630dd1fbfc16", false, "karimssss", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "be8a36a0-d272-4f79-ab49-b2633a56e910", 0, "5226ef72-65fa-41ff-b3a6-389a86133b60", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "44c1e93c-b9a7-41fc-97fe-7d1cf0152de3", false, "karimkamel", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "e59c86d8-6e17-4ace-a5fe-14e4d343fbf8", 0, "9fd681ad-4c2d-4029-99a4-d8a6463339e6", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "4d616d1c-1018-45d8-a015-fe96376c2c39", false, "karimAhmed", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 }
                });
        }
    }
}
