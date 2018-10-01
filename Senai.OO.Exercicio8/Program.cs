using System;
using Senai.OO.Exercicio8.Classes;

namespace Senai.OO.Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Funcionario 1
            Funcionario funcionario1 = new Funcionario();
            
            //Recebendo  0 nome
            Console.WriteLine("Insira o nome do funcinario");
            funcionario1.Nome = Console.ReadLine();
            
            //Recebendo o valor da hora
            Console.WriteLine("Insira o valor/hora");
            funcionario1.ValorHora = double.Parse(Console.ReadLine());

            //Recebendo o numero de horas trabalhadas
            Console.WriteLine("Insira a quantidade de horas trabalhadas");
            funcionario1.HorasTrabalhadas = int.Parse(Console.ReadLine());

            //Calculando o valor das horas trabalhadas
            Console.WriteLine($"Valor total a ser pago para {funcionario1.Nome}: {(funcionario1.CalcularValorProjeto()).ToString("c")}");
            #endregion

            #region Funcionario 2
            Funcionario funcionario2 = new Funcionario();
            
            //Recebendo  0 nome
            Console.WriteLine("Insira o nome do funcinario");
            funcionario2.Nome = Console.ReadLine();
            
            //Recebendo o valor da hora
            Console.WriteLine("Insira o valor/hora");
            funcionario2.ValorHora = double.Parse(Console.ReadLine());

            //Recebendo o numero de horas trabalhadas
            Console.WriteLine("Insira a quantidade de horas trabalhadas");
            funcionario2.HorasTrabalhadas = int.Parse(Console.ReadLine());

            //Calculando o valor das horas trabalhadas
            Console.WriteLine($"Valor total a ser pago para {funcionario2.Nome}: {(funcionario2.CalcularValorProjeto()).ToString("c")}");
            #endregion                    
        }
    }
}
