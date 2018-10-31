using System;
using System.Threading;

namespace Leitura_e_Escrita_de_Arquivos.ViewModels {

    public class MenuViewModel {

        /// <summary>
        /// Classe responsável pela visualização do menu.
        /// </summary>
        
        public void menuDeOpcoes () { //Método que se responsabiliza pela aparição do menu principal.

            Thread.Sleep (2000); //Atraso da aparição da mensagem.
            Console.WriteLine ("Escolha uma das opções abaixo, a fim de realizar uma operação de leitura ou escrita em arquivos.\n"); //Orientações para o usuário.

            Thread.Sleep (4000); //Atraso da aparição da mensagem.
            Console.WriteLine ("1 - Criar um arquivo"); //Função 1.

            Thread.Sleep (500); //Atraso da aparição da mensagem.
            Console.WriteLine ("2 - Deletar um arquivo"); //Função 2.

            Thread.Sleep (500); //Atraso da aparição da mensagem.
            Console.WriteLine ("3 - Escrever em um arquivo"); //Função 3.

            Thread.Sleep (500); //Atraso da aparição da mensagem.
            Console.WriteLine ("4 - Ler um arquivo"); //Função 4.

            Thread.Sleep (500); //Atraso da aparição da mensagem.
            Console.WriteLine ("5 - Modificar o diretório de arquivos"); //Função 5.

            Thread.Sleep (500); //Atraso da aparição da mensagem.
            Console.WriteLine ("6 - Tornar o diretório de arquivos padrão"); //Função 6.

            Thread.Sleep (500); //Atraso da aparição da mensagem.
            Console.WriteLine ("0 - Sair\n"); //Função 0.

            Thread.Sleep (1000); //Atraso da aparição da mensagem.
            Console.WriteLine ("----    Digita um número que corresponde à uma das funções a cima e prima entra   ----\n"); //Mais orientações para o usuário.

        }
    }
}
