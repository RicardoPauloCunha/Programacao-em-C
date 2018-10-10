using System;
using Senai.Metodos.Exercicio5.Classes;

namespace Senai.Metodos.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            Console.WriteLine("Informe: 1 - Encher, 2 - Esvaziar, a conta:");
            int acao = int.Parse(Console.ReadLine());
        
            switch (acao)
            {
                case 1:{
                    Console.WriteLine("Informe a quantidade de deposito");
                    float valor = float.Parse(Console.ReadLine());
                    conta.Encher(valor);
                    break;
                }
                case 2:{
                    Console.WriteLine("Informe a quantidade saque");
                    float valor = float.Parse(Console.ReadLine());
                    conta.Esvaziar(valor);
                    break;
                }
                default:
                    Console.WriteLine("Valor invalido");
                break;
            }

            conta.ExibirQuantia();
        }
    }
}
