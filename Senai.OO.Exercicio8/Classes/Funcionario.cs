namespace Senai.OO.Exercicio8.Classes
{
    public class Funcionario
    {
        public string Nome;
        public int HorasTrabalhadas;
        public double ValorHora;
        #region Metodos
            public double CalcularValorProjeto()
            {
                //Calculando o total atraves dos atributos
                double total = ValorHora * HorasTrabalhadas;
                return total;
            }
        #endregion
    }
}