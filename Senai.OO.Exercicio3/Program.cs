using System;
using Senai.OO.Exercicio3.Classes;

namespace Senai.OO.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cliente 1
            Conta cliente1 = new Conta();
            Console.WriteLine("Informe o nome do cliente 1:");
            cliente1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o número da conta do cliente 1:");
            cliente1.numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o saldo do cliente 1:");
            cliente1.Saldo = decimal.Parse(Console.ReadLine());
            #endregion

            #region Cliente 2
            Conta cliente2 = new Conta();
            Console.WriteLine("Informe o nome do cliente 2:");
            cliente2.Nome = Console.ReadLine();
            Console.WriteLine("Informe o número da conta do cliente 2:");
            cliente2.numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o saldo do cliente 2:");
            cliente2.Saldo = decimal.Parse(Console.ReadLine());
            #endregion

            #region Cliente 3
            Conta cliente3 = new Conta();
            Console.WriteLine("Informe o nome do cliente 3:");
            cliente3.Nome = Console.ReadLine();
            Console.WriteLine("Informe o número da conta do cliente 3:");
            cliente3.numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o saldo do cliente 3:");
            cliente3.Saldo = decimal.Parse(Console.ReadLine());
            #endregion

            Console.WriteLine($"Nome do clinte 1: {cliente1.Nome}, número da conta do cliente 1: {cliente1.numeroConta}, saldo do cliente 1: {cliente1.Saldo}");
            Console.WriteLine($"Nome do clinte 2: {cliente2.Nome}, número da conta do cliente 2: {cliente2.numeroConta}, saldo do cliente 2: {cliente2.Saldo}");
            Console.WriteLine($"Nome do clinte 3: {cliente3.Nome}, número da conta do cliente 3: {cliente3.numeroConta}, saldo do cliente 3: {cliente3.Saldo}");
            Console.WriteLine($"Valor total das contas: {cliente1.Saldo + cliente2.Saldo + cliente3.Saldo}");

        }
    }
}
