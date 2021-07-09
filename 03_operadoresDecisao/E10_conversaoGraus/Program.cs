using System;

namespace E10_conversaoGraus
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Converter graus Celsius para Fahrenheit(TRUE), concverter Fahrenheit para Celsius(FALSE)");
            bool cconverterCelsius = bool.Parse(Console.ReadLine());

            if (cconverterCelsius)
            {
                Console.WriteLine("Insira os medida em graus Celsius:");
                double Celsius = double.Parse(Console.ReadLine());

                double Fahrenheit = Celsius * 1.8 + 32;
                Console.WriteLine($"A medida e Fahrenheit é: {Fahrenheit}");
            }
            else if (!cconverterCelsius)
            {
                Console.WriteLine("Insira os medida em Fahrenheit:");
                double Fahrenheit = double.Parse(Console.ReadLine());

                double Celsius = Fahrenheit * 1.8 + 32;
                Console.WriteLine($"A medida e graus Celsius é: {Celsius}");
            }
            else
            {
                Console.WriteLine("Valor invalido, por favor insira TRUE para Fahrenheit, e FALSE para graus Celsius");
            }
        }
    }
}
