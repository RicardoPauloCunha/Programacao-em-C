using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.Repositorio
{
    public class ProdutoRepositorio
    {
        static List<ProdutoViewModel> lsProduto= new List<ProdutoViewModel>();

        /// <summary>
        /// Metodo responsavel por armazenar um produto
        /// </summary>
        /// <param name="produto">Produto que será armazenado</param>
        /// <returns>Retorna um Produto com os dados alterados</returns>
        public ProdutoViewModel Inserir(ProdutoViewModel produto) {
            //Incrementa  1 no id do objeto
            produto.Id = lsProduto.Count + 1;
            //define a data e hora da criação do objeto na lista
            produto.DataCriacao = DateTime.Now;
            
            //Isere o objeto na lista
            lsProduto.Add(produto);
            //Retorna um produto
            return produto;
        }

        /// <summary>
        /// LIsta os produtos
        /// </summary>
        /// <returns>Retorna uma lista de produtos</returns>
        public static List<ProdutoViewModel> Listar() {
            //Retorna
            return lsProduto;
        }

        /// <summary>
        /// Busca pelo id do produto
        /// </summary>
        /// <param name="Id">Id do produto</param>
        /// <returns>retorna o produto caso encontrado ou null caso não encontrado</returns>
        public static ProdutoViewModel BuscarId(int Id){
            //percorre a lista de produto
            foreach (ProdutoViewModel item in lsProduto)
            {
                //verifica se o id do produto é igual ao id passado
                if (item.Id == Id) {
                    //caso encontrado retorna o produto
                    return item;
                }
            }
            //case não encontrado retorna null
            return null;
        }
    }
}