using System;

namespace E07_converterMoeda
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe um valor em US$(Dolar):");
            decimal valorDolar = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor em R$(Real):");
            decimal valorReal = decimal.Parse(Console.ReadLine());

            decimal conversaoDolarReal = valorDolar * valorReal;

            Console.WriteLine($"US$ {valorDolar} * R$ {valorReal} = {conversaoDolarReal}");
        }
    }
}
