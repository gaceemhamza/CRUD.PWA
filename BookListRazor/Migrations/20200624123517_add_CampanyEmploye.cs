using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPWA.Migrations
{
    public partial class add_CampanyEmploye : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CampanyEmploye",
                columns: table => new
                {
                    EmployeId = table.Column<int>(nullable: false),
                    CampanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanyEmploye", x => new { x.CampanyId, x.EmployeId });
                    table.ForeignKey(
                        name: "FK_CampanyEmploye_Campanies_CampanyId",
                        column: x => x.CampanyId,
                        principalTable: "Campanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampanyEmploye_Employe_EmployeId",
                        column: x => x.EmployeId,
                        principalTable: "Employe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampanyEmploye_EmployeId",
                table: "CampanyEmploye",
                column: "EmployeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampanyEmploye");
        }
    }
}
