using Exemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo1.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoRepositorio produtorepositorio;

        public ProdutoController()
        {
            produtorepositorio = RepositorioFactory.InstanciarRepositorioProd();
        }
        // GET: Produto
        public ActionResult Index()
        {
            var produto = produtorepositorio.RetornaProduto();
            return View(produto);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Produto produto)
        {
            if (ModelState.IsValid)
            {
                var pId = produtorepositorio.RetornaProduto().OrderByDescending(p => p.ProdutoId).First();

                produto.ProdutoId = pId.ProdutoId + 1;
                produtorepositorio.Inserir(produto);

                var produtos = produtorepositorio.RetornaProduto();

                return View("Index", produtos);
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Alterar (int id)
        {
            var prod = produtorepositorio.RetornaProdutoPorId(id);

            return View(prod);
        }

        [HttpPost]
        public ActionResult Alterar (Produto produto)
        {
            if (ModelState.IsValid)
            {
                produtorepositorio.Alterar(produto);

                var produtos = produtorepositorio.RetornaProduto();

                return View("Index", produtos);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var produto = produtorepositorio.RetornaProdutoPorId(id);

            return View(produto);
        }


        [HttpPost]
        public ActionResult Delete(Produto produto)
        {
            produtorepositorio.Excluir(produto);

            var produtos = produtorepositorio.RetornaProduto();

            return View("Index", produtos);
        }

        public ActionResult Alterar(int id)
        {
            var prod = produtorepositorio.RetornaProdutoPorId(id);

            return View(prod);
        }
    }
}