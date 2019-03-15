using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice_v2.Operazioni
{
    interface IOperazione
    {
        decimal? N1 { get; set; }
        decimal? N2 { get; set; }

        List<decimal> Numeri { get; set; }

        decimal? Calcola();
    }
}
