using System;
using Senai.OO.Exercicio5.Classes;

namespace Senai.OO.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aplicação 1
            Aplicativo aplicacao1 = new Aplicativo();
            Console.WriteLine("Informe o nome da aplicação:");
            aplicacao1.Nome = Console.ReadLine();

            Console.WriteLine("Informe o inicio da aplicação:");
            aplicacao1.periodoInicio = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe o da periodo da aplicação:");
            aplicacao1.Periodo = byte.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor a ser aplicado:");
            aplicacao1.Valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a rentabilidade da aplicação por mes:");
            aplicacao1.Rentabilidade = decimal.Parse(Console.ReadLine());
            #endregion
            Console.WriteLine($"Nome da Aplicação: {aplicacao1.Nome}, valor da aplicação: {aplicacao1.Valor} , rentabilidade por mes: {aplicacao1.Rentabilidade}");
            Console.WriteLine($"Rentabilidade no periodo da aplicação: {aplicacao1.Rentabilidade * aplicacao1.Periodo}, em porcentagem: {((aplicacao1.Rentabilidade * aplicacao1.Periodo) * 100) / aplicacao1.Valor} %");
            Console.WriteLine($"Valor final: {(aplicacao1.Rentabilidade * aplicacao1.Periodo) + aplicacao1.Valor}");
        }
    }
}
