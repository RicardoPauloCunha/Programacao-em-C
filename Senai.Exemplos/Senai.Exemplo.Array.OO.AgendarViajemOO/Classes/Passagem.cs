using System;
namespace Senai.Exemplo.Array.OO.AgendarViajemOO.Classes
{
    public class Passagem
    {
        public int numeroPassagem { get; set; }
        public string nomePassageiro { get; set; }
        public DateTime dataVoo { get; set; }

        #region Metodos
            public void ReceberDados () {
                Console.WriteLine ("Digite o Número da Passagem");
                numeroPassagem = int.Parse (Console.ReadLine ());
                Console.WriteLine ("Digite o nome do passageiro");
                nomePassageiro = Console.ReadLine ();
                Console.WriteLine ("Digite a data do Voo");
                dataVoo = DateTime.Parse (Console.ReadLine());
            }
        #endregion
    }
}