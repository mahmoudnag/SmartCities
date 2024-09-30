using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FaceBookUr",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InstagramUrl",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LinkedInUrl",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TwiterUrl",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a160533d-1dcd-4ea7-8b3c-d9b507c4db40", "AQAAAAIAAYagAAAAEHcasdg0WxKnqGS3WwW3pBZIvt0uRBXzx8JrFPvkuF5bZrL17+qQf+Wsw42LthLHGw==", "a1b73600-9927-4a2e-a07b-fad2f8260824" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreateAt", "CreateBy", "Description", "ImageUrl", "Logo", "Name", "UpdateAt", "UpdateBy" },
                values: new object[,]
                {
                    { "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "Project discription", "/img/project-1.jpg", "/img/project-1.jpg", "Project1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "Project2 discription", "/img/project-1.jpg", "/img/project-1.jpg", "Project2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "Project3 discription", "/img/project-1.jpg", "/img/project-1.jpg", "Project3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9", "Project4 discription", "/img/project-1.jpg", "/img/project-1.jpg", "Project4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreateBy",
                table: "Projects",
                column: "CreateBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropColumn(
                name: "FaceBookUr",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "InstagramUrl",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "LinkedInUrl",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "TwiterUrl",
                table: "Company");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96d0fe69-2d2d-4f7f-b779-5c00d21c3ee3", "AQAAAAIAAYagAAAAEOP7YTJQARKJb2wB72vf6H9A7h83VVJTYJ2JNhDpRnkl98Av2MnKeMT1OSTSaHuSHQ==", "3a784dde-e011-49ca-b086-c21ff31b5d26" });
        }
    }
}
