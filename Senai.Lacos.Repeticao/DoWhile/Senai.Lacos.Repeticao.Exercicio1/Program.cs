using System;

namespace Senai.Lacos.Repeticao.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ValorX;
            double ValorY;
            int Calculadora;
            do {
                Console.WriteLine("Informe um número(X)");
                ValorX = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe outro número(Y)");
                ValorY = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe qual a operação você quer fazer:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potência");
                Console.WriteLine("0 - SAIR");
                Calculadora = int.Parse(Console.ReadLine());

                switch (Calculadora)
                {
                    case 1:{
                        Console.WriteLine("--Soma--");
                        double Soma = ValorX + ValorY;
                        Console.WriteLine(Soma);
                        break;
                    }
                    case 2:{
                        Console.WriteLine("--Subtração--");
                        double Subtracao = ValorX - ValorY;
                        Console.WriteLine(Subtracao);
                        break;
                    }
                    case 3:{
                        Console.WriteLine("--Multiplicação--");
                        double Multiplicacao = ValorX * ValorY;
                        Console.WriteLine(Multiplicacao);
                        break;
                    }
                    case 4:{
                        Console.WriteLine("--Divisão--");
                        double Divisao = ValorX / ValorY;
                        Console.WriteLine(Divisao);
                        break;
                    }
                    case 5:{
                        Console.WriteLine("--Potência--");
                        double Potencia = Math.Pow(ValorX, ValorY);
                        Console.WriteLine(Potencia);
                        break;
                    }
                    case 0:{
                        Console.Clear();
                        Console.WriteLine("--Sair--");
                        break;
                    }

                    default:
                        Console.Clear();
                        Console.WriteLine("Valor Inválido, insira:");
                        Console.WriteLine("1 - Soma");
                        Console.WriteLine("2 - Subtração");
                        Console.WriteLine("3 - Multiplicação");
                        Console.WriteLine("4 - Divisão");
                        Console.WriteLine("5 - Potência");
                        Console.WriteLine("6 - SAIR");
                    break;

                }
                
            }while(Calculadora < 0 || Calculadora > 5);
        }
    }
}
