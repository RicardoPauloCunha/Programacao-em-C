using System;

namespace Senai.Lacos.Repiticao.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informa os números entre dois outros números
            Console.WriteLine("Informe o Primeiro número da sequência:");
            int NumeroInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Ultimo número da sequência");
            int NumeroChegada = int.Parse(Console.ReadLine());

            int Contador = NumeroInicial;
            Console.Clear();
            if(NumeroInicial < NumeroChegada){
                while (Contador < NumeroChegada -1){
                    Contador++;
                    Console.WriteLine(Contador);
                }
            }else{
                while (Contador > NumeroChegada +1){
                    Contador--;
                    Console.WriteLine(Contador);
                }
            }
        }
    }
}
