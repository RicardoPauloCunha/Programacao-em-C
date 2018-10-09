using System;
namespace Senai.Metodos.Exercicio.Exemplo.Classes
{
    public class Calculo
    {
        public class Retangulo {
            public double ladoA;
            public double ladoB;

            #region Area
                public double CalculaArea(){
                double area = ladoA * ladoB;

                return area;
            }
            #endregion

            #region Perimetro
                public double CalcularPerimetro(){
                double perimetro = ladoA + ladoB + ladoA + ladoB;

                return perimetro;
            #endregion
            }
            
        }
    }
}