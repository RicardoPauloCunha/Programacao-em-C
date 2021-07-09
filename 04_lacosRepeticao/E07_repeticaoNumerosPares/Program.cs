using System;

namespace E07_repeticaoNumerosPares
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira um Número:");
            int valor1 = int.Parse(Console.ReadLine());

            int i = 0;

            do
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;       
            } while(i != valor1);

            Console.WriteLine($"Quantidade de números pares que se repetem: {(i / 2)}");
        }
    }
}
