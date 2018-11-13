using System;
namespace Senai.Finacas.Web.Mvc.Models
{
    public class TransacaoModel
    {
        public int id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
    }
}