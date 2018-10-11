using System;

namespace Senai.For.Exemplo1.Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebendo X
            Console.WriteLine("Insira um número:");
            int x = int.Parse(Console.ReadLine());

            //Recebendo limite
            Console.WriteLine("Insira o limite");
            int limite = int.Parse(Console.ReadLine());

            //Laço tabuada
            for (int cont = 0; cont <= limite; cont++)
            {
                Console.WriteLine($"{x} X {cont} = {x * cont}");
            }


        }
    }
}
