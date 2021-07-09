using System;

namespace E02_validaNumero
{
    class Program
    {
        static void Main()
        {
            float[] numeros = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Informe um numero({i+1}/5):");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (numeros[i] > 0)
                    Console.WriteLine($"O número {numeros[i]} é valido");
                else
                    Console.WriteLine($"O número {numeros[i]} não é valido");
            }
        }
    }
}
