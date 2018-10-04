using System;
using Senai.Lacos.Repiticao.Exemplo2.Classes;

namespace Senai.Lacos.Repiticao.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            char Resposta = 'S';

            while (Resposta == 'S' || Resposta == 's')
            {
                Console.WriteLine("Qual a tabuada que deseja calcular?");
                calculadora.Fator = int.Parse(Console.ReadLine());

                calculadora.Contador = 0;

                //Criando o laço while
                while (calculadora.Contador <= 10)
                {
                    calculadora.Valor = calculadora.Fator * calculadora.Contador;
                    Console.WriteLine($"{calculadora.Fator} X {calculadora.Contador} = {calculadora.Valor}");

                    calculadora.Contador++;
                }

                //Pergunatando se ele deseja fazer outra tabuada
                Console.WriteLine("Deseja criar uma outra tabuada? [S/N]");
                Resposta = char.Parse(Console.ReadLine());

                //Convertendo o caractere para MAIUSCULA
                Resposta = char.ToUpper(Resposta);
            }
        }
    }
}
