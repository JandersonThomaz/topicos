using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteTopicos;

namespace Testes
{
    [TestClass]
    public class ContaTeste
    {
        private decimal valorDoSaldo = 2000;
        private Conta conta;

        [TestInitialize]
        public void Inicializar()
        {
            this.conta = new Conta(valorDoSaldo);
        }

        [TestMethod]
        public void DeveSacar100Reais()
        {
            var valorDoSaque = 100;
            conta.Sacar(valorDoSaque);

            Assert.IsTrue(conta.Saldo == valorDoSaldo - valorDoSaque);
        }

        [TestMethod]
        public void DeveRetornarUmaMensagemDeErro()
        {
            Assert.ThrowsException<Exception>(() => conta.Sacar(2000));

        }

        [TestMethod]
        public void DeveRetornarUmaMensagemDeErroAoDepositar()
        {
            Assert.ThrowsException<Exception>(() => conta.Depositar(0));

        }

        [TestMethod]
        public void DeveDepositar100Reais()
        {

            conta.Depositar(100);

            Assert.IsTrue(conta.Saldo == valorDoSaldo);
        }


    }
}
