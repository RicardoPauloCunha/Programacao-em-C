using System;

namespace E01_sortearNumero
{
    class Program
    {
        static void Main()
        {
            int[] numerosSorteados = new int[1];

            Random random = new Random();

            do
            {
                int numerosRandomico = random.Next(51);
                int posicao = Array.IndexOf(numerosSorteados, numerosRandomico);

                if (posicao == -1) {
                    numerosSorteados[numerosSorteados.Length -1] = numerosRandomico;
                    Console.WriteLine($"O número sorteado foi: {numerosRandomico}");
                    Console.WriteLine("Aperte enter para continuar");
                    Console.ReadKey();
                }
            } while (numerosSorteados.Length < 50);
        }
    }
}
