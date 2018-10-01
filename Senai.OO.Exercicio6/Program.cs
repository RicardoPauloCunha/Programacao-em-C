using System;
using Senai.OO.Exercicio6.Classes;

namespace Senai.OO.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Console.WriteLine("Informe o nome da pessoa:");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine(pessoa1.Nome);
            Console.WriteLine(pessoa1.Nome.Substring(0,1));
            Console.WriteLine(pessoa1.Nome.Substring(0,3));
        }
    }
}
