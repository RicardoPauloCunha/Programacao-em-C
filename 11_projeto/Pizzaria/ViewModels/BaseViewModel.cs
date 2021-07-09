using System;
namespace Pizzaria.ViewModels
{
    public abstract class BaseViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}