using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4fc9ee8-69de-43ee-b80f-6c97f14317b4", "AQAAAAIAAYagAAAAEDbgnWOqFCcWFI6VUchipvdKcVfQ9MMiMsjlNcyp8AAa8RIzjiG8vqY7/YmRbnqt6w==", "2251c462-ab4a-4567-83ad-ab58492a2aa4" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreateBy",
                table: "Products",
                column: "CreateBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_CreateBy",
                table: "Products",
                column: "CreateBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_CreateBy",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CreateBy",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
