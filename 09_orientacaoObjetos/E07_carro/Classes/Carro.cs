using System;

namespace E07_carro.Classes
{
    public class Carro
    {
        public float Rodometro { get; set; }
        public float PotenciaMotor { get; set; }
        public float KilometroLitro { get; set; }
        public float NivelTanque { get; private set; }
        public float CapacidadeTanque { get; set; }

        public bool Ligado = false;

        /// <summary>
        /// Liga o carro
        /// </summary>
        public void Ligar ()
        {
            Console.WriteLine("Carro Ligado");
            Ligado = true;
        }

        /// <summary>
        /// Faz o carro andar
        /// </summary>
        /// <param name="kilometragem">Informe a kilometragem percorrida</param>
        public void Andar(float kilometragem)
        {
            if (Ligado)
            {
                float consumo = kilometragem / KilometroLitro;

                if (NivelTanque >= consumo)
                {
                    NivelTanque -= consumo;
                    Rodometro += kilometragem;
                    Console.WriteLine($"Andou e consumiu {consumo}l" );
                }
                else
                {
                    Console.WriteLine("Carro sem combustível, abasteça.");
                }  
            }
            else
            {
                Console.WriteLine("Ligue o carro");
            }
        }

        /// <summary>
        /// Abastece o carro
        /// </summary>
        /// <param name="quantidade">Informe a quantidade de litros</param>
        /// <returns>Retorna o nível do tanque</returns>
        public float Abastecer(float quantidade)
        {
            NivelTanque += quantidade;
            return NivelTanque;
        } 
    }
}