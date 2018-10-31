using System;
using System.Threading;
using Leitura_e_Escrita_de_Arquivos.Utils;

namespace Leitura_e_Escrita_de_Arquivos.ViewController {

    /// <summary>
    /// Classe que executa funções de acordo com a opção escolhida pelo usuário.
    /// </summary>

    public class MenuViewController {

        CriacaoUtils CriacaoUtils = new CriacaoUtils (); //Instanciando o objeto CriaçãoUtils.
        DeletarUtils DeletarUtils = new DeletarUtils (); //Instanciando o objeto DeletarUtils.
        EscritaUtils EscritaUtils = new EscritaUtils (); //Instanciando o objeto DeletarUtils.
        LeituraUtils LeituraUtils = new LeituraUtils (); //Instanciando o objeto DeletarUtils.

        public void switchCaseParaAsOpcoesDoMenu () {

            int escolhaDeOpcoesDoMenu; //Variável que define a opção a ser escolhida no menu.
            string diretorioCustomizado; //Variável que se responsabiliza por armazenar o diretório de arquivos inserido pelo usuário
            string diretorioPadrao; //Variável que se responsabiliza por armazenar o diretório de arquivos padrão.
            bool diretorioPadraoFlag; //Variável que indica se o diretório é ou não padrão.

            escolhaDeOpcoesDoMenu = int.Parse (Console.ReadLine ()); //Recebe a escolha de opções do menu.

            switch (escolhaDeOpcoesDoMenu) {

                case 1: //Função 1 - Criação de arquivos.
                    {

                    Thread.Sleep (2000); //Atraso na aparição da mensagem.
                    Console.WriteLine ("\n|//|----    Criação de arquivos    ----|//|"); //Título da tarefa.

                    CriacaoUtils.criarArquivo (); //Utilização do método que se responsabiliza pela criação de arquivos.

                    break; //Interrompe a função 1.

                    }

                case 2: //Função 2 - Remoção de arquivos.
                    {

                    Thread.Sleep (2000); //Atraso na aparição da mensagem.
                    Console.WriteLine ("\n|//|----    Remoção de arquivos    ----|//|"); //Título da tarefa.

                    DeletarUtils.deletarArquivo (); //Utilização do método que se responsabiliza pela remoção de arquivos.

                    break; //Interrompe a função 2.

                    }

                case 3: //Função 3 - Escrita de dados em arquivos.
                    {

                    Thread.Sleep (2000); //Atraso na aparição da mensagem.
                    Console.WriteLine ("\n|//|----    Escrita de dados em arquivos    ----|//|"); //Título da tarefa.

                    EscritaUtils.escreverEmArquivo (); //Método que se responsabiliza pela escrita de dados em arquivos.

                    break; //Interrompe a função 3.

                    }

                case 4: //Função 4 - Leitura de arquivos.
                    {

                    Thread.Sleep (2000); //Atraso na aparição da mensagem.
                    Console.WriteLine ("\n|//|----    Leitura de arquivos    ----|//|"); //Título da tarefa.

                    LeituraUtils.lerArquivo (); //Método que se responsabiliza pela leitura dos arquivos.

                    break; //Interrompe a função 4.

                    }

                case 5: //Função 5 - Localização de arquivos.
                    {

                    Thread.Sleep (2000); //Atraso na aparição da mensagem.
                    Console.WriteLine ("\n|//|----    Alteração de diretórios de arquivos    ----|//|"); //Título da tarefa.

                    Thread.Sleep (500); //Atraso na aparição da mensagem.
                    Console.WriteLine("Qual é o diretório do arquivo?"); //Mensagem que pede ao usuário, o diretório do arquivo.

                    Thread.Sleep (500); //Atraso na aparição do input.
                    diretorioCustomizado = Console.ReadLine(); //Recebe o diretório inserido pelo usuário.

                    if (diretorioCustomizado.Contains("/") || diretorioCustomizado.Contains(":")) { //Se o diretório inserido possuir "/" ou ":", a flag se torna falsa.

                    diretorioPadraoFlag = false; //Altera a flag para o valor falso, indicando que o diretório não é o padrão.

                    } else { //Se o diretório inserido não possui "/" ou ":", o laço retorna.

                        Console.WriteLine("Por favor, introduz um diretório válido."); //Informa o usuário de que o diretório inserido é inválido.

                    }

                    break; //Interrompre a função 5.

                    }

                case 6: //Função 6 - Alteração de diretório
                    {

                    diretorioPadrãoFlag = true; //Altera a flag para o valor verdadeiro, indicando que o diretório é o padrão.

                    diretorioPadrao = "~/Schreibtisch/Schulaktivitäten/SENAI/Aulas/Sprint 4/Programo/2018-10-29/Leitura-e-Escrita-de-Arquivos/ArquivosDeTexto/";

                    Thread.Sleep (500); //Atraso na aparição da mensagem.

                    Console.WriteLine("O diretório foi definido como padrão"); //Mensagem que indica ao usuário, que o diretório foi retomado ao padrão.

                    break; //Interrompe a função 6.

                    }

                case 0: //Função 0 - Saída/fechamento do programa.
                    {

                    escolhaDeOpcoesDoMenu = 0; //Alteração no valor da variável para um valor fora do laço, levando ao fechamento do programa.

                    Thread.Sleep (2000); //Atraso na aparição da mensagem.
                    Console.WriteLine ("\nSaindo...\n"); //Mensagem de saída.
                    Thread.Sleep (2000); //Atraso na saída do programa.

                    break; //Interrompe a função 0.

                    }

                default:
                    {

                        Console.WriteLine ("\nOpção inválida\n"); //Mensagem exibida para opções inválidas.

                        break; //Interrompe a função de exibição de mensagens para opções inválidas.

                    }
            }
        }
    }
}
