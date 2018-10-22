using System;
namespace Senai.Projeto.Financeiro.Classes {
    public class Funcionario {
        //Declaração variaveis
        public string Nome { get; set; }
        public float Salario { get; set; }

        #region Metodos
        public float[] RetornaValoresSalario () {
            float[] valores = new float[5];

            //Calcula os descontos e o salario liquido do funcionario
            #region Calculo
            //inss
            valores[0] = (Salario * 11.0f) / 100;
            //irrf
            valores[1] = (Salario * 7.5f) / 100;
            //vale trasporte
            valores[2] = (Salario * 6) / 100;
            //total do desconto
            valores[3] = valores[0] + valores[1] + valores[2];
            //salario atual
            valores[4] = Salario - valores[3];
            #endregion

            return valores;
        }

        public void FolhaPagamento () {
            float[] valores = RetornaValoresSalario ();

            //Exibi os resulados dos calculos do salario
            #region Exibir Resultado Calculo
            Console.WriteLine ("--FOLHA DE PAGAMENTO--");
            Console.WriteLine ("Funcionario: " + Nome);
            Console.WriteLine ("Salário Bruto: " + Salario.ToString ("c"));
            Console.WriteLine ("Desconto INSS(11,0%): " + valores[0].ToString ("c"));
            Console.WriteLine ("Desconto IRFF(7,5%): " + valores[1].ToString ("c"));
            Console.WriteLine ("Desconto Vale Transporte(6%): " + valores[2].ToString ("c"));
            Console.WriteLine ("Total de Desconto:" + valores[3].ToString ("c"));
            Console.WriteLine ("Salário Líquido: " + valores[4].ToString ("c"));
            Console.WriteLine ("Pressione enter para continuar");
            Console.ReadKey ();
            #endregion
        }

        public void AumentoSalario () {
            Console.WriteLine ("Salário: " + Salario.ToString ("c"));

            //Calcula a quantidade de aumento baseado no salario
            const float salarioMin = 834.50f;
            float salarioAum;

            //Aumento para salários de até 2 salario minimo
            if (Salario <= (salarioMin * 2)) {
                salarioAum = (Salario * 15) / 100;
                Salario += salarioAum;

                Console.WriteLine ("Aumento de 15% no salário: " + salarioAum.ToString ("c"));
                Console.WriteLine ("Salário atual: " + Salario.ToString ("c"));
            }

            //Aumento para salários de até 4 salario minimo
            else if (Salario <= (salarioMin * 4) && Salario > (salarioMin * 2)) {
                salarioAum = (Salario * 10) / 100;
                Salario += salarioAum;

                Console.WriteLine ("Salário: " + Salario.ToString ("c"));
                Console.WriteLine ("Aumento de 10% no salário: " + salarioAum.ToString ("c"));
                Console.WriteLine ("Salário atual: " + Salario.ToString ("c"));
            }

            //Aumento para salários de até 8 salario minimo
            else if (Salario <= (salarioMin * 8) && Salario > (salarioMin * 4)) {
                salarioAum = (Salario * 8) / 100;
                Salario += salarioAum;

                Console.WriteLine ("Salário: " + Salario.ToString ("c"));
                Console.WriteLine ("Aumento de 8% no salário: " + salarioAum.ToString ("c"));
                Console.WriteLine ("Salário atual: " + Salario.ToString ("c"));
            }

            //Aumento para salários acima de 8 salario minimo
            else if (Salario > (salarioMin * 8)) {
                salarioAum = (Salario * 5) / 100;
                Salario += salarioAum;

                Console.WriteLine ("Salário: " + Salario.ToString ("c"));
                Console.WriteLine ("Aumento de 5% no salário: " + salarioAum.ToString ("c"));
                Console.WriteLine ("Salário atual: " + Salario.ToString ("c"));
            }
            Console.WriteLine ("Pressione enter para continuar");
            Console.ReadKey ();
        }

        public void AlterarCadastro () {
            Console.WriteLine ("Alterar: 1- Nome, 2 - Salario");
            string opcao = Console.ReadLine ();
            switch (opcao) {
                case "1":
                    {
                        Console.WriteLine ("Insira o novo nome do funcionario");
                        Nome = Console.ReadLine ();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine ("Insira o novo salário do funcionario");
                        Salario = int.Parse (Console.ReadLine ());
                        break;
                    }
                default:
                    {
                        Console.WriteLine ("Valor Inválido");
                        break;
                    }
            }
        }
        #endregion
    }
}