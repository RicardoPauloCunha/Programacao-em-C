using System;

namespace Senai.Operadores.Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area de um Retangulo
            float Base;
            float Altura;
            float Area;

            Console.WriteLine("Informe a medida da base:");
            Base = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a medida da altura:");
            Altura = float.Parse(Console.ReadLine());

            Area = Base * Altura;

            Console.WriteLine($"Àrea = {Area}");
            #endregion
        }
    }
}
