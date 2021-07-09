using System;
using E11_usuario.Classes;

namespace E11_usuario
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Quantas pessoas deseja cadastrar");
            int quantidadeUsuarios = int.Parse(Console.ReadLine());

            Usuario[] usuarios = new Usuario[quantidadeUsuarios];

            for (int i = 0; i < quantidadeUsuarios; i++)
            {
                usuarios[i] = new Usuario();
                usuarios[i].Cadastrar();
            }
            for (int i = quantidadeUsuarios -1; i >= 0; i--)
            {
                Console.WriteLine($"{i+1}º {usuarios[i].Nome}, {usuarios[i].Idade}, {usuarios[i].Endereco}");
            }
        }
    }
}
