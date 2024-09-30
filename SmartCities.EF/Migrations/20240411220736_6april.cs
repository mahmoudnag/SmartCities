using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class _6april : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProjectTeam",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TeamId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTeam_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTeam_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b73996a-4a0f-49c8-abeb-5b0b4ea103e7", "AQAAAAIAAYagAAAAELBF9RGz+ro3k6xOGD0wfZju/Fi1+awsuykCHdCcc00DFwxIyToPG7xl2U3usenOcQ==", "7c0b89fe-b82a-44b0-9e63-c1d354127bc1" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeam_ProjectId",
                table: "ProjectTeam",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeam_TeamId",
                table: "ProjectTeam",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products",
                column: "ParentProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProjectTeam");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df0228ca-5134-4086-a820-a64568e9787d", "AQAAAAIAAYagAAAAEPQpYsFPRT6EX/kuandXbwuC7xH1jjxaVKaLeCH6Q0cqnBqCSez10ocoPbLPwtXHbw==", "e61c1bb6-b97b-4fcc-9018-c5a04c4d59cb" });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products",
                column: "ParentProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
