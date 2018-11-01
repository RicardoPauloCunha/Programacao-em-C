using System;
using Senai.SistemaPizzaria.MVC.ViewsControllers;

namespace Senai.SistemaPizzaria.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewController usuarioViewController = new UsuarioViewController();

            usuarioViewController.CadastroUsuario();
            usuarioViewController.CadastroUsuario();

            usuarioViewController.Login();

            usuarioViewController.ListarUsuarios();


        }
    }
}
