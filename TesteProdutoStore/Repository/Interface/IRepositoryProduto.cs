using System.Collections;
using TesteProdutoStore.Models;

namespace TesteProdutoStore.Data.Repository.Interface
{
    public interface IRepositoryProduto
    {
        IEnumerable<Produto> ListarProdutos();

        Produto ProcurarProdutoPorId(int id);
        void AddProduto(Produto produto);
        void AtualizarProduto(Produto produto);
        void DeletarProduto(int id);
    }
}
