using System;

namespace E14_areasObjetos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Coloque: 1 para QUADRADO, 2 PARA TRIÂNGUGLO E 3 PARA CÍRCULO:");
            int objeto = int.Parse(Console.ReadLine());

            switch (objeto)
            {
                case 1:
                    Console.WriteLine("Informe a medida de um dos lados do quadrao:");
                    double MedidaQuad = double.Parse(Console.ReadLine());

                    double AreaQuad = MedidaQuad * MedidaQuad;

                    Console.WriteLine($"Àrea do quadrado: {AreaQuad}");
                    break;
                case 2:
                    Console.WriteLine("Informe a altura do triângulo:");
                    double AlturaTria = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a medida da base do triângulo:");
                    double BaseTria = double.Parse(Console.ReadLine());

                    double AreaTria = (BaseTria * AlturaTria) / 2;

                    Console.WriteLine($"Àrea do triângulo: {AreaTria}");
                    break;
                case 3:
                    Console.WriteLine("Informe a medida do raio do círculo:");
                    double RaioCirc = double.Parse(Console.ReadLine());

                    double AreaCirc = 3.14 * RaioCirc * RaioCirc;

                    Console.WriteLine($"Àrea do círculo: {AreaCirc}");
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
        }
    }
}
