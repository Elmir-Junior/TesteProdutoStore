using TesteProdutoStore.Models;

namespace TesteProdutoStore.Repository.Interface
{
    public interface IRepositoryCategoria
    {
        IEnumerable<Categoria> ListarCategorias();
        Categoria ProcurarPorId(int id);

    }
}
