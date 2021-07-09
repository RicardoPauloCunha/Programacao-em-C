using System;
using E06_funcionario.Classes;

namespace E06_funcionario
{
    class Program
    {
        static void Main()
        {
            #region Funcionario 1
            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("Insira o nome do funcinario 1");
            funcionario1.Nome = Console.ReadLine();

            Console.WriteLine("Insira o valor/hora");
            funcionario1.ValorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas trabalhadas");
            funcionario1.HorasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valor total a ser pago para {funcionario1.Nome}: {(funcionario1.CalcularValorProjeto()).ToString("c")}");
            #endregion

            #region Funcionario 2
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Insira o nome do funcinario 2");
            funcionario2.Nome = Console.ReadLine();

            Console.WriteLine("Insira o valor/hora");
            funcionario2.ValorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas trabalhadas");
            funcionario2.HorasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valor total a ser pago para {funcionario2.Nome}: {(funcionario2.CalcularValorProjeto()).ToString("c")}");
            #endregion
        }
    }
}
