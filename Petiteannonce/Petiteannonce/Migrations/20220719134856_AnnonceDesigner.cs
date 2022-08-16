using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petiteannonce.Migrations
{
    public partial class AnnonceDesigner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_annonce_categorie_Categorie_id",
                table: "annonce");

            migrationBuilder.DropForeignKey(
                name: "FK_image_annonce_annonceId",
                table: "image");

            migrationBuilder.DropIndex(
                name: "IX_image_annonceId",
                table: "image");

            migrationBuilder.DropColumn(
                name: "annonceId",
                table: "image");

            migrationBuilder.RenameColumn(
                name: "Categorie_id",
                table: "annonce",
                newName: "categorie_id");

            migrationBuilder.RenameIndex(
                name: "IX_annonce_Categorie_id",
                table: "annonce",
                newName: "IX_annonce_categorie_id");

            migrationBuilder.CreateIndex(
                name: "IX_image_annonce_id",
                table: "image",
                column: "annonce_id");

            migrationBuilder.AddForeignKey(
                name: "FK_annonce_categorie_categorie_id",
                table: "annonce",
                column: "categorie_id",
                principalTable: "categorie",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_image_annonce_annonce_id",
                table: "image",
                column: "annonce_id",
                principalTable: "annonce",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_annonce_categorie_categorie_id",
                table: "annonce");

            migrationBuilder.DropForeignKey(
                name: "FK_image_annonce_annonce_id",
                table: "image");

            migrationBuilder.DropIndex(
                name: "IX_image_annonce_id",
                table: "image");

            migrationBuilder.RenameColumn(
                name: "categorie_id",
                table: "annonce",
                newName: "Categorie_id");

            migrationBuilder.RenameIndex(
                name: "IX_annonce_categorie_id",
                table: "annonce",
                newName: "IX_annonce_Categorie_id");

            migrationBuilder.AddColumn<int>(
                name: "annonceId",
                table: "image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_image_annonceId",
                table: "image",
                column: "annonceId");

            migrationBuilder.AddForeignKey(
                name: "FK_annonce_categorie_Categorie_id",
                table: "annonce",
                column: "Categorie_id",
                principalTable: "categorie",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_image_annonce_annonceId",
                table: "image",
                column: "annonceId",
                principalTable: "annonce",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
