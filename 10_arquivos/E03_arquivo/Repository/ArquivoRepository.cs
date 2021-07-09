using E03_arquivo.Utils;
using System;
using System.IO;

namespace E03_arquivo.Repository
{
    public class ArquivoRepository
    {
        private string NomearArquivo()
        {
            Console.WriteLine("Insira o nome do arquivo:");
            string nomeArquivo = Console.ReadLine();

            return nomeArquivo;
        }

        public void CriarArquivo()
        {
            Console.Clear();

            string nomeArquivo = NomearArquivo();
            File.Create(CaminhaPastaUtil.PegarCaminho() + nomeArquivo + ".txt");

            Console.WriteLine("Arquivo criado com sucesso");
            MenuUtil.Pause();
        }

        public void EscreverArquivo()
        {
            Console.Clear();

            string nomeArquivo = NomearArquivo();
            Console.WriteLine("Insira o conteudo do arquivo:");
            string texto = Console.ReadLine();
            File.WriteAllText(CaminhaPastaUtil.PegarCaminho() + nomeArquivo + ".txt", texto);

            Console.WriteLine("Conteudo registrado com sucesso");
            MenuUtil.Pause();
        }

        public void LerArquivo()
        {
            Console.Clear();

            string nomeArquivo = NomearArquivo();
            string texto = File.ReadAllText(CaminhaPastaUtil.PegarCaminho() + nomeArquivo + ".txt");
            Console.WriteLine("Conteudo:");
            Console.WriteLine(texto);

            MenuUtil.Pause();
        }

        public void DeletarArquivo()
        {
            Console.Clear();

            string nomeArquivo = NomearArquivo();
            File.Delete(CaminhaPastaUtil.PegarCaminho() + nomeArquivo + ".txt");
            Console.WriteLine("Arquivo deletado com sucesso");

            MenuUtil.Pause();
        }
    }
}
