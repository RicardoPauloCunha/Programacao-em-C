using System;

namespace Senai.Exemplo.Do.While
{
    class Program
    {
        static void Main(string[] args)
        {
            string Email;
            
            do {
                Console.WriteLine("Digite o seu E-Mail:");
                Email = Console.ReadLine();

            }while(string.IsNullOrEmpty(Email) || Email.Contains("@")  == false);

            Console.WriteLine("O E-mail é Válido");
        }
    }
}
