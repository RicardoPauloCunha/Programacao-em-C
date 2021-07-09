using SistemaFinancas.Models;
using System.Collections.Generic;

namespace SistemaFinancas.Interfaces
{
    interface ITransacaoRepositorio
    {
        TransacaoModel Cadastrar(TransacaoModel transacao);
        List<TransacaoModel> Listar();
    }
}
