using System;
using System.IO;
using Leitura_e_Escrita_de_Arquivos.Utils;
using Leitura_e_Escrita_de_Arquivos.ViewController;

namespace Leitura_e_Escrita_de_Arquivos.Utils {
        public class DeletarUtils {

            CriacaoUtils CriacaoUtils = new CriacaoUtils ();
            MenuViewController MenuViewController = new MenuViewController ();

            public string[] texto = { };

            public int contador = 0;

            public void deletarArquivo () {

                Console.WriteLine ($"\n----    Introduza o número do arquivo    [0 - {CriacaoUtils.contador}]    ----\n");
                contador = int.Parse (Console.ReadLine ());

                //File.Delete (@"C:\Users\48430817875\Documents\SENAI\Aulas\Sprint 4\Programação\2018-10-29\Leitura-e-Escrita-de-Arquivos\ArquivosDeTexto\" + $"{CriacaoUtils.nomeDoArquivo[contador]}" + ".txt"); //Deleta um arquivo.

                if (MenuViewController.diretorioPadraoFlag == true)
                {

                    File.Delete (@"~/Schreibtisch/Schulaktivitäten/SENAI/Aulas/Sprint 4/Programo/2018-10-29/Leitura-e-Escrita-de-Arquivos/ArquivosDeTexto/" + $"{CriacaoUtils.nomeDoArquivo[contador]}" + ".txt"); //Deleta um arquivo.

                } else if (MenuViewController.diretorioPadraoFlag == false)
                {

                  File.Delete (@"{MenuViewController.diretorioCustomizado}" + $"{CriacaoUtils.nomeDoArquivo[contador]}" + ".txt"); //Deleta um arquivo.

                }
        }
    }
}
