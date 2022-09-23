using TesteProdutoStore.Data;
using TesteProdutoStore.Data.Repository.Interface;
using TesteProdutoStore.Models;
using TesteProdutoStore.Repository.Interface;
using TesteProdutoStore.Services.Interface;

namespace TesteProdutoStore.Services
{
    public class ServiceCategorias : IServicoCategoria
    {
        private readonly IRepositoryCategoria _repositoryCategoria;
        public ServiceCategorias(IRepositoryCategoria repositoryCategoria)
        {
            _repositoryCategoria = repositoryCategoria;
        }

        public IEnumerable<Categoria> ListarCategorias()
        {
            return _repositoryCategoria.ListarCategorias().ToList();
        }

        public Categoria ProcurarPorId(int id)
        {
            return _repositoryCategoria.ProcurarPorId(id);
        }
    }
}
