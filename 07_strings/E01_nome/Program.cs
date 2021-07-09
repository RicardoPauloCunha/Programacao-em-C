using System;
using E01_nome.Classes;

namespace E01_nome
{
    class Program
    {
        static void Main()
        {
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Insira o seu nome:");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine($"Nome completo: {pessoa1.Nome}");
            Console.WriteLine($"Primeiro caractere: {pessoa1.Nome[0]}");

            int tamanho = pessoa1.Nome.Length;

            Console.WriteLine($"Ultimo caractere: {pessoa1.Nome[tamanho - 1]}");
            Console.WriteLine($"Três primerios letras :{pessoa1.Nome.Substring(0,3)}");
            Console.WriteLine($"Quarta letra: {pessoa1.Nome[3]}");
            Console.WriteLine($"Todos menos o primeiro: {pessoa1.Nome.Substring(1, tamanho -1)}");
        }
    }
}
