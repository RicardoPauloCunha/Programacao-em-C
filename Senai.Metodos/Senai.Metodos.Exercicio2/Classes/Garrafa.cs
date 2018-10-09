using System;
namespace Senai.Metodos.Exercicio2.Classes
{
    public class Garrafa
    {
        private float conteudo = 1000;

        #region Metodos
            public void Encher (float qtd) {
                conteudo += qtd;
            }
            public void Esvaziar (float qtd) {
                conteudo -= qtd;
            }
            public void ExibirQuantia () {
                Console.WriteLine($"Quantidade de conteudo na garrafa: {conteudo}");
            }
        #endregion
    }
}