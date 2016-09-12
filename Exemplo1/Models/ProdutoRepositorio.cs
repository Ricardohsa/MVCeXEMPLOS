using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exemplo1.Models;

namespace Exemplo1.Models
{
    public class ProdutoRepositorio
    {
        private IList<Produto> produtos;

        public ProdutoRepositorio()
        {
            produtos = new List<Produto>();
            produtos.Add(new Produto()
            {
                ProdutoId = 1,
                Nome = "Projeto",
                Descricao = "Projetor 3D",
                Preco = (decimal)500.00
            });

            produtos.Add(new Produto()
            {
                ProdutoId = 2,
                Nome = "Monitor",
                Descricao = "Monitor LCD",
                Preco = (decimal) 950.00
            });

            produtos.Add(new Produto()
            {
                ProdutoId = 3,
                Nome = "Teclado",
                Descricao = "Wire-less",
                Preco = (decimal)500.00
            });


        }

        public void Inserir(Produto produto)
        {
            if (produtos.Where(p => p.ProdutoId == produto.ProdutoId).Count() == 0)
                produtos.Add(produto);
            else
                throw new Exception("Produto já cadastrado");

        }

        public IList<Produto> RetornaProduto()
        {
            return produtos;
        }

        public Produto RetornaProdutoPorId(int id)
        {
            return produtos.Where(p => p.ProdutoId == id).First();
        }

        public void Alterar(Produto produto)
        {
            produtos.Where(prod => prod.ProdutoId == produto.ProdutoId).First().Descricao = produto.Descricao;
            produtos.Where(prod => prod.ProdutoId == produto.ProdutoId).First().Nome = produto.Nome;
            produtos.Where(prod => prod.ProdutoId == produto.ProdutoId).First().Preco = produto.Preco;
        }

        public void Excluir(Produto produto)
        {
            produtos.Remove(produto);
        }
    }
}