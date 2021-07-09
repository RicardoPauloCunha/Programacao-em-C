using System;
using System.Collections.Generic;
using Pizzaria.Repositorio;
using Pizzaria.Util;
using Pizzaria.ViewModels;

namespace Pizzaria.Controllers
{
    public static class UsuarioController
    {
        static readonly UsuarioRepositorio _usuarioRepositorio = new UsuarioRepositorio ();

        public static void CadastrarUsuario()
        {
            string nome, email, senha;

            #region Input
            do
            {
                Console.WriteLine("Insira o nome:");
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                    Console.WriteLine("Nome Inválido");
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine("Insira o email com @ e .");
                email = Console.ReadLine();

                if (!ValidacaoUtil.ValidarEmail(email))
                    Console.WriteLine("Email inválido");
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                Console.WriteLine("Insira o Senha");
                senha = Console.ReadLine();

                if (!ValidacaoUtil.ValidarSenha(senha))
                    Console.WriteLine("Senha inválida");
            } while (!ValidacaoUtil.ValidarSenha(senha));
            #endregion

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel(nome, email, senha);
            _usuarioRepositorio.Adicionar(usuarioViewModel);
            Console.WriteLine ("Usuário Cadastrado");
        }

        public static void ListarUsuarios()
        {
            List<UsuarioViewModel> usuarios = _usuarioRepositorio.Listar();

            foreach (UsuarioViewModel item in usuarios)
                Console.WriteLine($"{item.Id} - {item.Nome} - {item.Email}");
        }

        public static UsuarioViewModel EfetuarLogin()
        {
            string email, senha;

            #region Input     
            do {
                Console.WriteLine("Insira o email com @ e .");
                email = Console.ReadLine();

                if (!ValidacaoUtil.ValidarEmail(email))
                    Console.WriteLine("Email inválido");
            } while (!ValidacaoUtil.ValidarEmail(email));

            do {
                Console.WriteLine("Insira o Senha");
                senha = Console.ReadLine();

                if (!ValidacaoUtil.ValidarSenha(senha))
                    Console.WriteLine("Senha inválida");
            } while (!ValidacaoUtil.ValidarSenha(senha));
            #endregion

            UsuarioViewModel usuario = _usuarioRepositorio.EfetuarLogin(email, senha);

            if (usuario != null)
                return usuario;
            else
            {
                Console.WriteLine("Emaill ou Senha inválidos");
                return null;
            }
        }
    }
}