using Microsoft.EntityFrameworkCore;
using TesteProdutoStore.Data.Repository.Interface;
using TesteProdutoStore.Models;

namespace TesteProdutoStore.Data.Repository
{
    public class ProdutoRepository : IRepositoryProduto
    {
        private readonly ContextDB _context;
        public ProdutoRepository(ContextDB context)
        {
            _context = context;
        }

        public IEnumerable<Produto> ListarProdutos()
        {
            return _context.Set<Produto>().ToList();
        }
            

        public Produto ProcurarProdutoPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(x => x.Id == id);
        }
        public void AddProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void DeletarProduto(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(x => x.Id == id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }


        public void AtualizarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
    }
}
