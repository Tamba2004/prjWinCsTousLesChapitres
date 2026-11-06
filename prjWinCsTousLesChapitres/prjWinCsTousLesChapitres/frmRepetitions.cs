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

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // changer la couleur du texte
            lstResultats.ForeColor = Color.Black;

            // variables
            // valeurs echangees ?
            Single debut, fin, interval;
            // valeurs calculees ?
            Single compteur;

            // recuperer les valeurs saisies
            debut = Convert.ToSingle(txtDebut.Text);
            fin = Convert.ToSingle(txtFin.Text);
            interval = Convert.ToSingle(txtInterval.Text);

            // validation de debut et fin
            if(debut > fin)
            {
                MessageBox.Show("Veuillez entrer une valeur de fin plus grande que le debut");
                txtFin.Focus();
                return;
            }

            lstResultats.Items.Clear(); // vider la liste
            lstResultats.Items.Add("--- WHILE ----");

            compteur = debut;
            while (compteur <= fin)
            {
                lstResultats.Items.Add("- Valeur " + compteur);
                compteur = compteur + interval;
                // compteur += interval
            }


        }

        private void btnDowhile_Click(object sender, EventArgs e)
        {
            // changer la couleur du texte
            lstResultats.ForeColor = Color.Red;

            // variables
            // valeurs echangees ?
            Single debut, fin, interval;
            // valeurs calculees ?
            Single compteur;

            // recuperer les valeurs saisies
            debut = Convert.ToSingle(txtDebut.Text);
            fin = Convert.ToSingle(txtFin.Text);
            interval = Convert.ToSingle(txtInterval.Text);

            // validation de debut et fin
            if (debut > fin)
            {
                MessageBox.Show("Veuillez entrer une valeur de fin plus grande que le debut");
                txtFin.Focus();
                return;
            }

            lstResultats.Items.Clear(); // vider la liste
            lstResultats.Items.Add("--- DO WHILE ----");

            compteur = debut;
            do
            {
                lstResultats.Items.Add("- Valeur " + compteur);
                compteur = compteur + interval;
                // compteur += interval
            }
            while (compteur <= fin);

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            // changer la couleur du texte
            lstResultats.ForeColor = Color.Blue;

            // variables
            // valeurs echangees ?
            Single debut, fin, interval;
            // valeurs calculees ?
            Single compteur;

            // recuperer les valeurs saisies
            debut = Convert.ToSingle(txtDebut.Text);
            fin = Convert.ToSingle(txtFin.Text);
            interval = Convert.ToSingle(txtInterval.Text);

            // validation de debut et fin
            if (debut > fin)
            {
                MessageBox.Show("Veuillez entrer une valeur de fin plus grande que le debut");
                txtFin.Focus();
                return;
            }

            lstResultats.Items.Clear(); // vider la liste
            lstResultats.Items.Add("--- FOR ----");
            for(compteur = debut; compteur <= fin; compteur += interval)
            {
                lstResultats.Items.Add("- Valeur " + compteur);
            }
        }
    }
}
