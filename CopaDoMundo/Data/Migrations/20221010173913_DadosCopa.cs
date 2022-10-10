using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CopaDoMundo.Data.Migrations
{
    public partial class DadosCopa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    IDArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorIngresso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.IDArea);
                });

            migrationBuilder.CreateTable(
                name: "Torcedores",
                columns: table => new
                {
                    IDTor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torcedores", x => x.IDTor);
                });

            migrationBuilder.CreateTable(
                name: "Alocados",
                columns: table => new
                {
                    IDAlocacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDArea = table.Column<int>(type: "int", nullable: false),
                    IDTor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alocados", x => x.IDAlocacao);
                    table.ForeignKey(
                        name: "FK_Alocados_Areas_IDArea",
                        column: x => x.IDArea,
                        principalTable: "Areas",
                        principalColumn: "IDArea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alocados_Torcedores_IDTor",
                        column: x => x.IDTor,
                        principalTable: "Torcedores",
                        principalColumn: "IDTor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alocados_IDArea",
                table: "Alocados",
                column: "IDArea");

            migrationBuilder.CreateIndex(
                name: "IX_Alocados_IDTor",
                table: "Alocados",
                column: "IDTor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alocados");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Torcedores");
        }
    }
}
