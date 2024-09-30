using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCities.EF.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientProducts_Product_ProductId",
                table: "ClientProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_ParentProductId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductParteners_Parteners_PartenerId",
                table: "ProductParteners");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductParteners_Product_ProductId",
                table: "ProductParteners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductParteners",
                table: "ProductParteners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "ProductParteners",
                newName: "PartenerProducts");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_ProductParteners_ProductId",
                table: "PartenerProducts",
                newName: "IX_PartenerProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductParteners_PartenerId",
                table: "PartenerProducts",
                newName: "IX_PartenerProducts_PartenerId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ParentProductId",
                table: "Products",
                newName: "IX_Products_ParentProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartenerProducts",
                table: "PartenerProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "2aec2d98-c9ac-4aed-956b-4355913774dd", "aufci266@gmail.com", true, "Gamal", "Kassem", false, null, "AUFCI266@GMAIL.COM", "AUFCI266@GMAIL.COM", "AQAAAAIAAYagAAAAEDcqAglSFCwesb9qn61rltKblAqMKTKrTfVHY/IDp8P9+wlviJuSzxUDhnCMq5hIqQ==", "01026691741", true, "c7075903-8cf7-46e2-8274-890cbe3c74b9", false, "aufci266@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProducts_Products_ProductId",
                table: "ClientProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartenerProducts_Parteners_PartenerId",
                table: "PartenerProducts",
                column: "PartenerId",
                principalTable: "Parteners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartenerProducts_Products_ProductId",
                table: "PartenerProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products",
                column: "ParentProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientProducts_Products_ProductId",
                table: "ClientProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PartenerProducts_Parteners_PartenerId",
                table: "PartenerProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PartenerProducts_Products_ProductId",
                table: "PartenerProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ParentProductId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartenerProducts",
                table: "PartenerProducts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "PartenerProducts",
                newName: "ProductParteners");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ParentProductId",
                table: "Product",
                newName: "IX_Product_ParentProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PartenerProducts_ProductId",
                table: "ProductParteners",
                newName: "IX_ProductParteners_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PartenerProducts_PartenerId",
                table: "ProductParteners",
                newName: "IX_ProductParteners_PartenerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductParteners",
                table: "ProductParteners",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProducts_Product_ProductId",
                table: "ClientProducts",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_ParentProductId",
                table: "Product",
                column: "ParentProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductParteners_Parteners_PartenerId",
                table: "ProductParteners",
                column: "PartenerId",
                principalTable: "Parteners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductParteners_Product_ProductId",
                table: "ProductParteners",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
