using System;

namespace E03_preencherCartela
{
    class Program
    {
        static void Main()
        {
            int[,] cartela = new int[5,5];
            bool[,] marcador = new bool[5,5];

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    cartela[i,j] = random.Next(51);
                    marcador[i,j] = false;
                }
            }

            int opcao;

            do
            {
                Console.Clear();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marcador[i,j])
                            Console.Write($"X\t");
                        else
                            Console.Write($"{cartela[i,j]}\t");
                    }
                    Console.WriteLine("");
                }

                Console.WriteLine("1 - Informe as coordenadas");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe a coordenada X:");
                        int x = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a coordenada Y:");
                        int y = int.Parse(Console.ReadLine());

                        if ((x > 0) && (x <= 5) && (y > 0) && (y <= 5))
                            marcador[y-1, x-1] = true;
                        break;
                    case 0:
                        Console.WriteLine("Obrigado pelo jogo!!!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
