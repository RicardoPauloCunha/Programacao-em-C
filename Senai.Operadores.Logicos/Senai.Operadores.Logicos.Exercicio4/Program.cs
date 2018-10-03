using System;

namespace Senai.Operadores.Logicos.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita o número do maçãs compradas
            Console.WriteLine("Insira o número de maçãs compradas:");
            int Macas = int.Parse(Console.ReadLine());
            
            //verifica o número de maçãs compradas e calcula o preço total
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
