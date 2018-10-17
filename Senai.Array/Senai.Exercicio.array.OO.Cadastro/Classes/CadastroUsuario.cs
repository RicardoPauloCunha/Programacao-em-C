using System;
namespace Senai.Exercicio.array.OO.Cadastro.Classes
{
    public class CadastroUsuario
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string endereco { get; set; }

        #region Metodos
            public void ReceberDados () {
                Console.WriteLine("Informe o nome do usuario");
                nome = Console.ReadLine();
                Console.WriteLine("Informe a idade do usuario");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o endereço do usuario");
                endereco = Console.ReadLine();
            }
        #endregion
    }
}