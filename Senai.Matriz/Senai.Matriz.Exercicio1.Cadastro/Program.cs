using System;

namespace Senai.Matriz.Exercicio1.Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de cadastros");
            int quantCadastros = int.Parse(Console.ReadLine());

            string[,] dadosPessoais = new string[quantCadastros,3];

            for (int i = 0; i < quantCadastros; i++)
            {
                Console.WriteLine("Informe o nome do usuário:");
                dadosPessoais[i,0] = Console.ReadLine();
                Console.WriteLine("Informe o CPF do usuário:");
                dadosPessoais[i,1] = Console.ReadLine();
                Console.WriteLine("Informe o telefone do usuário:");
                dadosPessoais[i,2] = Console.ReadLine();
            }

            for (int i = 0; i < quantCadastros; i++)
            {
                Console.WriteLine($"| {dadosPessoais[i,0]}\t| {dadosPessoais[i,1]}\t| {dadosPessoais[i,2]} |");
            }
        }
    }
}
