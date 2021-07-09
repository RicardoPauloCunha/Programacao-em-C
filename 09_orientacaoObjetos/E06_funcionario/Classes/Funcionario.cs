namespace E06_funcionario.Classes
{
    public class Funcionario
    {
        public string Nome;
        public int HorasTrabalhadas;
        public double ValorHora;

        public double CalcularValorProjeto()
        {
            double total = ValorHora * HorasTrabalhadas;
            return total;
        }
    }
}