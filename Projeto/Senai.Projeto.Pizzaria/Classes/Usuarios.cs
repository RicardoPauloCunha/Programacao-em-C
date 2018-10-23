using System;

namespace Senai.Projeto.Pizzaria.Classes
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string  Senha { get; set; }
        public DateTime Data { get; set; }
        

        public  void Menu(){
             


             System.Console.WriteLine("\n\n********* PIZZARIA R & RICK ********\n\n\n");
                System.Console.WriteLine("1- Cadastrar Usuário\n");
                System.Console.WriteLine("2- Efetuar login\n");
                System.Console.WriteLine("3- Lista de Usuários\n");
                System.Console.WriteLine("9- Sair\n\n");


        }

    public void VoltarMenu(){
        System.Console.WriteLine("\n Digite alguma tecla para retornar ao menu inicial\n");
        Console.ReadKey();
    }


        public void NovoCliente(){

            System.Console.WriteLine("\n\n********CADRASTRO DE USUÁRIOS********\n\n\n");

            System.Console.WriteLine("\nEntre com o nome do usuário a ser cadastrado:\n");
            Nome=Console.ReadLine();
            System.Console.WriteLine("\nEntre com o email do usuário\n");
            Email=Console.ReadLine();
            System.Console.WriteLine("\nEntre com a senha do usuário:\n");
            Senha=Console.ReadLine();
            Data=DateTime.Now;
            


        }












    }

     

}