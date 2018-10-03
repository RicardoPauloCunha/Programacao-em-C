using System;

namespace Senai.Operadores.Logicos.Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita quanto a pessoa ganha de salário
            Console.WriteLine("Insira o salário atual:");
            double Salario = double.Parse(Console.ReadLine());

            //verifica qual a faixetaria do salário
            if(Salario>0.00&&Salario<300.00){
                //calcula o reajuste
                double Reajuste = (Salario * 10) / 100;
                Console.WriteLine($"Salário atual: {Salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 10%: {Reajuste.ToString("c")}");
                //calcula o salário + reajuste
                Console.WriteLine($"Salário após o reajuste: {(Salario + Reajuste).ToString("c")}");
            }
            if(Salario>300.01&&Salario<600.00){
                //calcula o reajuste
                double Reajuste = (Salario * 11) / 100;
                Console.WriteLine($"Salário atual: {Salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 11%: {Reajuste.ToString("c")}");
                //calcula o salário + reajuste
                Console.WriteLine($"Salário após o reajuste: {(Salario + Reajuste).ToString("c")}");
            }
            if(Salario>600.01&&Salario<900.00){
                //calcula o reajuste
                double Reajuste = (Salario * 12) / 100;
                Console.WriteLine($"Salário atual: {Salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 12%: {Reajuste.ToString("c")}");
                //calcula o salário + reajuste
                Console.WriteLine($"Salário após o reajuste: {(Salario + Reajuste).ToString("c")}");
            }
            if(Salario>900.01&&Salario<1500.00){
                //calcula o reajuste
                double Reajuste = (Salario * 6) / 100;
                Console.WriteLine($"Salário atual: {Salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 6%: {Reajuste.ToString("c")}");
                //calcula o salário + reajuste
                Console.WriteLine($"Salário após o reajuste: {(Salario + Reajuste).ToString("c")}");
            }
            if(Salario>1500.01&&Salario<2000.00){
                //calcula o reajuste
                double Reajuste = (Salario * 3) / 100;
                Console.WriteLine($"Salário atual: {Salario.ToString("c")}");
                Console.WriteLine($"Reajuste de 3%: {Reajuste.ToString("c")}");
                //calcula o salário + reajuste
                Console.WriteLine($"Salário após o reajuste: {(Salario + Reajuste).ToString("c")}");
            }
            if(Salario>2000.00){
                Console.WriteLine($"Salário atual: {Salario.ToString("c")}");
                Console.WriteLine($"Sem aumento");
                Console.WriteLine($"Salário não possui reajuste");
            }
        }
    }
}
