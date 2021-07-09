using System;

namespace Transacao.Models
{
    public class TransacaoModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string TipoTransacao { get; set; }
        public DateTime DataTransacao { get; set; }

        public TransacaoModel(string nome, string descricao, decimal valor, string tipoTransacao, DateTime dataTransacao)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            TipoTransacao = tipoTransacao;
            DataTransacao = dataTransacao;
        }
    }
}