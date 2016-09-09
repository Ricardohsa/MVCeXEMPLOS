using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exemplo1.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public override bool Equals(object obj)
        {
            return this.ClienteId == ((Cliente)obj).ClienteId;            
        }
    }
}