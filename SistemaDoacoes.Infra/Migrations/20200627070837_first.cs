using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDoacoes.Infra.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ASSISTIDO",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf = table.Column<string>(maxLength: 11, nullable: false),
                    nome = table.Column<string>(nullable: false),
                    data_nascimennto = table.Column<DateTime>(nullable: false),
                    qtd_dependentes = table.Column<int>(nullable: false),
                    escolaridade = table.Column<int>(nullable: false),
                    chefe_familia = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ASSISTIDO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TB_DOADOR",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: false),
                    cpf = table.Column<string>(maxLength: 11, nullable: false),
                    data_nascimennto = table.Column<DateTime>(nullable: false),
                    escolaridade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DOADOR", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TB_INSTITUICAO_ASSISTIDA",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cnpj = table.Column<string>(maxLength: 14, nullable: false),
                    nome_fantasia = table.Column<string>(nullable: false),
                    razao_social = table.Column<string>(nullable: false),
                    qtd_assistidos = table.Column<int>(nullable: false),
                    tipo_instituicao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_INSTITUICAO_ASSISTIDA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TB_INSTITUICAO_DOADORA",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cnpj = table.Column<string>(maxLength: 14, nullable: false),
                    nome_fantasia = table.Column<string>(nullable: false),
                    razao_social = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_INSTITUICAO_DOADORA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_DOACAO",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_origem = table.Column<int>(nullable: false),
                    id_destino = table.Column<int>(nullable: false),
                    tipo = table.Column<int>(nullable: false),
                    valor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DOACAO", x => x.id);
                    table.ForeignKey(
                        name: "FK_TB_DOACAO_TB_ASSISTIDO_id_destino",
                        column: x => x.id_destino,
                        principalTable: "TB_ASSISTIDO",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_DOACAO_TB_INSTITUICAO_ASSISTIDA_id_destino",
                        column: x => x.id_destino,
                        principalTable: "TB_INSTITUICAO_ASSISTIDA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_DOACAO_TB_DOADOR_id_origem",
                        column: x => x.id_origem,
                        principalTable: "TB_DOADOR",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_DOACAO_TB_INSTITUICAO_DOADORA_id_origem",
                        column: x => x.id_origem,
                        principalTable: "TB_INSTITUICAO_DOADORA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_DOACAO_id_destino",
                table: "TB_DOACAO",
                column: "id_destino");

            migrationBuilder.CreateIndex(
                name: "IX_TB_DOACAO_id_origem",
                table: "TB_DOACAO",
                column: "id_origem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_DOACAO");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TB_ASSISTIDO");

            migrationBuilder.DropTable(
                name: "TB_INSTITUICAO_ASSISTIDA");

            migrationBuilder.DropTable(
                name: "TB_DOADOR");

            migrationBuilder.DropTable(
                name: "TB_INSTITUICAO_DOADORA");
        }
    }
}
