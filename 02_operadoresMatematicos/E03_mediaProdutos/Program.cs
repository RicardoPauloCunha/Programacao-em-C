using System;

namespace E03_mediaProdutos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o preço do primeiro produto:");
            float produto1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do segundo produto:");
            float produto2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do terceiro produto:");
            float produto3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do quarto produto:");
            float produto4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do quinto produto:");
            float produto5 = float.Parse(Console.ReadLine());

            float media = (produto1 + produto2 + produto3 + produto4 + produto5) / 5;

            Console.WriteLine($"Média de preço = {media}");
        }
    }
}
