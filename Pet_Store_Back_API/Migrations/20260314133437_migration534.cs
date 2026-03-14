using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet_Store_Back_API.Migrations
{
    /// <inheritdoc />
    public partial class migration534 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductId",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategories_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_ProductId",
                table: "Product",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategories_ProductCategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_ProductId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Product");
        }
    }
}
