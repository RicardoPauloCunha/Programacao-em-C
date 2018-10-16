using System;

namespace Senai.Array.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [3];
            int contador = 0;

            do {
                Console.WriteLine("Informe um numero");
                numeros[contador] = int.Parse(Console.ReadLine());

                contador++;
            }while(contador < numeros.Length);

            // Console.WriteLine("O numero na 2º posição é: 2º + numeros[1]);

            System.Array.Sort(numeros);

            contador = 0;
            do {
                Console.WriteLine($"Número da posição {contador} é {numeros[contador]}");
                contador++;
            }while(contador < numeros.Length);
        }
    }
}
