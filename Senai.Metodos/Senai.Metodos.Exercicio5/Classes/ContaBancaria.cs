using System;
namespace Senai.Metodos.Exercicio5.Classes
{
    public class ContaBancaria
    {
        private float saldo;
        public string nome;
        public int CPF;

        #region Metodos
            public void Encher (float valor) {
                saldo += valor;
            }
            public void Esvaziar (float valor) {
                saldo -= valor;
            }
            public void ExibirQuantia () {
                Console.WriteLine($"Quantidade de saldo na garrafa: {saldo}");
            }
        #endregion
    }
}