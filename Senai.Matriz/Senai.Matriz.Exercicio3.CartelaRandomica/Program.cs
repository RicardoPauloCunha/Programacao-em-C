using System;

namespace Senai.Matriz.Exercicio3.CartelaRandomica
{
    class Program
    {
        static void Main(string[] args)
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

            int acao = 1;

            do {
                Console.WriteLine("1 - Verificar Numero:");
                Console.WriteLine("0 - sair");
                acao = int.Parse(Console.ReadLine());

                switch (acao)
                {
                    case 1: {
                        Console.WriteLine("Informe um numero:");
                        numero = int.Parse(Console.ReadLine());
                        for (int l = 0; l < 5; l++)
                        {
                            for (int c = 0; c < 5; c++)
                            {
                                if (numero == cartela[l,c]) {
                                    Console.WriteLine($"Coordenada X: {l}, Coordenada Y: {c}");
                                    encontrado = true;
                                }
                            }
                        }
                        if (!encontrado){
                            Console.WriteLine("Valor não encontrado");
                        }
                        break;
                    }
                    case 0: {
                        Console.WriteLine("Sair do jogo");
                        break;
                    }
                    default: {
                        Console.WriteLine("Valor incorreto");
                        break;
                    }
                }
            }while (acao != 0);


        }
    }
}
