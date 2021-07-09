using System;

namespace E04_bingo
{
    class Program
    {
        static void Main()
        {
            
            int[] cartela = new int[6]{9, 24, 36, 41, 57, 66};
            int acertos = 0, posicao, numero;

            do
            {
                Console.WriteLine("Informe um numero: ");
                numero = int.Parse(Console.ReadLine());

                posicao = System.Array.IndexOf(cartela, numero);

                if (posicao >= 0)
                {
                    acertos++; 
                    Console.WriteLine($"Acertou {acertos}, falta {6 - acertos}");
                }
            } while (acertos < 6);

            Console.WriteLine("Parabéns. Você ganhou!!!");
        }
    }
}
