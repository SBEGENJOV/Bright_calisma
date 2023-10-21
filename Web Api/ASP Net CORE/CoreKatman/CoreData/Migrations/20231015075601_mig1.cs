using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreData.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Derslers",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derslers", x => x.DersID);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencilers",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sinif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Giris = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencilers", x => x.OgrenciID);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmenlers",
                columns: table => new
                {
                    OgretmenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DersID = table.Column<int>(type: "int", nullable: false),
                    DerslerDersID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmenlers", x => x.OgretmenID);
                    table.ForeignKey(
                        name: "FK_Ogretmenlers_Derslers_DerslerDersID",
                        column: x => x.DerslerDersID,
                        principalTable: "Derslers",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DerslerOgrenciler",
                columns: table => new
                {
                    DerslersDersID = table.Column<int>(type: "int", nullable: false),
                    OgrencilersOgrenciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerslerOgrenciler", x => new { x.DerslersDersID, x.OgrencilersOgrenciID });
                    table.ForeignKey(
                        name: "FK_DerslerOgrenciler_Derslers_DerslersDersID",
                        column: x => x.DerslersDersID,
                        principalTable: "Derslers",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DerslerOgrenciler_Ogrencilers_OgrencilersOgrenciID",
                        column: x => x.OgrencilersOgrenciID,
                        principalTable: "Ogrencilers",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DerslerOgrenciler_OgrencilersOgrenciID",
                table: "DerslerOgrenciler",
                column: "OgrencilersOgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmenlers_DerslerDersID",
                table: "Ogretmenlers",
                column: "DerslerDersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DerslerOgrenciler");

            migrationBuilder.DropTable(
                name: "Ogretmenlers");

            migrationBuilder.DropTable(
                name: "Ogrencilers");

            migrationBuilder.DropTable(
                name: "Derslers");
        }
    }
}
