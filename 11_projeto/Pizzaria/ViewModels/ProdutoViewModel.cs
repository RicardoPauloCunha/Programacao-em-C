using System;

namespace Pizzaria.ViewModels
{
    public class ProdutoViewModel : BaseViewModel
    {
        public string Descricao { get; set; }
        public string Categoria { get; set; }        
        public decimal Preco { get; set; }

        public ProdutoViewModel(string nome, string descricao, string categoria, decimal preco)
        {
            Nome = nome;
            Descricao = descricao;
            Categoria = categoria;
            Preco = preco;
            DataCriacao = DateTime.Now;
        }
    }
}