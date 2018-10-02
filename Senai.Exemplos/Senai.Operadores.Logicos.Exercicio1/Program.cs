using System;

namespace Senai.Operadores.Logicos.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Desenvolva um programa que receba duas notas e retorne a média,
            Para ser aprovado a média deve ser maior ou igual a 50,
            caso o contrario o aluno sera reprovado
            */
            Console.WriteLine("Digite a primeira nota:");     
            double Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
                double Nota2 = double.Parse(Console.ReadLine());

            if(Nota1>100){
                Console.WriteLine("Digite um valor menor ou igual a 100");
            }else if(Nota1<0){
                Console.WriteLine("Digite um valor maior ou igual a 0");
            }else{    
                
                double Media = (Nota1 + Nota2) / 2;

            // Console.WriteLine($"Nota1: {Nota1}, Nota2: {Nota2}, Mèdia: {Media}"); 

            if(Media>=50){
                Console.WriteLine("A média do aluno é: " + Media);
                Console.WriteLine("Aprovado");
            }else{
                Console.WriteLine("A média do aluno é: " + Media);
                Console.WriteLine("Reprovado");
            }
            }
        }
    }
}
