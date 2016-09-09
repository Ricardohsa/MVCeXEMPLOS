using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo1.Controllers
{
    public class PaginaErroController : Controller
    {
        // GET: PaginaErro
        public ActionResult PaginaNaoEncontrada()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}