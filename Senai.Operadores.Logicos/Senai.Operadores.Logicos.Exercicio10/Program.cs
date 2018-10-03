using System;

namespace Senai.Operadores.Logicos.Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //pergunta qual a conversão que ser quer fazer
            Console.WriteLine("Converter graus Celsius para Fahrenheit(TRUE), concverter Fahrenheit para Celsius(FALSE)");
            bool Convercao = bool.Parse(Console.ReadLine());

            //verifica a converesão escolhida e calcula a concersão
            if(Convercao==true){
                Console.WriteLine("Insira os medida em graus Celsius:");
                double Celsius = double.Parse(Console.ReadLine());
                double Fahrenheit = Celsius * 1.8 + 32;
                Console.WriteLine($"A medida e Fahrenheit é: {Fahrenheit}");
            }else if(Convercao==false){
                Console.WriteLine("Insira os medida em Fahrenheit:");
                double Fahrenheit = double.Parse(Console.ReadLine());
                double Celsius = Fahrenheit * 1.8 + 32;
                Console.WriteLine($"A medida e graus Celsius é: {Celsius}");
            }else{
                Console.WriteLine("Valor invalido, por favor insira TRUE para Fahrenheit, e FALSE para graus Celsius");
            }
        }
    }
}
