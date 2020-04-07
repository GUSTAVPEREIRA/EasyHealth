using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyHealth.Server.Migrations
{
    public partial class HospitalSupply_And_HospitalSupplyCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplyCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HospitalSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SupplyCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalSupplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalSupplies_SupplyCategories_SupplyCategoryId",
                        column: x => x.SupplyCategoryId,
                        principalTable: "SupplyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSupplies_SupplyCategoryId",
                table: "HospitalSupplies",
                column: "SupplyCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalSupplies");

            migrationBuilder.DropTable(
                name: "SupplyCategories");
        }
    }
}
