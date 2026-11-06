using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsTousLesChapitres
{
    public partial class FrmRepetitions : Form
    {
        public FrmRepetitions()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            double val1, val2, interval;

            val1 = Convert.ToDouble(txtDebut.Text);
            val2 = Convert.ToDouble(txtFin.Text);
            interval = Convert.ToDouble(txtIntervalle.Text);


            string message = "La Boucle DO-WHILE\n";

            do
            {
                message += val1 + "\n";
                val1 += interval;
            }
            while (val1 <= val2);

            lblResultat.Text = message;
            txtDebut.Text = " ";
            txtFin.Text = " ";
            txtIntervalle.Text = " ";
            txtDebut.Focus();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double val1, val2, interval;

            val1 = Convert.ToDouble(txtDebut.Text);
            val2 = Convert.ToDouble(txtFin.Text);
            interval = Convert.ToDouble(txtIntervalle.Text);

            string message = "La Boucle WHILE\n";

            while (val1 <= val2)
            {
                message += val1 + "\n";
                val1 += interval;
            }

            lblResultat.Text = message;

            txtDebut.Text = " ";
            txtFin.Text = " ";
            txtIntervalle.Text = " ";
            txtDebut.Focus();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(txtDebut.Text);
            double val2 = Convert.ToDouble(txtFin.Text);
            double interval = Convert.ToDouble(txtIntervalle.Text);

            string message = "La Boucle FOR\n";

            for (double i = val1; i <= val2; i += interval)
            {
                message += i + "\n";
            }

            lblResultat.Text = message;
            txtDebut.Text = " ";
            txtFin.Text = " ";
            txtIntervalle.Text = " ";
            txtDebut.Focus();
        }
        

    }

}
