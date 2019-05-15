using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto
{
    class Tela
    {
        public static void mostrarMenu()
        {
            Console.WriteLine("1- Listar Produtos Ordenamente");
            Console.WriteLine("2- Cadastrar Produto");
            Console.WriteLine("3- Cadastrar Pedido");
            Console.WriteLine("4- Mostrar dados de um pedido");
            Console.WriteLine("5- Sair");
            Console.Write("Digite uma opcao: ");
        }

        public static void mostrarProdutos()
        {
            Console.WriteLine("Listagem de Produtos:");
            for(int i = 0 ; i<Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
        }

        public static void cadastrarProduto()
        {
            Console.WriteLine("Digite os dados do Protudo: ");
            Console.Write("Coodigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descricao: ");
            string descricao = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            Produto P = new Produto(codigo, descricao, preco);
            Program.produtos.Add(P);
            Program.produtos.Sort();
        }

        public static void cadastrarPedido()
        {
            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido P = new Pedido(codigo, dia, mes, ano);
            Console.Write("Quantos itens tem o pedido: ");
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i<N; i++)
            {
                Console.WriteLine("Digite os dados do " + i + "º item: ");
                Console.Write("Produto(codigo): ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(x => x.codigo == codProduto);
                if (pos == -1)
                {
                    throw new ModelExeption("Codigo de produto nao encontrado: " + codProduto);
                }
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double porcent = double.Parse(Console.ReadLine());
                itemPedido ip = new itemPedido(quantidade, porcent, P, Program.produtos[pos]);
                P.itens.Add(ip);
            }

            Program.pedidos.Add(P);
        }

        public static void mostrarPedido()
        {
            Console.WriteLine("Digite o codigo do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if (pos == -1)
            {
                throw new ModelExeption("Codigo de pedido nao encontrado: " + codPedido);
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.WriteLine();
        }
       
    }
}
