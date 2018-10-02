using System;

namespace Senai.Operadores.Exercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeProduto;
            decimal preco;
            Console.WriteLine("Informe o nome do produto:");
            nomeProduto = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto:");
            preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{nomeProduto} com 10% de desconto: {(preco * 90) / 100}");
        }
    }
}
