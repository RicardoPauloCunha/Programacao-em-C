using System;

namespace E05_precoTotalProduto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Preço de um deteminado produto:");
            float precoProduto = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade mínima deste produto no estoque:");
            int quantidadeMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade máxima deste produto no estoque:");
            int quantidadeMax = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade atual deste produto no estoque:");
            int quantidadeAtual = int.Parse(Console.ReadLine());

            int quantidadeMedia = (quantidadeMin + quantidadeMax) / 2;

            float custoMedio = precoProduto * quantidadeMedia;
            float custoAtual = precoProduto * quantidadeAtual;

            Console.WriteLine($"Estoque médio = {quantidadeMedia}");
            Console.WriteLine($"Custo total do produto considerando o estoque médio = {custoMedio}");
            Console.WriteLine($"Custo total do produto considerando o estoque atual = {custoAtual}");
        }
    }
}
