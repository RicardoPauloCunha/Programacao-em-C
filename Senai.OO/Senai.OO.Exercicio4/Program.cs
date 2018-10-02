using System;
using Senai.OO.Exercicio4.Classes;

namespace Senai.OO.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cartão 1
            cartaoDeCredito cartao1 = new cartaoDeCredito();
            Console.WriteLine("Informe o número do cartão 1:");
            cartao1.numeroCartao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a data de vencimento do cartão 1:");
            cartao1.dataVencimento = DateTime.Parse(Console.ReadLine());
            #endregion

            #region Cartão 2
            cartaoDeCredito cartao2 = new cartaoDeCredito();
            Console.WriteLine("Informe o número do cartão 2:");
            cartao2.numeroCartao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a data de vencimento do cartão 2:");
            cartao2.dataVencimento = DateTime.Parse(Console.ReadLine());
            #endregion

            Console.WriteLine($"Número do cartão 1: {cartao1.numeroCartao}, data de vencimento do cartão 1: {cartao1.dataVencimento.ToShortDateString()}");
            Console.WriteLine($"Número do cartão 2: {cartao2.numeroCartao}, data de vencimento do cartão 2: {cartao2.dataVencimento.ToShortDateString()}");
            
        }
    }
}
