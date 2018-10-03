using System;

namespace Senai.Operadores.Logicos.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {   
            //solicita a senha
            Console.WriteLine("Insira a senha:");
            int Senha = int.Parse(Console.ReadLine());

            //verifica se a senha está correta
            if(Senha==1234){
                Console.WriteLine("ACESSO PERMITIDO");
            }else{
                Console.WriteLine("ACESSO NEGADO");
            }
        }
    }
}
