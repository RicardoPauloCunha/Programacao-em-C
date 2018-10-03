using System;

namespace Senai.Operadores.Logicos.Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita um número
            Console.WriteLine("Insira um numero inteiro:");
            int NumeroInt = int.Parse(Console.ReadLine());
            int RestoInt = NumeroInt % 2;
            
            //verifica se ele é par ou impar
            if(RestoInt==0){
                Console.WriteLine("Este é um número PAR");
            }else{
                Console.WriteLine("Este é um número ÍMPAR");
            }
        }
    }
}
