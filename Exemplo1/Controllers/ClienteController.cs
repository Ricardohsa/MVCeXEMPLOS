using Exemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo1.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepositorio clienterepositorio;

        public ClienteController()
        {
            clienterepositorio = RepositorioFactory.InstanciarRepositorio();
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var clientes = RepositorioFactory.InstanciarRepositorio()
                .RetornarTodos();
            
            return View(clientes);
        }

        public ActionResult Inserir()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Inserir(Cliente cliente)
        {
            var cli = clienterepositorio.RetornarTodos().OrderByDescending(c => c.ClienteId).First();

            cliente.ClienteId = cli.ClienteId + 1;
            clienterepositorio.Inserir(cliente);

            TempData["Mensagem"] = "Cliente Incluido com Sucesso";

            var clientes = RepositorioFactory.InstanciarRepositorio()
                .RetornarTodos();

            return View("Index", clientes);
        }

        public ActionResult Alterar(int id)
        {
            var cli = clienterepositorio.RetornarPorId(id);

            return View(cli);
        }

        [HttpPost]
        public ActionResult Alterar(Cliente cliente)
        {
            clienterepositorio.alterar(cliente);

            TempData["Mensagem"] = "Cliente Alterado com Sucesso";

            var clientes = clienterepositorio.RetornarTodos();

            return View("Index", clientes);
        }

        public ActionResult Delete(int id)
        {
            var cliente = clienterepositorio.RetornarPorId(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Delete(Cliente cliente)
        {
            clienterepositorio.Excluir(cliente);

            TempData["Mensagem"] = "Cliente " + cliente.Nome + "Excluido com Sucesso";

            var clientes = clienterepositorio.RetornarTodos();                        

            return View("Index", clientes);
        }
      
    }
}