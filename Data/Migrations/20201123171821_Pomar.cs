using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Pomar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colheitas",
                columns: table => new
                {
                    IdColheita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Informações = table.Column<string>(type: "Varchar(100)", nullable: false),
                    DataColheita = table.Column<DateTime>(type: "Date", nullable: false),
                    PesoBruto = table.Column<decimal>(type: "Money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colheitas", x => x.IdColheita);
                });

            migrationBuilder.CreateTable(
                name: "Especies",
                columns: table => new
                {
                    IdEspecie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especies", x => x.IdEspecie);
                });

            migrationBuilder.CreateTable(
                name: "GrupoArvores",
                columns: table => new
                {
                    IdGrupoArvores = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoArvores", x => x.IdGrupoArvores);
                });

            migrationBuilder.CreateTable(
                name: "Arvores",
                columns: table => new
                {
                    IdArvore = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Idade = table.Column<int>(type: "Int", nullable: false),
                    EspecieId = table.Column<int>(type: "int", nullable: false),
                    ColheitaIdColheita = table.Column<int>(type: "int", nullable: true),
                    GrupoArvoresIdGrupoArvores = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arvores", x => x.IdArvore);
                    table.ForeignKey(
                        name: "FK_Arvores_Colheitas_ColheitaIdColheita",
                        column: x => x.ColheitaIdColheita,
                        principalTable: "Colheitas",
                        principalColumn: "IdColheita",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Arvores_Especies_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Especies",
                        principalColumn: "IdEspecie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arvores_GrupoArvores_GrupoArvoresIdGrupoArvores",
                        column: x => x.GrupoArvoresIdGrupoArvores,
                        principalTable: "GrupoArvores",
                        principalColumn: "IdGrupoArvores",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arvores_ColheitaIdColheita",
                table: "Arvores",
                column: "ColheitaIdColheita");

            migrationBuilder.CreateIndex(
                name: "IX_Arvores_EspecieId",
                table: "Arvores",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_Arvores_GrupoArvoresIdGrupoArvores",
                table: "Arvores",
                column: "GrupoArvoresIdGrupoArvores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arvores");

            migrationBuilder.DropTable(
                name: "Colheitas");

            migrationBuilder.DropTable(
                name: "Especies");

            migrationBuilder.DropTable(
                name: "GrupoArvores");
        }
    }
}
