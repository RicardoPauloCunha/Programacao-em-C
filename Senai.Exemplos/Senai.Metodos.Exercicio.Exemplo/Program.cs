using System;
using static Senai.Metodos.Exercicio.Exemplo.Classes.Calculo;

namespace Senai.Metodos.Exercicio.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();
            Console.WriteLine("Insira o lado A do retângulo:");
            retangulo1.ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado B do retângulo:");
            retangulo1.ladoB = double.Parse(Console.ReadLine());

            double area = retangulo1.CalculaArea();
            double perimetro = retangulo1.CalcularPerimetro();

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimetro: {perimetro}");
        }
    }
}
