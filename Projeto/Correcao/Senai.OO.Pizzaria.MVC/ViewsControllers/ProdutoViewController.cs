using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Repositorio;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.ViewsControllers
{
    /// <summary>
    /// Classe responsavel pela visualização e controle de dados do produto
    /// </summary>
    public class ProdutoViewController
    {
        static ProdutoRepositorio produtoRep = new ProdutoRepositorio();
        public static void CadastrarProduto() {
            string Nome, Descrição, Categoria, Preco;

            #region View            
            do {
                System.Console.WriteLine("Insira o nome do Produto");
                Nome = Console.ReadLine();
                
                if (string.IsNullOrEmpty(Nome)) {
                    System.Console.WriteLine("Nome de Produto inválido");
                }
            } while (string.IsNullOrEmpty(Nome));
        
            do {
                System.Console.WriteLine("Insira a Descrição do Produto");
                Descrição = Console.ReadLine();
                
                if (string.IsNullOrEmpty(Descrição)) {
                    System.Console.WriteLine("Descrição do Produto inválido");
                }
            } while (string.IsNullOrEmpty(Descrição));

            do {
                System.Console.WriteLine("Insira o Preço do Produto");
                Preco = Console.ReadLine();
                
                if (string.IsNullOrEmpty(Preco)) {
                    System.Console.WriteLine("Preço do Produto inválido");
                }
            } while (string.IsNullOrEmpty(Preco));

            do {
                System.Console.WriteLine("Informe a categoria do produto");
                Categoria = Console.ReadLine();
                
                if (!ValidacaoUtil.ValidarCategoria(Categoria)) {
                    System.Console.WriteLine("Categoria inválida");
                }

            } while (!ValidacaoUtil.ValidarCategoria(Categoria));
            #endregion

            #region Controller
                ProdutoViewModel produtoViewModel  = new ProdutoViewModel();
                produtoViewModel.Nome = Nome;
                produtoViewModel.Descricao = Descrição;
                produtoViewModel.Preco = decimal.Parse(Preco);
                produtoViewModel.Categoria = Categoria;
                produtoRep.Inserir(produtoViewModel);

                System.Console.WriteLine("Produto cadastrado");
            #endregion
        }

        public static void ListarProduto() {
            int IdProduto = 0;
            List<ProdutoViewModel> lsProduto = produtoRep.Listar();

            do {
                foreach (ProdutoViewModel item in lsProduto)
                {
                    System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco}");
                }

                System.Console.WriteLine("Insira o Id do produto para mais informações ou 0 para sair");
                IdProduto = int.Parse(Console.ReadLine());

                if (IdProduto == 0 ) {
                    break;
                }
                
                ProdutoViewModel produtoViewModel = produtoRep.BuscarId(IdProduto);

                if (produtoViewModel != null) {
                    System.Console.WriteLine($"{produtoViewModel.Id} - {produtoViewModel.Nome} - {produtoViewModel.Preco} - {produtoViewModel.Descricao} - {produtoViewModel.Preco} - {produtoViewModel.DataCriacao}");
                } else {
                    System.Console.WriteLine("Produto não encontrado");
                }
            } while (IdProduto != 0);
        }

        public static void ExibirTotal() {
            List<ProdutoViewModel> lsProduto = produtoRep.Listar();
            decimal TotalPreco = 0.0m;

            foreach (ProdutoViewModel item in lsProduto)
            {
                TotalPreco += item.Preco;
            }

            System.Console.WriteLine($"O preço total dos produtos é de {TotalPreco} e você possui {lsProduto.Count} produtos cadastrados");
        } 
    }
}