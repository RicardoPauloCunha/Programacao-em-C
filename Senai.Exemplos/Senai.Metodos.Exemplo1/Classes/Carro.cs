using System;

namespace Senai.Metodos.Exemplo1.Classes {
    public class Carro {
        //Declaração de variaveis da Classe Carro
        #region Atributos
        public float Odometro;
        public float PotenciaDoMotor = 1.0f;
        public float KilometroPorLitro = 10;
        public float NivelTanque = 0;
        public float CapacidadeTanque = 40;
        public bool Ligado = false;
        #endregion

        #region Metodos
        /// <summary>
        /// Liga o carro
        /// </summary>
        public void Ligar () {
            Console.WriteLine("Carro Ligado");
            Ligado = true;
        }

        /// <summary>
        /// Faz o carro andar
        /// </summary>
        /// <param name="kilometragem">Informe a kilometragem percorrida</param>
        public void Andar(float kilometragem){
            if (Ligado){
                //Calculo do consumo de litros por km
                float consumo = kilometragem / KilometroPorLitro;
                if (NivelTanque >= consumo){
                    //Retira o consumo do nível do tanque
                    NivelTanque -= consumo;
                    //Acrescenta a kilometragem informada ao atributo odometro
                    Odometro += kilometragem;
                    System.Console.WriteLine($"Andou e consumiu {consumo}l" );
                } else {
                    System.Console.WriteLine("Carro sem combustível, abasteça.");
                }  
            }
            else {
                System.Console.WriteLine("Ligue o carro");
            }
        }

        /// <summary>
        /// Abastece o carro
        /// </summary>
        /// <param name="quantidade">Informe a quantidade de litros</param>
        /// <returns>Retorna o nível do tanque</returns>
        public float Abastecer(float quantidade){
            NivelTanque += quantidade;
            return NivelTanque;
        } 
        #endregion
    }
}