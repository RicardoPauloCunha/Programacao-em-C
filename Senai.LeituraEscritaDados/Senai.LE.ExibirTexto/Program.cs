using System;
using System.IO;

namespace Senai.LE.ExibirTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter escritor;
            string caminho = @"C:\Users\50473694808\Desktop\C#\Senai.LeituraEscritaDados\Arquivos txt\NomeArq";
            escritor = File.CreateText(caminho);

            escritor.WriteLine("Escrita ; de texto ; em um arquivo txt");
            escritor.WriteLine("teste para ; uso de while para ; exibir o conteudo");

            // escritor.Close();
            // Console.ReadKey();

            // StreamReader leitor;

            // leitor = File.OpenText(caminho);
           
            // while (leitor.EndOfStream != true)
            // {
            //     string linha = leitor.ReadLine();
            //     Console.WriteLine(linha);
            // }

            // string linha = leitor.ReadToEnd();
            // Console.WriteLine(linha);

            // Console.ReadKey();

            try 
            { 
                //Declaro o StreamReader para o caminho onde se encontra o arquivo 
                StreamReader rd = new StreamReader(caminho); 
                //Declaro uma string que será utilizada para receber a linha completa do arquivo 
                string linha = null; 
                //Declaro um array do tipo string que será utilizado para adicionar o conteudo da linha separado 
                string[] linhaseparada = null; 
                //realizo o while para ler o conteudo da linha 
                while ((linha = rd.ReadLine()) != null) 
                { 
                    //com o split adiciono a string 'quebrada' dentro do array 
                    linhaseparada = linha.Split(';'); 
                    //aqui incluo o método necessário para continuar o trabalho 
                
                } 
                rd.Close(); 
            } 
            catch 
            { 
                Console.WriteLine("Erro ao executar Leitura do Arquivo"); 
            } 

        }
    }
}
