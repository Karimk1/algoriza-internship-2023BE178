using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class requestUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_AspNetUsers_pationtId",
                table: "requests");

            migrationBuilder.DropForeignKey(
                name: "FK_requests_doctors_doctorid",
                table: "requests");

            migrationBuilder.DropIndex(
                name: "IX_requests_pationtId",
                table: "requests");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1875501e-ffe8-4958-a9e6-7de2eb948597");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bfe0791-7bea-4810-9829-73f423547924");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b42ee4c-f620-43bd-bb3b-a5c9455f197d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86103773-f690-44ed-96dc-40babe117fd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93e71e68-8483-4354-ac6b-a74377dc7f6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6241ef3-d60f-4641-b440-ef7a28b54133");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb26b60-a909-4f1b-bc30-b36e9a2d6a95");

            migrationBuilder.RenameColumn(
                name: "doctorid",
                table: "requests",
                newName: "doctorId");

            migrationBuilder.RenameIndex(
                name: "IX_requests_doctorid",
                table: "requests",
                newName: "IX_requests_doctorId");

            migrationBuilder.AlterColumn<int>(
                name: "pationtId",
                table: "requests",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "pationtId1",
                table: "requests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "00821b57-c41a-4958-a811-7dad29621f0c", 0, "c9182bee-a8f4-46dc-aef2-9ef6a6788256", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "562783ac-30e8-43cf-9056-64b166bcbfb3", false, "karim", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "0b8c58ae-bfef-4d34-b7a7-6387bf7d27cd", 0, "3c4eb3ce-e13d-4515-a74d-f9734ea891cf", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "b685478d-ca84-494a-b4dc-adfa314321f3", false, "karimssss", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "156183a4-f41c-4126-b99e-860e2bc51aed", 0, "37c9a414-1683-4e3c-9101-0b0456430119", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "97cc1e17-b351-445c-af67-75f4213e53e3", false, "karimssdddss", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "3810e331-7be9-424b-a843-d5642bc50a3e", 0, "6510ddbb-e219-478a-b369-c47c038f7e00", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "cd9bdb27-191e-4f96-9c57-4574dca5e95c", false, "Ahmed", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "53fce3c2-16d8-455f-9868-55b0a6eec735", 0, "c8d375ab-36c6-4eb7-b333-c2f005cca6c4", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "536f2654-8e6f-4b4c-900a-6bd309d5f530", false, "karimAhmed", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "657dc2f1-d9e3-4ae4-aafd-8f444d64fa04", 0, "f7d29f87-e088-4d00-b868-363a7d38c237", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "534978d0-0e19-486b-8857-f640542635c5", false, "karimkamel", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "e9687e35-ee50-4d71-afe1-cb9ed3b46560", 0, "73bccd32-e12e-4c12-b707-8ca82076d3e0", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "2277fd82-8ac4-4666-810c-083390e8a88e", false, "Sarakamel", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_requests_pationtId1",
                table: "requests",
                column: "pationtId1");

            migrationBuilder.AddForeignKey(
                name: "FK_requests_AspNetUsers_pationtId1",
                table: "requests",
                column: "pationtId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_requests_doctors_doctorId",
                table: "requests",
                column: "doctorId",
                principalTable: "doctors",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_AspNetUsers_pationtId1",
                table: "requests");

            migrationBuilder.DropForeignKey(
                name: "FK_requests_doctors_doctorId",
                table: "requests");

            migrationBuilder.DropIndex(
                name: "IX_requests_pationtId1",
                table: "requests");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00821b57-c41a-4958-a811-7dad29621f0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b8c58ae-bfef-4d34-b7a7-6387bf7d27cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "156183a4-f41c-4126-b99e-860e2bc51aed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3810e331-7be9-424b-a843-d5642bc50a3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53fce3c2-16d8-455f-9868-55b0a6eec735");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "657dc2f1-d9e3-4ae4-aafd-8f444d64fa04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9687e35-ee50-4d71-afe1-cb9ed3b46560");

            migrationBuilder.DropColumn(
                name: "pationtId1",
                table: "requests");

            migrationBuilder.RenameColumn(
                name: "doctorId",
                table: "requests",
                newName: "doctorid");

            migrationBuilder.RenameIndex(
                name: "IX_requests_doctorId",
                table: "requests",
                newName: "IX_requests_doctorid");

            migrationBuilder.AlterColumn<string>(
                name: "pationtId",
                table: "requests",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "1875501e-ffe8-4958-a9e6-7de2eb948597", 0, "b7748a9b-9af4-40ed-a91e-9a97d2fa2fab", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "86923650-c10b-4e7c-8224-0f7603e575f2", false, "Ahmed", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "3bfe0791-7bea-4810-9829-73f423547924", 0, "79fda904-a460-4da0-aae4-ced2818ef75d", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "74a2ee74-1a35-4816-9d96-d5336bb5ac79", false, "karim", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "6b42ee4c-f620-43bd-bb3b-a5c9455f197d", 0, "5034dad3-11a2-4ed0-a970-b6698653119d", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "293279ca-17ed-4b58-a346-53032d3bf5a1", false, "Sarakamel", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "86103773-f690-44ed-96dc-40babe117fd7", 0, "eed10473-8fcb-4819-8efb-be3f25cdbc9c", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "699d06ab-b0c7-4451-8597-373c0afca8b5", false, "karimkamel", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "93e71e68-8483-4354-ac6b-a74377dc7f6f", 0, "97d80569-86ef-47f8-82bd-8a64b057e7b3", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "b1391668-9404-4619-9d16-6088003733d9", false, "karimssdddss", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "d6241ef3-d60f-4641-b440-ef7a28b54133", 0, "194247a7-fb00-4837-8e57-225a674d8169", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "3e6313e0-f178-4120-8b4a-1bc8ae7b1950", false, "karimssss", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "edb26b60-a909-4f1b-bc30-b36e9a2d6a95", 0, "b47f9eea-bc31-4406-b273-820adad7a06e", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "c14b6b97-f3ff-4e35-8a26-02948d21e4c5", false, "karimAhmed", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_requests_pationtId",
                table: "requests",
                column: "pationtId");

            migrationBuilder.AddForeignKey(
                name: "FK_requests_AspNetUsers_pationtId",
                table: "requests",
                column: "pationtId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_requests_doctors_doctorid",
                table: "requests",
                column: "doctorid",
                principalTable: "doctors",
                principalColumn: "id");
        }
    }
}
