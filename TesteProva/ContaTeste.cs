using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteProva
{
    [TestClass]
    public class ContaTeste
    {
        [TestMethod]
        public void DeveSacarSeContaCorrente()
        {
            Conta conta = new Conta();

            conta.Saldo = 100;

            var tipoConta = "Corrente";
            var valorDeSaque = 10m;

            conta.Sacar(valorDeSaque, tipoConta);

            Assert.IsTrue(conta.Saldo == 99);
        }

        [TestMethod]
        public void NaoDeveSacarSeNaoForCorrente()
        {
            Conta conta = new Conta();

            conta.Saldo = 100;

            var tipoConta = "Poupanca";
            var valorDeSaque = 10m;

            conta.Sacar(valorDeSaque, tipoConta);

            Assert.IsTrue(conta.Saldo == 100);
        }

    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveTestarOTipoDaConta()
        {
            Conta conta = new Conta();
            var tipo = "Corrente";
            Assert.IsTrue(tipo == "Corrente");
        }
        [TestMethod]
        public void DeveSacarDinheiro()
        {
            Conta conta = new Conta();
            conta.Saldo = 1000;

            var valorDoSaque = 900;
            conta.Sacar(valorDoSaque, "Corrente");

            Assert.IsTrue(valorDoSaque <= conta.Saldo);
        }

        [TestMethod]
        public void DeveTerSaldoParaTaxaDeSaque()
        {
            Conta conta = new Conta();
            conta.Saldo = 10;
            var valorDoSaque = 100;
            conta.Sacar(valorDoSaque, "Corrente");

            Assert.IsTrue((valorDoSaque * 0.10m) <= conta.Saldo);
        }

        [TestMethod]
        public void DeveCobrarTaxaDeSaque()
        {
            Conta conta = new Conta();
            conta.Saldo = 100;
            var valorDoSaque = 10;
            conta.Sacar(valorDoSaque, "Corrente");

            Assert.IsTrue(conta.Saldo == 99);
        }
    }

}
