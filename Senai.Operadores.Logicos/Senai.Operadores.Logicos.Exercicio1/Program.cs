using System;

namespace Senai.Operadores.Logicos.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando os valores
            Console.WriteLine("Insira um valor: ");
            double Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro valor: ");
            double Valor2 = double.Parse(Console.ReadLine());

            //Teste logico de maior ou menor
            if(Valor1>Valor2){
                Console.WriteLine($"O valor {Valor1} é o maior");
            }else{
                Console.WriteLine($"O valor {Valor2} é o maior");
            }


        }
    }
}
