using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Conta
    {
        public decimal Saldo { get; set; }

        public void Sacar(decimal valor, string tipoDeConta)
        {

            if (valor > this.Saldo)
            {

                throw new Exception("Saldo insuficiente!");

            }

            if ("Corrente".Equals(tipoDeConta))
            {

                this.Saldo -= valor * 0.10m;
            }

        }
    }
}
