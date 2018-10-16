using System;

namespace Senai.For.Exercicio4.Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numInicial = new int[5];
            int valor = 0;
            for (int cont = 0; cont != 5; cont++)

            //Calcula a media do numeros inseridos
            {
                Console.WriteLine("Informe um numero");
                numInicial[cont] = int.Parse(Console.ReadLine());

                valor += numInicial[cont];
            }
            Console.WriteLine(valor / numInicial.Length);
        }
    }
}
