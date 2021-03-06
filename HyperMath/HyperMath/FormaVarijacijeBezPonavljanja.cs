﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperMath
{
    public partial class FormaVarijacijeBezPonavljanja : Form
    {
        public FormaVarijacijeBezPonavljanja()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            //deklariranje objekta Formule
            Formule a = new Formule();

            //deklaracija varijabli
            float n;
            float k;

            //***************provjere dali su upisane vrijednosti brojevi i dali su vrjednost null***************
            bool provjeraN = float.TryParse(txtN.Text, out n);
            bool provjeraK = float.TryParse(txtK.Text, out k);

            if (string.IsNullOrEmpty(txtN.Text) || string.IsNullOrEmpty(txtK.Text) || !provjeraN || !provjeraK)
            {
                MessageBox.Show("Krivo ste upisali podatke", "Greška");
                return;
            }
            //****************************************************************************************************

            //****izračun formule****
            k = a.Permutacije(n - k);
            n = a.Permutacije(n);
            //**********************

            //ispis rješenja
            txtRjesenje.Text = Convert.ToString(n / k);
        }

        //povratak na početnu formu
        private void btnNazad_Click(object sender, EventArgs e)
        {
            FormaPocetna frm = new FormaPocetna();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
    }
}
