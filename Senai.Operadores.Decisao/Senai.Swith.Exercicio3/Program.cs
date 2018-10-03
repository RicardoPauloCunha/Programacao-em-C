using System;

namespace Senai.Swith.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome:");
            string Nome = Console.ReadLine();
            Console.WriteLine("informe o salário atual:");
            double Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código baseado no seu cargo:");
            int Codigo = int.Parse(Console.ReadLine());

            switch (Codigo)
            {
                case 1:{
                    string Cargo = "Escriturário";
                    int Aumento = 50;
                    Console.WriteLine($"{Nome}, salário atual: {Salario.ToString("c")}, código: {Codigo}, cargo: {Cargo}, percentual de aumento: {Aumento}%");
                    double AumentoBruto = (Salario * Aumento) / 100;
                    double SalarioAumento = Salario + AumentoBruto;
                    Console.WriteLine($"Aumento de: {AumentoBruto.ToString("c")}, o seu salário passa a ser: {SalarioAumento.ToString("c")}");
                    break;
                }
                case 2:{
                    string Cargo = "Secretário";
                    int Aumento = 35;
                    Console.WriteLine($"{Nome}, salário atual: {Salario.ToString("c")}, código: {Codigo}, cargo: {Cargo}, percentual de aumento: {Aumento}%");
                    double AumentoBruto = (Salario * Aumento) / 100;
                    double SalarioAumento = Salario + AumentoBruto;
                    Console.WriteLine($"Aumento de: {AumentoBruto.ToString("c")}, o seu salário passa a ser: {SalarioAumento.ToString("c")}");
                    break;
                }
                case 3:{
                    string Cargo = "Caixa";
                    int Aumento = 20;
                    Console.WriteLine($"{Nome}, salário atual: {Salario.ToString("c")}, código: {Codigo}, cargo: {Cargo}, percentual de aumento: {Aumento}%");
                    double AumentoBruto = (Salario * Aumento) / 100;
                    double SalarioAumento = Salario + AumentoBruto;
                    Console.WriteLine($"Aumento de: {AumentoBruto.ToString("c")}, o seu salário passa a ser: {SalarioAumento.ToString("c")}");
                    break;
                }
                case 4:{
                    string Cargo = "Gerente";
                    int Aumento = 10;
                    Console.WriteLine($"{Nome}, salário atual: {Salario.ToString("c")}, código: {Codigo}, cargo: {Cargo}, percentual de aumento: {Aumento}%");
                    double AumentoBruto = (Salario * Aumento) / 100;
                    double SalarioAumento = Salario + AumentoBruto;
                    Console.WriteLine($"Aumento de: {AumentoBruto.ToString("c")}, o seu salário passa a ser: {SalarioAumento.ToString("c")}");
                    break;
                }
                case 5:{
                    string Cargo = "Diretor";
                    int Aumento = 0;
                    Console.WriteLine($"{Nome}, salário atual: {Salario.ToString("c")}, código: {Codigo}, cargo: {Cargo}, percentual de aumento: {Aumento}%");
                    double AumentoBruto = (Salario * Aumento) / 100;
                    double SalarioAumento = Salario + AumentoBruto;
                    Console.WriteLine($"Aumento de: {AumentoBruto.ToString("c")}, o seu salário passa a ser: {SalarioAumento.ToString("c")}");
                    break;
                }

                default:{
                    Console.WriteLine("Valor inválido");
                    break;
                }
            }
        }
    }
}
