using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "512db50c-45e2-4a58-8a48-c9d9e8f4d292", "AQAAAAIAAYagAAAAELBbGjiZ28xnfz1TBRJY4wMuDTAjPpqw2kcBKY+FEdbHCQgqIWPZqpVbHB2/VuHA/w==", "7856b8ab-3650-4789-86b9-93e0fe2ecc90" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5152f964-22a4-4748-a82d-19cbe0c20e9d", "AQAAAAIAAYagAAAAEFCBCU6nC1SpX82epfai327TRJ9iOGmGUnUQ+ktUrVxcY6nna1uQ6VnciD4Zg00gRg==", "4bc9ddf8-9bee-4aed-817f-2a816208b621" });
        }
    }
}
