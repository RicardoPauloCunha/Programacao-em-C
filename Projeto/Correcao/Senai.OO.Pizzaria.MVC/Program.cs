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
            int opcaoDeslogado = 0, opcaoLogado = 0;

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
                        //chama a pagina login e aguardo o retorno
                        UsuarioViewModel usuarioViewModel = UsuarioViewController.EfetuarLogin();

                        //usuario valido
                        if (usuarioViewModel != null) {
                            System.Console.WriteLine($"Seja Bem-Vindo {usuarioViewModel.Nome}");

                            //laço menu logado
                            do {
                                //mostra o menu e obtem opção menu
                                MenuUtil.MenuLogado();
                                opcaoLogado = int.Parse(Console.ReadLine());
                            } while (opcaoLogado != 0);

                            switch (opcaoLogado)
                            {
                                case 1: {
                                    ProdutoViewController.CadastrarProduto();
                                    break;
                                }

                                case 2: {
                                    ProdutoViewController.ListarProduto();
                                    break;
                                }

                                case 3: {
                                    ProdutoViewController.ExibirTotal();
                                    break;
                                }
                                case 0: {
                                    System.Console.WriteLine("Tchau!!!");
                                    break;
                                }
                                
                                default: {
                                    System.Console.WriteLine("Opção inválida");
                                    break;
                                }
                            }
                        }
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
