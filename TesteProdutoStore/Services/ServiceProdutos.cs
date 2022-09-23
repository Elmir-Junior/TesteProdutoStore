using AutoMapper;
using TesteProdutoStore.Data.Repository.Interface;
using TesteProdutoStore.Models;
using TesteProdutoStore.Services.Interface;
using TesteProdutoStore.ViewModel;

namespace TesteProdutoStore.Services
{
    public class ServiceProdutos : IServicoProdutos
    {
        private readonly IRepositoryProduto _produtoRepository;
        private readonly IServicoCategoria _servicoCategoria;
        private readonly IMapper _mapper;

        public ServiceProdutos(IRepositoryProduto produtoRepository, IServicoCategoria servicoCategoria, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _servicoCategoria = servicoCategoria;
            _mapper = mapper;
        }

        public ProdutoViewModel ListarProdutos()
        {
            //Sem Map
            //var modelolista = new List<ProdutoViewModel>(); 
            //_produtoRepository.ListarProdutos().ToList().
            //ForEach(a => modelolista.Add(new ProdutoViewModel(a.Id, a.Nome, a.Descricao, a.Ativo,
            //a.Perecivel, _servicoCategoria.ProcurarPorId(a.CategoriaId).Nome, a.CategoriaId)));
            
            List<Produto> produtos = _produtoRepository.ListarProdutos().ToList();
            var listamodelo = _mapper.Map<List<ProdutoViewModel>>(produtos);
            var modelo = new ProdutoViewModel(listamodelo);
            return modelo;
        }

        public Produto ProcurarProdutoPorId(int id)
        {
            return _produtoRepository.ProcurarProdutoPorId(id);
        }

        public void AddProduto(ProdutoViewModel produto)
        {
            var produtoM = new Produto()
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Perecivel = produto.Perecivel,
                CategoriaId = produto.CategoriaId,
            };
            _produtoRepository.AddProduto(produtoM);
        }
        public void AtualizarProduto(Produto produto)
        {
            _produtoRepository.AtualizarProduto(produto);
        }
        public void DeletarProduto(int id)
        {
            _produtoRepository.DeletarProduto(id);
        }
    }
}
