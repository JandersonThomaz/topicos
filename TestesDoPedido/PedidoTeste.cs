using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Pedido2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDoPedido
{
    [TestClass]
    public class PedidoTeste
    {
        [TestMethod]
        public void DeveInserirItem()
        {
            var pedido = new Pedido();
            var item = new ItemDoPedido();

            item.Descricao = "Celular";
            item.Quantidade = 5;
            item.Valor = 782;

            pedido.InserirItem(item);

            Assert.IsTrue(pedido.Itens.Count > 0);
        }

        [TestMethod]
        public void DeveAdicionarMaisDeUmItem()
        {
            var pedido = new Pedido();
            var item1 = new ItemDoPedido();
            var item2 = new ItemDoPedido();

            item1.Descricao = "Celular";
            item1.Quantidade = 5;
            item1.Valor = 782;

            item2.Descricao = "XBOX";
            item2.Quantidade = 5;
            item2.Valor = 700;

            pedido.InserirItem(item1);
            pedido.InserirItem(item2);

            Assert.IsTrue(pedido.Itens.Count > 0);

            Assert.IsTrue(pedido.Itens[0].Descricao == "Celular");

            Assert.IsTrue(pedido.Itens[1].Descricao == "XBOX");
        }

        [TestMethod]
        public void DeveCalcularOValorTotal()
        {
            var mock = new Mock<PedidoDao>();

            mock.Setup(x => x.Update(new Pedido())).Returns(true);

            var pedido = new Pedido(mock.Object);

            var item1 = new ItemDoPedido();
            var item2 = new ItemDoPedido();

            item1.Descricao = "Celular";
            item1.Quantidade = 2;
            item1.Valor = 700;

            item2.Descricao = "XBOX";
            item2.Quantidade = 2;
            item2.Valor = 3000;

            pedido.InserirItem(item1);
            pedido.InserirItem(item2);

            Assert.IsTrue(pedido.CalcularValorTotal() ==  7400);
        }
    }
}
