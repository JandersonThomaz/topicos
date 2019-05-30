using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido2
{
    public class Pedido
    {
        private IPedidoDao dao;

        public Pedido()
        {

        }

        public Pedido(IPedidoDao dao)
        {
            this.dao = dao;
        }

        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public IList<ItemDoPedido> Itens { get; set; } = new List<ItemDoPedido>();
        public decimal ValorTotal { get; set; }

        public void InserirItem(ItemDoPedido item)
        {
            Itens.Add(item);
        }

        public decimal CalcularValorTotal()
        {
            decimal soma = 0;

            soma = Itens.Sum(x => x.Quantidade * x.Valor);

            foreach (var item in Itens)
            {
                soma = soma + (item.Valor * item.Quantidade);
            }

            this.ValorTotal = soma;

            var result = dao.Update(this);

            if (!result)
            {
                throw new Exception();
            }

            return soma;

        }

    }
}
