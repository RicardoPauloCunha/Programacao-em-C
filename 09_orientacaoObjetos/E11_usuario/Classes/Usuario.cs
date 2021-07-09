using System;

namespace E11_usuario.Classes
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }

        public void Cadastrar() {
            Console.WriteLine("Informe o nome do usuario");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade do usuario");
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o endereço do usuario");
            Endereco = Console.ReadLine();
        }
    }
}