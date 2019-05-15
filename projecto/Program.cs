using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projecto
{
    class Program

    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();
        static void Main(string[] args)
        {


            int opcao = 0;

            produtos.Add(new Produto(1001, "Cadeira simples", 500));
            produtos.Add(new Produto(1002, "Cadeira alcochoada", 900));
            produtos.Add(new Produto(1003, "Sofa de tres lugares", 2000));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000));
            produtos.Sort();

            while(opcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
               catch (Exception e)
                {
                    Console.WriteLine( "Erro Inesperado" + e.Message);
                    
                }

                Console.WriteLine();

                if (opcao == 1)
                {

                    Tela.mostrarProdutos();

                }
                else if (opcao == 2)
                {
                    try
                    {
                        Tela.cadastrarProduto();
                    }catch(Exception e)
                    {
                        Console.WriteLine("Erro Inesperado " + e.Message);
                    }
                    
                }
                else if (opcao == 3)
                {
                    try
                    {
                        Tela.cadastrarPedido();
                    }
                    catch(ModelExeption e)
                    {
                        Console.WriteLine("erro de negocio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro Inesperado " + e.Message);
                    }
                }
                else if (opcao == 4)
                {
                    try
                    {
                        Tela.mostrarPedido();
                    }
                    catch (ModelExeption e)
                    {
                        Console.WriteLine("erro de negocio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro Inesperado " + e.Message);
                    }
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Fim do Programa");
                }
                else
                {
                    Console.WriteLine("opcao invalida");
                    Console.WriteLine();
                }

                Console.ReadLine();

            }

            


            
        }
    }
}
