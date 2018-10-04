using System;

namespace Senai.Lacos.Repiticao.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a  tabuada que deseja calcular?");
            int Tabuada = int.Parse(Console.ReadLine());

            int Contador = 0;

            //Criando o laço while
            while (Contador <= 10)
            {
                int Valor = Tabuada * Contador;
                Console.WriteLine($"{Tabuada} X {Contador} = {Valor}");

                //Incremento (pega o valor atual e adiciona +1)
                Contador++;
            }

            //Probremas: laços infinitos, loop infinito, deadlock
            //Utilidade: repitiçao de e-mail e senha
        }
    }
}
