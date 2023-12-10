using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class appointmentTimeupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_AspNetUsers_pationtId1",
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
                name: "Day",
                table: "times");

            migrationBuilder.DropColumn(
                name: "pationtId1",
                table: "requests");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "times",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

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
                    { "1e03e343-6b94-4e95-a5c0-8a517a89eb2a", 0, "39b09c31-9118-44a8-b748-a042554a5af3", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "9fe61938-ffb7-41d5-8097-29b326bb9b47", false, "karimssdddss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "66cc0253-27d4-4b2e-a1b4-66c0a117bdf5", 0, "5803a0dc-ae61-4c13-9e19-f0537c93b9d1", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "065599ae-1f98-48bb-b3ff-ea7b0f7feb13", false, "karimssss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "7b650201-2bc9-4695-a272-33e7a8674b9b", 0, "b769c537-d8f8-4670-8a5b-6997cd58c6db", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "4e151649-dbf8-4860-9fe4-ce69195d3bc4", false, "karimAhmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "9ea68f3e-d1b6-4160-b41c-04bed45521a4", 0, "59295794-cf2f-4d35-af90-3634164e268c", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "c5ec5ba7-368c-4723-9349-c95cf219bda0", false, "Sarakamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "e255df8e-711c-4e91-99ed-689eaad7b653", 0, "131fa2bb-eb24-4d03-9352-c4f4caf0b65e", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "3dbd9ffa-3417-4f9b-a454-52e8283362c9", false, "Ahmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "f73557c5-3f85-4deb-9471-1675afa30cd6", 0, "d20b4d6e-5610-4935-9fb0-57134f690d15", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "f264f9db-20d0-45d4-a987-3922232df113", false, "karim", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "fcd3c9e0-84f6-4364-9725-a4b41c28b48e", 0, "f169f20c-c843-45a4-b5b1-ed8519ce7ac0", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "125366b9-3a39-472d-8fc8-f671037334ae", false, "karimkamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_AspNetUsers_pationtId",
                table: "requests");

            migrationBuilder.DropIndex(
                name: "IX_requests_pationtId",
                table: "requests");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e03e343-6b94-4e95-a5c0-8a517a89eb2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66cc0253-27d4-4b2e-a1b4-66c0a117bdf5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b650201-2bc9-4695-a272-33e7a8674b9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ea68f3e-d1b6-4160-b41c-04bed45521a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e255df8e-711c-4e91-99ed-689eaad7b653");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f73557c5-3f85-4deb-9471-1675afa30cd6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcd3c9e0-84f6-4364-9725-a4b41c28b48e");

            migrationBuilder.AlterColumn<bool>(
                name: "status",
                table: "times",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "times",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<float>(
                name: "Time",
                table: "Appointments",
                type: "real",
                nullable: false,
                defaultValue: 0f);

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
        }
    }
}
