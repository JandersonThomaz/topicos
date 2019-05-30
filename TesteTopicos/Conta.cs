using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTopicos
{
    public class Conta
    {
        public Conta(decimal saldo)
        {
            this.Saldo = saldo;
        }

        public string Numero { get; set; }
        public string Agencia { get; set; }
        public Cliente Cliente { get; set; }
        public TipoDaConta TipoDaConta { get; set; }
        public decimal Saldo { get; private set; }

        public bool ValidarSaldo(decimal valor)
        {
            if (valor < 100)
            {
                throw new Exception("Saldo deve ser maior 100 reais");
            }

            return true;
        }

        public void Sacar(decimal valor)
        {
            if (valor > this.Saldo)
            {
                throw new Exception("Saldo insuficiente!");
            }

            this.Saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            if (valor == 0)
            {
                throw new Exception("O Valor deve ser maior que zero!");
            }

            this.Saldo += valor;
        }


    }
}
