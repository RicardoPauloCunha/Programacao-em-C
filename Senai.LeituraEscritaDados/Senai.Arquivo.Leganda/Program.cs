using System;

namespace Senai.Arquivo.Leganda
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linha = new string[1];
            int cont = 0;
            int menu;


            do {
            Console.WriteLine("Deseja adicionar uma legenda? (1 = sim / 0 = não)");
            menu = int.Parse(Console.ReadLine());
;

                if (menu == 1) {
                    Array.Resize(ref linha, linha.Length + 2);

                    Console.WriteLine("Digite o tempo inicial");
                    DateTime tempoInicial = DateTime.Parse(Console.ReadLine());
                    //Console.WriteLine(tempoInicial.ToString("HH:mm:ss"));
                    string tempoI = tempoInicial.ToString("HH:mm:ss");

                    Console.WriteLine("Digite o tempo final");
                    DateTime tempoFinal = DateTime.Parse(Console.ReadLine());
                    //Console.WriteLine(tempoFinal.ToString("HH:mm:ss"));
                    string tempoF = tempoFinal.ToString("HH:mm:ss");


                    Console.WriteLine("Digite a fala");
                    string legenda = Console.ReadLine();

                    linha[cont] = ($"{tempoI} --> {tempoF}");
                    cont++;
                    linha[cont] = legenda;
                    cont += 2;

                    System.IO.File.WriteAllLines(@"C:\Users\50473694808\Desktop\C#\Senai.LeituraEscritaDados\Arquivos txt\TesteLegenda1.txt", linha );
                }
                
            } while (menu != 0);
        }
    }
}
