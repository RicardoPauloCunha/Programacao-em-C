using System;

namespace Senai.For.Exercicio3.NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero par");
            int numInicial = int.Parse(Console.ReadLine());

            //Pega o numero inicial e acrescenta +2 até formar 100 numeros pares depois do insiredo
            for (int cont = 0; cont <= 200; cont+=2)
            {
                Console.WriteLine(numInicial + cont);
            }
        }
    }
}
