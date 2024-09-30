using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FaceBookUrl",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Instagramurl",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LinkedInUrl",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TwitterUrl",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96d0fe69-2d2d-4f7f-b779-5c00d21c3ee3", "AQAAAAIAAYagAAAAEOP7YTJQARKJb2wB72vf6H9A7h83VVJTYJ2JNhDpRnkl98Av2MnKeMT1OSTSaHuSHQ==", "3a784dde-e011-49ca-b086-c21ff31b5d26" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Area", "City", "Country", "CreateBy", "Email", "Logo", "Name", "UpdateAt", "UpdateBy", "WebSiteUrl", "phoneNumber" },
                values: new object[,]
                {
                    { "3", "Assuit", "Assuit", "Egypt", "8e445865-a24d-4543-a6c6-9443d048cdb9", "mahmoudfci57@gmail.com", "/img/project-1.jpg", "google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "xxxxxxxxxxxxxxxxx", "0000000000" },
                    { "4", "Assuit", "Assuit", "Egypt", "8e445865-a24d-4543-a6c6-9443d048cdb9", "mahmoudfci57@gmail.com", "/img/project-1.jpg", "microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "xxxxxxxxxxxxxxxxx", "0000000000" }
                });

            migrationBuilder.InsertData(
                table: "Parteners",
                columns: new[] { "Id", "Address", "CreateBy", "Email", "LogoUrl", "Name", "UpdateAt", "UpdateBy", "phoneNumber" },
                values: new object[,]
                {
                    { "3", "Assuit", "8e445865-a24d-4543-a6c6-9443d048cdb9", "mahmoudfci57@gmail.com", "/img/project-1.jpg", "google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "0000000000" },
                    { "4", "Assuit", "8e445865-a24d-4543-a6c6-9443d048cdb9", "mahmoudfci57@gmail.com", "/img/project-1.jpg", "google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "0000000000" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "CreateBy", "Description", "ImageUrl", "Logo", "Name", "ParentProductId", "UpdateAt", "UpdateBy" },
                values: new object[,]
                {
                    { "3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "gate1 discription", "/img/project-1.jpg", "/img/project-1.jpg", "gate3", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "gate2 discription", "/img/project-1.jpg", "/img/project-1.jpg", "gate4", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "FaceBookUrl", "Instagramurl", "LinkedInUrl", "TwitterUrl" },
                values: new object[] { "x", "y", "x", "y" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "FaceBookUrl", "Instagramurl", "LinkedInUrl", "TwitterUrl" },
                values: new object[] { "x", "y", "x", "y" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreateBy", "FaceBookUrl", "ImageUrl", "Instagramurl", "JobTitle", "LinkedInUrl", "Name", "TwitterUrl", "UpdateAt", "UpdateBy" },
                values: new object[,]
                {
                    { "3", "8e445865-a24d-4543-a6c6-9443d048cdb9", "x", "/img/gamal.jpg", "y", "gate2 discription", "x", "Gamal", "y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "4", "8e445865-a24d-4543-a6c6-9443d048cdb9", "x", "/img/gamal.jpg", "y", "gate2 discription", "x", "Gamal", "y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Parteners",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Parteners",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DropColumn(
                name: "FaceBookUrl",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Instagramurl",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "LinkedInUrl",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TwitterUrl",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eb5115a-dc13-40d0-9ab1-d7d4f5ad3562", "AQAAAAIAAYagAAAAEPPTB3jkxVffeh15Fwn7hmrkV232MvObNW7awai56U2oTDhVS22XFgRAIEexyQJR8g==", "4d99de89-0a38-40be-9333-56b9a3d5f01d" });
        }
    }
}
