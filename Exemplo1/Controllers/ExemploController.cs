using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo1.Controllers
{
    public class ExemploController : Controller
    {
        public  ActionResult Hello()
        {
            ViewBag.Mensagem= "Passando informações pela ViewBag";
            return View();
        }


    }
}