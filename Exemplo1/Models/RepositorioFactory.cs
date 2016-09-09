using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exemplo1.Models
{
    public class RepositorioFactory
    {
        public static ClienteRepositorio InstanciarRepositorio()
        {
            if (HttpContext.Current.Application["repositorioCliente"] == null)
                return new ClienteRepositorio();
            else
                return (ClienteRepositorio)HttpContext.Current.Application["repositorioCliente"];

        }

        public static ProdutoRepositorio InstanciarRepositorioProd()
        {
            if (HttpContext.Current.Application["repositorioProdudo"] == null)
                return new ProdutoRepositorio();
            else
                return (ProdutoRepositorio)HttpContext.Current.Application["repositorioProdudo"];
        }
    }
}