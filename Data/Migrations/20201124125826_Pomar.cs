using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Pomar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    GrupoArvoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arvores", x => x.IdArvore);
                    table.ForeignKey(
                        name: "FK_Arvores_Especies_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Especies",
                        principalColumn: "IdEspecie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arvores_GrupoArvores_GrupoArvoresId",
                        column: x => x.GrupoArvoresId,
                        principalTable: "GrupoArvores",
                        principalColumn: "IdGrupoArvores",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colheitas",
                columns: table => new
                {
                    IdColheita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Informações = table.Column<string>(type: "Varchar(100)", nullable: false),
                    DataColheita = table.Column<DateTime>(type: "Date", nullable: false),
                    PesoBruto = table.Column<decimal>(type: "Money", nullable: false),
                    ArvoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colheitas", x => x.IdColheita);
                    table.ForeignKey(
                        name: "FK_Colheitas_Arvores_ArvoreId",
                        column: x => x.ArvoreId,
                        principalTable: "Arvores",
                        principalColumn: "IdArvore",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arvores_EspecieId",
                table: "Arvores",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_Arvores_GrupoArvoresId",
                table: "Arvores",
                column: "GrupoArvoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Colheitas_ArvoreId",
                table: "Colheitas",
                column: "ArvoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colheitas");

            migrationBuilder.DropTable(
                name: "Arvores");

            migrationBuilder.DropTable(
                name: "Especies");

            migrationBuilder.DropTable(
                name: "GrupoArvores");
        }
    }
}
