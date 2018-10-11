using System;

namespace Senai.Array.Exercicio1.ReservaDePassagens
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeroPassagem = new int[3];
            string[] nomePassageiro = new string[3];
            DateTime[] dataVoo = new DateTime[3];
            string menu;
            int contadorViajem = 0;

            do {
                Console.WriteLine("--Menu--");
                Console.WriteLine("1 = Agendar Viagem");
                Console.WriteLine("2 = Exibir Viagens");
                Console.WriteLine("0 = Sair");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":{
                        if (contadorViajem < numeroPassagem.Length) {
                            Console.WriteLine("--Registro--");
                            Console.WriteLine("Informe o número da passagem:");
                            numeroPassagem[contadorViajem] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o nome do passageiro:");
                            nomePassageiro[contadorViajem] = Console.ReadLine();
                            Console.WriteLine("Informe a data do voo:");
                            dataVoo[contadorViajem] = DateTime.Parse(Console.ReadLine());
                            contadorViajem++;
                        } 
                        else {
                            Console.WriteLine("Limite de passagens Excedida.");
                        }
                        break;
                    }
                    case "2":{
                        contadorViajem = 0;
                        Console.WriteLine($"--Agenda--");
                        do {
                            System.Array.Sort(numeroPassagem);
                            Console.WriteLine($"Número da passagem: {numeroPassagem[contadorViajem]}, Nome do passageiro: {nomePassageiro[contadorViajem]}, Data da viagem: {dataVoo[contadorViajem].ToShortDateString()}");
                            contadorViajem++;
                        } while (contadorViajem < 3);
                        break;
                    }

                    case "0":{
                        Console.WriteLine("--Sair--");
                        Console.Clear();
                        break;
                    }
                    default:
                        Console.WriteLine("Valor inválido.");
                    break;
                }
            } while (menu != "0");
        }
    }
}
