using System;
using E04_cartaCredito.Classes;

namespace E04_cartaCredito
{
    class Program
    {
        static void Main()
        {
            #region Cartao 1
            cartaoCredito cartao1 = new cartaoCredito();

            Console.WriteLine("Informe o número do cartão 1:");
            cartao1.numeroCartao = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a data de vencimento do cartão 1:");
            cartao1.dataVencimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Número do cartão 1: {cartao1.numeroCartao}, data de vencimento do cartão 1: {cartao1.dataVencimento.ToShortDateString()}");
            #endregion

            #region Cartao 2
            cartaoCredito cartao2 = new cartaoCredito();

            Console.WriteLine("Informe o número do cartão 2:");
            cartao2.numeroCartao = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a data de vencimento do cartão 2:");
            cartao2.dataVencimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Número do cartão 2: {cartao2.numeroCartao}, data de vencimento do cartão 2: {cartao2.dataVencimento.ToShortDateString()}");
            #endregion
        }
    }
}
