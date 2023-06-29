using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGIS.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnoCestice",
                columns: table => new
                {
                    MaticniBrojKo = table.Column<string>(type: "text", nullable: false),
                    Rotacija = table.Column<string>(type: "text", nullable: true),
                    AnoCesticaId = table.Column<string>(type: "text", nullable: true),
                    BrojCestice = table.Column<string>(type: "text", nullable: true),
                    Coordinates = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnoCestice", x => x.MaticniBrojKo);
                });

            migrationBuilder.CreateTable(
                name: "Cestice",
                columns: table => new
                {
                    MaticniBrojKo = table.Column<string>(type: "text", nullable: false),
                    CesticaId = table.Column<string>(type: "text", nullable: true),
                    BrojCestice = table.Column<string>(type: "text", nullable: true),
                    PovrsinaAtributna = table.Column<string>(type: "text", nullable: true),
                    PovrsinaGraficka = table.Column<string>(type: "text", nullable: true),
                    AdresaOpisna = table.Column<string>(type: "text", nullable: true),
                    StatusCestice = table.Column<string>(type: "text", nullable: true),
                    CesticaIzvorId = table.Column<string>(type: "text", nullable: true),
                    OznakaOkoline = table.Column<string>(type: "text", nullable: true),
                    DetaljniList = table.Column<string>(type: "text", nullable: true),
                    Coordinates = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cestice", x => x.MaticniBrojKo);
                });

            migrationBuilder.CreateTable(
                name: "CesticeZgrade",
                columns: table => new
                {
                    ZgradaId = table.Column<string>(type: "text", nullable: false),
                    CesticaId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CesticeZgrade", x => x.ZgradaId);
                });

            migrationBuilder.CreateTable(
                name: "Identifikacije",
                columns: table => new
                {
                    MaticniBrojKo = table.Column<string>(type: "text", nullable: false),
                    Verificirano = table.Column<string>(type: "text", nullable: true),
                    ZkCesticaId = table.Column<string>(type: "text", nullable: true),
                    BrojZkCestice = table.Column<string>(type: "text", nullable: true),
                    PodbrojZkCestice = table.Column<string>(type: "text", nullable: true),
                    GlavnaKnjigaId = table.Column<string>(type: "text", nullable: true),
                    OznakaVezeCestice = table.Column<string>(type: "text", nullable: true),
                    OznakaVezeZkCestice = table.Column<string>(type: "text", nullable: true),
                    BrojCestice = table.Column<string>(type: "text", nullable: true),
                    CesticaId = table.Column<string>(type: "text", nullable: true),
                    Coordinates = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifikacije", x => x.MaticniBrojKo);
                });

            migrationBuilder.CreateTable(
                name: "KatastarskeOpcine",
                columns: table => new
                {
                    MaticniBrojKo = table.Column<string>(type: "text", nullable: false),
                    NazivKo = table.Column<string>(type: "text", nullable: true),
                    IzvornoMjerilo = table.Column<string>(type: "text", nullable: true),
                    StatusKzKn = table.Column<string>(type: "text", nullable: true),
                    KatastarskaOpcinaId = table.Column<string>(type: "text", nullable: true),
                    VrstaKatastarskeOpcine = table.Column<string>(type: "text", nullable: true),
                    Coordinates = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KatastarskeOpcine", x => x.MaticniBrojKo);
                });

            migrationBuilder.CreateTable(
                name: "MedjeCestica",
                columns: table => new
                {
                    MaticniBrojKo = table.Column<string>(type: "text", nullable: false),
                    MedjaCesticeId = table.Column<string>(type: "text", nullable: true),
                    Broj = table.Column<string>(type: "text", nullable: true),
                    Coordinates = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedjeCestica", x => x.MaticniBrojKo);
                });

            migrationBuilder.CreateTable(
                name: "NaciniUporabe",
                columns: table => new
                {
                    NacinUporabeId = table.Column<string>(type: "text", nullable: false),
                    MaticniBrojKo = table.Column<string>(type: "text", nullable: true),
                    Povrsina = table.Column<string>(type: "text", nullable: true),
                    SifraVrsteUporabe = table.Column<string>(type: "text", nullable: true),
                    NazivVrsteUporabe = table.Column<string>(type: "text", nullable: true),
                    AdresaOpisna = table.Column<string>(type: "text", nullable: true),
                    PosjedovniListBroj = table.Column<string>(type: "text", nullable: true),
                    CesticaId = table.Column<string>(type: "text", nullable: true),
                    StatusNacinaUporabe = table.Column<string>(type: "text", nullable: true),
                    OznakaPravaGradjenja = table.Column<string>(type: "text", nullable: true),
                    Coordinates = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaciniUporabe", x => x.NacinUporabeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnoCestice");

            migrationBuilder.DropTable(
                name: "Cestice");

            migrationBuilder.DropTable(
                name: "CesticeZgrade");

            migrationBuilder.DropTable(
                name: "Identifikacije");

            migrationBuilder.DropTable(
                name: "KatastarskeOpcine");

            migrationBuilder.DropTable(
                name: "MedjeCestica");

            migrationBuilder.DropTable(
                name: "NaciniUporabe");
        }
    }
}
