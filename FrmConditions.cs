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
    public partial class FrmConditions : Form
    {
        public FrmConditions()
        {
            InitializeComponent();
        }

        private void FrmConditions_Load(object sender, EventArgs e)
        {
            radHomme.Checked = true;
        }

        private void btnEvaluer_Click(object sender, EventArgs e)
        {
            string nom, titre, result ;
            Single note;

            // recuperer les valeurs entrees
            nom = txtNom.Text;
            note = Convert.ToSingle(txtNote.Text);

            // trouver le titre
            if (radHomme.Checked == true)
            { titre = "Monsieur "; }
            else if (radFemme.Checked == true)
            { titre = "Madame "; }
            else
            { titre = "M. ou Mme "; }


            // trouver resultat
            if (note >= 60 && note <= 100)
            { result = "Vous PASSEZ."; }
            else if (note >= 0 && note < 60)
            { result = "Vous ECHOUEZ."; }
            else
            { result = "valeur invalide"; }

            

            // afficher resultats
            lblResultat.Text = titre + nom + ",\n" +
                 "Votre note est " + note + ", \n" + result;


        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            lblResultat.Text = "";
            txtNom.Text = txtNote.Text = "";
            txtNom.Focus();
        }
    }
}
