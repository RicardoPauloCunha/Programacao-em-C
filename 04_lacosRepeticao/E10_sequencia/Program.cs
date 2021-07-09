using System;

namespace E10_sequencia
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o primeiro número da sequência:");
            int numeroInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ultimo número da sequência");
            int numeroChegada = int.Parse(Console.ReadLine());

            int i = numeroInicial;
            Console.Clear();

            if (numeroInicial < numeroChegada)
                while (i < numeroChegada - 1) {
                    i++;
                    Console.WriteLine(i);
                }
            else
                while (i > numeroChegada + 1) {
                    i--;
                    Console.WriteLine(i);
                }
        }
    }
}
