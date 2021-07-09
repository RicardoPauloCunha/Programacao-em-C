using System;
using System.Diagnostics;
using System.IO;

namespace E02_folhaCadastro
{
    class Program
    {
        static void Main()
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"Cadastros\";
            fileName = fileName.Replace(@"\bin\Debug\netcoreapp2.1", "");

            string opcao;
            string caminho;

            Console.WriteLine("-- Cadastro de usuários --");
            Console.WriteLine("1 - Criar arquivo de cadastro");
            Console.WriteLine("2 - Ler arquivo");
            Console.WriteLine("0 - Sair");
            string menu = Console.ReadLine();
            
            switch (menu)
            {
                case "1":
                {
                    
                    #region Escrever arquivo
                    StreamWriter fileWriter;

                    Console.Clear();
                    Console.WriteLine("Insira o nome do arquivo de cadastro");
                    caminho = fileName + Console.ReadLine() + ".txt";

                    fileWriter = File.CreateText(caminho);

                    Console.Clear();
                    Console.WriteLine("-- Folha de cadastro --");
                    Console.WriteLine("Insira o nome do usuário:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Insira o email do usuário:");
                    string email = Console.ReadLine();

                    fileWriter.WriteLine("-- Folha de cadastro --");
                    fileWriter.WriteLine("");
                    fileWriter.WriteLine("Nome do usuário: ");
                    fileWriter.WriteLine(nome);
                    fileWriter.WriteLine("");
                    fileWriter.WriteLine("Email do usuário:");
                    fileWriter.WriteLine(email);
                    fileWriter.WriteLine("");

                    fileWriter.Close();
                    #endregion

                    #region Alterando arquivo
                    StreamWriter fileAppend = File.AppendText(caminho);

                    fileAppend.WriteLine("Data de criação:" + DateTime.Now);

                    fileAppend.Close();
                    #endregion

                    Console.Clear();
                    Console.WriteLine("Cadastro realizado com sucesso. Aperte ENTER para continuar.");
                    Console.ReadKey();
                    break;
                }
                case "2":
                {
                    break;
                }
                case "0":
                {
                    Console.WriteLine("Saindo...");
                    return;
                }
                default:
                {
                    Console.WriteLine("Valor inválido!");
                    break;
                }
            }

            #region Ler arquivo
            StreamReader fileReader;

            Console.Clear();
            Console.WriteLine("Insira o nome do arquivo para leitura");
            caminho = fileName + Console.ReadLine() + ".txt";

            fileReader = File.OpenText(caminho);

            Console.Clear();
            while (fileReader.EndOfStream != true)
            {
                string linha = fileReader.ReadLine();
                Console.WriteLine(linha);
            }

            fileReader.Close();

            Console.WriteLine("");
            Console.WriteLine("Aperte ENTER para continuar.");
            Console.ReadKey();
            #endregion

            Console.Clear();
            Console.WriteLine("Deseja deletar esse arquivo[S/N]");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "S":
                {
                    File.Delete(caminho);

                    Console.WriteLine("Arquivo deletado com sucesso");
                    break;
                }
                case "N":
                {
                    Process.Start("notepad", caminho); // Abre o arquivo
                    break;
                }
                default:
                {
                    Console.WriteLine("Valor inválido");
                    break;
                }
            }
        }
    }
}
