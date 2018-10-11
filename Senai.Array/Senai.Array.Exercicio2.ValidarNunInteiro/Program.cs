using System;
using static Senai.Array.Exercicio2.ValidarNunInteiro.Classes.ValNunInt;

namespace Senai.Array.Exercicio2.ValidarNunInteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero valor = new Numero();

            do {
                Console.WriteLine("Informe um numero:"); 
                valor.numeroA[valor.contador] = int.Parse(Console.ReadLine());
                valor.ValTrueInt();
                Console.WriteLine($"Validade do numero: {valor.validade}");
            } while (valor.contador <= valor.numeroA.Length);
        }
    }
}
