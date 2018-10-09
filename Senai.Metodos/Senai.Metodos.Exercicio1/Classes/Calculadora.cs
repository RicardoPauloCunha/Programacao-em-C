using System;
namespace Senai.Metodos.Exercicio.Exemplo.Classes
{
    public class Calculo
    {
        public class Calculadora {
            public float Valor1;
            public float Valor2;

            #region Area
                public float CalculaArea(){
                float area = ladoA * ladoB;

                return area;
            }
            #endregion

            #region Perimetro
                public float CalcularPerimetro(){
                float perimetro = ladoA + ladoB + ladoA + ladoB;

                return perimetro;
            #endregion
            }
            
        }
    }
}