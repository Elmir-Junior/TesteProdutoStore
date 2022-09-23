using TesteProdutoStore.Data;
using TesteProdutoStore.Models;
using TesteProdutoStore.Repository.Interface;

namespace TesteProdutoStore.Repository
{
    public class CategoriaRepository:IRepositoryCategoria
    {
        private readonly ContextDB _contextDB;
        public CategoriaRepository(ContextDB contextDB)
        {
            _contextDB = contextDB;
        }

        public IEnumerable<Categoria> ListarCategorias()
        {
            return _contextDB.Categorias.ToList();
        }

        public Categoria ProcurarPorId(int id)
        {
            return _contextDB.Set<Categoria>().FirstOrDefault(a => a.Id == id);
        }

    }
}
