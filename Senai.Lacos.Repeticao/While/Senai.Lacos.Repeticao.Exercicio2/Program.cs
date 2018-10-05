using System;

namespace Senai.Lacos.Repeticao.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastre uma Senha:");
            string SenhaCorr = Console.ReadLine();

            Console.WriteLine("Por favor insera a senha novamente:");
            string SenhaInco = Console.ReadLine();

            while (SenhaCorr != SenhaInco)
            {
                Console.WriteLine("Senha Incorreta. Acesso negado!");
                Console.WriteLine("Por favor insera a senha novamente:");
                SenhaInco = Console.ReadLine();
            }
            Console.WriteLine("Senha correta. Acesso Permitido");
        }
    }
}
