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
    public partial class frmRepetitions : Form
    {
        public frmRepetitions()
        {
            InitializeComponent();
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {

            /*lstIncrement.Items.Clear();
            Int32 valeur, fin, interv;

            valeur = Convert.ToInt32(txtDebut.Text);
            fin = Convert.ToInt32(txtFin.Text);
            interv = Convert.ToInt32(txtIntervalle.Text);
            lstIncrement.Items.Add("La Boucle DO-WHILE \n");
            */

            // Déclaration des variables
            Single debut, fin, interval;
            // valeurs calculées 
            Single compteur;

            // récupérer les valeurs saisies
            debut = Convert.ToSingle(txtDebut.Text);
            fin = Convert.ToSingle(txtFin.Text);
            interval = Convert.ToSingle(txtIntervalle.Text);

            compteur = debut;
            do
            {
                lstIncrement.Items.Add(compteur.ToString());
                compteur += interval;

            }
            while (compteur < fin);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstIncrement.Items.Clear();
            Int32 valeur, fin, interv;

            valeur = Convert.ToInt32(txtDebut.Text);
            fin = Convert.ToInt32(txtFin.Text);
            interv = Convert.ToInt32(txtIntervalle.Text);
            lstIncrement.Items.Add("La Boucle WHILE \n");

            while (valeur < fin)
            {
                lstIncrement.Items.Add(valeur.ToString());
                valeur += interv;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {   
            lstIncrement.Items.Clear();
            Int32 valeur, fin, interv;

            valeur = Convert.ToInt32(txtDebut.Text);
            fin = Convert.ToInt32(txtFin.Text);
            interv = Convert.ToInt32(txtIntervalle.Text);
            lstIncrement.Items.Add("La Boucle For \n");

            for (int i = valeur; i < fin; i+=interv)
            {
                lstIncrement.Items.Add(i.ToString());
            }
        }
    }
}
