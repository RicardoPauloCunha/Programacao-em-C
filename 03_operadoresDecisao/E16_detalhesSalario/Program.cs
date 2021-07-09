using System;

namespace E16_detalhesSalario
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o Salário Mínimo:");
            double salariominimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de Horas Trabalhadas:");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de Dependentes:");
            int dependente = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de Horas Extras");
            int horasExtra = int.Parse(Console.ReadLine());

            double valorHora = (salariominimo * 0.5) / 100;
            double valorMensal = horasTrabalhadas * valorHora;
            double valorHoraExtra = ((valorHora * 0.5) + valorHora) * horasExtra;
            double valorDependente = dependente * 64.00;
            double valorSalarioBruto = valorMensal + valorDependente + valorHoraExtra;

            Console.WriteLine($"Salario Minimo: {salariominimo.ToString("c")}");
            Console.WriteLine("--- Detalhes ---");
            Console.WriteLine($"Valor hora: {valorHora.ToString("c")}");
            Console.WriteLine($"Valor do salario mensal: {valorMensal.ToString("c")}");
            Console.WriteLine($"Valor das horas extras: {valorHoraExtra.ToString("c")}");
            Console.WriteLine($"Valor dos dependentes: {valorDependente.ToString("c")}");
            Console.WriteLine($"Valor do salario bruto: {valorSalarioBruto.ToString("c")}");

            double impostos = 0;

            if (valorSalarioBruto > 0 && valorSalarioBruto <= 1750)
                impostos = (valorSalarioBruto * 0) / 100; 
            else if (valorSalarioBruto > 1750 && valorSalarioBruto < 2500)
                impostos = (valorSalarioBruto * 10) / 100; 
            else if (valorSalarioBruto > 2500)
                impostos = (valorSalarioBruto * 20) / 100;
            else
                Console.WriteLine("Valor Inválido");

            double valorSalarioLiquido = valorSalarioBruto - impostos;
            double salarioFinal = 0;

            if (valorSalarioLiquido <= 1500)
                salarioFinal = valorSalarioLiquido + 400.00;
            else if (valorSalarioLiquido > 1500)
                salarioFinal = valorSalarioLiquido + 200.00;

            Console.WriteLine("--- Impostos ---");
            Console.WriteLine($"Valor Impostos{impostos.ToString("c")}");
            Console.WriteLine($"Valor Liquido{valorSalarioLiquido.ToString("c")}");
            Console.WriteLine("--- Salário ---");
            Console.WriteLine($"Salário final: {salarioFinal.ToString("c")}");
        }
    }
}
