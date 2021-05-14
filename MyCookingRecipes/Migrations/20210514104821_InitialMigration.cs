using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCookingRecipes.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Przepisy",
                columns: table => new
                {
                    PrzepisyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaPotrawy = table.Column<string>(nullable: true),
                    CzasPrzygotowania = table.Column<int>(nullable: false),
                    IloscPorcji = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przepisy", x => x.PrzepisyId);
                });

            migrationBuilder.CreateTable(
                name: "RodzajIlosciSkladnikow",
                columns: table => new
                {
                    RodzajIlosciSkladnikaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Liczebność = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RodzajIlosciSkladnikow", x => x.RodzajIlosciSkladnikaId);
                });

            migrationBuilder.CreateTable(
                name: "DataWybraniaPrzepisow",
                columns: table => new
                {
                    DataWybraniaPrzepisuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPrzepisu = table.Column<int>(nullable: false),
                    DataWybrania = table.Column<DateTime>(nullable: false),
                    PrzepisyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataWybraniaPrzepisow", x => x.DataWybraniaPrzepisuId);
                    table.ForeignKey(
                        name: "FK_DataWybraniaPrzepisow_Przepisy_PrzepisyId",
                        column: x => x.PrzepisyId,
                        principalTable: "Przepisy",
                        principalColumn: "PrzepisyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KrokiPrzygotowaniaPrzepisow",
                columns: table => new
                {
                    KrokiPrzygotowaniaPrzepisuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPrzepisu = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    KolejnoscWPrzepisie = table.Column<int>(nullable: false),
                    PrzepisyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrokiPrzygotowaniaPrzepisow", x => x.KrokiPrzygotowaniaPrzepisuId);
                    table.ForeignKey(
                        name: "FK_KrokiPrzygotowaniaPrzepisow_Przepisy_PrzepisyId",
                        column: x => x.PrzepisyId,
                        principalTable: "Przepisy",
                        principalColumn: "PrzepisyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ulubione",
                columns: table => new
                {
                    UlubioneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPrzepisu = table.Column<int>(nullable: false),
                    CzySystemDodal = table.Column<bool>(nullable: false),
                    PrzepisyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulubione", x => x.UlubioneId);
                    table.ForeignKey(
                        name: "FK_Ulubione_Przepisy_PrzepisyId",
                        column: x => x.PrzepisyId,
                        principalTable: "Przepisy",
                        principalColumn: "PrzepisyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skladniki",
                columns: table => new
                {
                    SkladnikiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRodzajuIlosciSkladnika = table.Column<int>(nullable: false),
                    NazwaSkladnika = table.Column<string>(nullable: true),
                    RodzajIlosciSkladnikaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladniki", x => x.SkladnikiId);
                    table.ForeignKey(
                        name: "FK_Skladniki_RodzajIlosciSkladnikow_RodzajIlosciSkladnikaId",
                        column: x => x.RodzajIlosciSkladnikaId,
                        principalTable: "RodzajIlosciSkladnikow",
                        principalColumn: "RodzajIlosciSkladnikaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkladnikiWPrzepisach",
                columns: table => new
                {
                    SkladnikWPrzepisieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPrzepisu = table.Column<int>(nullable: false),
                    IdSkladnika = table.Column<int>(nullable: false),
                    Ilosc = table.Column<decimal>(nullable: false),
                    PrzepisyId = table.Column<int>(nullable: true),
                    SkladnikiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkladnikiWPrzepisach", x => x.SkladnikWPrzepisieId);
                    table.ForeignKey(
                        name: "FK_SkladnikiWPrzepisach_Przepisy_PrzepisyId",
                        column: x => x.PrzepisyId,
                        principalTable: "Przepisy",
                        principalColumn: "PrzepisyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkladnikiWPrzepisach_Skladniki_SkladnikiId",
                        column: x => x.SkladnikiId,
                        principalTable: "Skladniki",
                        principalColumn: "SkladnikiId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataWybraniaPrzepisow_PrzepisyId",
                table: "DataWybraniaPrzepisow",
                column: "PrzepisyId");

            migrationBuilder.CreateIndex(
                name: "IX_KrokiPrzygotowaniaPrzepisow_PrzepisyId",
                table: "KrokiPrzygotowaniaPrzepisow",
                column: "PrzepisyId");

            migrationBuilder.CreateIndex(
                name: "IX_Skladniki_RodzajIlosciSkladnikaId",
                table: "Skladniki",
                column: "RodzajIlosciSkladnikaId");

            migrationBuilder.CreateIndex(
                name: "IX_SkladnikiWPrzepisach_PrzepisyId",
                table: "SkladnikiWPrzepisach",
                column: "PrzepisyId");

            migrationBuilder.CreateIndex(
                name: "IX_SkladnikiWPrzepisach_SkladnikiId",
                table: "SkladnikiWPrzepisach",
                column: "SkladnikiId");

            migrationBuilder.CreateIndex(
                name: "IX_Ulubione_PrzepisyId",
                table: "Ulubione",
                column: "PrzepisyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataWybraniaPrzepisow");

            migrationBuilder.DropTable(
                name: "KrokiPrzygotowaniaPrzepisow");

            migrationBuilder.DropTable(
                name: "SkladnikiWPrzepisach");

            migrationBuilder.DropTable(
                name: "Ulubione");

            migrationBuilder.DropTable(
                name: "Skladniki");

            migrationBuilder.DropTable(
                name: "Przepisy");

            migrationBuilder.DropTable(
                name: "RodzajIlosciSkladnikow");
        }
    }
}
