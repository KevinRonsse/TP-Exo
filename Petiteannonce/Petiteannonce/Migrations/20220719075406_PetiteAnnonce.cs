using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petiteannonce.Migrations
{
    public partial class PetiteAnnonce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "annonce",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "Text", nullable: false),
                    prix = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Categorie_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_annonce", x => x.id);
                    table.ForeignKey(
                        name: "FK_annonce_categorie_Categorie_id",
                        column: x => x.Categorie_id,
                        principalTable: "categorie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "image",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    annonce_id = table.Column<int>(type: "int", nullable: false),
                    annonceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_image", x => x.id);
                    table.ForeignKey(
                        name: "FK_image_annonce_annonceId",
                        column: x => x.annonceId,
                        principalTable: "annonce",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_annonce_Categorie_id",
                table: "annonce",
                column: "Categorie_id");

            migrationBuilder.CreateIndex(
                name: "IX_image_annonceId",
                table: "image",
                column: "annonceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "image");

            migrationBuilder.DropTable(
                name: "annonce");

            migrationBuilder.DropTable(
                name: "categorie");
        }
    }
}
