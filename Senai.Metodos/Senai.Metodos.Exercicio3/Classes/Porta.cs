using System;
namespace Senai.Metodos.Exercicio3.Classes
{
    public class Porta
    {
        public bool aberta;
        public int acao;

        #region Metodos
            public void Abrir () {
                switch (aberta)
                {   
                    case true:{
                        Console.WriteLine("Não precisa se esforçar para nada.");
                        break;
                    }
                    case false:{
                        Console.WriteLine("A porta abriu");
                        break;
                    }
                    default:
                    break;
                }
                Console.WriteLine("estado da porta: Aberta");
                aberta = true;
            }   
            public void Fechar () {
                switch (aberta)
                {   
                    case true:{
                        Console.WriteLine("A porta fechou.");
                        break;
                    }
                    case false:{
                        Console.WriteLine("Porta já fechada.");
                        break;
                    }
                    default:
                    break;
                }
                Console.WriteLine("estado da porta: Fechada");
                aberta = false;
            }
        #endregion
    }
}