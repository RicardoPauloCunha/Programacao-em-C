using System;

namespace SistemaFinancas.Models
{
    [Serializable]
    public class TransacaoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }

        public TransacaoModel(int id, string descricao, decimal valor, string tipo, DateTime data)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
            Data = data;
        }

        public TransacaoModel(string descricao, decimal valor, string tipo, DateTime data)
        {
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
            Data = data;
        }
    }
}