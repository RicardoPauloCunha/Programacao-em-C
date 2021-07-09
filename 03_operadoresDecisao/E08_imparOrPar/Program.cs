using System;

namespace E08_imparOrPar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira um numero inteiro:");
            int numero = int.Parse(Console.ReadLine());
            
            if(numero % 2 == 0)
                Console.WriteLine("Este é um número PAR");
            else
                Console.WriteLine("Este é um número ÍMPAR");
        }
    }
}
