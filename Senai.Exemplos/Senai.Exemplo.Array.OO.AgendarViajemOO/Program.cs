using System;
using Senai.Exemplo.Array.OO.AgendarViajemOO.Classes;

namespace Senai.Exdercicio.Arrays {
    class Program {
        static void Main (string[] args) {

            int resposta;
            Passagem[] passagens = new Passagem[3];
            int cont = 0;
            int contExibir = 0;

            do {
                Console.WriteLine ("Selecione uma opção");
                Console.WriteLine ("1 - Agendar Viagem");
                Console.WriteLine ("2 - Exibir Viagens");
                Console.WriteLine ("0 - Sair");
                resposta = int.Parse (Console.ReadLine ());
                switch (resposta) {
                    case 1:
                        {
                            if (cont < 3) {
                                passagens[cont] = new Passagem();
                                passagens[cont].ReceberDados();                                
                                cont++;
                            } else {
                                Console.WriteLine ("Limite de passagens Excedida");
                            }
                            break;
                        }
                    case 2:
                        {
                            contExibir = 0;
                            while (contExibir < cont) {
                                Console.WriteLine ($"Nome: {passagens[contExibir].nomePassageiro}, Nº Passagem: {passagens[contExibir].numeroPassagem}, Data: {passagens[contExibir].dataVoo.ToShortDateString()}");
                                contExibir++;
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Obrigado e Thau.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Valor Inválido");
                            break;
                        }
                }

            } while (resposta != 0);
        }
    }
}