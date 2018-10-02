using System;

namespace Senai.Operadores.Logicos.Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero de lados do poligono regular");
            int NumeroLado = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a medida do um dos lados do poligono regular:");
            double MedidaLado = double.Parse(Console.ReadLine());

            if(NumeroLado==3){
                Console.WriteLine($"Triangulo, area: {(MedidaLado * MedidaLado) / 2}");
            }            
        }    
    }
}
