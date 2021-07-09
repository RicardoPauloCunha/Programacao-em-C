using System;

namespace E03_verificarSenha
{
    class Program
    {
        static void Main()
        {
            const int SENHA = 1234; 

            Console.WriteLine("Insira a senha:");
            int senha = int.Parse(Console.ReadLine());

            if (senha == SENHA)
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO");
            }
        }
    }
}
