using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido2
{
    public interface IRegiao
    {
        decimal ValorDoFrete { get; }
            
        decimal CalcularFrete();
 
    }
}
