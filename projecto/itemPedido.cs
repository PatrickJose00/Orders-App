using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto
{
    class itemPedido
    {
        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }
        public Produto produto { get; set; }
        public Pedido pedido { get; set; }

        public itemPedido(int quantidade, double porcentagemDesconto, Pedido pedido, Produto produto)
        {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.pedido = pedido;
            this.produto = produto;
        }

        public double subTotal( )
        {
            double desconto = produto.preco * porcentagemDesconto / 100;
            return (produto.preco - desconto) * quantidade;
        }

        public override string ToString()
        {
            return produto.descricao
                + ", Preco "
                + produto.preco.ToString("F2")
                + ", QTE: "
                + quantidade
                + ", Desconto: "
                + porcentagemDesconto.ToString("F2")
                + "%, Subtotal: "
                + subTotal().ToString("F2");
        }
    }
}
