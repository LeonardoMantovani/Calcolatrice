using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_v2
{
    public partial class MainForm : Form
    {
        private bool azzeradisplay = false;
        Motore m = new Motore();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Pulisci(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void Cancella(object sender, EventArgs e)
        {
            m.Reset();
            txtDisplay.Text = "";
        }

        private void Backspace(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);

            }
        }

        private void Operazione(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            RegistraOperazione(b.Text);
        }

        private void Uguale(object sender, EventArgs e)
        {
            m.SalvaNumero(txtDisplay.Text);
            txtDisplay.Text = m.Esegui();
            azzeradisplay = true;
            m.Reset();
        }

        private void Numero(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            InserisciNumero(b.Text);
        }

        private void PiuMeno(object sender, EventArgs e)
        {
            if (Decimal.TryParse(txtDisplay.Text, out decimal result))
            {
                result *= -1;
                txtDisplay.Text = $"{result}";
            }
        }

        private void KeyDownDetector(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                //NUMERI
                case (int)Keys.D0:
                case (int)Keys.NumPad0:
                    InserisciNumero("0");
                    break;
                case (int)Keys.D1:
                case (int)Keys.NumPad1:
                    InserisciNumero("1");
                    break;
                case (int)Keys.D2:
                case (int)Keys.NumPad2:
                    InserisciNumero("2");
                    break;
                case (int)Keys.D3:
                case (int)Keys.NumPad3:
                    InserisciNumero("3");
                    break;
                case (int)Keys.D4:
                case (int)Keys.NumPad4:
                    InserisciNumero("4");
                    break;
                case (int)Keys.D5:
                case (int)Keys.NumPad5:
                    InserisciNumero("5");
                    break;
                case (int)Keys.D6:
                case (int)Keys.NumPad6:
                    InserisciNumero("6");
                    break;
                case (int)Keys.D7:
                case (int)Keys.NumPad7:
                    InserisciNumero("7");
                    break;
                case (int)Keys.D8:
                case (int)Keys.NumPad8:
                    InserisciNumero("8");
                    break;
                case (int)Keys.D9:
                case (int)Keys.NumPad9:
                    InserisciNumero("9");
                    break;
                //OPERATORI
                case (int)Keys.Add:
                    RegistraOperazione("+");
                    break;
                case (int)Keys.Subtract:
                    RegistraOperazione("-");
                    break;
                case (int)Keys.Multiply:
                    RegistraOperazione("×");
                    break;
                case (int)Keys.Divide:
                    RegistraOperazione("÷");
                    break;
                //UGUALE
                case (int)Keys.Enter:
                    m.SalvaNumero(txtDisplay.Text);
                    txtDisplay.Text = m.Esegui();
                    azzeradisplay = true;
                    m.Reset();
                    break;
                default:
                    break;
            }
        }

        private void InserisciNumero(string numero)
        {
            if (azzeradisplay == true)
            {
                txtDisplay.Text = "";
                azzeradisplay = false;
            }

            switch (numero)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    txtDisplay.Text += numero;
                    break;
                case ",":
                    if (!txtDisplay.Text.Contains(","))
                    {
                        txtDisplay.Text += numero;
                    }
                    break;
                default:

                    break;
            }
        }

        private void RegistraOperazione(string operazione)
        {
            m.SalvaNumero(txtDisplay.Text);
            m.SalvaOperazione(operazione);
            azzeradisplay = true;
        }
    }
}
