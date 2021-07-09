using System;
using E03_conta.Classes;

namespace E03_conta
{
    class Program
    {
        static void Main()
        {
            #region Conta 1
            Conta conta1 = new Conta();

            Console.WriteLine("Informe o nome do cliente 1:");
            conta1.Nome = Console.ReadLine();

            Console.WriteLine("Informe o número da conta 1:");
            conta1.numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o saldo do cliente 1:");
            conta1.Saldo = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Nome do clinte 1: {conta1.Nome}, número da conta do cliente 1: {conta1.numeroConta}, saldo do cliente 1: {conta1.Saldo}");
            #endregion

            #region Conta 2
            Conta conta2 = new Conta();

            Console.WriteLine("Informe o nome do cliente 2:");
            conta2.Nome = Console.ReadLine();

            Console.WriteLine("Informe o número da conta 2:");
            conta2.numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o saldo do cliente 2:");
            conta2.Saldo = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Nome do clinte 2: {conta2.Nome}, número da conta do cliente 2: {conta2.numeroConta}, saldo do cliente 2: {conta2.Saldo}");
            #endregion

            #region Conta 3
            Conta conta3 = new Conta();

            Console.WriteLine("Informe o nome do cliente 3:");
            conta3.Nome = Console.ReadLine();

            Console.WriteLine("Informe o número da conta 3:");
            conta3.numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o saldo do cliente 3:");
            conta3.Saldo = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Nome do clinte 3: {conta3.Nome}, número da conta do cliente 3: {conta3.numeroConta}, saldo do cliente 3: {conta3.Saldo}");
            #endregion

            Console.WriteLine($"Valor total das contas: {conta1.Saldo + conta2.Saldo + conta3.Saldo}");
        }
    }
}
