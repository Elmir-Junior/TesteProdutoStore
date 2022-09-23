using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProdutoStore.Models;

namespace TesteProdutoStore.ViewModel
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {}
        public ProdutoViewModel(List<ProdutoViewModel> lista)
        {
            Lista = lista;
        }
        public ProdutoViewModel(int id,string nome, string descricao, bool ativo,bool perecivel, string categoriaNome, int categoriaId)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Perecivel = perecivel;
            CategoriaNome = categoriaNome;
            CategoriaId = categoriaId;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public bool Perecivel { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }

        public List<ProdutoViewModel> Lista { get; set; }
    }
}
