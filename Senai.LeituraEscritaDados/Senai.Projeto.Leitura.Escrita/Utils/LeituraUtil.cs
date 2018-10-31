using System;
using System.IO;
using Leitura_e_Escrita_de_Arquivos.Utils;
using Leitura_e_Escrita_de_Arquivos.ViewController;

namespace Leitura_e_Escrita_de_Arquivos.Utils {

    /// <summary>
    /// Classe que realiza a leitura de dados de um arquivo.
    /// </summary>

    public class LeituraUtils {

        CriacaoUtils CriacaoUtils = new CriacaoUtils ();
        EscritaUtils EscritaUtils = new EscritaUtils ();
        MenuViewController MenuViewController = new MenuViewController ();

        public int contador = 0;

        public void lerArquivo () {

            Console.WriteLine ($"\n----    Introduza o número do arquivo    [0 - {CriacaoUtils.contador}]    ----\n");
            contador = int.Parse (Console.ReadLine ());

            //EscritaUtils.Texto = File.ReadAllText (@"C:\Users\48430817875\Documents\SENAI\Aulas\Sprint 4\Programação\2018-10-29\Leitura-e-Escrita-de-Arquivos\ArquivosDeTexto\" + $"{CriacaoUtils.nomeDoArquivo[contador]}" + ".txt"); //Lê os dados introduzidos em um arquivo.

            if (MenuViewController.diretorioPadraoFlag == true)
            {

                EscritaUtils.Texto = File.ReadAllText (@"~/Schreibtisch/Schulaktivitäten/SENAI/Aulas/Sprint 4/Programo/2018-10-29/Leitura-e-Escrita-de-Arquivos/ArquivosDeTexto/" + $"{CriacaoUtils.nomeDoArquivo[contador]}" + ".txt"); //Lê os dados introduzidos em um arquivo.

            } else if (MenuViewController.diretorioPadraoFlag == false)
            {

                EscritaUtils.Texto = File.ReadAllText (@"{MenuViewController.diretorioCustomizado}" + $"{CriacaoUtils.nomeDoArquivo[contador]}" + ".txt"); //Lê os dados introduzidos em um arquivo.

            }

            Console.WriteLine ($"Nome do arquivo: {CriacaoUtils.nomeDoArquivo[contador]}");

            Console.WriteLine ("\n" + EscritaUtils.Texto);

        }
    }
}
