using System;

namespace E06_validarEmail
{
    class Program
    {
        static void Main()
        {
            string email;
            
            do
            {
                Console.WriteLine("Digite o seu e-mail:");
                email = Console.ReadLine();
            } while(string.IsNullOrEmpty(email) || !email.Contains("@"));

            Console.WriteLine("o e-mail é Válido");
        }
    }
}
