using System;
using System.IO;

namespace E01_legenda
{
    class Program
    {
        static void Main()
        {
            string[] linha = new string[0];
            int cont = 0;
            int opcao;

            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"Legendas\legenda.txt";
            fileName = fileName.Replace(@"\bin\Debug\netcoreapp2.1", "");

            do
            {
                Console.Clear();
                Console.WriteLine("Deseja adicionar uma legenda?");
                Console.WriteLine("1 = Sim");
                Console.WriteLine("0 = Não");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1) {
                    Array.Resize(ref linha, linha.Length + 2);

                    Console.WriteLine("Digite o tempo inicial");
                    DateTime tempoInicial = DateTime.Parse(Console.ReadLine());
                    string tempoI = tempoInicial.ToString("HH:mm:ss");

                    Console.WriteLine("Digite o tempo final");
                    DateTime tempoFinal = DateTime.Parse(Console.ReadLine());
                    string tempoF = tempoFinal.ToString("HH:mm:ss");

                    Console.WriteLine("Digite a fala");
                    string legenda = Console.ReadLine();

                    linha[cont] = $"{tempoI} --> {tempoF}";
                    cont++;
                    linha[cont] = legenda;
                    cont++;

                    File.WriteAllLines(fileName, linha);
                }
                
            } while (opcao != 0);
        }
    }
}
