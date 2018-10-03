using System;

namespace Senai.Operadores.Logicos.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita os quatro números
            Console.WriteLine("Insira o primeiro número:");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            int Numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número:");
            int Numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o quarto número:");
            int Numero4 = int.Parse(Console.ReadLine());

            //calcula para obter o resto da divisão
            int DivDois1 = Numero1 % 2;
            int DivTres1 = Numero1 % 3;

            int DivDois2 = Numero2 % 2;
            int DivTres2 = Numero2 % 3;

            int DivDois3 = Numero3 % 2;
            int DivTres3 = Numero3 % 3;

            int DivDois4 = Numero4 % 2;
            int DivTres4 = Numero4 % 3;

            //verifica se o número é divisivél por 2 ou 3, baseado no resto da divisão
            if(DivDois1==0){
                Console.WriteLine($"{Numero1} é divisível por 2");
            }else if(DivTres1==0){
                Console.WriteLine($"{Numero1} é divisível por 3");
            }else{
                Console.WriteLine($"{Numero1} só é divisivel por ele mesmo");
            }

            if(DivDois2==0){
                Console.WriteLine($"{Numero2} é divisível por 2");
            }else if(DivTres2==0){
                Console.WriteLine($"{Numero2} é divisível por 3");
            }else{
                Console.WriteLine($"{Numero2} só é divisivel por ele mesmo");
            }

            if(DivDois3==0){
                Console.WriteLine($"{Numero3} é divisível por 2");
            }else if(DivTres3==0){
                Console.WriteLine($"{Numero3} é divisível por 3");
            }else{
                Console.WriteLine($"{Numero3} só é divisivel por ele mesmo");
            }

            if(DivDois4==0){
                Console.WriteLine($"{Numero4} é divisível por 2");
            }else if(DivTres4==0){
                Console.WriteLine($"{Numero4} é divisível por 3");
            }else{
                Console.WriteLine($"{Numero4} só é divisivel por ele mesmo");
            }
        }
    }
}
