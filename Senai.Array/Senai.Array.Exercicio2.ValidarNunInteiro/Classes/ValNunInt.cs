namespace Senai.Array.Exercicio2.ValidarNunInteiro.Classes
{
    public class ValNunInt
    {
        public class Numero {
        public float[] numeroA = new float[5];
        public int contador = 0;
        public bool validade;

        #region Metodos
            public bool ValTrueInt () {
                do {
                    validade = !(numeroA[contador] < 0);
                    contador++;
                    return validade;
                }while (contador <= numeroA.Length);
            }
        #endregion
        }
    }
}