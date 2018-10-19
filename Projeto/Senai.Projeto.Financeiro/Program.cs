using System;
using Senai.Projeto.Financeiro.Classes;

namespace Senai.Projeto.Financeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcao;
            Funcionario[] funcionario = new Funcionario[5];
            do {
                //Exibe o menu de Funções
                #region Menu
                    Console.WriteLine("--MENU--");
                    Console.WriteLine("1 - Cadastro de Funcionários");
                    Console.WriteLine("2 - Exibição de Folha de Pagamento");
                    Console.WriteLine("3 - Exibir Total de Custos Bruto da Folha");
                    Console.WriteLine("4 - Aumento de Salário");
                    Console.WriteLine("5 - Exibir Total de Custos Líquido da Folha");
                    Console.WriteLine("0 - Sair");
                    funcao = int.Parse(Console.ReadLine());
                #endregion

                #region Switch
                    switch (funcao)
                    {
                        //cadastro de Funcionários
                        #region Cadastro
                            case 1: {
                                string criarFun;
                                int contador = 0;
                                do
                                {
                                    Console.WriteLine("Deseja cadastrar um novo funcionario?[S/N]:");
                                    criarFun = Console.ReadLine();
                                    switch (criarFun)
                                    {
                                        case "S": {
                                            if (contador < 5) {
                                                funcionario[contador] = new Funcionario();
                                                Console.WriteLine("Informe o nome do funcionario:");
                                                funcionario[contador].nome = Console.ReadLine();
                                                Console.WriteLine("Informe o salário atual do funcionario:");
                                                funcionario[contador].salario = float.Parse(Console.ReadLine());
                                                contador++;
                                            } 
                                            else {
                                                Console.WriteLine("Limite maximo de usuarios cadastrados.");
                                            }
                                            break;
                                        }
                                        default:{
                                            Console.WriteLine("valor inválido");
                                            break;
                                        }
                                     }
                                } while (criarFun == "S");
                                
                            break;
                        }
                        #endregion
                        
                        //Exibição da Folha
                        #region Folha
                            case 2: {
                                Console.WriteLine("Inserir o índice do vetor em que se encontra o funcionário:");
                                int indice = int.Parse(Console.ReadLine());
                                #region validar
                                    for (int i = 0; i <= indice; i++)
                                    {
                                        if (funcionario[i] != null){
                                            if (i == indice) {
                                                funcionario[i].FolhaPagamento();
                                                i = 0;
                                                break;
                                            } 
                                        }
                                        else {
                                            Console.WriteLine("Funcionario não cadastrado. Tente novamente!");
                                        }
                                    }
                                #endregion
                                break;
                            }
                        #endregion
                        
                        //Exibir total custo pagamento bruto
                        #region Total Bruto
                            case 3: {
                                float custosBrutos = 0;
                                bool validar = false;
                                Console.WriteLine("--TOTAL DE CUSTOS BRUTO DA FOLHA");

                                //Calcula os custos do salario de todos os funcioinarios
                                for (int i = 0; i < 5; i++)
                                {
                                   if (funcionario[i] != null) {
                                        custosBrutos += funcionario[i].salario;
                                        validar = true;
                                   }
                                }
                                if (!validar) {
                                    Console.WriteLine("Nenhum funcionario cadastrado ainda!!");
                                }

                                Console.WriteLine($"Custos Brutos:" + custosBrutos.ToString("c"));
                                Console.ReadKey();
                                Console.WriteLine("Pressione enter para continuar");
                                break;
                            }
                        #endregion

                        //Calcula o aumento de salario
                        #region Aumento Salario
                            case 4: {
                                Console.WriteLine("--AUMENTO DE SALARIO");
                                Console.WriteLine("Inserir o índice do vetor em que se encontra o funcionário:");
                                int indice = int.Parse(Console.ReadLine());
                                #region validar
                                    for (int i = 0; i <= indice; i++)
                                    {
                                        if (funcionario[i] != null){
                                            if (i == indice) {
                                                funcionario[i].AumentoSalario();
                                                i = 0;
                                                break;
                                            } 
                                        }
                                        else {
                                            Console.WriteLine("Funcionario não cadastrado. Tente novamente!");
                                        }
                                    }
                                #endregion
                                break;
                            }
                        #endregion

                        //Exibir total custo pagamento bruto
                        #region Total Liquido
                            case 5: {
                                float custosLiquidos = 0;
                                bool validar = false;
                                Console.WriteLine("--TOTAL DE CUSTOS LÍQUIDOS DA FOLHA");

                                //Calcula os custos do salario de todos os funcioinarios
                                for (int i = 0; i < 5; i++)
                                {
                                   if (funcionario[i] != null) {
                                       custosLiquidos += funcionario[i]; 
                                        validar = true;
                                   }
                                }
                                if (!validar) {
                                    Console.WriteLine("Nenhum funcionario cadastrado ainda!!");
                                }

                                Console.WriteLine($"Custos Líquidos:");
                                Console.ReadKey();
                                Console.WriteLine("Pressione enter para continuar");
                                break;
                            }
                        #endregion

                        //Sair
                        #region Sair
                            case 0: {
                                Console.WriteLine("Obrigado por utilizar nosso sistema!!");
                                break;
                            }
                        #endregion

                        default:{
                            Console.WriteLine("Valor Inválido");
                            break;
                        }
                    }
                #endregion
            } while (funcao != 0);           
        }

    }
}
