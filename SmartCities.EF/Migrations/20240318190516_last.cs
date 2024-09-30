using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c2b49d1-77b2-41ee-ba6d-957e759286b3", "AQAAAAIAAYagAAAAEKmPODSf8TTq4EsYTMHJqrVo65kUyrOWyqBG8e6SGRjTqrzIevEjNpS0E2QDLH6S+A==", "7a9af4ff-e950-4453-b911-15c8304c73dd" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "AboutUs", "Address", "FaceBookUr", "InstagramUrl", "LinkedInUrl", "Logo", "Mission", "Name", "PhoneNumber", "TwiterUrl", "vision" },
                values: new object[] { "1", "", "Assuit", "", "", "", "", "", "google", "", "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6ca98ac-3856-4bd4-adfd-7f0718f83ee8", "AQAAAAIAAYagAAAAEPmtqXxAUeVPlem6NhQ2aaNbDO46ukmiYn+HVNje67nEVq1WrOiQRv0NFTGIlc62FQ==", "d35bbdbe-9f34-4bb6-91ba-32ef98e36ea1" });
        }
    }
}
