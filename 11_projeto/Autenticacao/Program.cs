using System;
using Autenticacao.Classes;

namespace Autenticacao
{
    class Program
    {
        static Usuario[] usuarios;
        
        static void Main()
        {
            Console.WriteLine("Informe a quantidade cadastros");
            int quantidadeUsuarios = int.Parse(Console.ReadLine());

            usuarios = new Usuario[quantidadeUsuarios];

            int opcao;
            int contador = 0;

            do
            {
                MontarMenu();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    {
                        if (contador < quantidadeUsuarios) {
                            usuarios[contador] = new Usuario();
                            
                            #region Validar email
                            bool emailValido = false;

                            do
                            {
                                Console.WriteLine("Informe seu e-mail");
                                string email = Console.ReadLine();

                                if (email.Contains("@"))
                                {
                                    emailValido = true;
                                    usuarios[contador].Email = email;
                                }
                                else
                                {
                                    Console.WriteLine("E-mail inválido");
                                }
                            } while (!emailValido);
                            #endregion

                            #region Validar senha
                            bool senhaValida = false;

                            do
                            {
                                Console.WriteLine("Informe sua senha");
                                string senha = Console.ReadLine();

                                if (senha.Length >= 4)
                                {
                                    senhaValida = true;
                                    usuarios[contador].Senha = senha;
                                }
                                else
                                {
                                    Console.WriteLine("Coloque uma senha maior que 4 caracteres");
                                }
                            } while (!senhaValida);
                            #endregion

                            Console.WriteLine("Informe o seu nome");
                            usuarios[contador].Nome = Console.ReadLine();
                            
                            Console.WriteLine("Usuário Cadastrado");
                            contador++;
                        }
                        else
                        {
                            Console.WriteLine("Número máximo de usuários atingido");
                        }
                        break;
                    }
                    case 2:
                    {
                        ListarUsuarios();
                        break;
                    }
                    case 3:
                    {
                        #region Email
                        string email;
                        bool emailValido = false;
                                
                        do
                        {
                            Console.WriteLine("Informe seu e-mail");
                            email = Console.ReadLine();

                            if (email.Contains("@"))
                                emailValido = true;
                            else
                                Console.WriteLine("E-mail inválido");
                        } while (!emailValido);
                        #endregion

                        #region Senha
                        string senha;
                        bool senhaValida = false;

                        do
                        {
                            Console.WriteLine("Informe sua senha");
                            senha = Console.ReadLine();

                            if (senha.Length >= 4)
                                senhaValida = true;
                            else
                                Console.WriteLine("Coloque uma senha maior que 4 caracteres");
                        } while (!senhaValida);
                        #endregion

                        Login(email, senha);
                        break;
                    }
                    case 0:
                    {
                        Console.WriteLine("Volte sempre!!!");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Opção Inválida");
                        break;
                    }
                }
            } while (opcao != 0);
        }

        static void MontarMenu(){
            Console.WriteLine("Menu de Opções");
            Console.WriteLine("1 - Cadastrar Novo Usuário");
            Console.WriteLine("2 - Listar Usuários");
            Console.WriteLine("3 - Acessar Sistema");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma opção");
        }

        static void ListarUsuarios()
        {
            foreach (Usuario item in usuarios)
            {
                if(item != null)
                    Console.WriteLine($"{item.Nome} - {item.Email}");
            }
        }
    
        static void Login(string email, string senha)
        {
            bool encontrado = false;

            foreach (Usuario item in usuarios)
            {
                if (item != null && item.Email == email && item.Senha == senha)
                {
                    Console.WriteLine("Acesso Liberado");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                Console.WriteLine("Acesso não Autorizado");
        }
    }
}
