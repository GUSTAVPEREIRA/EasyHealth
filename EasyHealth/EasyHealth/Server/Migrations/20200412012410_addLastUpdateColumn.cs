using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyHealth.Server.Migrations
{
    public partial class addLastUpdateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "SupplyCategories",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "HospitalSupplies",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "SupplyCategories");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "HospitalSupplies");
        }
    }
}
