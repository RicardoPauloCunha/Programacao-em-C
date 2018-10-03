using System;

namespace Senai.Exemplo.Swith.RodizioCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o ultumo digito da placa do seu carro:");
            int DigitoPlacaCarro = int.Parse(Console.ReadLine());

            switch (DigitoPlacaCarro)
            {
                case 1: case 2:{
                    Console.WriteLine("Segunda-feira");
                    break;
                }
                case 3: case 4:{
                    Console.WriteLine("Terça-feira");
                    break;
                }
                case 5: case 6:{
                    Console.WriteLine("Quarta-feira");
                    break;
                }
                case 7: case 8:{
                    Console.WriteLine("Quinta-feira");
                    break;
                }
                case 9: case 0:{
                    Console.WriteLine("Sexta-feira");
                    break;
                }
                default:{
                    Console.WriteLine("Placa inválida");
                    break;
                }
            }
        }
    }
}
