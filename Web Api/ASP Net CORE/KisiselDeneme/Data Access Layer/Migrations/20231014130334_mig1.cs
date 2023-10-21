using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access_Layer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lig1s",
                columns: table => new
                {
                    LigID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LigAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LigResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LigDeger = table.Column<int>(type: "int", nullable: false),
                    LigIzleyciSay = table.Column<int>(type: "int", nullable: false),
                    LigTakimSay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lig1s", x => x.LigID);
                });

            migrationBuilder.CreateTable(
                name: "Takim1s",
                columns: table => new
                {
                    TakimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakimAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakimResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakimDeger = table.Column<int>(type: "int", nullable: false),
                    TakimOyunSay = table.Column<int>(type: "int", nullable: false),
                    LigID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takim1s", x => x.TakimID);
                    table.ForeignKey(
                        name: "FK_Takim1s_Lig1s_LigID",
                        column: x => x.LigID,
                        principalTable: "Lig1s",
                        principalColumn: "LigID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oyuncu1s",
                columns: table => new
                {
                    OyuncuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyuncuAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OyuncuMevki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OyuncuResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OyuncuYas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakimID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuncu1s", x => x.OyuncuId);
                    table.ForeignKey(
                        name: "FK_Oyuncu1s_Takim1s_TakimID",
                        column: x => x.TakimID,
                        principalTable: "Takim1s",
                        principalColumn: "TakimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oyuncu1s_TakimID",
                table: "Oyuncu1s",
                column: "TakimID");

            migrationBuilder.CreateIndex(
                name: "IX_Takim1s_LigID",
                table: "Takim1s",
                column: "LigID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oyuncu1s");

            migrationBuilder.DropTable(
                name: "Takim1s");

            migrationBuilder.DropTable(
                name: "Lig1s");
        }
    }
}
