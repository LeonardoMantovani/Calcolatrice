﻿using System;
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
            m.SalvaNumero(txtDisplay.Text);
            m.SalvaOperazione(b.Text);
            azzeradisplay = true;

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

            if (azzeradisplay == true)
            {
                txtDisplay.Text = "";
                azzeradisplay = false;
            }

            switch (b.Text)
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
                    txtDisplay.Text += b.Text;
                    break;
                case ",":
                    if (!txtDisplay.Text.Contains(","))
                    {
                        txtDisplay.Text += b.Text;
                    }
                    break;
                case "±":
                    if(Decimal.TryParse(txtDisplay.Text, out decimal result))
                    {
                        result *= -1;
                        txtDisplay.Text = $"{result}";
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
