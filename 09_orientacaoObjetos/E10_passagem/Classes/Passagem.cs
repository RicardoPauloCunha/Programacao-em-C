using System;

namespace E10_passagem.Classes
{
    public class Passagem
    {
        public int NumeroPassagem { get; set; }
        public string NomePassageiro { get; set; }
        public DateTime DataVoo { get; set; }

        public void AgendarVoo() {
            Console.WriteLine ("Digite o Número da Passagem");
            NumeroPassagem = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o nome do passageiro");
            NomePassageiro = Console.ReadLine ();

            Console.WriteLine ("Digite a data do Voo");
            DataVoo = DateTime.Parse (Console.ReadLine());
        }
    }
}