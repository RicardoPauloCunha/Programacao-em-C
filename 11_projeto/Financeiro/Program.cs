using System;
using Financeiro.Classes;

namespace Financeiro
{
    class Program
    {
        static void Main ()
        {
            Funcionario[] funcionarios = new Funcionario[1000];
            Console.WriteLine(FolhaDePagamento.INSS);

            string opcao;
            int quantidadeCadastros = 0;

            do {
                #region Menu
                Console.Clear();
                Console.WriteLine ("[1]. Cadastrar Funcionário");
                Console.WriteLine ("[2]. Exibir Folha de Pagamento");
                Console.WriteLine ("[3]. Total de custo bruto da folha");
                Console.WriteLine ("[4]. Aumento de salário");
                Console.WriteLine ("[5]. Total de custo líquido da folha\n");
                Console.WriteLine ("[0]. Sair");
                opcao = Console.ReadLine ();
                #endregion

                switch (opcao) {
                    case "1":
                        if (quantidadeCadastros < funcionarios.Length)
                        {
                            funcionarios[quantidadeCadastros] = new Funcionario ();

                            Console.WriteLine ("Informe o nome: ");
                            funcionarios[quantidadeCadastros].Nome = Console.ReadLine ();

                            Console.WriteLine ("Informe o salário: ");
                            funcionarios[quantidadeCadastros].Salario = double.Parse (Console.ReadLine ());

                            quantidadeCadastros++;
                        }
                        else
                            Console.WriteLine ("Erro. Quantidade máxima de usuários cadastrados");
                        break;
                    case "2":
                        int cont = 0;

                        foreach (Funcionario f in funcionarios)
                        {
                            if (f == null)
                                break;

                            Console.WriteLine ($"[{cont}] - Nome: {f.Nome}; Salário: {f.Salario}");
                            cont++;
                        }

                        Console.WriteLine ($"Escolha o usuario entre [0 - {quantidadeCadastros - 1}]");
                        int indice = int.Parse (Console.ReadLine ());

                        if (indice >= 0 && indice < quantidadeCadastros)
                            FolhaDePagamento.MostrarFolhaDePagamento (funcionarios[indice]);
                        else
                            Console.WriteLine ("Índice inválido");
                        break;
                    case "3":
                        double total = 0;

                        foreach (Funcionario f in funcionarios)
                        {
                            if (f == null)
                                break;

                            total += f.Salario;
                        }
                        Console.WriteLine ($"Total de salários brutos: {total}");
                        break;
                    case "4":
                        Console.WriteLine ($"Escolha o usuario entre [0 - {quantidadeCadastros - 1}]");
                        int indice2 = int.Parse (Console.ReadLine ());

                        if (indice2 >= 0 && indice2 < quantidadeCadastros)
                            FolhaDePagamento.AumentarSalario (funcionarios[indice2]);
                        else
                            Console.WriteLine ("Índice inválido");
                        break;
                    case "5":
                        double totalLiquido = 0;

                        foreach (Funcionario f in funcionarios) {
                            if (f == null)
                                break;

                            totalLiquido += f.Salario - FolhaDePagamento.CalcularDescontos(f.Salario);
                        }
                        Console.WriteLine ($"Total de salários brutos: {totalLiquido}");
                        break;
                    default:
                        Console.WriteLine ("Comando inválido");
                        break;
                }
                Console.ReadKey ();
            } while (opcao != "0");
        }
    }
}