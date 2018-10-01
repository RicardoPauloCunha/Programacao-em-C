using System;
using Senai.OO.Exercicio5.Classes;

namespace Senai.OO.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aplicação 1
            Aplicacao aplicacao1 = new Aplicacao();
            //Recebendo o nome
            Console.WriteLine("Insira o nome da aplicação");
            aplicacao1.Nome = Console.ReadLine();

            //Recebendo o valor que sera aplicado
            Console.WriteLine("Quanto deseja investir?");
            double ValorAplicado1 = double.Parse(Console.ReadLine());
            
            //Recebendo o periodo de retencao
            Console.WriteLine("Insira o perido de retencao");
            aplicacao1.PeriodoRentecao = int.Parse(Console.ReadLine());
            
            //Recebendo a taxa de juros
            Console.WriteLine("Insira a taxa de juros");
            aplicacao1.Juros = double.Parse(Console.ReadLine());

            //Exibindo relatorio 1
            Console.WriteLine($"----APLICACAO {aplicacao1.Nome}----");
            Console.WriteLine($"Valor aplicado: {ValorAplicado1.ToString("c")}");
            Console.WriteLine($"Taxa de juros: {aplicacao1.Juros} %");
            Console.WriteLine($"Periodo de retenção: {aplicacao1.PeriodoRentecao} (meses)");

            //Calculando a margem de lucro
            double MargemLucro = aplicacao1.Juros / 100 * ValorAplicado1;
            DateTime Hoje = DateTime.Now; //Criando um objeto datetime para hoje
            DateTime DataRetorno = Hoje.AddMonths(aplicacao1.PeriodoRentecao);
            Console.WriteLine($"Lucro (Juros): {MargemLucro.ToString("c")}");
            Console.WriteLine($"Total retorno financeiro: {ValorAplicado1 + MargemLucro}");
            Console.WriteLine($"Data de retirado {DataRetorno.ToShortDateString()}");
            #endregion
        }
    }
}
