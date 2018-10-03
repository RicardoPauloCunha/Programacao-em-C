using System;

namespace Senai.Operadores.Logicos.Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOGICA ERRADO
            //Não utilizei ++(incremento) e --(Decremento)
            Console.WriteLine("Insira o primeiro número");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            int Numero2 = int.Parse(Console.ReadLine());

            int Resultado = Numero1 + Numero2;
        
            if(Resultado>10){
                Resultado = Resultado + 8;
                Console.WriteLine($"O resultado é : {Resultado}");
            }else if(Resultado<=20){
                Resultado = Resultado - 5;
                Console.WriteLine($"O resultado é : {Resultado}");
            }
        }
    }
}
