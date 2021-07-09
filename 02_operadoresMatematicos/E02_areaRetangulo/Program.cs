using System;

namespace E02_areaRetangulo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe a medida da base:");
            float valorBase = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a medida da altura:");
            float valorAltura = float.Parse(Console.ReadLine());

            float area = valorBase * valorAltura;

            Console.WriteLine($"Àrea = {area}");
        }
    }
}
