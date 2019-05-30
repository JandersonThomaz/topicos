using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class NotaFiscal
    {
        public IList<Item> Itens { get; set; } = new List<Item>();

        public void AddItem(Item item)
        {
            Itens.Add(item);
        }

        public decimal ValorTotal()
        {
            return Itens.Sum(x => x.Valor * x.Quantidade);
        }
    }
}
