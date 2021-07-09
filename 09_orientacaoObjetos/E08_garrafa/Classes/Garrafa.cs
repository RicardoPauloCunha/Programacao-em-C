using System;
namespace E08_garrafa.Classes
{
    public class Garrafa
    {
        private float conteudo = 1000;

        public void Encher(float qtd)
        {
            conteudo += qtd;
        }

        public void Esvaziar(float qtd)
        {
            conteudo -= qtd;
        }

        public void ExibirQuantia()
        {
            Console.WriteLine($"Quantidade de conteudo na garrafa: {conteudo}");
        }
    }
}