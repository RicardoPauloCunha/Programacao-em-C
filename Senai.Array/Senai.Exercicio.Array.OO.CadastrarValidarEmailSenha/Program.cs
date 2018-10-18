﻿using System;
using Senai.Exercicio.Array.OO.CadastrarValidarEmailSenha.Classes;

namespace Senai.Exercicio.Array.OO.CadastrarValidarEmailSenha
{
    class Program
    {
        static Usuario[] arrayUsuario;
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe a quantidade cadastros");
            int quantMaximaUsuarios = int.Parse(Console.ReadLine());

            arrayUsuario = new Usuario[quantMaximaUsuarios];
            int opcao = 0, contador = 0;

            //Fica no laço do menu de opções
            do
            {
                MontarMenu();

                //Pega do usuário a opção do menu
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:{
                        if(contador < quantMaximaUsuarios){
                            //Instancio o meu objeto Usuário no indice do array
                            arrayUsuario[contador] = new Usuario();
                            
                            #region Email
                                bool emailValido = false;
                                do
                                {
                                    System.Console.WriteLine("Informe seu e-mail");
                                    string email = Console.ReadLine();

                                    if (email.Contains("@")){
                                        emailValido = true;
                                        arrayUsuario[contador].Email = email;
                                    } else {
                                        System.Console.WriteLine("E-mail inválido");
                                    }
                                } while (!emailValido);
                            #endregion

                            #region Senha
                                bool senhaValida = false;
                                do
                                {
                                    System.Console.WriteLine("Informe sua senha");
                                    string senha = Console.ReadLine();

                                    if (senha.Length >= 4){
                                        senhaValida = true;
                                        arrayUsuario[contador].Senha = senha;
                                    } else {
                                        System.Console.WriteLine("Senha inválida");
                                    }
                                } while (!senhaValida);
                            #endregion

                            #region Nome
                                System.Console.WriteLine("Informe o seu nome");
                                arrayUsuario[contador].Nome = Console.ReadLine();
                            #endregion
                            
                            System.Console.WriteLine("Usuário Cadastrado");
                            
                            contador++;
                        } else {
                            System.Console.WriteLine("Número máximo de usuários atingido");
                        }
                        break;
                    }
                    case 2:{
                        ListarUsuarios();
                        break;
                    }
                    case 3:{
                        string email;
                        string senha;
                        #region Email
                                bool emailValido = false;
                                
                                do
                                {
                                    System.Console.WriteLine("Informe seu e-mail");
                                    email = Console.ReadLine();

                                    if (email.Contains("@")){
                                        emailValido = true;
                                    } else {
                                        System.Console.WriteLine("E-mail inválido");
                                    }
                                } while (!emailValido);
                            #endregion

                        #region Senha
                                bool senhaValida = false;
                                do
                                {
                                    System.Console.WriteLine("Informe sua senha");
                                    senha = Console.ReadLine();

                                    if (senha.Length >= 4){
                                        senhaValida = true;
                                    } else {
                                        System.Console.WriteLine("Senha inválida");
                                    }
                                } while (!senhaValida);
                            #endregion

                        ValidaEmailSenha(email, senha);
                        break;
                    }
                    case 0 :{
                        System.Console.WriteLine("Volte sempre!!!");
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Opção Inválida");
                        break;
                    }
                }
            } while (opcao != 0);
        }

        /// <summary>
        /// Monta a estrutura do Menu
        /// </summary>
        static void MontarMenu(){
            System.Console.WriteLine("Menu de Opções");
            System.Console.WriteLine("1 - Cadastrar Novo Usuário");
            System.Console.WriteLine("2 - Listar Usuários");
            System.Console.WriteLine("3 - Acessar Sistema");
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine("Escolha a opção");
        }

        /// <summary>
        /// Lista todos os usuários cadastrados
        /// </summary>
        static void ListarUsuarios(){
            foreach (Usuario item in arrayUsuario)
            {
                if(item != null)
                    System.Console.WriteLine($"{item.Nome} - {item.Email}");
            }
        }
    
        static void ValidaEmailSenha(string email, string senha){
            bool encontrado = false;
            foreach (Usuario item in arrayUsuario)
            {
                if (item != null){
                    if(item.Email == email && item.Senha == senha){
                        System.Console.WriteLine("Acesso Liberado");
                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado)
                System.Console.WriteLine("Acesso não Autorizado");
        }
    }
}
