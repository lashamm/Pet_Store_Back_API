using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet_Store_Back_API.Migrations
{
    /// <inheritdoc />
    public partial class migraiton31426520 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pet_category",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pet_category",
                table: "ProductCategories");
        }
    }
}
