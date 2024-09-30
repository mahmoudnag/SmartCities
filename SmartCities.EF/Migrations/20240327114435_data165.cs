using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data165 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Aims",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df0228ca-5134-4086-a820-a64568e9787d", "AQAAAAIAAYagAAAAEPQpYsFPRT6EX/kuandXbwuC7xH1jjxaVKaLeCH6Q0cqnBqCSez10ocoPbLPwtXHbw==", "e61c1bb6-b97b-4fcc-9018-c5a04c4d59cb" });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: "1",
                column: "Aims",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products",
                column: "ParentProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Aims",
                table: "Company");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4fc9ee8-69de-43ee-b80f-6c97f14317b4", "AQAAAAIAAYagAAAAEDbgnWOqFCcWFI6VUchipvdKcVfQ9MMiMsjlNcyp8AAa8RIzjiG8vqY7/YmRbnqt6w==", "2251c462-ab4a-4567-83ad-ab58492a2aa4" });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products",
                column: "ParentProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
