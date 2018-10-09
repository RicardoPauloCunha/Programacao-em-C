using System;
using Senai.Metodos.Exercicio3.Classes;

namespace Senai.Metodos.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Porta porta = new Porta();
            Console.WriteLine("A porta esta aberta?[true/false]");
            porta.estado = bool.Parse(Console.ReadLine());

            do {
                Console.WriteLine("O que você deseja fazer: 1 - abrir, 2 - fechar, 3 - sair?");
                porta.acao = int.Parse(Console.ReadLine());

            switch (porta.acao)
            {
                case 1:{
                    porta.Abrir();
                    break;
                }
                case 2:{
                    porta.Fechar();
                    break;
                }
                
                default:
                break;
            }
            }while(porta.acao > 0 || porta.acao < 4);
        }
    }
}
