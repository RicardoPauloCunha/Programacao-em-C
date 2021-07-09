using System;

namespace E09_contaBancaria.Classes
{
    public class ContaBancaria
    {
        private float saldo;
        public string nome;
        public int CPF;

        public void Depositar(float valor) {
            saldo += valor;
        }

        public void Sacar(float valor) {
            saldo -= valor;
        }

        public void ExibirSaldo() {
            Console.WriteLine($"Saldo na conta: {saldo}");
        }
    }
}