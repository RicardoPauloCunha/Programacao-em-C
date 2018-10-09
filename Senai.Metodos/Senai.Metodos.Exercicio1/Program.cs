using System;
using Senai.Metodos.Exercicio1.Classes;

namespace Senai.Metodos.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculo = new Calculadora ();
            int contas;
            Console.WriteLine("Insira o valor 1:");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor 2:");
             double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Escolha qual operação você quer realizar:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
            contas = int.Parse(Console.ReadLine());

            switch (contas)
            {
                case 1:{
                    calculo.Somar(valor1, valor2);
                    break;
                }
                case 2:{
                    calculo.Subtrair(valor1, valor2);
                    break;
                }
                case 3:{
                    calculo.Multiplicar(valor1, valor2);
                    break;
                }
                case 4:{
                    calculo.Dividir(valor1, valor2);
                    break;
                }
                case 0:{
                    Console.WriteLine("Sair");
                    break;
                }
                    
                default:
                    Console.Clear();
                    Console.WriteLine("Valor Inválido, insira:");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("0 - Sair");
                    break;
                }
            }
        }
    }

