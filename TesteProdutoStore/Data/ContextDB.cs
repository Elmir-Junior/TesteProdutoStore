using Microsoft.EntityFrameworkCore;
using TesteProdutoStore.Models;

namespace TesteProdutoStore.Data
{
    public class ContextDB : DbContext
    {
        public ContextDB() { }
        public ContextDB(DbContextOptions<ContextDB> options) : base(options) { }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categoriaEletronico = new Categoria(){ Id = 1,Nome = "Eletrônico", Descricao = "Eletrodomestico", Ativo = true};
            var categoriaInformatica = new Categoria() { Id = 2, Nome = "Informática", Descricao = "Produtos para Informatica", Ativo = true };
            var categoriaCelulares = new Categoria(){ Id = 3, Nome = "Celulares", Descricao = "Aparelhos e Acessórios", Ativo = true };
            var categoriaModa = new Categoria(){ Id = 4, Nome = "Moda", Descricao = "Artigos para Vestuário em Geral" , Ativo = true };
            var categoriaLivros = new Categoria(){ Id = 5, Nome = "Livros", Descricao = "Livros", Ativo = true  };
            modelBuilder.Entity<Categoria>().HasData(
                 categoriaEletronico, categoriaCelulares, categoriaModa, categoriaLivros, categoriaInformatica);
        }
    }
}
