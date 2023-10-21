using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDataLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gorevs",
                columns: table => new
                {
                    GorevNO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorevTanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GorevAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GorevPuan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevs", x => x.GorevNO);
                });

            migrationBuilder.CreateTable(
                name: "Projes",
                columns: table => new
                {
                    ProjeNO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaslamaTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projes", x => x.ProjeNO);
                });

            migrationBuilder.CreateTable(
                name: "Unvans",
                columns: table => new
                {
                    UnvanNO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvans", x => x.UnvanNO);
                });

            migrationBuilder.CreateTable(
                name: "Birimlers",
                columns: table => new
                {
                    BirimNO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimCalisanSayisi = table.Column<int>(type: "int", nullable: false),
                    GorevNO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birimlers", x => x.BirimNO);
                    table.ForeignKey(
                        name: "FK_Birimlers_Gorevs_GorevNO",
                        column: x => x.GorevNO,
                        principalTable: "Gorevs",
                        principalColumn: "GorevNO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GorevProje",
                columns: table => new
                {
                    GorevsGorevNO = table.Column<int>(type: "int", nullable: false),
                    ProjesProjeNO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevProje", x => new { x.GorevsGorevNO, x.ProjesProjeNO });
                    table.ForeignKey(
                        name: "FK_GorevProje_Gorevs_GorevsGorevNO",
                        column: x => x.GorevsGorevNO,
                        principalTable: "Gorevs",
                        principalColumn: "GorevNO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GorevProje_Projes_ProjesProjeNO",
                        column: x => x.ProjesProjeNO,
                        principalTable: "Projes",
                        principalColumn: "ProjeNO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelNO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelCinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelBTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonelVardiyeDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelMaas = table.Column<int>(type: "int", nullable: false),
                    PersonelPrim = table.Column<int>(type: "int", nullable: false),
                    GorevNO = table.Column<int>(type: "int", nullable: false),
                    UnvanNO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelNO);
                    table.ForeignKey(
                        name: "FK_Personels_Gorevs_GorevNO",
                        column: x => x.GorevNO,
                        principalTable: "Gorevs",
                        principalColumn: "GorevNO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personels_Unvans_UnvanNO",
                        column: x => x.UnvanNO,
                        principalTable: "Unvans",
                        principalColumn: "UnvanNO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cocuks",
                columns: table => new
                {
                    CocukNO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CocukAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CocukCinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CocukDogumTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonelNO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocuks", x => x.CocukNO);
                    table.ForeignKey(
                        name: "FK_Cocuks_Personels_PersonelNO",
                        column: x => x.PersonelNO,
                        principalTable: "Personels",
                        principalColumn: "PersonelNO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Birimlers_GorevNO",
                table: "Birimlers",
                column: "GorevNO");

            migrationBuilder.CreateIndex(
                name: "IX_Cocuks_PersonelNO",
                table: "Cocuks",
                column: "PersonelNO");

            migrationBuilder.CreateIndex(
                name: "IX_GorevProje_ProjesProjeNO",
                table: "GorevProje",
                column: "ProjesProjeNO");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_GorevNO",
                table: "Personels",
                column: "GorevNO");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_UnvanNO",
                table: "Personels",
                column: "UnvanNO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Birimlers");

            migrationBuilder.DropTable(
                name: "Cocuks");

            migrationBuilder.DropTable(
                name: "GorevProje");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Projes");

            migrationBuilder.DropTable(
                name: "Gorevs");

            migrationBuilder.DropTable(
                name: "Unvans");
        }
    }
}
