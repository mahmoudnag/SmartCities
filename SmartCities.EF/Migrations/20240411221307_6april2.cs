using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class _6april2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeam_Projects_ProjectId",
                table: "ProjectTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeam_Teams_TeamId",
                table: "ProjectTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectTeam",
                table: "ProjectTeam");

            migrationBuilder.RenameTable(
                name: "ProjectTeam",
                newName: "ProjectTeams");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTeam_TeamId",
                table: "ProjectTeams",
                newName: "IX_ProjectTeams_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTeam_ProjectId",
                table: "ProjectTeams",
                newName: "IX_ProjectTeams_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectTeams",
                table: "ProjectTeams",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f715588-b41f-4ff2-a245-040136cdd33d", "AQAAAAIAAYagAAAAEL9qTnJREtOot3FUIXujBoiFR2z4ba8YpcY0mfsnVCYIIRfw7FAycpfMMYsBk5EOzQ==", "50661369-e91f-406d-9675-c5c2cc37c4c3" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTeams_Projects_ProjectId",
                table: "ProjectTeams",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTeams_Teams_TeamId",
                table: "ProjectTeams",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeams_Projects_ProjectId",
                table: "ProjectTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeams_Teams_TeamId",
                table: "ProjectTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectTeams",
                table: "ProjectTeams");

            migrationBuilder.RenameTable(
                name: "ProjectTeams",
                newName: "ProjectTeam");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTeams_TeamId",
                table: "ProjectTeam",
                newName: "IX_ProjectTeam_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTeams_ProjectId",
                table: "ProjectTeam",
                newName: "IX_ProjectTeam_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectTeam",
                table: "ProjectTeam",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b73996a-4a0f-49c8-abeb-5b0b4ea103e7", "AQAAAAIAAYagAAAAELBF9RGz+ro3k6xOGD0wfZju/Fi1+awsuykCHdCcc00DFwxIyToPG7xl2U3usenOcQ==", "7c0b89fe-b82a-44b0-9e63-c1d354127bc1" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTeam_Projects_ProjectId",
                table: "ProjectTeam",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTeam_Teams_TeamId",
                table: "ProjectTeam",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
