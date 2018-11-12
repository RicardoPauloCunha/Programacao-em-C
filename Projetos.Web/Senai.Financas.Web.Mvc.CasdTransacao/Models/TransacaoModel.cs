using System;

namespace Senai.Financas.Web.Mvc.CasdTransacao.Models
{
    public class TransacaoModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string TipoTransacao { get; set; }
        public DateTime DataTransacao { get; set; }
    }
}