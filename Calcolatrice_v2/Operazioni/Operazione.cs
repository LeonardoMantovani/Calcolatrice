using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice_v2.Operazioni
{
    abstract class Operazione : IOperazione
    {
        public decimal? N1 { get; set; }
        public decimal? N2 { get; set; }

        public List<decimal> Numeri { get; set; }

        public abstract decimal? Calcola();
    }
}
