using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice_v2
{
    public class Motore
    {
        private decimal? N1 { get; set; }
        private decimal? N2 { get; set; }
        private string Operazione { get; set; } //TODO: cambia in un tipo IOperazione

        public void Reset()
        {
            N1 = null;
            N2 = null;
            Operazione = null;
        }

        public void SalvaNumero(string numero)
        {
            if (N1 == null)
            {
                N1 = Convert.ToDecimal(numero);
            }
            else
            {
                N2 = Convert.ToDecimal(numero);
            }
        }

        public void SalvaOperazione(string operatore)
        {
            //TODO: salva l'operazione in base all'operatore scelto dall'utente
        }

        public string Esegui()
        {
            decimal? R = null;
            //TODO: chiama il metodo Calcola dell'operazione
            return $"{R}";
        }
    }
}
