using System;

namespace Senai.Exemplo.Matriz.Binco.GeradorCartela
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel Matriz para armanezar os numeros da cartela
            int[,] cartela = new int[5,3]; //linha, colunas
            bool[,] marcador = new bool[5,3];

            Random random = new Random();

            //Percorre as linhas da cartela
            for (int l = 0; l < 5; l++)
            {
                //Percorre as colunas da tabela
                for (int c = 0; c < 3; c++)
                {
                    cartela[l,c] = random.Next(51);
                    marcador[l,c] = false;
                }
            }

            int opcao = 0;

            do {
                //Desenha cartela na tela
                for (int l = 0; l < 5; l++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        //Se verdade mostra o X na posição
                        //Senão mostra o número
                        if (marcador[l,c])
                        {
                            Console.Write($"X\t");
                        }
                        else {
                            Console.Write($"{cartela[l,c]}\t");
                        }
                    }
                    Console.WriteLine("");
                }
                //Menu de opções
                Console.WriteLine("1 - Informe as coordenadas");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: {
                        //Pede para o usuário informar as coordenadas da
                        Console.WriteLine("Informe a coordenada X:");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a coordenada Y:");
                        int y = int.Parse(Console.ReadLine());

                        //verifica se o valor informado de x e y estão dentro das co
                        if ((x >= 0) && (x < 3) && (y >= 0) && (y < 5)) {
                            marcador[y,x] = true;
                        }
                        break;
                    }
                    case 0: {
                        Console.WriteLine("Obrigado pelo jogo!!!");
                        break;
                    }
                    
                    default: {
                        Console.WriteLine("Opção inválida. Tente novamente");
                        break;
                    }
                    
                }
            } while (opcao != 0);
        }
    }
}
