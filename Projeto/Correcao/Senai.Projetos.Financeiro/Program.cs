using System;
using Senai.Projetos.Financeiro.Classes;

namespace Senai.Projetos.Financeiro {
    class Program {
        static void Main (string[] args) {
            //Criando o nosso vetor
            Funcionario[] funcionarios = new Funcionario[1000];
            System.Console.WriteLine (FolhaDePagamento.INSS);

            string comando = null;
            int quantidadeDeCadastros = 0;

            do {
                //Limpa o menu
                Console.Clear ();

                #region Menu
                Console.WriteLine ("[1]. Cadastrar Funcionário");
                Console.WriteLine ("[2]. Exibir Folha de Pagamento");
                Console.WriteLine ("[3]. Total de custo bruto da folha");
                Console.WriteLine ("[4]. Aumento de salário");
                Console.WriteLine ("[5]. Total de custo líquido da folha\n");
                Console.WriteLine ("[0]. Sair");
                comando = Console.ReadLine ();
                #endregion

                switch (comando) {
                    #region Cadastro de usuário
                    case "1":
                        if (quantidadeDeCadastros < funcionarios.Length) {
                            //Instancia do funcionario
                            funcionarios[quantidadeDeCadastros] = new Funcionario ();

                            //Recebendo o nome
                            Console.WriteLine ("Informe o nome: ");
                            funcionarios[quantidadeDeCadastros].Nome = Console.ReadLine ();

                            //Recebendo o salario
                            Console.WriteLine ("Informe o salário: ");
                            funcionarios[quantidadeDeCadastros].Salario = double.Parse (Console.ReadLine ());

                            //Incrementa a quantidade
                            quantidadeDeCadastros++;
                        } else {
                            System.Console.WriteLine ("Erro. Quantidade máxima de usuários cadastrados");
                        }

                        break;
                        #endregion

                        #region Folha de pagamento

                    case "2":

                        //Exibindo os funcionarios
                        int cont = 0;
                        foreach (Funcionario f in funcionarios) {
                            //Verificando se o f for diferete de nulo
                            if (f == null) break;

                            Console.WriteLine ($"[{cont}] - Nome: {f.Nome}; Salário: {f.Salario}");
                            cont++;
                        }

                        System.Console.WriteLine ($"Escolha o usuario entre [0 - {quantidadeDeCadastros - 1}]");
                        int indice = int.Parse (Console.ReadLine ());

                        if (indice >= 0 && indice < quantidadeDeCadastros) {
                            FolhaDePagamento.MostrarFolhaDePagamento (funcionarios[indice]);
                        } else {
                            System.Console.WriteLine ("Índice inválido");
                        }

                        break;

                        #endregion

                        #region Salario Bruto
                    case "3":
                        double total = 0;
                        //Percorre a lista de funcionarios
                        foreach (Funcionario f in funcionarios) {
                            //Verificando se o funcionario e nulo
                            if (f == null) {
                                break;
                            }

                            //Realiza a soma dos salarios
                            total += f.Salario;
                        }
                        System.Console.WriteLine ($"Total de salários brutos: {total}");
                        break;
                        #endregion

                    case "4":
                        System.Console.WriteLine ($"Escolha o usuario entre [0 - {quantidadeDeCadastros - 1}]");
                        int indice2 = int.Parse (Console.ReadLine ());

                        if (indice2 >= 0 && indice2 < quantidadeDeCadastros) {
                            FolhaDePagamento.AumentarSalario (funcionarios[indice2]);
                        } else {
                            System.Console.WriteLine ("Índice inválido");
                        }
                        break;

                    case "5":
                        double totalLiquido = 0;
                        //Percorre a lista de funcionarios
                        foreach (Funcionario f in funcionarios) {
                            //Verificando se o funcionario e nulo
                            if (f == null) {
                                break;
                            }

                            //Realiza a soma dos salarios
                            totalLiquido += f.Salario - FolhaDePagamento.CalcularDescontos(f.Salario);
                        }
                        System.Console.WriteLine ($"Total de salários brutos: {totalLiquido}");
                        break;
                    default:
                        Console.WriteLine ("Comando inválido");

                        break;
                }

                Console.ReadKey ();

            } while (comando != "0");
        }
    }
}