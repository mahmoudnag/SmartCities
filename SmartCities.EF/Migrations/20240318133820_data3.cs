using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_UserId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_UserId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eb5115a-dc13-40d0-9ab1-d7d4f5ad3562", "AQAAAAIAAYagAAAAEPPTB3jkxVffeh15Fwn7hmrkV232MvObNW7awai56U2oTDhVS22XFgRAIEexyQJR8g==", "4d99de89-0a38-40be-9333-56b9a3d5f01d" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Area", "City", "Country", "CreateBy", "Email", "Logo", "Name", "UpdateAt", "UpdateBy", "WebSiteUrl", "phoneNumber" },
                values: new object[,]
                {
                    { "1", "Assuit", "Assuit", "Egypt", "8e445865-a24d-4543-a6c6-9443d048cdb9", "mahmoudfci57@gmail.com", "/img/project-1.jpg", "google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "xxxxxxxxxxxxxxxxx", "0000000000" },
                    { "2", "Assuit", "Assuit", "Egypt", "8e445865-a24d-4543-a6c6-9443d048cdb9", "mahmoudfci57@gmail.com", "/img/project-1.jpg", "microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "xxxxxxxxxxxxxxxxx", "0000000000" }
                });

            migrationBuilder.InsertData(
                table: "Parteners",
                columns: new[] { "Id", "Address", "CreateBy", "Email", "LogoUrl", "Name", "UpdateAt", "UpdateBy", "phoneNumber" },
                values: new object[,]
                {
                    { "1", "Assuit", "8e445865-a24d-4543-a6c6-9443d048cdb9", "mahmoudfci57@gmail.com", "/img/project-1.jpg", "google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "0000000000" },
                    { "2", "cairo", "8e445865-a24d-4543-a6c6-9443d048cdb9", "mahmoudfci57@gmail.com", "/img/project-1.jpg", "microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "0000000000" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreateBy", "ImageUrl", "JobTitle", "Name", "UpdateAt", "UpdateBy" },
                values: new object[,]
                {
                    { "1", "8e445865-a24d-4543-a6c6-9443d048cdb9", "/img/mahmoud.jpeg", "SoftWare Engineer", "Mahmoud", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "2", "8e445865-a24d-4543-a6c6-9443d048cdb9", "/img/gamal.jpg", "gate2 discription", "Gamal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CreateBy",
                table: "Clients",
                column: "CreateBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_CreateBy",
                table: "Clients",
                column: "CreateBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_CreateBy",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CreateBy",
                table: "Clients");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Parteners",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Parteners",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a3232eb-059b-47f3-8051-8f9e85e96de5", "AQAAAAIAAYagAAAAEGjBaHp/wWhQa+Vch6crCfHaOHAjn3ebZS7t00vLwqlsLrS8WPo1ui9jLk/b/koIMg==", "cdfde6f4-d08b-493a-924d-3ec464e6edc5" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_UserId",
                table: "Clients",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
