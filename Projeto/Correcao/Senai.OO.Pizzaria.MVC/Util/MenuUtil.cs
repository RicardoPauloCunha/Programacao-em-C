using System;
namespace Senai.OO.Pizzaria.MVC.Util
{
    /// <summary>
    /// Classes responsavel pela criação dos menus do sistema
    /// </summary>
    public static class MenuUtil
    {
        /// <summary>
        /// Mostra as opções do usuario logado
        /// </summary>
        public static void MenuDeslogardo() {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------------Pizzaria TKPizza---------------");
            Console.WriteLine("-------------      Conta      --------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Usuário            ");
            Console.WriteLine("           (2) Efetuar Login                ");
            Console.WriteLine("           (3) Listar                       ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");        
        }

        /// <summary>
        /// Mostra as opções do usuario deslogado
        /// </summary>
        public static void MenuLogado() {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------------Pizzaria TKPizza---------------");
            Console.WriteLine("-----------      Cardápio      -------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Produto            ");
            Console.WriteLine("           (2) Listar                       ");
            Console.WriteLine("           (3) Valor Total                  ");
            Console.WriteLine("           (4) Alterar                      ");
            Console.WriteLine("           (5) Remover                      ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");
        }
    }
}