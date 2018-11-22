using System.Collections.Generic;
using Senai.Finacas.Web.Mvc.Models;

namespace Senai.Finacas.Web.Mvc.Interfaces
{
    public interface IUsuario
    {
        /// <summary>
        /// Interface do usuário
        /// Metódos que a calsse que irpa herdar deverá ter
        /// </summary>
        /// <returns>Retorna um List<UsuarioModel></returns>
         List<UsuarioModel> Listar();

        /// <summary>
        /// Cadastrar um novo usuário
        /// </summary>
        /// <param name="usuario">UsuarioModel</param>
        /// <returns>Retorna um usuário</returns>
         UsuarioModel Cadastrar(UsuarioModel usuario);
         
        /// <summary>
        /// Edita um usuário
        /// </summary>
        /// <param name="usuario">UsuarioModel</param>
        /// <returns>Retorna um usuario editado</returns>
        UsuarioModel Editar(UsuarioModel usuario);

        /// <summary>
        /// exclui um usuário por meio do seu id
        /// </summary>
        /// <param name="id">id do usuário</param>
        void Excluir(int id);

        /// <summary>
        /// Efetua o login do usurario
        /// </summary>
        /// <param name="email">Email do usuario</param>
        /// <param name="senha">Senha do usuario</param>
        /// <returns></returns>
        UsuarioModel Login(string email, string senha);
    
        UsuarioModel BuscarPorId(int id);
    }
}