using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e7519ac-e282-46b3-a6a2-d0736dd96bee", "AQAAAAIAAYagAAAAEETGIiseqF0RQSziNbXWvtNrHU7uARFbPRdWDJKFUX8c4bmfCIyYuD7h3JtYF+1siw==", "84a5b1fd-9f0b-420e-978e-a008c6402ccb" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ClientId", "CreateAt", "CreateBy", "Description", "UpdateAt", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "external", "comment1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "external" },
                    { 2, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "external", "comment2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "external" },
                    { 3, "3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "external", "comment3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "external" },
                    { 4, "4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "external", "comment4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "external" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf58bfc1-0472-4f3f-9cdb-89aef00ff55c", "AQAAAAIAAYagAAAAEO8ZSJc8snp1nXweHuxkAZD2bEnzPiJxmWRsT39OmdGVS4CR9TRLe7UaX4K3rZLsEg==", "54b25865-43fa-476a-b6bd-121e5c484853" });
        }
    }
}
