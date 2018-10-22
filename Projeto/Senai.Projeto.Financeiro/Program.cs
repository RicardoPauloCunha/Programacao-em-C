using System;
using Senai.Projeto.Financeiro.Classes;

namespace Senai.Projeto.Financeiro {
    class Program {
        static void Main (string[] args) {
            int funcao;
            int contador = 0;
            Funcionario[] funcionario = new Funcionario[1000];
            do {
                //Exibe o menu de Funções
                #region Menu
                Console.WriteLine ("--MENU--");
                Console.WriteLine ("1 - Cadastro de Funcionários");
                Console.WriteLine ("2 - Exibição de Folha de Pagamento");
                Console.WriteLine ("3 - Exibir Total de Custos Bruto da Folha");
                Console.WriteLine ("4 - Aumento de Salário");
                Console.WriteLine ("5 - Exibir Total de Custos Líquido da Folha");
                Console.WriteLine ("6 - Exibir Maior Salário ao Menor Salário");
                Console.WriteLine ("7 - Alterar Cadastro");
                Console.WriteLine ("8 - Remover Cadastro");
                Console.WriteLine ("0 - Sair");
                funcao = int.Parse (Console.ReadLine ());
                Console.WriteLine ("");
                #endregion

                #region Switch
                switch (funcao) {
                    //cadastro de Funcionários

                    #region Cadastro
                    case 1:
                        {
                            string criarFun;
                            do {
                                Console.WriteLine ("Deseja cadastrar um novo funcionario?[S/N]:");
                                criarFun = Console.ReadLine ().ToUpper ();
                                switch (criarFun) {
                                    case "S":
                                        {
                                            if (contador < funcionario.Length) {
                                                funcionario[contador] = new Funcionario ();
                                                Console.WriteLine ("Informe o nome do funcionario:");
                                                funcionario[contador].Nome = Console.ReadLine ();
                                                Console.WriteLine ("Informe o salário atual do funcionario:");
                                                funcionario[contador].Salario = float.Parse (Console.ReadLine ());
                                                contador++;
                                                Console.WriteLine ("");
                                            } else {
                                                Console.WriteLine ("Limite maximo de usuarios cadastrados.");
                                            }
                                            break;
                                        }
                                    case "N":
                                        {
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine ("valor inválido");
                                            break;
                                        }
                                }
                            } while (criarFun == "S");
                            Console.WriteLine ("");
                            break;
                        }
                        #endregion

                        //Exibição da Folha
                        #region Folha
                    case 2:
                        {
                            Console.WriteLine ("Inserir o índice do vetor em que se encontra o funcionário:");
                            int indice = int.Parse (Console.ReadLine ());
                            bool validar = false;
                            #region validar
                            for (int i = 0; i <= indice; i++) {
                                if (funcionario[i] != null) {
                                    if (i == indice) {
                                        funcionario[i].FolhaPagamento ();
                                        i = 0;
                                        break;
                                    }
                                } else {
                                    validar = true;
                                }
                            }
                            if (validar == true) {
                                Console.WriteLine ("Funcionario não cadastrado. Tente novamente!");
                            }
                            Console.WriteLine ("");
                            #endregion
                            break;
                        }
                        #endregion

                        //Exibir total custo pagamento bruto
                        #region Total Bruto
                    case 3:
                        {
                            Console.WriteLine ("--TOTAL DE CUSTOS BRUTO DA FOLHA");
                            float custosBrutos = 0;
                            bool validar = false;

                            //Calcula os custos do salario de todos os funcioinarios
                            for (int i = 0; i <= contador; i++) {
                                if (funcionario[i] != null) {
                                    custosBrutos += funcionario[i].Salario;
                                    validar = true;
                                }
                            }
                            if (!validar) {
                                Console.WriteLine ("Nenhum funcionario cadastrado ainda!!");
                            }

                            Console.WriteLine ($"Custos Brutos:" + custosBrutos.ToString ("c"));
                            Console.WriteLine ("Pressione enter para continuar");
                            Console.ReadKey ();
                            Console.WriteLine ("");
                            break;
                        }
                        #endregion

                        //Calcula o aumento de salario
                        #region Aumento Salario
                    case 4:
                        {
                            Console.WriteLine ("--AUMENTO DE SALARIO");
                            Console.WriteLine ("Inserir o índice do vetor em que se encontra o funcionário:");
                            int indice = int.Parse (Console.ReadLine ());
                            bool validar = false;
                            #region validar
                            for (int i = 0; i <= indice; i++) {
                                if (funcionario[i] != null) {
                                    if (i == indice) {
                                        funcionario[i].AumentoSalario ();
                                        i = 0;
                                        break;
                                    }
                                } else {
                                    validar = true;
                                }
                            }
                            if (validar == true) {
                                Console.WriteLine ("Funcionario não cadastrado. Tente novamente!");
                            }
                            Console.WriteLine ("");
                            #endregion
                            break;
                        }
                        #endregion

                        //Exibir total custo pagamento bruto
                        #region Total Liquido
                    case 5:
                        {
                            float custosLiquidos = 0;
                            bool validar = false;
                            Console.WriteLine ("--TOTAL DE CUSTOS LÍQUIDOS DA FOLHA--");

                            //Calcula os custos do salario de todos os funcioinarios
                            for (int i = 0; i < contador; i++) {
                                if (funcionario[i] != null) {
                                    float[] valores = funcionario[i].RetornaValoresSalario ();
                                    custosLiquidos += valores[4];
                                    validar = true;
                                }
                            }
                            if (!validar) {
                                Console.WriteLine ("Nenhum funcionario cadastrado ainda!!");
                            }

                            Console.WriteLine ($"Custos Líquidos: " + custosLiquidos);
                            Console.WriteLine ("Pressione enter para continuar");
                            Console.ReadKey ();
                            Console.WriteLine ("");
                            break;
                        }
                        #endregion

                        //Exibir Maior e Menor Salário
                        #region Maior e Menor Salário
                    case 6:
                        float maiorSal = 0;
                        float menorSal = 0;
                        int indexMaior = 0;
                        int indexMenor = 0;
                        Console.WriteLine ("--MAIOR E MENOR SALÁRIO--"); {
                            for (int i = 0; i < contador; i++) {
                                if (funcionario[i] != null) {
                                    if (i == 0) {
                                        menorSal = funcionario[0].Salario;
                                        maiorSal = funcionario[0].Salario;
                                    }
                                    if (funcionario[i].Salario < menorSal) {
                                        menorSal = funcionario[i].Salario;
                                        indexMenor = i;

                                    } else if (funcionario[i].Salario > maiorSal) {
                                        maiorSal = funcionario[i].Salario;
                                        indexMaior = i;
                                    }
                                }
                            }
                            Console.WriteLine ($"O Menor salario é do funcionairo: {funcionario[indexMenor].Nome}");
                            Console.WriteLine ($"O Maior salario é do funcionairo: {funcionario[indexMaior].Nome}");
                            Console.WriteLine ("Pressione enter para continuar");
                            Console.ReadKey ();
                            Console.WriteLine ("");
                            break;
                        }
                        #endregion

                        //Alterar nome ou salário
                        #region Alteração de Cadastro
                    case 7:
                        {
                            Console.WriteLine ("--ALTERAÇÃO DE CADASTRO--");
                            Console.WriteLine ("Inserir o índice do vetor em que se encontra o funcionário:");
                            int indice = int.Parse (Console.ReadLine ());
                            bool validar = false;
                            #region validar
                            for (int i = 0; i <= indice; i++) {
                                if (funcionario[i] != null) {
                                    if (i == indice) {
                                        Console.WriteLine ($"{funcionario[i].Nome}, salário {funcionario[i].Salario.ToString("c")}");
                                        funcionario[i].AlterarCadastro ();
                                        i = 0;
                                        break;
                                    }
                                } else {
                                    validar = true;
                                }
                            }
                            if (validar == true) {
                                Console.WriteLine ("Funcionario não cadastrado. Tente novamente!");
                            }
                            Console.WriteLine ("");
                            #endregion
                            break;
                        }
                        #endregion

                        //Remover cadastro funcionario
                        #region Remover Cadastro
                    case 8:
                        {
                            Console.WriteLine ("");
                            break;
                        }
                        #endregion

                        //Sair
                        #region Sair
                    case 0:
                        {
                            Console.WriteLine ("Obrigado por utilizar nosso sistema!!");
                            break;
                        }
                        #endregion
                        //Caso nenhum dos valores acima sejam recebidos:
                    default:
                        {
                            Console.WriteLine ("Valor Inválido");
                            break;
                        }
                }
                #endregion
            } while (funcao != 0);
        }

    }
}