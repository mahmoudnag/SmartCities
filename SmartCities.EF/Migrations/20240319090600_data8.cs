using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf58bfc1-0472-4f3f-9cdb-89aef00ff55c", "AQAAAAIAAYagAAAAEO8ZSJc8snp1nXweHuxkAZD2bEnzPiJxmWRsT39OmdGVS4CR9TRLe7UaX4K3rZLsEg==", "54b25865-43fa-476a-b6bd-121e5c484853" });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "FaceBookUr", "InstagramUrl", "LinkedInUrl", "Mission", "TwiterUrl", "vision" },
                values: new object[] { "x", "x", "x", "xxxxxxxxxxxx", "x", "xxxxxxxxxxxxxx" });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ClientId",
                table: "Comment",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c2b49d1-77b2-41ee-ba6d-957e759286b3", "AQAAAAIAAYagAAAAEKmPODSf8TTq4EsYTMHJqrVo65kUyrOWyqBG8e6SGRjTqrzIevEjNpS0E2QDLH6S+A==", "7a9af4ff-e950-4453-b911-15c8304c73dd" });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "FaceBookUr", "InstagramUrl", "LinkedInUrl", "Mission", "TwiterUrl", "vision" },
                values: new object[] { "", "", "", "", "", "" });
        }
    }
}
