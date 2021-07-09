using System;

namespace E03_arquivo.Utils
{
    public static class MenuUtil
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("Seja bem-vindo!");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Criar um arquivo");
            Console.WriteLine("2 - Escrever em um arquivo");
            Console.WriteLine("3 - Ler um arquivo");
            Console.WriteLine("4 - Deletar um arquivo");
            Console.WriteLine("0 - Sair");
        }

        public static void Pause()
        {
            Console.Write("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
