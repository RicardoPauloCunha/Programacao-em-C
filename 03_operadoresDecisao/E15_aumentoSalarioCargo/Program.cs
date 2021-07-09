using System;

namespace E15_aumentoSalarioCargo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o seu nome:");
            string Nome = Console.ReadLine();

            Console.WriteLine("informe o salário atual:");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código baseado no seu cargo:");
            int Codigo = int.Parse(Console.ReadLine());

            string cargo = "";
            int porcentagemAumento = 0;

            switch (Codigo)
            {
                case 1:
                    cargo = "Escriturário";
                    porcentagemAumento = 50;
                    break;
                case 2:
                    cargo = "Secretário";
                    porcentagemAumento = 35;
                    break;
                case 3:
                    cargo = "Caixa";
                    porcentagemAumento = 20;
                    break;
                case 4:
                    cargo = "Gerente";
                    porcentagemAumento = 10;
                    break;
                case 5:
                    cargo = "Diretor";
                    porcentagemAumento = 0;
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }

            double aumentoBruto = (salario * porcentagemAumento) / 100;
            double salarioAumento = salario + aumentoBruto;

            Console.WriteLine($"{Nome}, salário atual: {salario.ToString("c")}, código: {Codigo}, cargo: {cargo}, percentual de aumento: {porcentagemAumento}%");
            Console.WriteLine($"Aumento de: {aumentoBruto.ToString("c")}, o seu salário passa a ser: {salarioAumento.ToString("c")}");
        }
    }
}
