using System;

namespace E02_porta
{
    class Program
    {
        static void Main()
        {
            int opcao;
            Console.WriteLine("A porta esta aberta?[true/false]");
            bool aberta = bool.Parse(Console.ReadLine());

            do {
                Console.WriteLine("-- Porta --");
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Abrir");
                Console.WriteLine("2 - Fechar");
                Console.WriteLine("3 - Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        aberta = Abrir(aberta);
                        break;
                    case 2:
                        aberta = Fechar(aberta);
                        break;
                    case 3:
                        Console.Write("Saindo...");
                        break;
                    default:
                        Console.Write("Opção inválida. Tente novamente");
                        break;
                }
            } while(opcao != 3);
        }

        public static bool Abrir(bool aberta)
        {
            if (aberta)
                Console.WriteLine("Não precisa se esforçar para nada.");
            else
                Console.WriteLine("A porta abriu");

            Console.WriteLine("estado da porta: Aberta");
            return true;
        }

        public static bool Fechar(bool aberta)
        {
            if (aberta)
                Console.WriteLine("A porta fechou.");
            else
                Console.WriteLine("Porta já fechada.");

            Console.WriteLine("estado da porta: Fechada");
            return false;
        }
    }
}
