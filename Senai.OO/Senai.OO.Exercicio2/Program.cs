using System;
using Senai.OO.Exercicio2.obj.Classes;

namespace Senai.OO.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Produto 1
            Produto produto1 = new Produto();
            Console.WriteLine("Informe o nome do produto 1:");
            produto1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto 1:");
            produto1.Preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto 1 no estoque:");
            produto1.Quantidade = byte.Parse(Console.ReadLine());
            #endregion

            #region Produto 2
            Produto produto2 = new Produto();
            Console.WriteLine("Informe o nome do produto 2:");
            produto2.Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto 2:");
            produto2.Preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto 2 no estoque:");
            produto2.Quantidade = byte.Parse(Console.ReadLine());
            #endregion

            #region Produto 3
            Produto produto3 = new Produto();
            Console.WriteLine("Informe o nome do produto 3:");
            produto3.Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto 3:");
            produto3.Preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto 3 no estoque:");
            produto3.Quantidade = byte.Parse(Console.ReadLine());
            #endregion

            Console.WriteLine($"Nome do Produto: {produto1.Nome}, preço do produto: {produto1.Preco}, quantidade em estoque: {produto1.Quantidade}");
            Console.WriteLine($"Nome do Produto: {produto2.Nome}, preço do produto: {produto2.Preco}, quantidade em estoque: {produto2.Quantidade}");
            Console.WriteLine($"Nome do Produto: {produto3.Nome}, preço do produto: {produto3.Preco}, quantidade em estoque: {produto3.Quantidade}");
            Console.WriteLine($"A média de preço entre esses produtos é: {(produto1.Preco + produto2.Preco + produto3.Preco) / 3}");
        }
    }
}
