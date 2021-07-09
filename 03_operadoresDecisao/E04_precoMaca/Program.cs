using System;

namespace E04_precoMaca
{
    class Program
    {
        static void Main()
        {
            const double PRECO1 = 0.25;
            const double PRECO2 = 0.30;

            Console.WriteLine("Insira o número de maçãs compradas:");
            int macas = int.Parse(Console.ReadLine());
            
            if (macas >= 12)
            {
                double preco = PRECO1 * macas;
                Console.WriteLine($"Valor total da compra: {preco.ToString("c")}");
            }
            else
            {
                double preco = PRECO2 * macas;
                Console.WriteLine($"Valor total de compra: {preco.ToString("c")}");
            }
        }
    }
}
