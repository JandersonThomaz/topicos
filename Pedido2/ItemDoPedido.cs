using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido2
{
    public class ItemDoPedido
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        public Pedido Pedido { get; set; }
    }
}
