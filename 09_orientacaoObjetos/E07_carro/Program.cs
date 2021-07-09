using E07_carro.Classes;
using System;

namespace E07_carro
{
    class Program
    {
        static void Main()
        {
            #region Carro 1
            Carro carro1 = new Carro();

            carro1.Ligar();
            carro1.Andar(125);
            carro1.Andar(200);
            carro1.Andar(125);
            carro1.Andar(3);
            carro1.Andar(50);

            Console.WriteLine("Nível do tanque " + carro1.NivelTanque);
            Console.WriteLine("Total km " + carro1.Rodometro);
            #endregion

            #region Carro 2
            Carro corsa = new Carro();

            corsa.Ligar();
            float nivel = corsa.Abastecer(20);
            nivel = corsa.Abastecer(25);

            Console.WriteLine("Tanque " + nivel);

            corsa.CapacidadeTanque = 45;
            corsa.PotenciaMotor = 1.0f;
            corsa.KilometroLitro = 15;
            corsa.Andar(20);

            Console.WriteLine(corsa.NivelTanque);
            #endregion
        }
    }
}
