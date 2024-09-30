using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a3232eb-059b-47f3-8051-8f9e85e96de5", "AQAAAAIAAYagAAAAEGjBaHp/wWhQa+Vch6crCfHaOHAjn3ebZS7t00vLwqlsLrS8WPo1ui9jLk/b/koIMg==", "cdfde6f4-d08b-493a-924d-3ec464e6edc5" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "CreateBy", "Description", "ImageUrl", "Logo", "Name", "ParentProductId", "UpdateAt", "UpdateBy" },
                values: new object[,]
                {
                    { "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "gate1 discription", "/img/project-1.jpg", "/img/project-1.jpg", "gate1", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "gate2 discription", "/img/project-1.jpg", "/img/project-1.jpg", "gate2", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aec2d98-c9ac-4aed-956b-4355913774dd", "AQAAAAIAAYagAAAAEDcqAglSFCwesb9qn61rltKblAqMKTKrTfVHY/IDp8P9+wlviJuSzxUDhnCMq5hIqQ==", "c7075903-8cf7-46e2-8274-890cbe3c74b9" });
        }
    }
}
