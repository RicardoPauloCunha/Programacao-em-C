using System;
using Ricardo.projetoPizzaria.Classes;

namespace Ricardo.projetoPizzaria {
    class Program {
        Usuario[] usuarios = new Usuario[0];
        static void Main (string[] args) {
            int QuantCadastro = 0;
            Usuario[] usuario = new Usuario[QuantCadastro];
            string opcao;
            int ContadorUsuario = 0;
            bool Acesso = false;

            //Menu do Usuario
            do {
                Menu ();
                opcao = Console.ReadLine ();
                Console.WriteLine ("");

                switch (opcao) {

                    //Cadastrar Usuario
                    case "1":
                        {
                            string Email;
                            String Senha;
                            String OpcaoCad;

                            do {
                                Console.WriteLine ("deseja cadastrar um novo usuario?[S/N]");
                                OpcaoCad = Console.ReadLine ();

                                switch (OpcaoCad) {
                                    case "S":
                                        {
                                            #region Aumentar limite array
                                            QuantCadastro++;
                                            Array.Resize (ref usuario, QuantCadastro);
                                            usuario[ContadorUsuario] = new Usuario ();
                                            #endregion

                                            #region Id 
                                            usuario[ContadorUsuario].Id = ContadorUsuario + 1;
                                            #endregion

                                            #region Nome
                                            System.Console.WriteLine ("Insira o Nome de cadastro");
                                            usuario[ContadorUsuario].Nome = Console.ReadLine ();
                                            #endregion

                                            #region Email
                                            bool emailValido = false;
                                            do {
                                                System.Console.WriteLine ("Insira o E-mail de cadastro");
                                                Email = Console.ReadLine ();

                                                if (Email.Contains ("@") && Email.Contains (".")) {
                                                    emailValido = true;
                                                    usuario[ContadorUsuario].Email = Email;
                                                } else {
                                                    System.Console.WriteLine ("E-mail inválido");
                                                }
                                            } while (!emailValido);
                                            #endregion

                                            #region Senha
                                            bool senhaValida = false;
                                            do {
                                                System.Console.WriteLine ("Insira a Senha de cadastro");
                                                Senha = Console.ReadLine ();

                                                if (Senha.Length >= 6) {
                                                    senhaValida = true;
                                                    usuario[ContadorUsuario].Senha = Senha;
                                                } else {
                                                    System.Console.WriteLine ("Senha inválida");
                                                }
                                            } while (!senhaValida);
                                            #endregion

                                            #region Data
                                            usuario[ContadorUsuario].Data = DateTime.Now;
                                            #endregion

                                            ContadorUsuario++;
                                            break;
                                        }

                                    case "N":
                                        {
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine ("Valor Inválido");
                                            break;
                                        }
                                }
                            } while (OpcaoCad != "N");
                            Console.WriteLine ("");
                            break;
                        }

                    //Validar login
                    case "2":
                        {
                            string Email;
                            String Senha;

                            Console.WriteLine ("--LOGIN--");

                            #region Email
                            bool emailValido = false;
                            do {
                                System.Console.WriteLine ("Insira o E-mail");
                                Email = Console.ReadLine ();

                                if (Email.Contains ("@") && Email.Contains (".")) {
                                    emailValido = true;
                                } else {
                                    System.Console.WriteLine ("E-mail inválido");
                                }
                            } while (!emailValido);
                            #endregion

                            #region Senha
                            bool senhaValida = false;
                            do {
                                System.Console.WriteLine ("Insira a Senha:");
                                Senha = Console.ReadLine ();

                                if (Senha.Length >= 6) {
                                    senhaValida = true;
                                } else {
                                    System.Console.WriteLine ("Senha inválida");
                                }
                            } while (!senhaValida);
                            #endregion

                            #region ValidarConta
                            if (emailValido == true && senhaValida == true) {
                                for (int i = 0; i < QuantCadastro; i++) {
                                    if (usuario[i].Email == Email && usuario[i].Senha == Senha) {
                                        Console.WriteLine ("Acesso Permitido");
                                        Acesso = true;
                                    } else {
                                        Acesso = false;
                                    }
                                }
                                if (!Acesso) {
                                    Console.WriteLine ("Acesso negado. Tente novamente");
                                }
                            }
                            #endregion

                            break;
                        }

                    //Exibir lista de Usuarios
                    case "3":
                        {
                            Console.WriteLine ("--LISTAR USUARIO--");
                            for (int i = 0; i < QuantCadastro; i++) {
                                #region Exibir usuarios
                                Console.WriteLine ($"Id: {usuario[i].Id}, Nome: {usuario[i].Nome}, E-mail: {usuario[i].Email}");
                                #endregion
                            }
                            Console.ReadKey ();
                            break;
                        }

                    //Sair    
                    case "9":
                        {
                            Console.WriteLine ("--SAIR--");
                            break;
                        }

                    //Caso nenhuma das anteriores
                    default:
                        {
                            Console.WriteLine ("Valor inválio");
                            break;
                        }
                }
            } while (opcao != "9");
            }

            //Menu da Pizzaria
        public static void Menu () {
            Console.WriteLine ("1 - cadastrar");
            Console.WriteLine ("2 - login");
            Console.WriteLine ("3 - listar");
            Console.WriteLine ("9 - sair");
        }

    }

}