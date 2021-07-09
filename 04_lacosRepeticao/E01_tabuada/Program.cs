using System;

namespace E01_tabuada
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o numero inicial");
            int numInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um numero limite");
            int numLimite = int.Parse(Console.ReadLine());

            for (int cont = 0; cont <= numLimite; cont++)
            {
                int calculo = numInicial * cont;
                Console.WriteLine($"{numInicial} X {cont} = {calculo}");
            }
        }
    }
}
