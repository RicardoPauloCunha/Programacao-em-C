using System;

namespace E09_validarDataNascimento
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o dia do seu aniversario:");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o mês do seu aniversario:");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o ano do seu aniversario:");
            int ano = int.Parse(Console.ReadLine());

            if(dia <= 0 || dia > 31)
                Console.WriteLine("Dia de nascimento é invalido");
            else if(mes <= 0 || mes > 12)
                Console.WriteLine("Mês de nascimento é invalido");
            else if(ano <= 0 || ano > 2013)
                Console.WriteLine("Ano de nascimento é invalido");
            else
                Console.WriteLine($"Seu aniverserio é valido: {dia}/{mes}/{ano}");
        }
    }
}
