using System;

namespace Senai.Operadores.Logicos.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //coleta os dados(Números)
            Console.WriteLine("Insira o primeiro valor");
            int Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor");
            int Valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor");
            int Valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("A ordem crescente dos números inseridos é:");

            //determina o menor número(Primeiro)
            if(Valor1<Valor2&&Valor1<Valor3){
                Console.WriteLine(Valor1);
            }else if(Valor2<Valor1&&Valor2<Valor3){
                Console.WriteLine(Valor2);
            }else if(Valor3<Valor2&&Valor3<Valor1){
                Console.WriteLine(Valor3);
            }

            //determina o número do meio(Segundo)
            if(Valor1>Valor2&&Valor1<Valor3){
                Console.WriteLine(Valor1);
            }else if(Valor2>Valor1&&Valor2<Valor3){
                Console.WriteLine(Valor2);
            }else if(Valor3>Valor2&&Valor3<Valor1){
                Console.WriteLine(Valor3);
            }

            //determina o maior número(terceiro)
            if(Valor1>Valor2&&Valor1>Valor3){
                Console.WriteLine(Valor1);
            }else if(Valor2>Valor1&&Valor2>Valor3){
                Console.WriteLine(Valor2);
            }else if(Valor3>Valor2&&Valor3>Valor1){
                Console.WriteLine(Valor3);
            }
         
        }
    }
}