using System;
using System.Threading;

namespace csharp_console_market2system
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //intro
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("===                                                                                                        ===");
            Console.WriteLine("=== ////     ////   ///   /// ///////////     ///    ///    ///   ///   /////////// //////// ////     //// ===");
            Console.WriteLine("=== /////   /////   ///  ///  ///////////   //////   ///   ///  //////  /////////// //////// /////   ///// ===");
            Console.WriteLine("=== ////// //////   /// ///       ///      ///  ///  ///  ///  ///  ///     ///     ///      ////// ////// ===");
            Console.WriteLine("=== /// ///// ///   //////        ///      ///       /// ///   ///          ///     ///////  /// ///// /// ===");
            Console.WriteLine("=== ///  ///  ///   //////        ///       ////      /////     ////        ///     ///////  ///  ///  /// ===");
            Console.WriteLine("=== ///  //   ///   /// ///       ///          ///     ///        ///       ///     ///      ///  //   /// ===");
            Console.WriteLine("=== ///       ///   ///  ///      ///     ///  ///    ///    ///  ///       ///     ///      ///       /// ===");
            Console.WriteLine("=== ///       ///   ///   ///     ///     ///////    ///     ///////        ///     //////// ///       /// ===");
            Console.WriteLine("=== ///       ///   ///    ///    ///      ////     ///       ////          ///     //////// ///       /// ===");
            Console.WriteLine("===                                                                                                        ===");
            Console.WriteLine("=== ////////////////////////////////////////////////////////////////////////////////////////////////////// ===");
            Console.WriteLine("===                                                                                                        ===");
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("==============================================================================================================");
            
            //Limpa a tela depois de x milisegundos
            Thread.Sleep(3000);
            Console.Clear();
            

            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("===                                                                                                        ===");
            Console.WriteLine("===       ///////   //////// ////     ////   ///     /// /// ////      /// /////         ////    ///       ===");
            Console.WriteLine("===       ////////  //////// /////   /////   ///    ///  /// /////     /// ///////     /// ///   ///       ===");
            Console.WriteLine("===       ///  //// ///      ////// //////   ///   ///       //////    /// ///  ///   ///   ///  ///       ===");
            Console.WriteLine("===       ////////  //////   /// ///// ///   ///  ///    /// ///////   /// ///   /// ///     /// ///       ===");
            Console.WriteLine("===       ///////   //////   ///  ///  ///   /// ///     /// ///  ///  /// ///   /// ///     /// ///       ===");
            Console.WriteLine("===       ////////  ///      ///  //   ///   //////      /// ///   /// /// ///   /// ///     /// ///       ===");
            Console.WriteLine("===       ///  //// ///      ///       ///   /////       /// ///    ////// ///  ///   ///   ///            ===");
            Console.WriteLine("===       ////////  //////// ///       ///   ////        /// ///     ///// ///////     /// ///   ///       ===");
            Console.WriteLine("===       ///////   //////// ///       ///   ///         /// ///      //// /////         ////    ///       ===");
            Console.WriteLine("===                                                                                                        ===");
            Console.WriteLine("===       ////////////////////////////////   ///////////////////////////////////////////////////////       ===");
            Console.WriteLine("===                                                                                                        ===");
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("==============================================================================================================");
            Thread.Sleep(3000);
            Console.Clear();         

            //itens do menu
            string menu_1 = "Funcionários";
            string menu_2 = "Produtos";
            string menu_3 = "Compras";
            string menu_4 = "Relatórios";
            string menu_5 = "Sair";

            string menu = $"Menu Principal\n1- {menu_1} \n2- {menu_2} \n3- {menu_3} \n4- {menu_4} \n5- {menu_5} \n\nDigite a opção desejada: ";
            string confirmacao = "Deseja utilizar outra opção?\n(S ou s para Sim, N ou n para Não)\n";
            string opcao_confirm = "s";
            string tecla = "Aperte qualquer TECLA para CONTINUAR...";
            int opcao;

            Console.WriteLine(menu);
            opcao = Int32.Parse(Console.ReadLine());
            Console.Clear();

            do
            {
                Console.Clear();

                switch (opcao)
                {

                    case 1:
                        ManterFuncionarios(menu_1);
                        Console.ReadKey();
                        break;
                    case 2:
                        ManterProdutos(menu_2);
                        Console.ReadKey();
                        break;
                    case 3:
                        RealizarCompras(menu_3);
                        Console.ReadKey();
                        break;
                    case 4:
                        ManterRelatórios(menu_4);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine(menu_5);
                        Console.WriteLine(tecla);
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Opção inválida!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine(menu);
                        opcao = Int32.Parse(Console.ReadLine());
                        break;
                }
                Console.Clear();

                if (opcao != 5)
                {
                    Console.WriteLine(confirmacao);
                    opcao_confirm = Console.ReadLine();
                    if (opcao_confirm.Equals("S") || opcao_confirm.Equals("s"))
                    {
                        Console.Clear();
                        Console.WriteLine(menu);
                        opcao = Int32.Parse(Console.ReadLine());
                    }
                }

                //repete se a opção está entre 1 e 4 e foi confirmado que quer continuar utilizando o sistema
            } while ((opcao > 0 && opcao < 5) && (opcao_confirm.Equals("s") || opcao_confirm.Equals("S")));

            if (opcao == 5 || opcao_confirm.Equals("n") || opcao_confirm.Equals("N"))
            {
                Sair();
            }
        }

        public static void ManterFuncionarios(string menu)
        {
            Console.Clear();
            Console.WriteLine(menu);

            int opcao;
            string m1 = "Cadastrar";
            string m2 = "Alterar";
            string m3 = "Excluir";
            string m4 = "Buscar";
            string m5 = "Voltar ao Menu Principal";
            string m6 = "Sair";
            string menu_1 = $"Opções\n\n1- {m1}\n2- {m2}\n3- {m3}\n4- {m4}\n5- {m5}\n6- {m6}\n\nDigite a opção desejada: ";

            //sub menu
            Console.Write(menu_1);
            opcao = Int32.Parse(Console.ReadLine());

            do
            {
                Console.Clear();

                switch (opcao)
                {

                    case 1:
                        ManterFuncionarios(m1);
                        Console.ReadKey();
                        break;
                    case 2:
                        ManterProdutos(m2);
                        Console.ReadKey();
                        break;
                    case 3:
                        RealizarCompras(m3);
                        Console.ReadKey();
                        break;
                    case 4:
                        ManterRelatórios(m4);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Voltando ao Menu principal...");
                        Thread.Sleep(1000);
                        break;
                    case 6:
                        Sair();
                        break;
                    default:
                        Console.Write("Opção inválida!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine(menu);
                        opcao = Int32.Parse(Console.ReadLine());
                        break;
                }
                Console.Clear();
            } while(opcao > 0 && opcao < 5);
        }

        public static void ManterProdutos(string menu_2)
        {

        }

        public static void RealizarCompras(string menu_3)
        {

        }

        public static void ManterRelatórios(string menu_4)
        {

        }

        public static void Sair()
        {
            Console.Clear();

            Console.WriteLine("Saindo em:");
            for (int i = 3; i > 0; i--)
            {
                Console.Write($"{i}.");
                Thread.Sleep(333);
                Console.Write(".");
                Thread.Sleep(333);
                Console.Write(".");
                Thread.Sleep(334);
            }
            Environment.Exit(1);
        }
    }
}
