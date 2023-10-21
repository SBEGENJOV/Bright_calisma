using Microsoft.EntityFrameworkCore.Migrations;

namespace coreapiproject.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Takimlars",
                columns: table => new
                {
                    TakimlarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakimAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takimlars", x => x.TakimlarID);
                });

            migrationBuilder.CreateTable(
                name: "Sporculars",
                columns: table => new
                {
                    SporcuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakimlarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sporculars", x => x.SporcuID);
                    table.ForeignKey(
                        name: "FK_Sporculars_Takimlars_TakimlarID",
                        column: x => x.TakimlarID,
                        principalTable: "Takimlars",
                        principalColumn: "TakimlarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sporculars_TakimlarID",
                table: "Sporculars",
                column: "TakimlarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sporculars");

            migrationBuilder.DropTable(
                name: "Takimlars");
        }
    }
}
