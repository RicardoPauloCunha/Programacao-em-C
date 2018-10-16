using System;

namespace Senai.For.Exercicio5.Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[3];
            int[] idade = new int[3];
            int maior = 0;
            int menor = 0;
            int igual50 = 0;

            for (int cont = 0; cont < idade.Length; cont++)
            {
                //Solicita as dados
                Console.WriteLine($"Informe o nome de usuario {cont}:");
                nome[cont] = Console.ReadLine();
                Console.WriteLine($"Informe informe a idade do usuario: {cont}");
                idade[cont] = int.Parse(Console.ReadLine());
                
                //conta quantas idades são <18, >18 e >50
                if (idade[cont] < 18 ) {
                    menor++;
                } else if (idade[cont] > 50) {
                    igual50++;
                } else {
                    maior++;
                }
            }
            Console.WriteLine($"Usuarios com idade menor que 18 anos: {menor}");
            Console.WriteLine($"Usuarios com idade maior que 18 anos: {maior}");
            Console.WriteLine($"Usuarios com idade maior que 50 anos: {igual50}");

        }
    }
}
