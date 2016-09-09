using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exemplo1.Models
{
    public class ClienteRepositorio
    {
        private IList<Cliente> clientes;

        public ClienteRepositorio()
        {
            clientes = new List<Cliente>();
            clientes.Add(new Cliente()
            {
                ClienteId = 1,
                Nome = "Ricardo",
                Idade = 34
            });

            clientes.Add(new Cliente()
            {
                ClienteId = 2,
                Nome = "Miguel",
                Idade = 1

            });

            clientes.Add(new Cliente()
            {
                ClienteId = 3,
                Nome = "Michelle",
                Idade = 34

            });
        }

        public void Inserir(Cliente cliente)
        {
            if (clientes.Where(c => c.ClienteId == cliente.ClienteId).Count() == 0)
                clientes.Add(cliente);
            else
                throw new Exception("Cliente já existe");
        }

        public IList<Cliente> RetornarTodos()
        {
            return clientes;
        }

        public Cliente RetornarPorId(int id)
        {
            return clientes.Where(c => c.ClienteId == id).First();
        }

        public void alterar(Cliente cliente)
        {
            clientes.Where(cli => cli.ClienteId == cliente.ClienteId).First().Nome = cliente.Nome;
            clientes.Where(cli => cli.ClienteId == cliente.ClienteId).First().Idade = cliente.Idade;            
        }


        public void Excluir(Cliente cliente)
        {
            //var cli = clientes.Where(c => c.ClienteId == cliente.ClienteId).First();

            clientes.Remove(cliente);            
            
        }
              
    }
}