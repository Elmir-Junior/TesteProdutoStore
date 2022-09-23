using TesteProdutoStore.Models;
using TesteProdutoStore.ViewModel;

namespace TesteProdutoStore.Services.Interface
{
    public interface IServicoProdutos
    {
        ProdutoViewModel ListarProdutos();
        Produto ProcurarProdutoPorId(int id);
        void AddProduto(ProdutoViewModel produto);
        void AtualizarProduto(Produto produto);
        void DeletarProduto(int id);
    }
}
