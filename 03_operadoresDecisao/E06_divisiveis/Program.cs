using System;

namespace E06_divisiveis
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número:");
            int numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o quarto número:");
            int numero4 = int.Parse(Console.ReadLine());

            if(numero1 % 2 == 0)
                Console.WriteLine($"{numero1} é divisível por 2");
            else if(numero1 % 3 == 0)
                Console.WriteLine($"{numero1} é divisível por 3");
            else
                Console.WriteLine($"{numero1} só é divisivel por ele mesmo");

            if(numero2 % 2 == 0)
                Console.WriteLine($"{numero2} é divisível por 2");
            else if(numero2 % 3 == 0)
                Console.WriteLine($"{numero2} é divisível por 3");
            else
                Console.WriteLine($"{numero2} só é divisivel por ele mesmo");

            if(numero3 % 2 == 0)
                Console.WriteLine($"{numero3} é divisível por 2");
            else if(numero3 % 3 == 0)
                Console.WriteLine($"{numero3} é divisível por 3");
            else
                Console.WriteLine($"{numero3} só é divisivel por ele mesmo");

            if(numero4 % 2 == 0)
                Console.WriteLine($"{numero4} é divisível por 2");
            else if(numero4 % 3 == 0)
                Console.WriteLine($"{numero4} é divisível por 3");
            else
                Console.WriteLine($"{numero4} só é divisivel por ele mesmo");
        }
    }
}
