using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_1.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dizilers",
                columns: table => new
                {
                    diziNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Sermaye = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CalisanSayisi = table.Column<int>(type: "int", nullable: false),
                    Yetkili = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dizilers", x => x.diziNo);
                });

            migrationBuilder.CreateTable(
                name: "Oyunculars",
                columns: table => new
                {
                    OyuncuNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiziNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyunculars", x => x.OyuncuNo);
                    table.ForeignKey(
                        name: "FK_Oyunculars_Dizilers_DiziNo",
                        column: x => x.DiziNo,
                        principalTable: "Dizilers",
                        principalColumn: "diziNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oyunculars_DiziNo",
                table: "Oyunculars",
                column: "DiziNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oyunculars");

            migrationBuilder.DropTable(
                name: "Dizilers");
        }
    }
}
