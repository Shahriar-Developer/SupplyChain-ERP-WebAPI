using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperShop_Management.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationAndGRN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StorageLocationId",
                table: "Inventories");

            migrationBuilder.AddColumn<int>(
                name: "FromAisleId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FromBinId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FromFloorId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FromRackId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FromShelfId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FromWarehouseId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FromZoneId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToAisleId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToBinId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToFloorId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToRackId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToShelfId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToWarehouseId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToZoneId",
                table: "StockMovements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AisleId",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BinId",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FloorId",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RackId",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShelfId",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZoneId",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    FloorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WarehouseId = table.Column<int>(type: "int", nullable: true),
                    WarehouseId1 = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.FloorId);
                    table.ForeignKey(
                        name: "FK_Floors_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Floors_Warehouses_WarehouseId1",
                        column: x => x.WarehouseId1,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId");
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    ZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoneName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true),
                    WarehouseId = table.Column<int>(type: "int", nullable: true),
                    FloorId1 = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.ZoneId);
                    table.ForeignKey(
                        name: "FK_Zones_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "FloorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zones_Floors_FloorId1",
                        column: x => x.FloorId1,
                        principalTable: "Floors",
                        principalColumn: "FloorId");
                    table.ForeignKey(
                        name: "FK_Zones_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId");
                });

            migrationBuilder.CreateTable(
                name: "Aisles",
                columns: table => new
                {
                    AisleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AisleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ZoneId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true),
                    WarehouseId = table.Column<int>(type: "int", nullable: true),
                    ZoneId1 = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aisles", x => x.AisleId);
                    table.ForeignKey(
                        name: "FK_Aisles_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "FloorId");
                    table.ForeignKey(
                        name: "FK_Aisles_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId");
                    table.ForeignKey(
                        name: "FK_Aisles_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "ZoneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aisles_Zones_ZoneId1",
                        column: x => x.ZoneId1,
                        principalTable: "Zones",
                        principalColumn: "ZoneId");
                });

            migrationBuilder.CreateTable(
                name: "Racks",
                columns: table => new
                {
                    RackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RackName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AisleId = table.Column<int>(type: "int", nullable: true),
                    ZoneId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true),
                    WarehouseId = table.Column<int>(type: "int", nullable: true),
                    AisleId1 = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racks", x => x.RackId);
                    table.ForeignKey(
                        name: "FK_Racks_Aisles_AisleId",
                        column: x => x.AisleId,
                        principalTable: "Aisles",
                        principalColumn: "AisleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racks_Aisles_AisleId1",
                        column: x => x.AisleId1,
                        principalTable: "Aisles",
                        principalColumn: "AisleId");
                    table.ForeignKey(
                        name: "FK_Racks_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "FloorId");
                    table.ForeignKey(
                        name: "FK_Racks_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId");
                    table.ForeignKey(
                        name: "FK_Racks_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "ZoneId");
                });

            migrationBuilder.CreateTable(
                name: "Shelves",
                columns: table => new
                {
                    ShelfId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShelfName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RackId = table.Column<int>(type: "int", nullable: true),
                    AisleId = table.Column<int>(type: "int", nullable: true),
                    ZoneId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true),
                    WarehouseId = table.Column<int>(type: "int", nullable: true),
                    RackId1 = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.ShelfId);
                    table.ForeignKey(
                        name: "FK_Shelves_Aisles_AisleId",
                        column: x => x.AisleId,
                        principalTable: "Aisles",
                        principalColumn: "AisleId");
                    table.ForeignKey(
                        name: "FK_Shelves_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "FloorId");
                    table.ForeignKey(
                        name: "FK_Shelves_Racks_RackId",
                        column: x => x.RackId,
                        principalTable: "Racks",
                        principalColumn: "RackId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shelves_Racks_RackId1",
                        column: x => x.RackId1,
                        principalTable: "Racks",
                        principalColumn: "RackId");
                    table.ForeignKey(
                        name: "FK_Shelves_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId");
                    table.ForeignKey(
                        name: "FK_Shelves_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "ZoneId");
                });

            migrationBuilder.CreateTable(
                name: "Bins",
                columns: table => new
                {
                    BinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShelfId = table.Column<int>(type: "int", nullable: true),
                    RackId = table.Column<int>(type: "int", nullable: true),
                    AisleId = table.Column<int>(type: "int", nullable: true),
                    ZoneId = table.Column<int>(type: "int", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true),
                    WarehouseId = table.Column<int>(type: "int", nullable: true),
                    ShelfId1 = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bins", x => x.BinId);
                    table.ForeignKey(
                        name: "FK_Bins_Aisles_AisleId",
                        column: x => x.AisleId,
                        principalTable: "Aisles",
                        principalColumn: "AisleId");
                    table.ForeignKey(
                        name: "FK_Bins_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "FloorId");
                    table.ForeignKey(
                        name: "FK_Bins_Racks_RackId",
                        column: x => x.RackId,
                        principalTable: "Racks",
                        principalColumn: "RackId");
                    table.ForeignKey(
                        name: "FK_Bins_Shelves_ShelfId",
                        column: x => x.ShelfId,
                        principalTable: "Shelves",
                        principalColumn: "ShelfId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bins_Shelves_ShelfId1",
                        column: x => x.ShelfId1,
                        principalTable: "Shelves",
                        principalColumn: "ShelfId");
                    table.ForeignKey(
                        name: "FK_Bins_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId");
                    table.ForeignKey(
                        name: "FK_Bins_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "ZoneId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_FromAisleId",
                table: "StockMovements",
                column: "FromAisleId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_FromBinId",
                table: "StockMovements",
                column: "FromBinId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_FromFloorId",
                table: "StockMovements",
                column: "FromFloorId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_FromRackId",
                table: "StockMovements",
                column: "FromRackId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_FromShelfId",
                table: "StockMovements",
                column: "FromShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_FromWarehouseId",
                table: "StockMovements",
                column: "FromWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_FromZoneId",
                table: "StockMovements",
                column: "FromZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ToAisleId",
                table: "StockMovements",
                column: "ToAisleId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ToBinId",
                table: "StockMovements",
                column: "ToBinId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ToFloorId",
                table: "StockMovements",
                column: "ToFloorId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ToRackId",
                table: "StockMovements",
                column: "ToRackId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ToShelfId",
                table: "StockMovements",
                column: "ToShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ToWarehouseId",
                table: "StockMovements",
                column: "ToWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ToZoneId",
                table: "StockMovements",
                column: "ToZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_AisleId",
                table: "Inventories",
                column: "AisleId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_BinId",
                table: "Inventories",
                column: "BinId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_FloorId",
                table: "Inventories",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_RackId",
                table: "Inventories",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ShelfId",
                table: "Inventories",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_WarehouseId",
                table: "Inventories",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ZoneId",
                table: "Inventories",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Aisles_FloorId",
                table: "Aisles",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Aisles_WarehouseId",
                table: "Aisles",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Aisles_ZoneId",
                table: "Aisles",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Aisles_ZoneId1",
                table: "Aisles",
                column: "ZoneId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bins_AisleId",
                table: "Bins",
                column: "AisleId");

            migrationBuilder.CreateIndex(
                name: "IX_Bins_FloorId",
                table: "Bins",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bins_RackId",
                table: "Bins",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Bins_ShelfId",
                table: "Bins",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_Bins_ShelfId1",
                table: "Bins",
                column: "ShelfId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bins_WarehouseId",
                table: "Bins",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Bins_ZoneId",
                table: "Bins",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_WarehouseId",
                table: "Floors",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_WarehouseId1",
                table: "Floors",
                column: "WarehouseId1");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_AisleId",
                table: "Racks",
                column: "AisleId");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_AisleId1",
                table: "Racks",
                column: "AisleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_FloorId",
                table: "Racks",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_WarehouseId",
                table: "Racks",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_ZoneId",
                table: "Racks",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_AisleId",
                table: "Shelves",
                column: "AisleId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_FloorId",
                table: "Shelves",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_RackId",
                table: "Shelves",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_RackId1",
                table: "Shelves",
                column: "RackId1");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_WarehouseId",
                table: "Shelves",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_ZoneId",
                table: "Shelves",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_FloorId",
                table: "Zones",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_FloorId1",
                table: "Zones",
                column: "FloorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_WarehouseId",
                table: "Zones",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Aisles_AisleId",
                table: "Inventories",
                column: "AisleId",
                principalTable: "Aisles",
                principalColumn: "AisleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Bins_BinId",
                table: "Inventories",
                column: "BinId",
                principalTable: "Bins",
                principalColumn: "BinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Floors_FloorId",
                table: "Inventories",
                column: "FloorId",
                principalTable: "Floors",
                principalColumn: "FloorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Racks_RackId",
                table: "Inventories",
                column: "RackId",
                principalTable: "Racks",
                principalColumn: "RackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Shelves_ShelfId",
                table: "Inventories",
                column: "ShelfId",
                principalTable: "Shelves",
                principalColumn: "ShelfId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Warehouses_WarehouseId",
                table: "Inventories",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Zones_ZoneId",
                table: "Inventories",
                column: "ZoneId",
                principalTable: "Zones",
                principalColumn: "ZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Aisles_FromAisleId",
                table: "StockMovements",
                column: "FromAisleId",
                principalTable: "Aisles",
                principalColumn: "AisleId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Aisles_ToAisleId",
                table: "StockMovements",
                column: "ToAisleId",
                principalTable: "Aisles",
                principalColumn: "AisleId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Bins_FromBinId",
                table: "StockMovements",
                column: "FromBinId",
                principalTable: "Bins",
                principalColumn: "BinId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Bins_ToBinId",
                table: "StockMovements",
                column: "ToBinId",
                principalTable: "Bins",
                principalColumn: "BinId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Floors_FromFloorId",
                table: "StockMovements",
                column: "FromFloorId",
                principalTable: "Floors",
                principalColumn: "FloorId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Floors_ToFloorId",
                table: "StockMovements",
                column: "ToFloorId",
                principalTable: "Floors",
                principalColumn: "FloorId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Racks_FromRackId",
                table: "StockMovements",
                column: "FromRackId",
                principalTable: "Racks",
                principalColumn: "RackId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Racks_ToRackId",
                table: "StockMovements",
                column: "ToRackId",
                principalTable: "Racks",
                principalColumn: "RackId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Shelves_FromShelfId",
                table: "StockMovements",
                column: "FromShelfId",
                principalTable: "Shelves",
                principalColumn: "ShelfId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Shelves_ToShelfId",
                table: "StockMovements",
                column: "ToShelfId",
                principalTable: "Shelves",
                principalColumn: "ShelfId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Warehouses_FromWarehouseId",
                table: "StockMovements",
                column: "FromWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Warehouses_ToWarehouseId",
                table: "StockMovements",
                column: "ToWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Zones_FromZoneId",
                table: "StockMovements",
                column: "FromZoneId",
                principalTable: "Zones",
                principalColumn: "ZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Zones_ToZoneId",
                table: "StockMovements",
                column: "ToZoneId",
                principalTable: "Zones",
                principalColumn: "ZoneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Aisles_AisleId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Bins_BinId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Floors_FloorId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Racks_RackId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Shelves_ShelfId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Warehouses_WarehouseId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Zones_ZoneId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Aisles_FromAisleId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Aisles_ToAisleId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Bins_FromBinId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Bins_ToBinId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Floors_FromFloorId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Floors_ToFloorId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Racks_FromRackId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Racks_ToRackId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Shelves_FromShelfId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Shelves_ToShelfId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Warehouses_FromWarehouseId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Warehouses_ToWarehouseId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Zones_FromZoneId",
                table: "StockMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_StockMovements_Zones_ToZoneId",
                table: "StockMovements");

            migrationBuilder.DropTable(
                name: "Bins");

            migrationBuilder.DropTable(
                name: "Shelves");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "Aisles");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_FromAisleId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_FromBinId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_FromFloorId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_FromRackId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_FromShelfId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_FromWarehouseId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_FromZoneId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_ToAisleId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_ToBinId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_ToFloorId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_ToRackId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_ToShelfId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_ToWarehouseId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_StockMovements_ToZoneId",
                table: "StockMovements");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_AisleId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_BinId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_FloorId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_RackId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_ShelfId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_WarehouseId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_ZoneId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "FromAisleId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "FromBinId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "FromFloorId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "FromRackId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "FromShelfId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "FromWarehouseId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "FromZoneId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "ToAisleId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "ToBinId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "ToFloorId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "ToRackId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "ToShelfId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "ToWarehouseId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "ToZoneId",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "AisleId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "BinId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "FloorId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "RackId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "ShelfId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Inventories");

            migrationBuilder.AddColumn<int>(
                name: "StorageLocationId",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
