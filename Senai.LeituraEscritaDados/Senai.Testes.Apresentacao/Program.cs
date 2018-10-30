using System;
using System.IO;

namespace Senai.Testes.Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string Menu;
            string EndereçoArq;
            string NomeArq;
            string Caminho;
            string Nome;
            string Email;
            DateTime Data = DateTime.Now;
            string opcao;

            //BASE PARA A ESCRITA DE TEXTO:
            StreamWriter WrArquivoTexto;
            Console.WriteLine("1 - Criar um Arquivo de Texto");
            Console.WriteLine("0 - Sair");
            Menu = Console.ReadLine();
            
            switch (Menu)
            {
                case "1": {
                    //Criando o arquivo texto
                    Console.WriteLine("--Criar Arquivo Texto--");
                    Console.WriteLine("Insira o Local onde deseja criar o arquivo(Endereço)");
                    EndereçoArq = Console.ReadLine();
                    
                    Console.WriteLine("Insira o nome da arquivo");
                    NomeArq = Console.ReadLine();
                    Console.WriteLine();
                    
                    Caminho = EndereçoArq + NomeArq + ".txt";
                    WrArquivoTexto = File.CreateText(Caminho);

                    //ESCRITA DE ARQUIVOS TEXTO:
                    WrArquivoTexto.WriteLine("--Folha de Cadastro--");
                    Console.WriteLine("--Folha de Cadastro--");
                    WrArquivoTexto.WriteLine();
                    WrArquivoTexto.WriteLine("Nome do Usuario: ");
                    Console.WriteLine("Insira o nome do Usuario:");
                    Nome = Console.ReadLine();
                    WrArquivoTexto.WriteLine(Nome);
                    WrArquivoTexto.WriteLine("Email do Usuario:");
                    Console.WriteLine("Inisira o Email do Usuario:");
                    Email = Console.ReadLine();
                    WrArquivoTexto.WriteLine(Email);     

                    WrArquivoTexto.Close();

                    //ABRINDO E ALTERANDO O ARQUIVO TEXTO
                    WrArquivoTexto = File.AppendText(Caminho);

                    WrArquivoTexto.WriteLine("Data de Criação:" + Data);
                    WrArquivoTexto.WriteLine();
                    WrArquivoTexto.WriteLine("Cadastro efetuado com Sucesso!");
                    WrArquivoTexto.Close();
                    
                    System.Diagnostics.Process.Start("notepad", Caminho);
                    Console.ReadKey();
                    break;
                }

                case "0": {
                    Console.WriteLine("--Sair--");
                    break;
                }
                
                default: 
                Console.WriteLine("Valor Inválido!");
                break;
            }

            //LENDO O ARQUIVO:
            StreamReader RdArquivoTexto;

            Console.WriteLine("Insira o local do arquivo");
            EndereçoArq = Console.ReadLine();
            Console.WriteLine("Insira o nome do arquivo");
            NomeArq = Console.ReadLine();
            RdArquivoTexto = File.OpenText(EndereçoArq + NomeArq + ".txt");

            while (RdArquivoTexto.EndOfStream !=true) {
                string linha = RdArquivoTexto.ReadLine();
                Console.WriteLine(linha);
            }
            Console.ReadKey();

            //DELETA O ARQUIVO:
            Console.WriteLine("deseja deletar esse arquivo[S/N]");
            opcao = Console.ReadLine();
             switch (opcao)
             {
                 case "S": {
                    Console.WriteLine("Insira o local do arquivo");
                    EndereçoArq = Console.ReadLine();
                    Console.WriteLine("Insira o nome do arquivo");
                    NomeArq = Console.ReadLine();
                    File.Delete(EndereçoArq + NomeArq + ".txt");
                    Console.WriteLine("Arquivo deletado com sucesso");
                    break;
                 }

                 case "N": {
                     Console.WriteLine("Deletado com Sucesso");
                     break;
                 }
                 
                 default:
                 Console.WriteLine("Valor inválido");
                 break;
            }
        }
    }
}
