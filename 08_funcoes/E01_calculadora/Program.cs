using System;

namespace E01_calculadora
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o valor 1:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor 2:");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha qual operação você quer realizar:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Somar(valor1, valor2);
                    break;
                case 2:
                    Subtrair(valor1, valor2);
                    break;
                case 3:
                    Multiplicar(valor1, valor2);
                    break;
                case 4:
                    Dividir(valor1, valor2);
                    break;
                case 0:
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Operação inválida. Tente novamente.");
                    break;
            }
        }

        public static void Somar(double valor1, double valor2)
        {
            double resultado = valor1 + valor2;
            Console.WriteLine($"A soma dos dois valos é: {resultado}");
        }

        public static void Subtrair(double valor1, double valor2)
        {
            double resultado = valor1 - valor2;
            Console.WriteLine($"A subtração dos dois valos é: {resultado}");
        }

        public static void Multiplicar(double valor1, double valor2)
        {
            double resultado = valor1 * valor2;
            Console.WriteLine($"A multiplicação dos dois valos é: {resultado}");
        }

        public static void Dividir(double valor1, double valor2)
        {
            double resultado = valor1 / valor2;
            Console.WriteLine($"A divisão dos dois valos é: {resultado}");
        }
    }
}

