using System;
using E05_aplicacao.Classes;

namespace E05_aplicacao
{
    class Program
    {
        static void Main()
        {
            Aplicacao aplicacao = new Aplicacao();

            Console.WriteLine("Insira o nome da aplicação");
            aplicacao.Nome = Console.ReadLine();

            Console.WriteLine("Quanto deseja investir?");
            double valorAplicado1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira o perido de retencao");
            aplicacao.PeriodoRentecao = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira a taxa de juros");
            aplicacao.Juros = double.Parse(Console.ReadLine());

            Console.WriteLine($"----APLICACAO {aplicacao.Nome}----");
            Console.WriteLine($"Valor aplicado: {valorAplicado1.ToString("c")}");
            Console.WriteLine($"Taxa de juros: {aplicacao.Juros} %");
            Console.WriteLine($"Periodo de retenção: {aplicacao.PeriodoRentecao} (meses)");

            double margemLucro = aplicacao.Juros / 100 * valorAplicado1;
            DateTime hoje = DateTime.Now;
            DateTime dataRetorno = hoje.AddMonths(aplicacao.PeriodoRentecao);

            Console.WriteLine($"Lucro (Juros): {margemLucro.ToString("c")}");
            Console.WriteLine($"Total retorno financeiro: {valorAplicado1 + margemLucro}");
            Console.WriteLine($"Data de retirado {dataRetorno.ToShortDateString()}");
        }
    }
}
