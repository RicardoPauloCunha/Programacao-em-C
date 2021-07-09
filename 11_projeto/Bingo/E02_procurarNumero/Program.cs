using System;

namespace E02_procurarNumero
{
    class Program
    {
        static void Main()
        {
            int[,] cartela = new int[5,5];
            int numero;
            bool encontrado = false;

            Random random = new Random();

            for (int l = 0; l < 5; l++)
            {
                for (int c = 0; c < 5; c++)
                {
                    cartela[l,c] = random.Next(51);
                    Console.Write($"{cartela[l,c]}\t");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Informe um numero:");
            numero = int.Parse(Console.ReadLine());

            for (int l = 0; l < 5; l++) 
            {
                for (int c = 0; c < 5; c++)
                {
                    if (numero == cartela[l,c]) {
                        Console.WriteLine($"Coordenada X: {l}, Coordenada Y: {c}");
                        encontrado = true;
                        break;
                    }
                }
                if (encontrado){
                    break;
                }
            }

            if (!encontrado) {
                Console.WriteLine("Número não encontrado");
            }
        }
    }
}
