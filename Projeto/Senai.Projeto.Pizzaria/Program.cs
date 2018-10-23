using System;
using Senai.Projeto.Pizzaria.Classes;

namespace Senai.Projeto.Pizzaria
{

    class Program
    {
        static void Main(string[] args)
        {   string opcao;
            int quantidade=1;
            Usuarios fazer =new Usuarios();
            Usuarios [] user = new Usuarios[quantidade];
            
            
            fazer.Menu();

            do{
                opcao=Console.ReadLine();

                
                  switch(opcao){
            case "1":{

        
                user[quantidade-1] =new Usuarios();
                user[quantidade-1].NovoCliente();
 
                System.Console.WriteLine($"id= {quantidade}  Usuario {user[quantidade-1].Nome}    email: {user[quantidade-1].Email}  Senha{user[quantidade-1].Senha} Data: {user[quantidade-1].Data}");
                quantidade++;
                Array.Resize(ref user, quantidade );

                
                fazer.VoltarMenu();
                fazer.Menu();
                break;
            }


             case "2":{System.Console.WriteLine("Opção2");
                
                fazer.VoltarMenu();
                fazer.Menu();
                break;
            }


             case "3":{ System.Console.WriteLine("Opçao3");
                
                fazer.VoltarMenu();
                fazer.Menu();
                break;  
            }


            default:{



                System.Console.WriteLine("\nDigite uma opção válida!!!\n");
                fazer.VoltarMenu();
                fazer.Menu();
                break;
            }




                  }
                }while(opcao!="9");

          
            

          












            
        }
    }
}
