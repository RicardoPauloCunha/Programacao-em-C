using System;

namespace Senai.Operadores.Logicos.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a senha:");
            double Senha = double.Parse(Console.ReadLine());

            if(Senha==1234){
                Console.WriteLine("ACESSO PERMITIDO");
            }else{
                Console.WriteLine("ACESSO NEGADO");
            }
        }
    }
}
