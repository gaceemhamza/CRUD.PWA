using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPWA.Migrations
{
    public partial class add_Campany_CampanyEmploye1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Siret = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    adresse = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campanies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campanies");
        }
    }
}
