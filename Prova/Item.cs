using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Item
    {
        public Item(string descricao, int quantidade, decimal valor)
        {
            Descricao = descricao;
            Quantidade = quantidade;
            Valor = valor;
        }
        public Item()
        {

        }

        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
