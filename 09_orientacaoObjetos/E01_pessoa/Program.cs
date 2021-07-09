using System;
using E01_pessoa.Classes;

namespace E01_pessoa
{
    class Program
    {
        static void Main()
        {
            #region Pessoa 1
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Informe o nome da pessoa 1:");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Informe a altura da pessoa 1:");
            pessoa1.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da pessoa 1:");
            pessoa1.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O IMC de {pessoa1.Nome} é {pessoa1.Peso / Math.Pow(pessoa1.Altura, 2)}");
            #endregion

            #region Pessoa 2
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Informe o nome da pessoa 2:");
            pessoa2.Nome = Console.ReadLine();

            Console.WriteLine("Informe a altura da pessoa 2:");
            pessoa2.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da pessoa 2:");
            pessoa2.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O IMC de {pessoa2.Nome} é {pessoa2.Peso / Math.Pow(pessoa2.Altura, 2)}");
            #endregion
        }
    }
}
