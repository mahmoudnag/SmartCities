using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "youtubeUrl",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61822d6b-5cce-49bb-bf6f-316ab4e8fd9a", "AQAAAAIAAYagAAAAEAzGTY03IXKvcg7RfJibOtpSeH28hBftRcMrnGP2ruEOX7JuHQoHFW85OtVHpzYZDg==", "891ccc7b-a450-4b2a-aed3-ec82041cbd24" });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Email", "youtubeUrl" },
                values: new object[] { "mahmfci57@gmail.com", "x" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "youtubeUrl",
                table: "Company");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0e30625-9253-46d2-9fbb-9d7630c62142", "AQAAAAIAAYagAAAAEEqdcx2JsiuKYKOCieXNy40ZAjmbw0nvJT5Rkb83OHqxDTSlTgPL3ElX8mdykxZhBg==", "89cb6f87-60f0-483a-8e33-6beeddcf08ba" });
        }
    }
}
