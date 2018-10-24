using System;
using Projeto.Pizzaria.Classes;

namespace Projeto.Pizzaria {
    class Program {
        Usuario[] usuarios = new Usuario[0];
        Produto[] produtos = new Produto[0];

        static void Main (string[] args) {
            int QuantCadastro = 0;
            Usuario[] usuario = new Usuario[QuantCadastro];
            int ContadorUsuario = 0;
            bool Acesso = false;

            //Menu do Usuario
            #region Menu Usuario
            string OpcaoFun;

            do {
                Menu ();
                OpcaoFun = Console.ReadLine ();
                Console.WriteLine ("");

                switch (OpcaoFun) {
                    //Cadastrar Usuario
                    case "1":
                        {
                            Console.WriteLine ("--CADASTRAR USUARIO--");

                            string Email;
                            String Senha;
                            String OpcaoCad;

                            do {
                                Console.WriteLine ("deseja cadastrar um novo usuario?[S/N]");
                                OpcaoCad = Console.ReadLine().ToUpper();

                                switch (OpcaoCad) {
                                    case "S":
                                        {
                                            #region Aumentar limite array
                                            QuantCadastro++;
                                            Array.Resize (ref usuario, QuantCadastro);
                                            usuario[ContadorUsuario] = new Usuario ();
                                            #endregion

                                            #region Id 
                                            usuario[ContadorUsuario].Id = ContadorUsuario + 1;
                                            #endregion

                                            #region Nome
                                            System.Console.WriteLine ("Insira o Nome de cadastro");
                                            usuario[ContadorUsuario].Nome = Console.ReadLine ();
                                            #endregion

                                            #region Email
                                            bool emailValido = false;
                                            do {
                                                System.Console.WriteLine ("Insira o E-mail de cadastro");
                                                Email = Console.ReadLine ();

                                                if (Email.Contains ("@") && Email.Contains (".")) {
                                                    emailValido = true;
                                                    usuario[ContadorUsuario].Email = Email;
                                                } else {
                                                    System.Console.WriteLine ("E-mail inválido");
                                                }
                                            } while (!emailValido);
                                            #endregion

                                            #region Senha
                                            bool senhaValida = false;
                                            do {
                                                System.Console.WriteLine ("Insira a Senha de cadastro");
                                                Senha = Console.ReadLine ();

                                                if (Senha.Length >= 6) {
                                                    senhaValida = true;
                                                    usuario[ContadorUsuario].Senha = Senha;
                                                } else {
                                                    System.Console.WriteLine ("Senha inválida");
                                                }
                                            } while (!senhaValida);
                                            #endregion

                                            #region Data
                                            usuario[ContadorUsuario].Data = DateTime.Now;
                                            #endregion

                                            ContadorUsuario++;
                                            Console.WriteLine ("");
                                            break;
                                        }

                                    case "N":
                                        {
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine ("Valor Inválido");
                                            break;
                                        }
                                }
                            } while (OpcaoCad != "N");

                            Console.WriteLine ("");
                            break;
                        }

                        //Validar login
                    case "2":
                        {
                            Console.WriteLine ("--LOGIN--");

                            string Email;
                            string Senha;
                            bool EmailValido = false;
                            bool SenhaValida = false;
                            Acesso = false;

                            do {
                                #region Email
                                do {
                                    Console.WriteLine ("Insira o E-mail:");
                                    Email = Console.ReadLine ();

                                    if (Email.Contains ("@") && Email.Contains (".")) {
                                        EmailValido = true;
                                    } else {
                                        Console.WriteLine ("E-mail Inválido");
                                    }
                                } while (!EmailValido);
                                #endregion

                                #region Senha
                                do {
                                    Console.WriteLine ("Insira a Senha:");
                                    Senha = Console.ReadLine ();

                                    if (Senha.Length > 6) {
                                        SenhaValida = true;
                                    } else {
                                        Console.WriteLine ("Senha Inválida");
                                    }
                                } while (!SenhaValida);
                                #endregion

                                #region Validar Login
                                for (int i = 0; i < ContadorUsuario; i++) {
                                    if (Email == usuario[i].Email && Senha == usuario[i].Senha) {
                                        Console.WriteLine ("\nAcesso Permitido\n");
                                        Acesso = true;
                                        break;
                                    } else {
                                        Acesso = false;
                                    }
                                } 
                                if (!Acesso) {
                                    Console.WriteLine ("\nAcesso Negado\n");
                                }                               
                                #endregion  
                            } while (!Acesso);
  
                            //Menu da Pizzaria
                            #region Menu Pizzaria 

                            int QuantCadastroProduto = 0;
                            Produto[] produto = new Produto[QuantCadastroProduto];
                            int ContadorProduto = 0;
                            string OpcaoPro;

                            if (Acesso) {
                                do {
                                    MenuProduto ();
                                    OpcaoPro = Console.ReadLine ();
                                    Console.WriteLine ("");

                                    switch (OpcaoPro) {
                                        //Cadatro produtos
                                        case "1":
                                            {
                                                Console.WriteLine ("--CADASTRAR PRODUTO--");
                                                String OpcaoCadPro;

                                                do {
                                                    Console.WriteLine ("Deseja cadastrar um novo Produto?[S/N]");
                                                    OpcaoCadPro = Console.ReadLine ().ToUpper();

                                                    switch (OpcaoCadPro) {
                                                        case "S":
                                                            {
                                                                #region Aumentar limite array
                                                                QuantCadastroProduto++;
                                                                Array.Resize (ref produto, QuantCadastroProduto);
                                                                produto[ContadorProduto] = new Produto ();
                                                                #endregion

                                                                #region Id 
                                                                produto[ContadorProduto].Id = ContadorProduto + 1;
                                                                #endregion

                                                                #region Nome
                                                                System.Console.WriteLine ("Insira o Nome de Produto:");
                                                                produto[ContadorProduto].Nome = Console.ReadLine ();
                                                                #endregion

                                                                #region Descriçao
                                                                Console.WriteLine ("Insira a Descrição do Produto:");
                                                                produto[ContadorProduto].Descricao = Console.ReadLine ();
                                                                #endregion

                                                                #region Categoria
                                                                string Categoria;
                                                                bool CategoriaVal = true;
                                                                
                                                                do {
                                                                    Console.WriteLine ("Insira a Categoria do Produto: 1 - Pizza, 2 - Bebida");
                                                                    Categoria = Console.ReadLine ();

                                                                    switch (Categoria)
                                                                    {
                                                                        case "1": case "Pizza": {
                                                                            produto[ContadorProduto].Categoria = "Pizza";
                                                                            CategoriaVal = true;
                                                                            break;
                                                                        }

                                                                        case "2": case "Bebida": {
                                                                            produto[ContadorProduto].Categoria = "Bebida";
                                                                            CategoriaVal = true;
                                                                            break;
                                                                        }
                                                                        
                                                                        default: {
                                                                            Console.WriteLine("Valor Inválido");
                                                                            CategoriaVal = false;
                                                                            break;
                                                                        }                                                                    
                                                                    }
                                                                } while (CategoriaVal != true);
                                                                #endregion

                                                                #region Preço
                                                                Console.WriteLine ("Insira o Preço do Produto:");
                                                                produto[ContadorProduto].Preco = float.Parse (Console.ReadLine ());
                                                                #endregion

                                                                #region Data
                                                                produto[ContadorProduto].Data = DateTime.Now;
                                                                #endregion

                                                                ContadorProduto++;
                                                                Console.WriteLine("");
                                                                break;
                                                            }

                                                        case "N":
                                                            {
                                                                break;
                                                            }

                                                        default:
                                                            {
                                                                Console.WriteLine ("Valor Inválido");
                                                                break;
                                                            }
                                                    }
                                                } while (OpcaoCadPro != "N");
                                                break;
                                            }

                                        //Exibe todos os produtos cadastrados
                                        case "2": {
                                                string Opcao;

                                                do {                                                    
                                                    Console.WriteLine ("--LISTA DE PRODUTOS--");
                                                    Console.WriteLine ("1 - Lista Todos os Produtos");
                                                    Console.WriteLine ("2 - Listar um Produto Especifico");
                                                    Console.WriteLine ("0 - Sair");
                                                    Opcao = Console.ReadLine ();
                                                    
                                                    switch (Opcao) {
                                                        //Exibir todos os produtos
                                                        case "1":
                                                            {
                                                                Console.WriteLine("--CARDAPIO--");
                                                                for (int b = 0; b < produto.Length; b++) {
                                                                    Console.WriteLine ($"Id: {produto[b].Id}, Nome: {produto[b].Nome}, Preço: {produto[b].Preco.ToString("c")}");
                                                                }
                                                                PauseContinue ();
                                                                break;
                                                            }

                                                        //Exibir um produto
                                                        case "2":
                                                            {
                                                                int IndiceProduto;
                                                                bool IndiceValidar= true;
                                                                do {
                                                                    Console.WriteLine ("Insira o Id do produto que deseja exibir, ou 0 para Sair):");
                                                                    IndiceProduto = int.Parse (Console.ReadLine ());

                                                                    for (int i = 0; i < produto.Length; i++) {
                                                                        if (IndiceProduto == produto[i].Id) {
                                                                            Console.WriteLine ($"Id: {produto[i].Id},\nNome {produto[i].Nome},\nDescrição: {produto[i].Descricao},\nCategoria: {produto[i].Categoria},\nData de Cadastro: {produto[i].Data}");
                                                                            IndiceValidar = true;
                                                                            PauseContinue ();                                                            
                                                                        } else if (IndiceProduto == 0) {                                                                        
                                                                            Console.WriteLine ("-Sair-");
                                                                        } else { 
                                                                            IndiceValidar = false;                                                                      
                                                                        }
                                                                    }
                                                                    if (IndiceValidar == false) {
                                                                        Console.WriteLine ("Produto não cadastrado");
                                                                    }
                                                                } while (IndiceProduto != 0);
                                                                break;
                                                            }

                                                        //Sair    
                                                        case "0":
                                                            {
                                                                Console.WriteLine ("--SAIR--");
                                                                break;
                                                            }

                                                        //Caso nenhuma das anteriores
                                                        default:
                                                            {
                                                                Console.WriteLine ("Valor Inválido");
                                                                break;
                                                            }
                                                    }                                                                                                        
                                                } while (Opcao != "0");

                                                break;
                                            }
                                                
                                        //Exibe a soma total de todos os produtos                                        
                                        case "3":
                                            {
                                                Console.WriteLine ("--TOTAL DO PREÇO DOS PRODUTOS--");
                                                float TotalPrecoPro = 0;
                                                for (int a = 0; a < QuantCadastroProduto; a++) {
                                                    TotalPrecoPro += produto[a].Preco;
                                                }
                                                Console.WriteLine ($"Total: {TotalPrecoPro.ToString("c")}");
                                                PauseContinue ();
                                                break;
                                            }
                                        
                                        //Exibi maior e menor
                                        case "4": {
                                            float MaiorPreco = 0;
                                            float MenorPreco = 0;
                                            int IndexMaior = 0;
                                            int IndexMenor = 0;

                                            #region Maior e Menor
                                                for (int i = 0; i < produto.Length; i++)
                                                {
                                                    if (produto[i] != null){
                                                        if (i == 0) {
                                                        MenorPreco = produto[i].Preco;
                                                        MaiorPreco = produto[i].Preco;
                                                        }
                                                    
                                                    if (produto[i].Preco < MenorPreco) {
                                                        MenorPreco = produto[i].Preco;
                                                        IndexMenor = i;
                                                    } else if (produto[i].Preco > MaiorPreco) {
                                                        MaiorPreco = produto[i].Preco;
                                                        IndexMaior = i;
                                                        }
                                                    }
                                                }
                                            #endregion
                                            Console.WriteLine(" --MAIOR E MENOR PREÇO");
                                            Console.WriteLine($"Produto com Menor preço: Id: {produto[IndexMenor].Id}, Nome: {produto[IndexMenor].Nome}, Preço: {produto[IndexMenor].Preco.ToString("c")}");
                                            Console.WriteLine($"Produto com Maior preço: Id: {produto[IndexMaior].Id}, Nome: {produto[IndexMaior].Nome}, Preço: {produto[IndexMaior].Preco.ToString("c")}");                                        
                                            PauseContinue();
                                            break;
                                        }

                                        case "5": {
                                            string OpcaoMenu;

                                            do {
                                                Console.WriteLine("--AUMENTAR PREÇO--");
                                                Console.WriteLine ("1 - Lista Todos os Produtos");
                                                Console.WriteLine ("2 - Aumentar Salário");
                                                Console.WriteLine ("0 - Sair");
                                                OpcaoMenu = Console.ReadLine ();
                                            
                                                switch (OpcaoMenu)
                                                {
                                                    // Exibir todos os produtos
                                                        case "1":
                                                            {
                                                                for (int i = 0; i < QuantCadastroProduto; i++) {
                                                                    Console.WriteLine ($"Id: {produto[i].Id}, Nome: {produto[i].Nome}, Preço: {produto[i].Preco.ToString("c")}");
                                                                }
                                                                PauseContinue ();
                                                                break;
                                                            }
                                                        case "2": {
                                                            int IdProduto;
                                                            bool IdProdutoVal = false;
                                                            float AumentoPreco;
                                                        
                                                            do {
                                                                Console.WriteLine ("Insira o Id do produto que deseja aumentar o salário, ou 0 para Sair:");
                                                                IdProduto = int.Parse (Console.ReadLine ());

                                                                for (int i = 0; i < QuantCadastroProduto; i++) {
                                                                        if (produto[i].Id == IdProduto) {
                                                                            Console.WriteLine($"Nome: {produto[i].Nome}, Preço: {produto[i].Preco.ToString("c")}");
                                                                            Console.WriteLine("Insira o valor que deseja aumentar no preço do produto");
                                                                            AumentoPreco = float.Parse(Console.ReadLine());
                                                                            produto[i].Preco += AumentoPreco;
                                                                            Console.WriteLine($"Nome: {produto[i].Nome}, Preço com aumento: {produto[i].Preco.ToString("c")}");
                                                                            IdProdutoVal = true;
                                                                            PauseContinue();
                                                                        } else if (IdProduto == 0) {
                                                                            Console.WriteLine ("-Sair-");
                                                                            break;
                                                                        } else {
                                                                            IdProdutoVal = false;
                                                                        }
                                                                    }

                                                                    if (IdProdutoVal != true) {
                                                                        Console.WriteLine ("Produto não cadastrado");
                                                                    }
                                                            } while (IdProduto != 0);        
                                                            break;
                                                        }
                                                            case "0": {
                                                                Console.WriteLine("--SAIR--");
                                                                break;
                                                            }
                                                    default: {
                                                        break;
                                                    } 
                                                    
                                                }
                                            } while (OpcaoMenu != "0");
                                            break;
                                        }
                                        
                                        //Sair                                            
                                        case "0":
                                            {
                                                Console.WriteLine ("--SAIR--");
                                                break;
                                            }

                                        //Caso nenhuma das anteriores
                                        default: {
                                                Console.WriteLine ("Valor Inválido");
                                                break;
                                            }
                                    } // fim swith 5
                                } while (OpcaoPro != "0"); // fim acesso produto
                            } 
                            #endregion
                            break;
                        }

                    //Exibir lista de Usuarios
                    case "3":
                        {
                            Console.WriteLine ("--LISTAR USUARIO--");

                            for (int i = 0; i < QuantCadastro; i++) {
                                if (usuario[i] != null) {
                                    Console.WriteLine ($"Id: {usuario[i].Id}, Nome: {usuario[i].Nome}, E-mail: {usuario[i].Email}");
                                }
                            }
                            PauseContinue ();
                            break;
                        }

                    //Sair    
                    case "0":
                        {
                            Console.WriteLine ("--SAIR--");
                            break;
                        }

                    //Caso nenhuma das anteriores
                    default:
                        {
                            Console.WriteLine ("Valor Inválio");
                            break;
                        }
                } //FIM MENU USUARIO
            }
            while (OpcaoFun != "0" || Acesso != true);
            #endregion

        } // FIM MAIN

        //Menu da Pizzaria
        public static void Menu () {
            Console.WriteLine ("--MENU DE USUARIO--");
            Console.WriteLine ("1 - Cadastrar Usuario");
            Console.WriteLine ("2 - Login");
            Console.WriteLine ("3 - Listar Usuarios");
            Console.WriteLine ("0 - sair");
        }

        public static void MenuProduto () {
            Console.WriteLine ("--MENU DE PRODUTO--");
            Console.WriteLine ("1 - Cadastro de Produto");
            Console.WriteLine ("2 - Listar Produtos");
            Console.WriteLine ("3 - Exibir Total");
            Console.WriteLine ("4 - Exibir Dados do Maior e Menor Preço de Produto");
            Console.WriteLine ("5 - Aumentar Preço do Produto");
            Console.WriteLine ("0 - sair");
        }

        public static void PauseContinue () {
            Console.WriteLine ("");
            Console.WriteLine ("Pressione enter para continuar");
            Console.ReadKey ();
        }
    }
}
//listar fica repitindo "Produto não cadastrado" mesmo com o produto não cadastrado
//fazer break direto no listar