using TesteProdutoStore.Models;

namespace TesteProdutoStore.Services.Interface
{
    public interface IServicoCategoria
    {
        IEnumerable<Categoria> ListarCategorias();
        Categoria ProcurarPorId(int id);
    }
}
