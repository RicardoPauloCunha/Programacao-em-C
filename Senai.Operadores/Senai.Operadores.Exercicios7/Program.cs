using System;

namespace Senai.Operadores.Exercicios7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            decimal valorDolar;
            decimal valorReal;
            decimal conversaoDolarReal;
            Console.WriteLine("Informe um valor em US$(Dolar):");
            valorDolar = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe um valor em R$(Real):");
            valorReal = decimal.Parse(Console.ReadLine());
            conversaoDolarReal = valorDolar * valorReal;
            Console.WriteLine($"US$ {valorDolar} * R$ {valorReal} = {conversaoDolarReal}");
            #endregion
        }
    }
}
