using System;

namespace Senai.Operadores.Logicos.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número de maçãs compradas:");
            double Macas = double.Parse(Console.ReadLine());
            
            if(Macas>=12){
                double Preco = 0.25 * Macas;
                Console.WriteLine($"Valor total da compra: {Preco.ToString("c")}");
            }else{
                double Preco = 0.30 * Macas;
                Console.WriteLine($"Valor total de compra: {Preco.ToString("c")}");
            }
        }
    }
}
