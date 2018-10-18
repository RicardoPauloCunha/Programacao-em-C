using System;

namespace Senai.Exemplo.Matriz.Binco.NumerosSortiados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numerosSortiados = new int[1];

            do {
                int numerosRandomico = random.Next(51);
                //Verifica se o numero existe no array
                int posicao = Array.IndexOf(numerosSortiados, numerosRandomico);

                //Caso não exista o array adiciona o valor -1 não foi encontrado
                if (posicao == -1) {
                    //Atribui o numero sorteado ao Array
                    numerosSortiados[numerosSortiados.Length -1] = numerosRandomico;
                    //gera um novo limite de array
                    // Array.Resize(ref numerosSortiados, numerosSortiados.Length + 1);
                    Console.WriteLine($"O número sorteado foi: {numerosRandomico}");
                    Console.WriteLine("Aperte enter para continuar");
                    Console.ReadKey();
                }
            } while (numerosSortiados.Length < 50);
        }
    }
}
