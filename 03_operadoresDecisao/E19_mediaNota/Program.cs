using System;

namespace E19_mediaNota
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite a primeira nota:");     
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            double nota2 = double.Parse(Console.ReadLine());

            if (nota1>100)
                Console.WriteLine("Digite um valor menor ou igual a 100");
            else if(nota1<0)
                Console.WriteLine("Digite um valor maior ou igual a 0");
            else
            {
                double media = (nota1 + nota2) / 2;
                Console.WriteLine("A média do aluno é: " + media);

                if (media >= 50)
                    Console.WriteLine("Aprovado");
                else
                    Console.WriteLine("Reprovado");
            }
        }
    }
}
