using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido
{
    public class Pedido
    {
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public IList<ItemDoPedido> Itens { get; set; }


    }
}
