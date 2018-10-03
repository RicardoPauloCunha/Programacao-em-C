using System;

namespace Senai.Exemplo.Swith.DiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do dia da semana:");
            int DiaSemana = int.Parse(Console.ReadLine());

            switch (DiaSemana)
            {
                case 1:{
                    Console.WriteLine("Domingo");
                    break;
                }
                case 2:{
                    Console.WriteLine("Segunda-Feira");
                    break;
                }
                case 3:{
                    Console.WriteLine("Terça-Feira");
                    break;
                }
                case 4:{
                    Console.WriteLine("Quarta-Feira");
                    break;
                }
                case 5:{
                    Console.WriteLine("Quinta-Feira");
                    break;
                }
                case 6:{
                    Console.WriteLine("Sexta-Feira");
                    break;
                }
                case 7:{
                    Console.WriteLine("Sabádo");
                    break;
                }
                default:{
                    Console.WriteLine("Dia inválido");
                    break;
                }
            }
        }
    }
}
