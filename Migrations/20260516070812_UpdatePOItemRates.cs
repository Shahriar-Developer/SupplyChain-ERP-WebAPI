using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperShop_Management.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePOItemRates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "POItems",
                newName: "SupplierRate");

            migrationBuilder.AddColumn<decimal>(
                name: "PORate",
                table: "POItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PORate",
                table: "POItems");

            migrationBuilder.RenameColumn(
                name: "SupplierRate",
                table: "POItems",
                newName: "UnitPrice");
        }
    }
}
