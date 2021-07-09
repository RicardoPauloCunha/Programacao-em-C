using System;

namespace E01_cadastrarDados
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe a quantidade de cadastros:");
            int qtdCadastros = int.Parse(Console.ReadLine());

            string[,] dadosPessoais = new string[qtdCadastros,3];

            for (int i = 0; i < qtdCadastros; i++)
            {
                Console.WriteLine("Informe o nome do usuário:");
                dadosPessoais[i,0] = Console.ReadLine();

                Console.WriteLine("Informe o CPF do usuário:");
                dadosPessoais[i,1] = Console.ReadLine();

                Console.WriteLine("Informe o telefone do usuário:");
                dadosPessoais[i,2] = Console.ReadLine();
            }

            for (int i = 0; i < qtdCadastros; i++)
            {
                Console.WriteLine($"| {dadosPessoais[i,0]}\t| {dadosPessoais[i,1]}\t| {dadosPessoais[i,2]} |");
            }
        }
    }
}
