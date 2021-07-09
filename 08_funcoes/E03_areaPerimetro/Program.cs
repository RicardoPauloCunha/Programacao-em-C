using System;

namespace E03_areaPerimetro
{
    class Program
    {
        static void Main()
        {
            double ladoA;
            double ladoB;

            Console.WriteLine("Insira o lado A do retângulo:");
            ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado B do retângulo:");
            ladoB = double.Parse(Console.ReadLine());

            double area = CalculaArea(ladoA, ladoB);
            double perimetro = CalcularPerimetro(ladoA, ladoB);

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimetro: {perimetro}");
        }

        public static double CalculaArea(double ladoA, double ladoB)
        {
            double area = ladoA * ladoB;

            return area;
        }

        public static double CalcularPerimetro(double ladoA, double ladoB)
        {
            double perimetro = ladoA + ladoB + ladoA + ladoB;

            return perimetro;
        }
    }
}
