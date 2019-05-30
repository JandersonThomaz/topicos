using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prova;

namespace TesteProva
{
    [TestClass]
    public class NotaFiscalTeste
    {
        [TestMethod]
        public void DeveAdicionarItens()
        {
            NotaFiscal nf = new NotaFiscal();

            nf.AddItem(new Item("Computador", 3, 3000));

            Assert.IsTrue(nf.Itens.Count > 0);

            Assert.IsTrue(nf.Itens[0].Descricao == "Computador");
        }

        [TestMethod]
        public void DeveAumentarOValorTotalDaNotaQuandoAddItens()
        {
            NotaFiscal nf = new NotaFiscal();

            nf.AddItem(new Item("Computador", 3, 3000));
            nf.AddItem(new Item("Celular", 2, 2500));

            Assert.IsTrue(nf.ValorTotal() == 14000);

        }
    }


}
