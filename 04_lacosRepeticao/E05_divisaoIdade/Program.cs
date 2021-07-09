using System;

namespace E05_divisaoIdade
{
    class Program
    {
        static void Main()
        {
            int qtdMaior18 = 0;
            int qtdMenor18 = 0;
            int qtdMaior50 = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Informe informe a idade do usuario({i+1}/5):");
                int idade = int.Parse(Console.ReadLine());
                
                if (idade < 18 )
                    qtdMenor18++;
                else if (idade > 50)
                    qtdMaior50++;
                else
                    qtdMaior18++;
            }
            Console.WriteLine($"Usuarios com idade menor que 18 anos: {qtdMenor18}");
            Console.WriteLine($"Usuarios com idade maior que 18 anos: {qtdMaior18}");
            Console.WriteLine($"Usuarios com idade maior que 50 anos: {qtdMaior50}");

        }
    }
}
