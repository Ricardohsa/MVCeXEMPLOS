﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exemplo1.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }
    }
}