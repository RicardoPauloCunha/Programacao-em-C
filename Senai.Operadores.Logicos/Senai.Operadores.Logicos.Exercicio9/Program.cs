using System;

namespace Senai.Operadores.Logicos.Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o dia do seu aniversario:");
            int Dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o mês do seu aniversario:");
            int Mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o ano do seu aniversario:");
            int Ano = int.Parse(Console.ReadLine());

            //verifica a data de nascimento
            if(Dia<=0&&Dia>31){
                Console.WriteLine("Dia de nascimento é invalido");
            }

            if(Mes<=0&&Mes>12){
                Console.WriteLine("Mês de nascimento é invalido");
            }

            if(Ano<0=&&Ano>2013){
                Console.WriteLine("Ano de nascimento é invalido");
            }else{
                Console.WriteLine($"Seu aniverserio é valido: {Dia}/{Mes}/{Ano}");
            }
        }
    }
}
