using System;

namespace Senai.Operadores.Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
             #region Converter graus Célsius em Fahrenheit
            float grausCelsius;
            float Fahrenheit;

            Console.WriteLine("Informe a temperatura em graus célsius");
            grausCelsius = float.Parse(Console.ReadLine());
            Fahrenheit = (((9 * grausCelsius) + 160) /5);
            Console.WriteLine($"Graus em Fahrenheit = {Fahrenheit}");
            #endregion
        }
    }
}
