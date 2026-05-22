using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperShop_Management.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeRequisitionMasterDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRequisitions_Products_ItemId",
                table: "EmployeeRequisitions");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeRequisitions_ItemId",
                table: "EmployeeRequisitions");

            migrationBuilder.DropColumn(
                name: "CurrentStock",
                table: "EmployeeRequisitions");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "EmployeeRequisitions");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "EmployeeRequisitions");

            migrationBuilder.DropColumn(
                name: "RequiredQty",
                table: "EmployeeRequisitions");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "EmployeeRequisitions",
                newName: "Notes");

            migrationBuilder.AddColumn<DateTime>(
                name: "RequiredByDate",
                table: "EmployeeRequisitions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeRequisitionItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeRequisitionId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequiredQty = table.Column<int>(type: "int", nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRequisitionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeRequisitionItems_EmployeeRequisitions_EmployeeRequisitionId",
                        column: x => x.EmployeeRequisitionId,
                        principalTable: "EmployeeRequisitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeRequisitionItems_Products_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequisitionItems_EmployeeRequisitionId",
                table: "EmployeeRequisitionItems",
                column: "EmployeeRequisitionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequisitionItems_ItemId",
                table: "EmployeeRequisitionItems",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeRequisitionItems");

            migrationBuilder.DropColumn(
                name: "RequiredByDate",
                table: "EmployeeRequisitions");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "EmployeeRequisitions",
                newName: "Remarks");

            migrationBuilder.AddColumn<int>(
                name: "CurrentStock",
                table: "EmployeeRequisitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "EmployeeRequisitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "EmployeeRequisitions",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RequiredQty",
                table: "EmployeeRequisitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequisitions_ItemId",
                table: "EmployeeRequisitions",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRequisitions_Products_ItemId",
                table: "EmployeeRequisitions",
                column: "ItemId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
