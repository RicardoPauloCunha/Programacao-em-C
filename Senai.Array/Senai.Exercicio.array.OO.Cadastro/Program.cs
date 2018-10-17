using System;
using Senai.Exercicio.array.OO.Cadastro.Classes;

namespace Senai.Exercicio.Array.OO.Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas pessoas deseja cadastrar");
            int quantCadastro = int.Parse(Console.ReadLine());
            CadastroUsuario[] Cadastro = new CadastroUsuario[quantCadastro];

            for (int i = 0; i < quantCadastro; i++)
            {
                Cadastro[i] = new CadastroUsuario();
                Cadastro[i].ReceberDados();
            }
            for (int i = 0; i < quantCadastro; i++)
            {
                Console.WriteLine($"{Cadastro[i].nome}, {Cadastro[i].idade}, {Cadastro[i].endereco}");
            }
        }
    }
}
