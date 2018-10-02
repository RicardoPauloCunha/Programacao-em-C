using System;
using Senai.OO.Exercicio6.Classes;

namespace Senai.OO.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            //Recebe o nome da pessoa
            Console.WriteLine("Insira o seu nome:");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine($"Nome completo: {pessoa1.Nome}");

            Console.WriteLine($"Primeiro caractere: {pessoa1.Nome[0]}");

            //Calculando tamanho da string
            int tamanho = pessoa1.Nome.Length;
            Console.WriteLine($"Ultimo caractere: {pessoa1.Nome[tamanho - 1]}");

            Console.WriteLine($"Três primerios letras :{pessoa1.Nome.Substring(0,3)}");

            Console.WriteLine($"Quarta letra: {pessoa1.Nome[3]}");

            Console.WriteLine($"Todos menos o primeiro: {pessoa1.Nome.Substring(1, tamanho -1)}");

            Console.WriteLine($"Todos menos so dois primeiros: {pessoa1.Nome.Substring(tamanho -2, 2)}");
            
            
        }
    }
}
