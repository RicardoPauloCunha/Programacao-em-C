using E03_arquivo.Repository;
using E03_arquivo.Utils;
using System;

namespace E03_arquivo
{
    class Program
    {
        static void Main ()
        {
            ArquivoRepository _arquivoRepository = new ArquivoRepository();
            int opcao;

            do {
                MenuUtil.MostrarMenu();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        _arquivoRepository.CriarArquivo();
                        break;
                    case 2:
                        _arquivoRepository.EscreverArquivo();
                        break;
                    case 3:
                        _arquivoRepository.LerArquivo();
                        break;
                    case 4:
                        _arquivoRepository.DeletarArquivo();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
