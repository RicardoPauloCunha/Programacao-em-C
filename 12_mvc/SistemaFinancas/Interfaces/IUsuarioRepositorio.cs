using System.Collections.Generic;
using SistemaFinancas.Models;

namespace SistemaFinancas.Interfaces
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel Cadastrar(UsuarioModel usuario);
        UsuarioModel Editar(UsuarioModel usuario);
        UsuarioModel Login(string email, string senha);
        UsuarioModel BuscarPorId(int id);
        List<UsuarioModel> Listar();
        void Excluir(int id);
    }
}