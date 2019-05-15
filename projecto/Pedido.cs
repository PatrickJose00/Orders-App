using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto
{
    class Pedido
    {
        public int codigo { get; set; }
        public DateTime data { get; set; }

        public List<itemPedido> itens { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano)
        {
            this.codigo = codigo;
            data = new DateTime(ano, mes, dia);
            itens = new List<itemPedido>();
        }

        public double valortotal()
        {
            double soma = 0;
            for(int i = 0; i<itens.Count; i++)
            {
                soma = soma + itens[i].subTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            String s = "Pedido: " + codigo
                + ", data: " + data.Date + "/" + data.Month + "/" + data.Year + "\n"
                + "itens:\n";

            for(int i = 0; i<itens.Count; i++)
            {
                s = s + itens[i] + "\n";
            }
            s = s + "Total do pedido: " + valortotal().ToString("F2");
            return s;
        }
    }
}
