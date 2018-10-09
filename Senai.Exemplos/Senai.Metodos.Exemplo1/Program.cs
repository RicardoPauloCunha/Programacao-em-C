using System;
using Senai.Metodos.Exemplo1.Classes;

namespace Senai.Metodos.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            // carro1.NivelTanque = 50;
            carro1.Ligar();
            carro1.Andar(125);
            carro1.Andar(200);
            carro1.Andar(125);
            carro1.Andar(3);
            carro1.Andar(50);
            System.Console.WriteLine("Nível do tanque " + carro1.NivelTanque);
            System.Console.WriteLine("Total km " + carro1.Odometro);

            Carro corsa = new  Carro();
            corsa.Ligar();
            float Nivel = corsa.Abastecer(20);
            Nivel = corsa.Abastecer(25);
            System.Console.WriteLine("Tanque " + Nivel );

            corsa.CapacidadeTanque = 45;
            corsa.PotenciaDoMotor = 1.0f;
            //corsa.NivelTanque = 45;
            corsa.KilometroPorLitro = 15;
            corsa.Andar(20);
            System.Console.WriteLine(corsa.NivelTanque);


        }
    }
}
