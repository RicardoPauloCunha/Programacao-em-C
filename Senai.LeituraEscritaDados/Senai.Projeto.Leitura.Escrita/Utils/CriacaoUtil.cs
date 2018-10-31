using System;
using System.IO;
using System.Threading;
using Leitura_e_Escrita_de_Arquivos.Utils;
using Leitura_e_Escrita_de_Arquivos.ViewController;

namespace Leitura_e_Escrita_de_Arquivos.Utils {

        /// <summary>
        /// Classe que realiza a criação de dados em um arquivo.
        /// </summary>

        public class CriacaoUtils {

            public int contador = 0;
            MenuViewController MenuViewController = new MenuViewController ();

            public string[] nomeDoArquivo = new string[9999]; //Cria a variável para armazenar o nome do arquivo.

            public string nomearArquivo () {

                Console.WriteLine ("\n----    Introduza o nome do arquivo    ----\n"); //"Título" da função

                nomeDoArquivo [contador] = (Console.ReadLine ()); //Faz a leitura do nome do arquivo e o armazena.
                return nomeDoArquivo[contador];

            }
            public void criarArquivo () {

                //var CriacaoArquivo = File.Create (@"C:\Users\48430817875\Documents\SENAI\Aulas\Sprint 4\Programação\2018-10-29\Leitura-e-Escrita-de-Arquivos\ArquivosDeTexto\" + nomearArquivo () + ".txt "); //Escreve os dados introduzidos em um arquivo.

                if (MenuViewController.diretorioPadraoFlag == true)
                {

                  var CriacaoArquivo = File.Create (@"~/Schreibtisch/Schulaktivitäten/SENAI/Aulas/Sprint 4/Programo/2018-10-29/Leitura-e-Escrita-de-Arquivos/ArquivosDeTexto/" + nomearArquivo () + ".txt"); //Escreve os dados introduzidos em um arquivo.

                } else if (MenuViewController.diretorioPadraoFlag == true) {

                  var CriacaoArquivo = File.Create (@"{MenuViewController.diretorioCustomizado}" + nomearArquivo () + ".txt"); //Escreve os dados introduzidos em um arquivo.

                  CriacaoArquivo.Close ();

                }
                contador++; //Incremento do contador para o array.
        }
    }
}
