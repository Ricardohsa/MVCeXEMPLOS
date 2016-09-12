using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo1.Models
{
    public class Cliente
    {
        [HiddenInput(DisplayValue = false)]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório")]
        [MinLength(8,ErrorMessage = "Nome deve ter no mínimo 8 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Idade é Obrigatório")]
        public int Idade { get; set; }

        public override bool Equals(object obj)
        {
            return this.ClienteId == ((Cliente)obj).ClienteId;            
        }
    }
}