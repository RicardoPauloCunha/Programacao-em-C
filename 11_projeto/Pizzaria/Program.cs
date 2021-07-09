using System;
using Pizzaria.Util;
using Pizzaria.ViewModels;
using Pizzaria.Controllers;

namespace Pizzaria
{
    class Program
    {
        static void Main()
        {
            int opcaoDeslogado, opcaoLogado;

            do {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1: {
                        UsuarioController.CadastrarUsuario();
                        break;
                    }

                    case 2: {
                        UsuarioViewModel usuario = UsuarioController.EfetuarLogin();

                        if (usuario != null) {
                            Console.WriteLine($"Seja Bem-Vindo {usuario.Nome}");

                            do {
                                MenuUtil.MenuLogado();
                                opcaoLogado = int.Parse(Console.ReadLine());
                            } while (opcaoLogado != 0);

                            switch (opcaoLogado)
                            {
                                case 1: {
                                    ProdutoController.CadastrarProduto();
                                    break;
                                }
                                case 2: {
                                    ProdutoController.ListarProduto();
                                    break;
                                }
                                case 3: {
                                    ProdutoController.ExibirTotal();
                                    break;
                                }
                                case 0: {
                                    Console.WriteLine("Tchau!!!");
                                    break;
                                }
                                default: {
                                    Console.WriteLine("Opção inválida");
                                    break;
                                }
                            }
                        }
                        break;
                    }
                    case 3: {
                        UsuarioController.ListarUsuarios();
                        break;
                    }
                    case 0: {
                        Console.WriteLine("Sair");
                        break;
                    }
                    default: {
                        Console.WriteLine("Opção Inválida");
                        break;
                    }
                }
            } while (opcaoDeslogado != 0);
        }
    }
}
