using System;
using E10_passagem.Classes;

namespace E10_passagem
{
    class Program
    {
        static void Main ()
        {
            int opcao;
            int cont = 0;
            Passagem[] passagens = new Passagem[3];

            do
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Agendar Viagem");
                Console.WriteLine("2 - Exibir Viagens");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao)
                {
                    case 1:
                        if (cont < 3)
                        {
                            passagens[cont] = new Passagem();
                            passagens[cont].AgendarVoo();
                            cont++;
                        }
                        else
                        {
                            Console.WriteLine("Limite de passagens Excedida");
                        }
                        break;
                    case 2:
                        int contExibir = 0;
                        while (contExibir < cont)
                        {
                            Console.WriteLine($"Nome: {passagens[contExibir].NomePassageiro}, Nº Passagem: {passagens[contExibir].NumeroPassagem}, Data: {passagens[contExibir].DataVoo.ToShortDateString()}");
                            contExibir++;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado e boa viagem.");
                        break;
                    default:
                        Console.WriteLine("Valor Inválido");
                        break;
                }
            } while (opcao != 0);
        }
    }
}