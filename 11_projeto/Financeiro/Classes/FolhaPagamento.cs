using System;

namespace Financeiro.Classes
{
    public class FolhaDePagamento
    {
        public const double INSS = 0.11;
        public const double IRRF = 0.075;
        public const double VT = 0.06;
        public const double SalarioMinimo = 875.5;

        public static void AumentarSalario(Funcionario f)
        {
            if (f.Salario <= SalarioMinimo * 2) 
            {
                f.Salario += f.Salario * 0.15;
                Console.WriteLine("Salario aumentado em 15%");
            }
            else if (f.Salario <= SalarioMinimo * 4)
            {
                f.Salario += f.Salario * 0.10;
                Console.WriteLine("Salario aumentado em 10%");
            }
            else if (f.Salario <= SalarioMinimo * 8)
            {
                f.Salario += f.Salario * 0.08;
                Console.WriteLine("Salario aumentado em 8%");
            }
            else
            {
                f.Salario += f.Salario * 0.05;
                Console.WriteLine("Salario aumentado em 5%");
            }
        }

        public static double CalcularINSS(double salario) => salario * INSS;

        public static double CalcularIRRF(double salario) => salario * IRRF;

        public static double CalcularVT(double salario) => salario * VT;

        public static double CalcularDescontos(double salario) => CalcularINSS(salario) + CalcularIRRF(salario) + CalcularVT(salario);

        public static void MostrarFolhaDePagamento(Funcionario funcionario)
        {
            double totalDesccontos = CalcularDescontos(funcionario.Salario);

            System.Console.WriteLine("-------F0LH4 DE P4G4M3NT0--------");
            System.Console.WriteLine($"Nome: {funcionario.Nome}");
            System.Console.WriteLine($"Salário Bruto: {funcionario.Salario}");
            System.Console.WriteLine($"INSS: {CalcularINSS(funcionario.Salario)}");
            System.Console.WriteLine($"IRRF: {CalcularIRRF(funcionario.Salario)}");
            System.Console.WriteLine($"VT: {CalcularVT(funcionario.Salario)}");
            System.Console.WriteLine($"----------------------------------------------------");
            System.Console.WriteLine($"Total de descontos: {totalDesccontos}");
            System.Console.WriteLine($"TOTAL LÍQUIDO: {funcionario.Salario - totalDesccontos}");
        }
    }
}