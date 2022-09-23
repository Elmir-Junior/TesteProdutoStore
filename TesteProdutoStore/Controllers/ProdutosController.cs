using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TesteProdutoStore.Data;
using TesteProdutoStore.Models;
using TesteProdutoStore.Services.Interface;
using TesteProdutoStore.ViewModel;

namespace TesteProdutoStore.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IServicoProdutos _servicoProdutos;
        private readonly IServicoCategoria _servicoCategoria;
        public ProdutosController(IServicoProdutos servicoProdutos, IServicoCategoria servicoCategoria)
        {
            _servicoProdutos = servicoProdutos;
            _servicoCategoria = servicoCategoria;
        }
        public ActionResult Index()
        {
            ViewData["Categoria"] = new SelectList(_servicoCategoria.ListarCategorias(), "Id", "Nome");

            return View(_servicoProdutos.ListarProdutos());
        }

        [HttpPost]
        public ActionResult Create(ProdutoViewModel produto)
        {
            _servicoProdutos.AddProduto(produto);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            ViewData["Categoria"] = new SelectList(_servicoCategoria.ListarCategorias(), "Id", "Nome", "Nome");

            return View(_servicoProdutos.ProcurarProdutoPorId(id));
        }

        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            _servicoProdutos.AtualizarProduto(produto);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            return View(_servicoProdutos.ProcurarProdutoPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Produto produto)
        {
            _servicoProdutos.DeletarProduto(produto.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
