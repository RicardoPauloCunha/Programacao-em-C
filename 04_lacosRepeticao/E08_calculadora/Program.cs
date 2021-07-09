using System;

namespace E08_calculadora
{
    class Program
    {
        static void Main()
        {
            int calculadora;

            do
            {
                Console.WriteLine("Informe um número(X)");
                double valorX = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe outro número(Y)");
                double valorY = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe qual a operação você quer fazer:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potência");
                Console.WriteLine("0 - SAIR");

                calculadora = int.Parse(Console.ReadLine());

                switch (calculadora)
                {
                    case 1:
                        double Soma = valorX + valorY;
                        Console.WriteLine("-- Soma --");
                        Console.WriteLine(Soma);
                        break;
                    case 2:
                        double Subtracao = valorX - valorY;
                        Console.WriteLine("-- Subtração --");
                        Console.WriteLine(Subtracao);
                        break;
                    case 3:
                        double Multiplicacao = valorX * valorY;
                        Console.WriteLine("-- Multiplicação --");
                        Console.WriteLine(Multiplicacao);
                        break;
                    case 4:
                        double Divisao = valorX / valorY;
                        Console.WriteLine("-- Divisão --");
                        Console.WriteLine(Divisao);
                        break;
                    case 5:
                        double Potencia = Math.Pow(valorX, valorY);
                        Console.WriteLine("-- Potência --");
                        Console.WriteLine(Potencia);
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("-- Sair --");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Operação Inválida. Rente novamente:");
                    break;

                }
                
            } while(calculadora < 0 || calculadora > 5);
        }
    }
}
