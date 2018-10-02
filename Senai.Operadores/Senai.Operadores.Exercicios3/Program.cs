using System;

namespace Senai.Operadores.Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Média do preço de produtos
            float Produto1;
            float Produto2;
            float Produto3;
            float Produto4;
            float Produto5;
            float Media;
            
            Console.WriteLine("Informe o preço do primeiro produto:");
            Produto1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do segundo produto:");
            Produto2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do terceiro produto:");
            Produto3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do quarto produto:");
            Produto4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do quinto produto:");
            Produto5 = float.Parse(Console.ReadLine());
            Media = ((Produto1 + Produto2 + Produto3 + Produto4 + Produto5) / 5);
            Console.WriteLine($"Média de preço = {Media}");
            #endregion
        }
    }
}
