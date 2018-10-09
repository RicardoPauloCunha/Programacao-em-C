using System;
using static Senai.Metodos.Exercicio.Exemplo.Classes.Calculo;

namespace Senai.Metodos.Exercicio.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calculo = new Calculadora();
            Console.WriteLine("Insira o lado A do retângulo:");
            retangulo1.ladoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado B do retângulo:");
            retangulo1.ladoB = float.Parse(Console.ReadLine());

            float area = retangulo1.CalculaArea();
            float perimetro = retangulo1.CalcularPerimetro();

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimetro: {perimetro}");
        }
    }
}
