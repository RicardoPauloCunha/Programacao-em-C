using System;

namespace Senai.Swith.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coleta os dados da pessoa, como salario minimo, horas trabalhadas, dependetes e horas extras.
            Console.WriteLine("Informe o Salário Mínimo:");
            double SalarioMin = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de Horas Trabalhadas:");
            int HoraTrabalhada = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de Dependentes:");
            int Dependente = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de Horas Extras");
            int HoraExtra = int.Parse(Console.ReadLine());

            //Calcular salario bruto
            double ValorHT = (SalarioMin * 0.5) / 100;
            double ValorSalarioMensal = HoraTrabalhada * ValorHT;
            double ValorHE = ((ValorHT * 50) / 100) + ValorHT;
            double ValorDp = Dependente * 64.00;

            //Calculo do salario bruto
            double ValorSalarioBruto = ValorSalarioMensal + ValorDp + ValorHE;

            //Teste para ver o resultado
            Console.WriteLine($"Salario Minino: {SalarioMin.ToString("c")}");
            Console.WriteLine("---Dados dos Calculos---");
            Console.WriteLine($"Valor Horas Trabalhadas: {ValorHT.ToString("c")}");
            Console.WriteLine($"Valor do Salario Bruto: {ValorSalarioMensal.ToString("c")}");
            Console.WriteLine($"Valor das Horas Extras: {ValorHE.ToString("c")}");
            Console.WriteLine($"Valor dos Dependentes: {ValorDp.ToString("c")}");
            Console.WriteLine($"Valor do Salario Bruto: {ValorSalarioBruto.ToString("c")}");
            Console.WriteLine("---Fim Dados dos Calculos---");
            //fim teste

            //Calcular impostos
            if(ValorSalarioBruto>0&&ValorSalarioBruto<1750){
                double Impostos = (ValorSalarioBruto * 0) / 100; 
                double ValorSalarioLiquido = ValorSalarioBruto - Impostos;

                //teste para ver o resultado
                Console.WriteLine("---Dados Impostos---");
                Console.WriteLine($"Valor Impostos{Impostos.ToString("c")}");
                Console.WriteLine($"Valor Liquido{ValorSalarioLiquido.ToString("c")}");
                Console.WriteLine("---Fim Dados Impostos---");
                //fim teste
                
                if(ValorSalarioLiquido<1500){ 
                    double SalarioFinal = ValorSalarioLiquido + 400.00;
                    Console.WriteLine($"Salário final: {SalarioFinal.ToString("c")}"); 
                }else if(ValorSalarioLiquido>1500){
                    double SalarioFinal = ValorSalarioLiquido + 200.00;
                    Console.WriteLine($"Salário final: {SalarioFinal.ToString("c")}");
                }
            }else if(ValorSalarioBruto>1750&&ValorSalarioBruto<2500){
                double Impostos = (ValorSalarioBruto * 10) / 100; 
                double ValorSalarioLiquido = ValorSalarioBruto - Impostos;

                //teste para ver o resultado
                Console.WriteLine("---Dados Impostos---");
                Console.WriteLine($"Valor Impostos{Impostos.ToString("c")}");
                Console.WriteLine($"Valor Liquido{ValorSalarioLiquido.ToString("c")}");
                Console.WriteLine("---Fim Dados Impostos---");
                Console.WriteLine("");
                //fim teste

                //Calculando valor final
                if(ValorSalarioLiquido<1500){ 
                    double SalarioFinal = ValorSalarioLiquido + 400.00;
                    Console.WriteLine($"Salário final: {SalarioFinal.ToString("c")}"); 
                }else if(ValorSalarioLiquido>1500){
                    double SalarioFinal = ValorSalarioLiquido + 200.00;
                    Console.WriteLine($"Salário final: {SalarioFinal.ToString("c")}");
                }

            //Calculando Impostos    
            }else if(ValorSalarioBruto>2500){
                double Impostos = (ValorSalarioBruto * 20) / 100;
                double ValorSalarioLiquido = ValorSalarioBruto - Impostos;

                //teste para ver o resultado
                Console.WriteLine("---Dados Impostos---");
                Console.WriteLine($"Valor Impostos{Impostos.ToString("c")}");
                Console.WriteLine($"Valor Liquido{ValorSalarioLiquido.ToString("c")}");
                Console.WriteLine("---Fim Dados Impostos---");
                Console.WriteLine("");
                //fim teste
                
                //Calculando valor final
                if(ValorSalarioLiquido<1500){ 
                    double SalarioFinal = ValorSalarioLiquido + 400.00; 
                    Console.WriteLine($"Salário final: {SalarioFinal.ToString("c")}");
                }else if(ValorSalarioLiquido>1500){
                    double SalarioFinal = ValorSalarioLiquido + 250.00;
                    Console.WriteLine($"Salário final: {SalarioFinal.ToString("c")}");
                }
            //Valor inválido
            }else{
                Console.WriteLine("Valor Inválido");
            }
        }
    }
}
