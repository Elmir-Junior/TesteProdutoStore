using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteProdutoStore.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCategoriaProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategoriaProduto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Perecivel = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProduto_tblCategoriaProduto_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "tblCategoriaProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblCategoriaProduto",
                columns: new[] { "Id", "Ativo", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, true, "Eletrodomestico", "Eletrônico" },
                    { 2, true, "Produtos para Informatica", "Informática" },
                    { 3, true, "Aparelhos e Acessórios", "Celulares" },
                    { 4, true, "Artigos para Vestuário em Geral", "Moda" },
                    { 5, true, "Livros", "Livros" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblProduto_CategoriaId",
                table: "tblProduto",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblProduto");

            migrationBuilder.DropTable(
                name: "tblCategoriaProduto");
        }
    }
}
