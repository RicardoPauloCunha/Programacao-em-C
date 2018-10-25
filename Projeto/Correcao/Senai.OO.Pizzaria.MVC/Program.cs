using System;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;
using Senai.OO.Pizzaria.MVC.ViewsControllers;

namespace Senai.OO.Pizzaria.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0, opcaoLogado;

            do {
                MenuUtil.MenuDeslogardo();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1: {
                        UsuarioViewController.CadastrarUsuario();
                        break;
                    }

                    case 2: {
                        
                        break;
                    }

                    case 3: {
                        UsuarioViewController.ListarUsuarios();
                        break;
                    }

                    case 0: {
                        Console.WriteLine("Sair");
                        break;
                    }
                    default: {
                        System.Console.WriteLine("Opção Inválida");
                        break;
                    }
                }
            } while (opcaoDeslogado != 0);
        }
    }
}
