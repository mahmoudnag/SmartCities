using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Statues",
                table: "Teams",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Budget",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Compeletion",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Statues",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef9b5226-3498-4e9e-b378-5ce9a16371e9", "AQAAAAIAAYagAAAAEGcOtVbbdOsMWXhKKmtiSu42x7BxGbPI71gD4ySJ6LkEyKR1NwzLur68Bgo6qyNnfg==", "71d9f47d-6ad6-4efa-941d-6329e068f902" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Budget", "Compeletion", "Statues" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Budget", "Compeletion", "Statues" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Budget", "Compeletion", "Statues" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Budget", "Compeletion", "Statues" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "1",
                column: "Statues",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "2",
                column: "Statues",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "3",
                column: "Statues",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "4",
                column: "Statues",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Statues",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Compeletion",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Statues",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d79fb68-6b48-4db1-b4f3-1a075e4e7ed3", "AQAAAAIAAYagAAAAENHl7EMa8E5Yd0JB6hVgjSZOrzprghcuP19zZBttXiqwh1taxh71M2B3OYCWTg4agA==", "2c9db1f7-fc18-4d8f-b1e5-4156a23a2aa0" });
        }
    }
}
