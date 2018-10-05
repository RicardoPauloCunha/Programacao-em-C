using System;

namespace Senai.Exemplo.DoWhile.RepitirNunPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um Número:");
            int Valor1 = int.Parse(Console.ReadLine());

            int Contador = 0;

            do {
                int Par = Contador % 2;
                if(Par == 0){
                    Console.WriteLine(Contador);
                }
                Contador++;       
            }while(Contador != Valor1);

            Console.WriteLine($"Quantidade de números pares que se repetem: {(Contador / 2) - 1}");
        }
    }
}
