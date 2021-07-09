using System;

namespace E03_numerosPares
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe um numero par");
            int numInicial = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < 20; cont+=2)
            {
                Console.WriteLine(numInicial + cont);
            }
        }
    }
}
