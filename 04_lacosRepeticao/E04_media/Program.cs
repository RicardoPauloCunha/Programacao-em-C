using System;

namespace E04_media
{
    class Program
    {
        static void Main()
        {
            int i;
            int valor = 0;

            for (i = 0; i != 5; i++)
            {
                Console.WriteLine($"Informe um numero({i+1}/5):");
                valor += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Meida dos números: {valor / i}");
        }
    }
}
