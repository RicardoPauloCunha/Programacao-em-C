using System;
namespace Senai.Metodos.Exercicio1.Classes
{
    public class Calculadora
    {
        #region Metodos
            public double Somar (double valor1, double valor2) {
                double resultado = valor1 + valor2;
                Console.WriteLine($"A soma dos dois valos é: {resultado}");
                return resultado; 
            }

            public double Subtrair (double valor1, double valor2) {
                double resultado = valor1 - valor2;
                Console.WriteLine($"A subtração dos dois valos é: {resultado}");
                return resultado;
            }

            public double Multiplicar (double valor1, double valor2) {
                double resultado = valor1 * valor2;
                Console.WriteLine($"A multiplicação dos dois valos é: {resultado}");
                return resultado;
            }

            public double Dividir (double valor1, double valor2) {
                double resultado = valor1 / valor2;
                Console.WriteLine($"A divisão dos dois valos é: {resultado}");
                return resultado;
            }
        #endregion
        }
    }
