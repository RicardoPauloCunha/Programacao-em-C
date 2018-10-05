using System;

namespace Senai.Lacos.Repeticao.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            string Idade;
            int Telefone;
            bool Resposta; 
            do {
                Console.WriteLine("Insira o seu nome:");
                Nome = Console.ReadLine();

                Console.WriteLine("Insira a sua idade:");
                Idade = Console.ReadLine();
                
                Console.WriteLine("Insira o seu telefone:");
                Telefone = int.Parse(Console.ReadLine());

                Console.WriteLine("Cadastro realizado com sucesso");
                Console.WriteLine("Deseja continuar o cadastro?[true/false]");
                Resposta = bool.Parse(Console.ReadLine());
            }while(Resposta == false);

        }
    }
}
