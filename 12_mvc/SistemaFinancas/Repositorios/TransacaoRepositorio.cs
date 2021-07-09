using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SistemaFinancas.Interfaces;
using SistemaFinancas.Models;

namespace SistemaFinancas.Repositorios
{
    public class TransacaoRepositorio : ITransacaoRepositorio
    {
        private readonly List<TransacaoModel> _transacoes;
        private const string NOMEARQUIVO = "transacoes.dat";

        public TransacaoRepositorio()
        {
            if (File.Exists(NOMEARQUIVO))
                _transacoes = Listar();
            else
                _transacoes = new List<TransacaoModel>();
        }

        public TransacaoModel Cadastrar(TransacaoModel transacao)
        {
            transacao.Id = _transacoes.Count + 1;
            _transacoes.Add(transacao);

            SerializarTransacoes();

            return transacao;
        }

        public List<TransacaoModel> Listar()
        {
            if (!File.Exists(NOMEARQUIVO))
                return new List<TransacaoModel>();

            byte[] bytesSerializado = File.ReadAllBytes(NOMEARQUIVO);

            BinaryFormatter serializador = new BinaryFormatter();
            MemoryStream memoria = new MemoryStream(bytesSerializado);

            return (List<TransacaoModel>)serializador.Deserialize(memoria);
        }

        private void SerializarTransacoes()
        {
            MemoryStream memoria = new MemoryStream();
            BinaryFormatter serializador = new BinaryFormatter();

            serializador.Serialize(memoria, _transacoes);

            File.WriteAllBytes(NOMEARQUIVO, memoria.ToArray());
        }
    }
}