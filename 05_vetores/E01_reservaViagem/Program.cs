using System;

namespace E01_reservaViagem
{
    class Program
    {
        static void Main()
        {
            int[] numeroPassagem = new int[3];
            string[] nomePassageiro = new string[3];
            DateTime[] dataVoo = new DateTime[3];
            string menu;
            int i = 0;

            do {
                Console.WriteLine("-- Menu --");
                Console.WriteLine("1 = Agendar Viagem");
                Console.WriteLine("2 = Exibir Viagens");
                Console.WriteLine("0 = Sair");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                    {
                        if (i < numeroPassagem.Length)
                        {
                            Console.WriteLine("-- Registro --");
                            Console.WriteLine("Informe o número da passagem:");
                            numeroPassagem[i] = int.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o nome do passageiro:");
                            nomePassageiro[i] = Console.ReadLine();

                            Console.WriteLine("Informe a data do voo:");
                            dataVoo[i] = DateTime.Parse(Console.ReadLine());

                            i++;
                        } 
                        else
                        {
                            Console.WriteLine("Limite de passagens Excedida.");
                        }
                        break;
                    }
                    case "2":
                    {
                        i = 0;
                        Console.WriteLine("-- Agenda --");

                        do
                        {
                            System.Array.Sort(numeroPassagem);
                            Console.WriteLine($"Número da passagem: {numeroPassagem[i]}, Nome do passageiro: {nomePassageiro[i]}, Data da viagem: {dataVoo[i].ToShortDateString()}");
                            i++;
                        } while (i < 3);
                        break;
                    }
                    case "0":
                    {
                        Console.WriteLine("-- Sair --");
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
