using System;

namespace Senai.Operadores.Logicos.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando os valores
            Console.WriteLine("Insira um valor: ");
            int Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro valor: ");
            int Valor2 = int.Parse(Console.ReadLine());

            //Teste logico de maior ou menor
            if(Valor1>Valor2){
                Console.WriteLine($"O valor {Valor1} é o maior");
            }else{
                Console.WriteLine($"O valor {Valor2} é o maior");
            }


        }
    }
}
