using System;
using System.Collections.Generic;
using Pizzaria.Repositorio;
using Pizzaria.Util;
using Pizzaria.ViewModels;

namespace Pizzaria.Controllers
{
    public class ProdutoController
    {
        static readonly ProdutoRepositorio _produtoRepositorio = new ProdutoRepositorio();
        public static void CadastrarProduto() {
            string nome, descricao, categoria, preco;

            #region input
            do {
                Console.WriteLine("Insira o nome do Produto");
                nome = Console.ReadLine();
                
                if (string.IsNullOrEmpty(nome))
                    Console.WriteLine("Nome de Produto inválido");
            } while (string.IsNullOrEmpty(nome));
        
            do {
                Console.WriteLine("Insira a Descrição do Produto");
                descricao = Console.ReadLine();
                
                if (string.IsNullOrEmpty(descricao))
                    Console.WriteLine("Descrição do Produto inválido");
            } while (string.IsNullOrEmpty(descricao));

            do {
                Console.WriteLine("Insira o Preço do Produto");
                preco = Console.ReadLine();
                
                if (string.IsNullOrEmpty(preco))
                    Console.WriteLine("Preço do Produto inválido");
            } while (string.IsNullOrEmpty(preco));

            do {
                Console.WriteLine("Informe a categoria do produto");
                categoria = Console.ReadLine();
                
                if (!ValidacaoUtil.ValidarCategoria(categoria))
                    Console.WriteLine("Categoria inválida");
            } while (!ValidacaoUtil.ValidarCategoria(categoria));
            #endregion

            ProdutoViewModel produtoViewModel  = new ProdutoViewModel(nome, descricao, categoria, decimal.Parse(preco));
            _produtoRepositorio.Adicionar(produtoViewModel);
            Console.WriteLine("Produto cadastrado");
        }

        public static void ListarProduto() {
            int produtoId;
            List<ProdutoViewModel> produtos = _produtoRepositorio.Listar();

            do {
                foreach (ProdutoViewModel item in produtos)
                    Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco}");

                Console.WriteLine("Insira o Id do produto para mais informações ou 0 para sair");
                produtoId = int.Parse(Console.ReadLine());

                if (produtoId == 0 )
                    break;
                
                ProdutoViewModel produto = _produtoRepositorio.Buscar(produtoId);

                if (produto != null)
                    Console.WriteLine($"{produto.Id} - {produto.Nome} - {produto.Preco} - {produto.Descricao} - {produto.Preco} - {produto.DataCriacao}");
                else
                    Console.WriteLine("Produto não encontrado");
            } while (produtoId != 0);
        }

        public static void ExibirTotal() {
            List<ProdutoViewModel> produtos = _produtoRepositorio.Listar();

            decimal TotalPreco = 0.0m;

            foreach (ProdutoViewModel item in produtos)
                TotalPreco += item.Preco;

            Console.WriteLine($"O preço total dos produtos é de {TotalPreco} e você possui {produtos.Count} produtos cadastrados");
        } 
    }
}