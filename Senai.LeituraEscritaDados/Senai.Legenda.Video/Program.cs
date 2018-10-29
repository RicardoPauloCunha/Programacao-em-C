using System;
using System.IO;

namespace Senai.Legenda.Video
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ArquivoText;
            string Caminho = "C:\\Users\\50473694808\\Desktop\\C#\\Senai.LeituraEscritaDados\\Arquivos de Texto\\Arquivo.txt";
            
            ArquivoText = File.CreateText(Caminho);

            ArquivoText.WriteLine("00.00.01 --> 00.00.10 = ola mundo");
            ArquivoText.WriteLine("00.00.10 --> 00.00.20 = oi");

            ArquivoText.Close();
            ArquivoText = File.AppendText(Caminho);
        }
    }
}
