using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Repositorio;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.ViewsControllers {
    /// <summary>
    /// classe responsavel por receber e mostrar os dados referentes ao usuario
    /// </summary>
    public static class UsuarioViewController {
        static UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();

        /// <summary>
        /// Metodo que representa a tela de  cadastro de usuario
        /// obtem nome, email e senha e mandar inserir
        /// </summary>
        public static void CadastrarUsuario () {
            string Nome, Email, Senha;

            do {
                System.Console.WriteLine ("Insira o nome:");
                Nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (Nome)) {
                    System.Console.WriteLine ("Nome Inválido");
                }

            } while (string.IsNullOrEmpty (Nome));

            do {
                System.Console.WriteLine ("Insira o email com @ e .");
                Email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (Email)) {
                    System.Console.WriteLine ("Email inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail (Email));

            do {
                System.Console.WriteLine ("Insira o Senha");
                Senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (Senha)) {
                    System.Console.WriteLine ("Senha inválida");
                }
            } while (!ValidacaoUtil.ValidarSenha (Senha));

            //cria o objeto do tipo usuarioViewModel
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = Nome;
            usuarioViewModel.Email = Email;
            usuarioViewModel.Senha = Senha;

            //Atribui os valores ao objeto
            usuarioRep.Inserir (usuarioViewModel);

            //mostra mensagem de usuario cadastrado
            System.Console.WriteLine ("Usuário Cadastrado");
        }

        public static void ListarUsuarios() {
            List<UsuarioViewModel> lsUsuarios = usuarioRep.Listar();

            foreach (UsuarioViewModel item in lsUsuarios)
            {
                System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Email}");
            }
        }

        public static UsuarioViewModel EfetuarLogin() {
            string Email, Senha;

            #region View            
            do {
                System.Console.WriteLine ("Insira o email com @ e .");
                Email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (Email)) {
                    System.Console.WriteLine ("Email inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail (Email));

            do {
                System.Console.WriteLine ("Insira o Senha");
                Senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (Senha)) {
                    System.Console.WriteLine ("Senha inválida");
                }
            } while (!ValidacaoUtil.ValidarSenha (Senha));
            #endregion

            #region Controller
            //verifica se usuario existe
            UsuarioViewModel usuarioViewModel = usuarioRep.EfetuarLogin(Email, Senha);

            //verifica se retorna um usuario valído
            if (usuarioViewModel != null) {
                return usuarioViewModel;
            } else {
                System.Console.WriteLine("Emaill ou Senha inválidos");
                return null;
            }
            #endregion   
            }
    }
}