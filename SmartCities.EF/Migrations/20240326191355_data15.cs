using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0c72099-b778-437e-aac8-bcabf85b10f9", "AQAAAAIAAYagAAAAEGPqCsZHHXCuPBzv65VQ9q4QXN8BvWnbccEaI6e94xgHu9Zw764TP2eEDv82nmau3Q==", "9d687d99-9313-4c7c-8006-49dbe7073e20" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1",
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2",
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3",
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4",
                column: "UserId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_UserId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef9b5226-3498-4e9e-b378-5ce9a16371e9", "AQAAAAIAAYagAAAAEGcOtVbbdOsMWXhKKmtiSu42x7BxGbPI71gD4ySJ6LkEyKR1NwzLur68Bgo6qyNnfg==", "71d9f47d-6ad6-4efa-941d-6329e068f902" });
        }
    }
}
