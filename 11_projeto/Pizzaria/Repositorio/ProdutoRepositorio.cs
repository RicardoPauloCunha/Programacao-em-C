using System;
using System.Collections.Generic;
using Pizzaria.ViewModels;

namespace Pizzaria.Repositorio
{
    public class ProdutoRepositorio
    {
        static readonly List<ProdutoViewModel> _produtos = new List<ProdutoViewModel>();

        public ProdutoViewModel Adicionar(ProdutoViewModel produto)
        {
            produto.Id = _produtos.Count + 1;
            
            _produtos.Add(produto);
            return produto;
        }

        public List<ProdutoViewModel> Listar()
        {
            return _produtos;
        }

        public ProdutoViewModel Buscar(int produtoId)
        {
            foreach (ProdutoViewModel item in _produtos)
            {
                if (item.Id == produtoId)
                    return item;
            }

            return null;
        }
    }
}