using System;

namespace E12_reajusteSalario
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o salário atual:");
            double salario = double.Parse(Console.ReadLine());

            if (salario >= 0 && salario <= 300)
            {
                double Reajuste = salario * 10 / 100;
                Console.WriteLine($"Salário atual: {salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 10%: {Reajuste.ToString("c")}");
                Console.WriteLine($"Salário após o reajuste: {(salario + Reajuste).ToString("c")}");
            }
            if (salario > 300 && salario <= 600)
            {
                double Reajuste = salario * 11 / 100;
                Console.WriteLine($"Salário atual: {salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 11%: {Reajuste.ToString("c")}");
                Console.WriteLine($"Salário após o reajuste: {(salario + Reajuste).ToString("c")}");
            }
            if (salario > 600 && salario <= 900)
            {
                double Reajuste = salario * 12 / 100;
                Console.WriteLine($"Salário atual: {salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 12%: {Reajuste.ToString("c")}");
                Console.WriteLine($"Salário após o reajuste: {(salario + Reajuste).ToString("c")}");
            }
            if (salario > 900 && salario <= 1500)
            {
                double Reajuste = salario * 6 / 100;
                Console.WriteLine($"Salário atual: {salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 6%: {Reajuste.ToString("c")}");
                Console.WriteLine($"Salário após o reajuste: {(salario + Reajuste).ToString("c")}");
            }
            if (salario > 1500 && salario <= 2000)
            {
                double Reajuste = (salario * 3) / 100;
                Console.WriteLine($"Salário atual: {salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 3%: {Reajuste.ToString("c")}");
                Console.WriteLine($"Salário após o reajuste: {(salario + Reajuste).ToString("c")}");
            }
            if (salario > 2000)
            {
                Console.WriteLine($"Salário atual: {salario.ToString("c")}");
                Console.WriteLine($"Sem aumento");
                Console.WriteLine($"Salário não possui reajuste");
            }
        }
    }
}
