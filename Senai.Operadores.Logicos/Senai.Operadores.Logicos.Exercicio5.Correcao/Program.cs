using System;

namespace Senai.Operadores.Logicos.Exercicio5.Correcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número:");
            int Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            int Valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número:");
            int Valor3 = int.Parse(Console.ReadLine());

            //verifica se o valor1 é maior que o valor valor2 "E"
            //valor1 é maior que valor3, neste caso
            //valor1 é maior que todos
            if(Valor1>Valor2&&Valor1>Valor3){
                //verifica se o valor2 é maior que valor3
                //mostra valor3, valor2 e valor 1
                //senão mostrar valor2, valor3 e valor 1
                if(Valor2>Valor3){
                    Console.WriteLine($"{Valor3}, {Valor2}, {Valor1}");
                }else{
                    Console.WriteLine($"{Valor2}, {Valor3}, {Valor1}");
                }
            //verifica se o valor2 é maior que valor "E"
            //valor2 é maior que valor3, neste caso
            //valor2 é maior
            }else if(Valor2>Valor1&&Valor2>Valor3){
                if(Valor3>Valor1){
                    Console.WriteLine($"{Valor1}, {Valor3}, {Valor2}");
                }else{
                    Console.WriteLine($"{Valor3}, {Valor1}, {Valor2}");
                }
            }else{
                //case entre neste bloco valor3 é maior que valor1 e 2
                //verifica se o valor é maior que valor2
                //se sim mostra valor2, valor1 e valor3
                //senão mostra valor1, valor2, valor3
                if(Valor1>Valor2){
                    Console.WriteLine($"{Valor2}, {Valor1}, {Valor3}");
                }else{
                    Console.WriteLine($"{Valor1}, {Valor2}, {Valor3}");
                }
            }
        }
    }
}
