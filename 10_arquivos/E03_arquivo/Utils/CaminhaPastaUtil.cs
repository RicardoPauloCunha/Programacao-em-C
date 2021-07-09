using System;

namespace E03_arquivo.Utils
{
    public static class CaminhaPastaUtil
    {
        public static string PegarCaminho()
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"ArquivosTexto\";
            return fileName.Replace(@"\bin\Debug\netcoreapp2.1", "");
        }
    }
}
