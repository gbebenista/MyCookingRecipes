using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCookingRecipes.Migrations
{
    public partial class Secon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPrzepisu",
                table: "Ulubione");

            migrationBuilder.DropColumn(
                name: "IdPrzepisu",
                table: "SkladnikiWPrzepisach");

            migrationBuilder.DropColumn(
                name: "IdSkladnika",
                table: "SkladnikiWPrzepisach");

            migrationBuilder.DropColumn(
                name: "IdRodzajuIlosciSkladnika",
                table: "Skladniki");

            migrationBuilder.DropColumn(
                name: "IdPrzepisu",
                table: "KrokiPrzygotowaniaPrzepisow");

            migrationBuilder.DropColumn(
                name: "IdPrzepisu",
                table: "DataWybraniaPrzepisow");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPrzepisu",
                table: "Ulubione",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPrzepisu",
                table: "SkladnikiWPrzepisach",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSkladnika",
                table: "SkladnikiWPrzepisach",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRodzajuIlosciSkladnika",
                table: "Skladniki",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPrzepisu",
                table: "KrokiPrzygotowaniaPrzepisow",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPrzepisu",
                table: "DataWybraniaPrzepisow",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
