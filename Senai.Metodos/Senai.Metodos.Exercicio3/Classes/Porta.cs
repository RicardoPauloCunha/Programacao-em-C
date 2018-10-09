using System;
namespace Senai.Metodos.Exercicio3.Classes
{
    public class Porta
    {
        public bool estado;
        public int acao;

        #region Metodos
            public void Abrir () {
                switch (estado)
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
                Console.WriteLine("Estado da porta: Aberta");
                estado = true;
            }   
            public void Fechar () {
                switch (estado)
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
                Console.WriteLine("Estado da porta: Fechada");
                estado = false;
            }
        #endregion
    }
}