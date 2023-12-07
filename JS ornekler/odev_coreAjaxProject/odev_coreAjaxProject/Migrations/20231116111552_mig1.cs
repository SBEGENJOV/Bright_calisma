using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace odev_coreAjaxProject.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitaps",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapYazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapYil = table.Column<int>(type: "int", nullable: false),
                    KitapSayfa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaps", x => x.KitapID);
                });

            migrationBuilder.CreateTable(
                name: "Kutuphanes",
                columns: table => new
                {
                    KutuphaneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KutuphaneAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KutuphaneKonum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KutuphaneMasaSay = table.Column<int>(type: "int", nullable: false),
                    KutuphaneYonetici = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutuphanes", x => x.KutuphaneID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    kID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kAd = table.Column<int>(type: "int", nullable: false),
                    kSifre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.kID);
                });

            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarMemleket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarYas = table.Column<int>(type: "int", nullable: false),
                    YazarKitapYaz = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.YazarID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitaps");

            migrationBuilder.DropTable(
                name: "Kutuphanes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Yazars");
        }
    }
}
