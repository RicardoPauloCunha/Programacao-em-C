using System;

namespace E07_areaGeometrica
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o numero de lados do poligono regular");
            int numeroLado = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a medida do um dos lados do poligono regular:");
            double medidaLado = double.Parse(Console.ReadLine());

            if(numeroLado == 3)
                Console.WriteLine($"TRIÂNGULO, área: {(medidaLado * medidaLado) / 2}");
            else if(numeroLado == 4)
                Console.WriteLine($"QUADRADO, área: {Math.Pow(medidaLado, 2)}");
            else if(numeroLado == 5)
                Console.WriteLine("PENTÁGONO");
            else
                Console.WriteLine("Forma geometrica não identificada, insira outra quantidade de lados");
        }    
    }
}
