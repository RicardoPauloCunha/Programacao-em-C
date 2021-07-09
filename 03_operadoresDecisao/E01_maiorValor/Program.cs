using System;

namespace E01_maiorValor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira um valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro valor:");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine($"O valor {valor1} é o maior");
            }
            else
            {
                Console.WriteLine($"O valor {valor2} é o maior");
            }
        }
    }
}
