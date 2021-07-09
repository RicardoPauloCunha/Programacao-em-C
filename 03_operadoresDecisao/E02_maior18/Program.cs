using System;

namespace E02_maior18
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira seu ano de nascimento:");
            int anoNascimento = int.Parse(Console.ReadLine());

            int anoMinimo = DateTime.Now.Year - 18;

            if (anoNascimento > anoMinimo)
            {
                Console.WriteLine("Você não poderá votar esse ano");
            }
            else
            {
                Console.WriteLine("Você poderá votar esse ano");
            }
        }
    }
}
