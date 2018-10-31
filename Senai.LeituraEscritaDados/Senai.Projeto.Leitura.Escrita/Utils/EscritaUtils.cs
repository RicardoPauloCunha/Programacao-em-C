using System;
using System.IO;
using Leitura_e_Escrita_de_Arquivos.Utils;
using Leitura_e_Escrita_de_Arquivos.ViewController;

namespace Leitura_e_Escrita_de_Arquivos.Utils {

        /// <summary>
        /// Classe que realiza a escrita de dados em um arquivo.
        /// </summary>

        public class EscritaUtils {

            CriacaoUtils CriacaoUtils = new CriacaoUtils ();
            MenuViewController MenuViewController = new MenuViewController ();

            public string Texto;

            public int contador = 0;

            public void escreverEmArquivo () {

                Console.WriteLine ($"\n----    Introduza o número do arquivo    [0 - {CriacaoUtils.contador}]    ----\n");
                contador =int.Parse (Console.ReadLine ());

                Console.WriteLine ("Introduza o teu texto.");
                Texto = Console.ReadLine ();

                //File.WriteAllText (@"C:\Users\48430817875\Documents\SENAI\Aulas\Sprint 4\Programação\2018-10-29\Leitura-e-Escrita-de-Arquivos\ArquivosDeTexto\" + $" { CriacaoUtils.nomeDoArquivo[contador]}" + ".txt ", Texto); //Escreve os dados introduzidos em um arquivo.

                if (MenuViewController.diretorioPadraoFlag == true)
                {

                  File.WriteAllText (@"~/Schreibtisch/Schulaktivitäten/SENAI/Aulas/Sprint 4/Programo/2018-10-29/Leitura-e-Escrita-de-Arquivos/ArquivosDeTexto/" + $" { CriacaoUtils.nomeDoArquivo[contador]}" + ".txt ", Texto); //Escreve os dados introduzidos em um arquivo.

                } else if (MenuViewController.diretorioPadraoFlag == false)
                {

                  File.WriteAllText (@"{MenuViewController.diretorioCustomizado}" + $" { CriacaoUtils.nomeDoArquivo[contador]}" + ".txt ", Texto); //Escreve os dados introduzidos em um arquivo.

                }

        }

    }
}
