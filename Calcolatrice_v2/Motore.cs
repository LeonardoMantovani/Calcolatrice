using Calcolatrice_v2.Operazioni;
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
        private IOperazione Operazione { get; set; }

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
            switch (operatore)
            {
                case "+":
                    Operazione = new Addizione();
                    break;
                case "-":
                    Operazione = new Sottrazione();
                    break;
                case "×":
                    Operazione = new Moltiplicazione();
                    break;
                case "÷":
                    Operazione = new Divisione();
                    break;
                default:
                    break;
            }
        }

        public string Esegui()
        {
            if (N1 != null && 
                N2 != null &&
                Operazione != null)
            {
                Operazione.N1 = N1;
                Operazione.N2 = N2;

                decimal? R = Operazione.Calcola();
                return $"{R}";
            }
            else
            {
                return "oooops";
            }
        }
    }
}
