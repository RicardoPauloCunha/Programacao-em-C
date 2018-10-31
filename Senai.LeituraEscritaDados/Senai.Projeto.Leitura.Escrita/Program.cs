using System;
using System.Threading;
using Leitura_e_Escrita_de_Arquivos.Utils;
using Leitura_e_Escrita_de_Arquivos.ViewController;
using Leitura_e_Escrita_de_Arquivos.ViewModels;

namespace Leitura_e_Escrita_de_Arquivos {
    class Program {
        static void Main (string[] args) {

            MenuViewModel Menu = new MenuViewModel (); //Instanciando a classe MenuViewModel.
            MenuViewController MenuViewController = new MenuViewController (); //Instancionado a classe MenuViewController.
            CriacaoUtils CriacaoUtils = new CriacaoUtils ();

            do { //Laço de repetição principal.

            Thread.Sleep (1000); //Atraso da aparição da mensagem.
            Console.WriteLine ("\nOlá!\n"); //Saudações.

            Thread.Sleep (2000); //Atraso da aparição da mensagem.
            Console.WriteLine ("Seja bemvindo!\n"); //Conformidade para o usuário.

            Menu.menuDeOpcoes (); //Apresenta o menu de opções ao usuário.

            MenuViewController.switchCaseParaAsOpcoesDoMenu (); //Inicia a operação escolhida pelo usuário.

            } while (MenuViewController.escolhaDeOpcoesDoMenu != 0); //Mantém o programa aberto, enquanto a escolhaDeOpçõesDoMenu for diferente de zero.
        }
    }
}
