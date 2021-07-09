using System;
using E08_garrafa.Classes;

namespace Senai.Metodos.Exercicio2
{
    class Program
    {
        static void Main()
        {
            Garrafa garrafa = new Garrafa();

            Console.WriteLine("Ações da garrafa:");
            Console.WriteLine("1 - Encher");
            Console.WriteLine("2 - Esvaziar");
            int acao = int.Parse(Console.ReadLine());
        
            switch (acao)
            {
                case 1:
                {
                    Console.WriteLine("Informe a quantidade para adicionar");
                    float qdt = float.Parse(Console.ReadLine());

                    garrafa.Encher(qdt);
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Informe a quantidade para retirar");
                    float qdt = float.Parse(Console.ReadLine());

                    garrafa.Esvaziar(qdt);
                    break;
                }
                default:
                {
                    Console.WriteLine("Valor invalido");
                }
                break;
            }

            garrafa.ExibirQuantia();
        }
    }
}
