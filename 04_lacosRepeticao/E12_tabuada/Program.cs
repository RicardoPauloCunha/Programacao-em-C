using System;

namespace E12_tabuada
{
    class Program
    {
        static void Main()
        {
            char resposta = 'S';
            int valor;
            int fator;
            int contador;

            while (resposta == 'S' || resposta == 's')
            {
                Console.WriteLine("Qual a tabuada que deseja calcular?");
                fator = int.Parse(Console.ReadLine());

                contador = 0;

                while (contador <= 10)
                {
                    valor = fator * contador;
                    Console.WriteLine($"{fator} X {contador} = {valor}");

                    contador++;
                }

                Console.WriteLine("Deseja criar uma outra tabuada? [S/N]");
                resposta = char.ToUpper(char.Parse(Console.ReadLine()));
            }
        }
    }
}
