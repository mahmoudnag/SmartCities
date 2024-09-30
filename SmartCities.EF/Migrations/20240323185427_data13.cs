using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d79fb68-6b48-4db1-b4f3-1a075e4e7ed3", "AQAAAAIAAYagAAAAENHl7EMa8E5Yd0JB6hVgjSZOrzprghcuP19zZBttXiqwh1taxh71M2B3OYCWTg4agA==", "2c9db1f7-fc18-4d8f-b1e5-4156a23a2aa0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Requests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99d803d3-795a-4cc8-b295-4c338aeb3055", "AQAAAAIAAYagAAAAEKj2WTSIASsCaFYbri8R+ZTfy2F9Oc9hWo3ydzsAey3zTvrnmtvoQ7sEZCW6Cu+LZQ==", "d599973f-6dc0-4f3c-8b9b-7728603c2bac" });
        }
    }
}
