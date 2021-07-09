using System;

namespace E04_converterGraus
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe a temperatura em graus célsius");
            float grausCelsius = float.Parse(Console.ReadLine());

            float Fahrenheit = ((9 * grausCelsius) + 160) /5;

            Console.WriteLine($"Graus em Fahrenheit = {Fahrenheit}");
        }
    }
}
