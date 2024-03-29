﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyBanHang.WebApi.Migrations
{
    public partial class AdjustModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "Discription",
            //    table: "Items",
            //    newName: "Description");

            //migrationBuilder.AddColumn<int>(
            //    name: "CategoryId",
            //    table: "Items",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "CreatedDate",
            //    table: "Items",
            //    type: "datetime(6)",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<double>(
            //    name: "Discount",
            //    table: "Items",
            //    type: "double",
            //    nullable: false,
            //    defaultValue: 0.0);

            //migrationBuilder.AddColumn<bool>(
            //    name: "IsDelete",
            //    table: "Items",
            //    type: "tinyint(1)",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<double>(
            //    name: "Price",
            //    table: "Items",
            //    type: "double",
            //    nullable: false,
            //    defaultValue: 0.0);

            //migrationBuilder.AddColumn<int>(
            //    name: "Quantity",
            //    table: "Items",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<int>(
            //    name: "UnitId",
            //    table: "Items",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "UpdatedDate",
            //    table: "Items",
            //    type: "datetime(6)",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "CreatedDate",
            //    table: "Categories",
            //    type: "datetime(6)",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<bool>(
            //    name: "IsDelete",
            //    table: "Categories",
            //    type: "tinyint(1)",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<int>(
            //    name: "ParentId",
            //    table: "Categories",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "UpdatedDate",
            //    table: "Categories",
            //    type: "datetime(6)",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.CreateTable(
            //    name: "Guests",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Phone = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Guests", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "ItemImages",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Data = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemImages", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ItemImages_Items_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Items",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Orders",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        OrderNumber = table.Column<int>(type: "int", nullable: false),
            //        Description = table.Column<int>(type: "int", nullable: false),
            //        Voided = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        TotalPrice = table.Column<double>(type: "double", nullable: false),
            //        PaidAmount = table.Column<double>(type: "double", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Orders", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Roles",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Roles", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Statuses",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Statuses", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "UnitTypes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UnitTypes", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "OrderItems",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Voided = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        SalePrice = table.Column<double>(type: "double", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: true),
            //        OrderId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderItems", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_OrderItems_Items_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Items",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_OrderItems_Orders_OrderId",
            //            column: x => x.OrderId,
            //            principalTable: "Orders",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "GuestTables",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        StatusId = table.Column<int>(type: "int", nullable: true),
            //        GuestId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GuestTables", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_GuestTables_Guests_GuestId",
            //            column: x => x.GuestId,
            //            principalTable: "Guests",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_GuestTables_Statuses_StatusId",
            //            column: x => x.StatusId,
            //            principalTable: "Statuses",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Units",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        UnitTypeId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Units", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Units_UnitTypes_UnitTypeId",
            //            column: x => x.UnitTypeId,
            //            principalTable: "UnitTypes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Items_CategoryId",
            //    table: "Items",
            //    column: "CategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Items_UnitId",
            //    table: "Items",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTables_GuestId",
            //    table: "GuestTables",
            //    column: "GuestId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTables_StatusId",
            //    table: "GuestTables",
            //    column: "StatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ItemImages_ItemId",
            //    table: "ItemImages",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItems_ItemId",
            //    table: "OrderItems",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItems_OrderId",
            //    table: "OrderItems",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Units_UnitTypeId",
            //    table: "Units",
            //    column: "UnitTypeId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Items_Categories_CategoryId",
            //    table: "Items",
            //    column: "CategoryId",
            //    principalTable: "Categories",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Items_Units_UnitId",
            //    table: "Items",
            //    column: "UnitId",
            //    principalTable: "Units",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Items_Categories_CategoryId",
            //    table: "Items");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Items_Units_UnitId",
            //    table: "Items");

            //migrationBuilder.DropTable(
            //    name: "GuestTables");

            //migrationBuilder.DropTable(
            //    name: "ItemImages");

            //migrationBuilder.DropTable(
            //    name: "OrderItems");

            //migrationBuilder.DropTable(
            //    name: "Roles");

            //migrationBuilder.DropTable(
            //    name: "Units");

            //migrationBuilder.DropTable(
            //    name: "Guests");

            //migrationBuilder.DropTable(
            //    name: "Statuses");

            //migrationBuilder.DropTable(
            //    name: "Orders");

            //migrationBuilder.DropTable(
            //    name: "UnitTypes");

            //migrationBuilder.DropIndex(
            //    name: "IX_Items_CategoryId",
            //    table: "Items");

            //migrationBuilder.DropIndex(
            //    name: "IX_Items_UnitId",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "CategoryId",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "CreatedDate",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "Discount",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "IsDelete",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "Price",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "Quantity",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "UnitId",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "UpdatedDate",
            //    table: "Items");

            //migrationBuilder.DropColumn(
            //    name: "CreatedDate",
            //    table: "Categories");

            //migrationBuilder.DropColumn(
            //    name: "IsDelete",
            //    table: "Categories");

            //migrationBuilder.DropColumn(
            //    name: "ParentId",
            //    table: "Categories");

            //migrationBuilder.DropColumn(
            //    name: "UpdatedDate",
            //    table: "Categories");

            //migrationBuilder.RenameColumn(
            //    name: "Description",
            //    table: "Items",
            //    newName: "Discription");
        }
    }
}
