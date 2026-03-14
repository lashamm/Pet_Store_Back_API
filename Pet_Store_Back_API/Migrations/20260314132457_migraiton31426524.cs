using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet_Store_Back_API.Migrations
{
    /// <inheritdoc />
    public partial class migraiton31426524 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pet_category",
                table: "ProductCategories");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_PetCategoryId",
                table: "ProductCategories",
                column: "PetCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Pets_PetCategoryId",
                table: "ProductCategories",
                column: "PetCategoryId",
                principalTable: "Pets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Pets_PetCategoryId",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_PetCategoryId",
                table: "ProductCategories");

            migrationBuilder.AddColumn<int>(
                name: "pet_category",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
