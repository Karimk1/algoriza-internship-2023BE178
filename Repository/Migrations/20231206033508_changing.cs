using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class changing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_coupons_couponId",
                table: "requests");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120e48a2-da84-4a5d-955b-6d91fd3d3820");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15f7a60b-5591-4ee0-a7db-aae178e5ca4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29c0207e-4144-4c4b-9412-7d6b3c5a91e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ecfc360-3cfb-4147-8a39-3eb7e43a7044");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87402b3d-1f3a-4327-958c-f76e9949d1b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96a444ab-2651-4472-9e84-a1d2f7f36012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd6e57f0-20f1-448d-bce3-e2e823383e67");

            migrationBuilder.AlterColumn<double>(
                name: "finalPrice",
                table: "requests",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "couponId",
                table: "requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_requests_coupons_couponId",
                table: "requests",
                column: "couponId",
                principalTable: "coupons",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_coupons_couponId",
                table: "requests");

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

            migrationBuilder.AlterColumn<int>(
                name: "finalPrice",
                table: "requests",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "couponId",
                table: "requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "120e48a2-da84-4a5d-955b-6d91fd3d3820", 0, "05261203-9a35-450c-8d00-1527326033fd", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "3d14bf3a-4630-4b46-bc68-ad4218e089ba", false, "karim", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "15f7a60b-5591-4ee0-a7db-aae178e5ca4f", 0, "4b031f4a-df34-4e01-80ec-ffd992ac3ddc", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "8f51c1f3-fae0-40f7-92e9-6e7825cfd11d", false, "karimssss", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "29c0207e-4144-4c4b-9412-7d6b3c5a91e4", 0, "b8d205b4-9cd2-4029-9258-b0b85ad73839", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "47847ba6-cc16-4734-bff7-716bba465f84", false, "Ahmed", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "3ecfc360-3cfb-4147-8a39-3eb7e43a7044", 0, "b5beddd5-2e07-499b-900e-a6896011d7e4", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "b9394229-0f9c-47b6-9e87-9f3470724fd8", false, "karimAhmed", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "87402b3d-1f3a-4327-958c-f76e9949d1b6", 0, "859d7616-b7af-40f9-b3c3-322832bc69c7", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "9f4e9391-0c31-4abd-8655-7ad0bec0df50", false, "karimssdddss", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "96a444ab-2651-4472-9e84-a1d2f7f36012", 0, "952cff58-f866-4c88-a43a-d3cff754a418", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "09f8fe0b-055b-48dd-a73b-dd89e457e441", false, "karimkamel", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "dd6e57f0-20f1-448d-bce3-e2e823383e67", 0, "f2e1fb83-3ea0-4b2c-bf5e-9412a6547035", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "df65b9ab-2ba8-4da5-a31d-320a279fd8ee", false, "Sarakamel", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_requests_coupons_couponId",
                table: "requests",
                column: "couponId",
                principalTable: "coupons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
