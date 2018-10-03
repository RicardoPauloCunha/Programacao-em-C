using System;

namespace Senai.Operadores.Logicos.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOGICA ERRADA

            //solicita o ano de nascimento
            Console.WriteLine("Insira o seu ano de nascimento:");
            int Nascimento1 = int.Parse(Console.ReadLine());

            //verifica se a pessoa poderá votar baseado no seu ano de nascimento
            if(Nascimento1>1918&&Nascimento1<=2000){
                Console.WriteLine("Você poderá votar esse ano");
            }else if(Nascimento1>2018&&Nascimento1<1918){
                Console.WriteLine("Ano invalido");
            }else{
                Console.WriteLine("Você não poderá votar esse ano");
            }
        }
    }
}
