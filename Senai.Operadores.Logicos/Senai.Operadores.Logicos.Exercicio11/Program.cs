using System;

namespace Senai.Operadores.Logicos.Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro número");
            double Numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            double Numero2 = double.Parse(Console.ReadLine());

            double Resultado = Numero1 + Numero2;

            if(Resultado>20){
                Console.WriteLine($"O resultado é: {Resultado + 8}");
            }else if(Resultado<=20){
                Console.WriteLine($"O resultado é: {Resultado - 5}");
            }
        }
    }
}
