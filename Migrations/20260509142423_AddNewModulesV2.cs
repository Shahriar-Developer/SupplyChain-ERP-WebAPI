using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperShop_Management.Migrations
{
    /// <inheritdoc />
    public partial class AddNewModulesV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SubmittedAt",
                table: "SupplierQuotations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidityDate",
                table: "SupplierQuotations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SourceRequisitionId",
                table: "Requisitions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryType",
                table: "PurchaseOrders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "MDApprovedAt",
                table: "PurchaseOrders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MDApprovedById",
                table: "PurchaseOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SentAt",
                table: "PurchaseOrders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiveType",
                table: "GRNs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StoreApprovedAt",
                table: "GRNs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreApprovedById",
                table: "GRNs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "GRNItems",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "SelectedQuotationItemId",
                table: "CSItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "CSItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CSSupplierRows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CSId = table.Column<int>(type: "int", nullable: false),
                    CSItemId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    QuotationItemId = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    SelectedReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSSupplierRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CSSupplierRows_CSItems_CSItemId",
                        column: x => x.CSItemId,
                        principalTable: "CSItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CSSupplierRows_ComparativeStatements_CSId",
                        column: x => x.CSId,
                        principalTable: "ComparativeStatements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CSSupplierRows_QuotationItems_QuotationItemId",
                        column: x => x.QuotationItemId,
                        principalTable: "QuotationItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CSSupplierRows_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRequisitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequisitionNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequiredQty = table.Column<int>(type: "int", nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    RequestedBy = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ForwardedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRequisitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeRequisitions_AspNetUsers_RequestedBy",
                        column: x => x.RequestedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeRequisitions_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeRequisitions_Products_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RFQSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RFQId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RFQSuppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RFQSuppliers_RequestForQuotations_RFQId",
                        column: x => x.RFQId,
                        principalTable: "RequestForQuotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RFQSuppliers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoreIssues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequisitionId = table.Column<int>(type: "int", nullable: false),
                    IssuedQty = table.Column<int>(type: "int", nullable: false),
                    IssueType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IssuedById = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IssuedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreIssues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreIssues_AspNetUsers_IssuedById",
                        column: x => x.IssuedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreIssues_EmployeeRequisitions_RequisitionId",
                        column: x => x.RequisitionId,
                        principalTable: "EmployeeRequisitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_MDApprovedById",
                table: "PurchaseOrders",
                column: "MDApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_GRNs_StoreApprovedById",
                table: "GRNs",
                column: "StoreApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_CSSupplierRows_CSId",
                table: "CSSupplierRows",
                column: "CSId");

            migrationBuilder.CreateIndex(
                name: "IX_CSSupplierRows_CSItemId",
                table: "CSSupplierRows",
                column: "CSItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CSSupplierRows_QuotationItemId",
                table: "CSSupplierRows",
                column: "QuotationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CSSupplierRows_SupplierId",
                table: "CSSupplierRows",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequisitions_DepartmentId",
                table: "EmployeeRequisitions",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequisitions_ItemId",
                table: "EmployeeRequisitions",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRequisitions_RequestedBy",
                table: "EmployeeRequisitions",
                column: "RequestedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RFQSuppliers_RFQId",
                table: "RFQSuppliers",
                column: "RFQId");

            migrationBuilder.CreateIndex(
                name: "IX_RFQSuppliers_SupplierId",
                table: "RFQSuppliers",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreIssues_IssuedById",
                table: "StoreIssues",
                column: "IssuedById");

            migrationBuilder.CreateIndex(
                name: "IX_StoreIssues_RequisitionId",
                table: "StoreIssues",
                column: "RequisitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_GRNs_AspNetUsers_StoreApprovedById",
                table: "GRNs",
                column: "StoreApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_AspNetUsers_MDApprovedById",
                table: "PurchaseOrders",
                column: "MDApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GRNs_AspNetUsers_StoreApprovedById",
                table: "GRNs");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_AspNetUsers_MDApprovedById",
                table: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "CSSupplierRows");

            migrationBuilder.DropTable(
                name: "RFQSuppliers");

            migrationBuilder.DropTable(
                name: "StoreIssues");

            migrationBuilder.DropTable(
                name: "EmployeeRequisitions");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrders_MDApprovedById",
                table: "PurchaseOrders");

            migrationBuilder.DropIndex(
                name: "IX_GRNs_StoreApprovedById",
                table: "GRNs");

            migrationBuilder.DropColumn(
                name: "SubmittedAt",
                table: "SupplierQuotations");

            migrationBuilder.DropColumn(
                name: "ValidityDate",
                table: "SupplierQuotations");

            migrationBuilder.DropColumn(
                name: "SourceRequisitionId",
                table: "Requisitions");

            migrationBuilder.DropColumn(
                name: "DeliveryType",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "MDApprovedAt",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "MDApprovedById",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "SentAt",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "ReceiveType",
                table: "GRNs");

            migrationBuilder.DropColumn(
                name: "StoreApprovedAt",
                table: "GRNs");

            migrationBuilder.DropColumn(
                name: "StoreApprovedById",
                table: "GRNs");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "GRNItems");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "CSItems");

            migrationBuilder.AlterColumn<int>(
                name: "SelectedQuotationItemId",
                table: "CSItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
