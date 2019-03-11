using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice_v2.Operazioni
{
    class Divisione : Operazione
    {
        public override decimal? Calcola()
        {
            return N1 / N2;
        }
    }
}
