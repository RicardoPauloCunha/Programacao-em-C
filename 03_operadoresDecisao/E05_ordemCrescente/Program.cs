using System;

namespace E05_ordemCrescente
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor:");
            int valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("A ordem crescente dos números inseridos é:");

            if (valor1 < valor2 && valor1 < valor3)
                Console.WriteLine(valor1);
            else if (valor2 < valor3)
                Console.WriteLine(valor2);
            else
                Console.WriteLine(valor3);

            if (valor1 > valor2 && valor1 < valor3)
                Console.WriteLine(valor1);
            else if (valor2 > valor1 || valor2 > valor3)
                Console.WriteLine(valor2);
            else
                Console.WriteLine(valor3);

            if (valor1 > valor2 && valor1 > valor3)
                Console.WriteLine(valor1);
            else if (valor2 > valor3)
                Console.WriteLine(valor2);
            else
                Console.WriteLine(valor3);
        }
    }
}