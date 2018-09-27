using System;

namespace Senai.Operadores.Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Imc Pessoa 1
            Console.WriteLine("Informe a altura da primeira pessoa:");
            float alturaPessoa1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu Peso:");
            float pesoPessoa1 = float.Parse(Console.ReadLine());

            float imcPessoa1 = pesoPessoa1 / (alturaPessoa1 * alturaPessoa1);
            #endregion

            #region Imc Pessoa 2
            Console.WriteLine("Informe a altura da segunda pessoa:");
            float alturaPessoa2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu Peso:");
            float pesoPessoa2 = float.Parse(Console.ReadLine());

            float imcPessoa2 = (float) (pesoPessoa2 / Math.Pow(alturaPessoa2, 2));
            #endregion

            #region Exibir
            Console.WriteLine("Pessoa 1: peso " + pesoPessoa1 +
            ", altura :" + alturaPessoa1 +
            ", imc = " + imcPessoa1);

            Console.WriteLine($"Pessoa 2: peso { pesoPessoa2 }, altura : { alturaPessoa2 }, imc { imcPessoa2 }");
            #endregion
        }
    }
}
