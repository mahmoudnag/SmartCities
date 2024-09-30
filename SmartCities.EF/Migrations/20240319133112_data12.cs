using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "externel ContactRequests",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "externel ContactRequests",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "externel Subscriber"),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "externel Subscriber")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99d803d3-795a-4cc8-b295-4c338aeb3055", "AQAAAAIAAYagAAAAEKj2WTSIASsCaFYbri8R+ZTfy2F9Oc9hWo3ydzsAey3zTvrnmtvoQ7sEZCW6Cu+LZQ==", "d599973f-6dc0-4f3c-8b9b-7728603c2bac" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "externel ContactRequests");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "externel ContactRequests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61822d6b-5cce-49bb-bf6f-316ab4e8fd9a", "AQAAAAIAAYagAAAAEAzGTY03IXKvcg7RfJibOtpSeH28hBftRcMrnGP2ruEOX7JuHQoHFW85OtVHpzYZDg==", "891ccc7b-a450-4b2a-aed3-ec82041cbd24" });
        }
    }
}
