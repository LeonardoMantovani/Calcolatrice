using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice_v2.Operazioni
{
    class Moltiplicazione : Operazione
    {
        public override decimal? Calcola()
        {
            decimal? result = null;
            foreach (var N in Numeri)
            {
                if (result == null)
                {
                    result = N;
                }
                else
                {
                    result *= N;
                }
            }
            return result;
        }
    }
}
