using System;
namespace Senai.Projeto.Financeiro.Classes
{
    public class Funcionario
    {
        //Declaração variaveis
        public string nome { get; set; }
        public float salario { get; set; }
        #region Metodos

            public float[] RetornaValoresSalario(){
                float[] valores = new float[5];

                #region Calculo
                    //inss
                    valores[0] = (salario * 11.0f) / 100;
                    //irff
                    valores[1] = (salario * 7.5f) / 100;
                    //vale trasporte
                    valores[2] = (salario * 6) / 100;
                    //total do desconto
                    valores[3] = valores[0] + valores[1] + valores[2];
                    //salario atual
                    valores[4] = salario - valores[3];
                #endregion

                return valores;

            }
            public void FolhaPagamento () {
                
                float[] valores = RetornaValoresSalario();

                //Calcula os descontos e o salario liquido do funcionario
               
                //Exibi os resulados dos calculos do salario
                #region Exibir Resultado Calculo
                    Console.WriteLine("--FOLHA DE PAGAMENTO--");
                    Console.WriteLine("Funcionario: " + nome);
                    Console.WriteLine("Salário Bruto: " + salario.ToString("c"));
                    Console.WriteLine("Desconto INSS(11,0%): " + valores[0].ToString("c"));
                    Console.WriteLine("Desconto IRFF(7,5%): " + valores[1].ToString("c"));
                    Console.WriteLine("Desconto Vale Transporte(6%): " + valores[2].ToString("c"));
                    Console.WriteLine("Total de Desconto:" + valores[3].ToString("c"));
                    Console.WriteLine("Salário Líquido: " + valores[4].ToString("c"));
                    Console.ReadKey();
                    Console.WriteLine("Pressione enter para continuar");
                #endregion
            }

            public void AumentoSalario () {
                float salarioMin = 834.50f;
                float salarioAum;
                if (salario <= (salarioMin * 2)){
                    salarioAum = (salario * 15) / 100;
                    salario += salarioAum;

                    Console.WriteLine("Aumento de 15% no salário: " + salarioAum.ToString("c"));
                    Console.WriteLine("Salário atual: " + salario.ToString("c")); 
                }
                if (salario <= (salarioMin * 4) && salario > (salarioMin * 2)){
                    salarioAum = (salario * 10) / 100;
                    salario += salarioAum;

                    Console.WriteLine("Aumento de 10% no salário: " + salarioAum.ToString("c"));
                    Console.WriteLine("Salário atual: " + salario.ToString("c"));
                }
                if (salario <= (salarioMin * 8) && salario > (salarioMin * 4)){
                    salarioAum = (salario * 8) / 100;
                    salario += salarioAum;

                    Console.WriteLine("Aumento de 8% no salário: " + salarioAum.ToString("c"));
                    Console.WriteLine("Salário atual: " + salario.ToString("c"));
                }
                if (salario > (salarioMin * 8)) {
                    salarioAum = (salario * 5) / 100;
                    salario += salarioAum;

                    Console.WriteLine("Aumento de 5% no salário: " + salarioAum.ToString("c"));
                    Console.WriteLine("Salário atual: " + salario.ToString("c"));
                }
                Console.ReadKey();
                Console.WriteLine("Pressione enter para continuar");
            }
        #endregion
    }
}