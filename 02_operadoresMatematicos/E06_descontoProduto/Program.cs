using System;

namespace E06_descontoProduto
{
    class Program
    {
        static void Main()
        {
            const float DESCONTO = 0.1F;

            Console.WriteLine("Informe o nome do produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto:");
            float preco = float.Parse(Console.ReadLine());

            preco -= preco * DESCONTO;

            Console.WriteLine($"{nomeProduto} com 10% de desconto: {preco}");
        }
    }
}
