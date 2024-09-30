using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "level",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0e30625-9253-46d2-9fbb-9d7630c62142", "AQAAAAIAAYagAAAAEEqdcx2JsiuKYKOCieXNy40ZAjmbw0nvJT5Rkb83OHqxDTSlTgPL3ElX8mdykxZhBg==", "89cb6f87-60f0-483a-8e33-6beeddcf08ba" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "1",
                column: "level",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "2",
                column: "level",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "3",
                column: "level",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "4",
                column: "level",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateBy", "UpdateBy" },
                values: new object[] { "external", "external" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateBy", "UpdateBy" },
                values: new object[] { "external", "external" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "level",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e7519ac-e282-46b3-a6a2-d0736dd96bee", "AQAAAAIAAYagAAAAEETGIiseqF0RQSziNbXWvtNrHU7uARFbPRdWDJKFUX8c4bmfCIyYuD7h3JtYF+1siw==", "84a5b1fd-9f0b-420e-978e-a008c6402ccb" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateBy", "UpdateBy" },
                values: new object[] { "3", "3" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateBy", "UpdateBy" },
                values: new object[] { "4", "4" });
        }
    }
}
