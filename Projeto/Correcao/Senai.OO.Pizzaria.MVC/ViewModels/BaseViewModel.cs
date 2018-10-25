using System;
namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classes que será utilizada como base para outras classes
    /// Abstract define que a classe não poderá ser instânciada
    /// </summary>
    public abstract class BaseViewModel
    {
        /// <summary>
        /// Id do objeto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do objeto que será herdada
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de criação do objeto na base de dados
        /// </summary>
        public DateTime DataCriacao { get; set; }
    }
}