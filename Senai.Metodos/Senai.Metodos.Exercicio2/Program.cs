using System;
using Senai.Metodos.Exercicio2.Classes;

namespace Senai.Metodos.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garrafa garrafa = new Garrafa();
            Console.WriteLine("Informe: 1 - Encher, 2 - Esvaziar, a garrafa:");
            int acao = int.Parse(Console.ReadLine());
        
            switch (acao)
            {
                case 1:{
                    Console.WriteLine("Informe a quantidade para adicionar");
                    float qdt = float.Parse(Console.ReadLine());
                    garrafa.Encher(qdt);
                    break;
                }
                case 2:{
                    Console.WriteLine("Informe a quantidade para retirar");
                    float qdt = float.Parse(Console.ReadLine());
                    garrafa.Esvaziar(qdt);
                    break;
                }
                default:
                    Console.WriteLine("Valor invalido");
                break;
            }

            garrafa.ExibirQuantia();
        }
    }
}
