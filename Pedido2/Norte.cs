namespace Pedido2
{
    public class Norte : IRegiao
    {
        public decimal ValorDoFrete { get; set; }

        public decimal CalcularFrete()
        {
            var valorDoImposto = 10m;
            return ValorDoFrete + valorDoImposto;
        }
    }
}