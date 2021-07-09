using System;
using E09_contaBancaria.Classes;

namespace E09_contaBancaria
{
    class Program
    {
        static void Main()
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            Console.WriteLine("Ações da conta bancaria:");
            Console.WriteLine("1 - Deposito");
            Console.WriteLine("2 - Saque");
            int opcao = int.Parse(Console.ReadLine());
        
            switch (opcao)
            {
                case 1:
                {
                    Console.WriteLine("Informe o valor do deposito");
                    float valor = float.Parse(Console.ReadLine());

                    contaBancaria.Depositar(valor);
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Informe o valor do saque");
                    float valor = float.Parse(Console.ReadLine());

                    contaBancaria.Sacar(valor);
                    break;
                }
                default:
                {
                    Console.WriteLine("Valor invalido");
                }
                break;
            }

            contaBancaria.ExibirSaldo();
        }
    }
}
