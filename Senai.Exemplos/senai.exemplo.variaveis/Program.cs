using System;

namespace senai.exemplo.variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variavéis
            string Nome;
            sbyte Idade;
            float Altura;
            DateTime dataNascimento;
            char Sexo;

            Console.WriteLine("Informe o seu nome");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade");
            Idade = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Infomorme a sua altura");
            Altura = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a sua data de nascimento");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu sexo [M/F]");
            Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + Nome + 
            ", Idade: " + Idade + 
            ", Altura: " + Altura + 
            ", data de nascimento: " + dataNascimento.ToShortDateString() + 
            ", sexo: " + Sexo);
        }
    }
}
