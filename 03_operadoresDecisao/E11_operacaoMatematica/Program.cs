using System;

namespace E11_operacaoMatematica
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o primeiro número");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = numero1 + numero2;

            if (resultado > 10 && resultado <= 20)
                Console.WriteLine($"O resultado é: {resultado - 5}");
            else
                Console.WriteLine($"O resultado é: {resultado + 8}");
        }
    }
}
