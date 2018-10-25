using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.Repositorio
{
    /// <summary>
    /// Classes responsável pela leitura e gravação do usuario
    /// </summary>
    public class UsuarioRepositorio
    {
        //criação do objeto list que esta presente no namespace System.Collections.Generic
        //Responsavel por armazenar as informaçoes do usuario
        List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel>();

        /// <summary>
        /// Metódo resposável por armazenar um usuario
        /// </summary>
        /// <param name="Usuario">Usuario que será armazenado</param>
        /// <returns>Retorna um Usuario com os dados alterados</returns>
        public UsuarioViewModel Inserir(UsuarioViewModel usuario) {
            //Incrementa  1 no id do objeto
            usuario.Id = lsUsuarios.Count + 1;
            //define a data e hora da criação do objeto na lista
            usuario.DataCriacao = DateTime.Now;

            //Isere o objeto na lista
            lsUsuarios.Add(usuario);
            //Retorna um usuario
            return usuario;
        }

        /// <summary>
        /// Lista todos os usuarios
        /// </summary>
        /// <returns> Retorna a lista de usuários cadastrados</returns>
        public List<UsuarioViewModel> Listar() {
            //Retorna
            return lsUsuarios;
        }

        /// <summary>
        ///  Verifica se um usuario é valído
        /// </summary>
        /// <param name="Email">Email do usuario</param>
        /// <param name="Senha">Senha do usuario</param>
        /// <returns>Retorna um usuario caso o mesmo seja encontrado ou null caso não exista</returns>
        public UsuarioViewModel EfetuarLogin(string Email, string Senha) {
            //percorre a lista de usuarios            
            foreach (UsuarioViewModel item in lsUsuarios)
            {
                //verifica se um usuario é valido, caso seja retorna o usuario
                if (item.Email == Email && item.Senha == Senha) {
                    return item;
                }
            }
            //Usuario não valido retorna null
            return null;
        }
    }
}