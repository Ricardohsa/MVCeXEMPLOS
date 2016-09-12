using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo1.Models
{
    public class Produto
    {
        [HiddenInput(DisplayValue = false)]        
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório")]
        [MinLength(8, ErrorMessage = "Nome deve ter no mínimo 8 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preço é Obrigatório")]        
        public decimal Preco { get; set; }

        public override bool Equals(object obj)
        {
            return this.ProdutoId == ((Produto)obj).ProdutoId;

        }
    }
}