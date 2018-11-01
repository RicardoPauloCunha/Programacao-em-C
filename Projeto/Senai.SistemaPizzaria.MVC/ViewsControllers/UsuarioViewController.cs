using System;
using System.Collections.Generic;
using System.IO;
using Senai.SistemaPizzaria.MVC.Models;

namespace Senai.SistemaPizzaria.MVC.ViewsControllers 
{
    public class UsuarioViewController 
    {
        public void CadastroUsuario () {
            //Recebe os dados
            #region View
            Console.WriteLine ("Informe o seu nome");
            string nome = Console.ReadLine ();

            Console.WriteLine ("Informe o seu email");
            string email = Console.ReadLine ();

            Console.WriteLine ("Informe a sua senha");
            string senha = Console.ReadLine ();
            #endregion

            //Trata os dados
            #region Controller   
            int contador = 0;              
            List<UsuarioViewModel> lsUsuario = Listar();

            if (lsUsuario != null)
                contador = lsUsuario.Count;

            StreamWriter sw = new StreamWriter ("Usuarios.txt", true); //declarado true depois do nome do arquivo para ele não sobescrever o que já foi salvo ou escrito;
            
            UsuarioViewModel Usuario = new UsuarioViewModel ();
            Usuario.Id = contador + 1;
            Usuario.Nome = nome;
            Usuario.Email = email;
            Usuario.Senha = senha;
            Usuario.DataCriacao = DateTime.Now;

            sw.WriteLine ($"{Usuario.Id} ; {Usuario.Nome} ; {Usuario.Email} ; {Usuario.Senha} ; {Usuario.DataCriacao}"); // padrão CSV com ";" para poder transformar o arquivo txt em uma tabela no excel
            sw.Close ();
            #endregion
        }

        public void Login () {
            #region View
            Console.WriteLine ("Informe o seu email");
            string email = Console.ReadLine ();

            Console.WriteLine ("Informe a sua senha");
            string senha = Console.ReadLine ();
            #endregion

            #region Controller
            List<UsuarioViewModel> lsUsuario = Listar();

            foreach (UsuarioViewModel item in lsUsuario) {
                if (item.Email == email && item.Senha == senha) {
                    Console.WriteLine ("Acesso Permitido");
                    break;
                }
            }
            #endregion
        }

        public void ListarUsuarios () {
            #region Controller
            List<UsuarioViewModel> lsUsuario = Listar();
            #endregion

            #region View
            foreach (UsuarioViewModel item in lsUsuario) {
                Console.WriteLine ($"{item.Id}\t{item.Nome}\t{item.Email}\t{item.DataCriacao}");
            }
            #endregion            
        }

        private List<UsuarioViewModel> Listar () {
            #region Controller
            List<UsuarioViewModel> lsUsuario = new List<UsuarioViewModel> ();
            UsuarioViewModel usuario;

            if (File.Exists("Usuarios.txt"))
            return null;

            string[] usuarios = File.ReadAllLines ("Usuarios.txt"); //Recebe todas as linhas do documento

            foreach (string item in usuarios) {
                string[] dados = item.Split (";"); //Referente as linhas recebidas acima, separa as partes do arquivo com o ";"
                usuario = new UsuarioViewModel ();

                usuario.Id = int.Parse (dados[0]);
                usuario.Nome = dados[1];
                usuario.Email = dados[2];
                usuario.Senha = dados[3];
                usuario.DataCriacao = DateTime.Parse (dados[4]);
                lsUsuario.Add (usuario);
            }
            #endregion

            return lsUsuario;
        }
    }
}