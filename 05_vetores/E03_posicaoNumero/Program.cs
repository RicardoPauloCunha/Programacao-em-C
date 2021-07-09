using System;

namespace E03_posicaoNumero
{
    class Program
    {
        static void Main()
        {
            int[] numeros = new int [3];
            int i = 0;

            do
            {
                Console.WriteLine("Informe um numero");
                numeros[i] = int.Parse(Console.ReadLine());
                i++;
            } while(i < 3);

            System.Array.Sort(numeros);

            i = 0;
            do
            {
                Console.WriteLine($"Número da posição {i} é {numeros[i]}");
                i++;
            } while(i < 3);
        }
    }
}
