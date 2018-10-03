using System;

namespace Senai.Operadores.Logicos.Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //coleta o dados do poligono
            Console.WriteLine("Insira o numero de lados do poligono regular");
            int NumeroLado = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a medida do um dos lados do poligono regular:");
            double MedidaLado = double.Parse(Console.ReadLine());

            //verifica e determina qual é o tipo de poligono e sua area
            if(NumeroLado==3){
                Console.WriteLine($"TRIÂNGULO, área: {(MedidaLado * MedidaLado) / 2}");
            }else if(NumeroLado==4){
                Console.WriteLine($"QUADRADO, área: {Math.Pow(MedidaLado, 2)}");
            }else if(NumeroLado==5){
                Console.WriteLine("PENTÁGONO");
            }else{
                Console.WriteLine("Forma geometrica não identificada, insira outra quantidade de lados");
            }
        }    
    }
}
