using System;

namespace E09_cadastrarDados
{
    class Program
    {
        static void Main()
        {
            bool resposta;

            do
            {
                Console.Clear();

                Console.WriteLine("Insira o nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira a idade:");
                string telefone = Console.ReadLine();
                
                Console.WriteLine("Insira o telefone:");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("--- Cadastro realizado com sucesso ---");
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Telefone: {telefone}");
                Console.WriteLine($"Idade: {idade}");

                Console.WriteLine("Deseja continuar o cadastro?[true/false]");
                resposta = bool.Parse(Console.ReadLine());
            } while(resposta);
        }
    }
}
