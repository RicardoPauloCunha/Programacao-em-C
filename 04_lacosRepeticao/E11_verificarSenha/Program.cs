using System;

namespace E11_verificarSenha
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Cadastre uma Senha:");
            string senha = Console.ReadLine();

            Console.WriteLine("Por favor insera a senha novamente:");
            string confirmarSenha = Console.ReadLine();

            while (senha != confirmarSenha)
            {
                Console.WriteLine("Senha diferente da cadastra");
                Console.WriteLine("Por favor insera a senha novamente:");
                confirmarSenha = Console.ReadLine();
            }

            Console.WriteLine("Senha válida");
        }
    }
}
