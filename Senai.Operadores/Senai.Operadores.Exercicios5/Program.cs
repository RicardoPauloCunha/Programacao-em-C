using System;

namespace Senai.Operadores.Exercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Produtos em estoque
            float produto;
            float qMin;
            float qMax;
            float ea;
            float em;
            float custoTotalEM;
            float custoTotalEA;
            Console.WriteLine("Preço de um deteminado produto:");
            produto = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade mínima deste produto no estoque:");
            qMin = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade máxima deste produto no estoque:");
            qMax = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade atual deste produto no estoque:");
            ea = float.Parse(Console.ReadLine());
            em = ((qMin + qMax) / 2);
            Console.WriteLine($"Estoque médio = {em}");
            custoTotalEM = produto * em;
            custoTotalEA = produto * ea;
            Console.WriteLine($"Custo total do produto considerando o estoque médio = {custoTotalEM}");
            Console.WriteLine($"Custo total do produto considerando o estoque atual = {custoTotalEA}");
            #endregion

        }
    }
}
