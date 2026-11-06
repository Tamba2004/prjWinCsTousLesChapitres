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
    public partial class frmExoCondition : Form
    {
        public frmExoCondition()
        {
            InitializeComponent();
        }

        

        

        private void btnEvaluer_Click(object sender, EventArgs e)
        {
            string titre = "";
            string nom = "", noteAlpha = "", result ="Vous PASSEZ.";
            Single note;

            // trouver titre
            //if(radHomme.Checked==true )
            //{ titre = "Monsieur "; }
            //else
            //{ titre = "Madame "; }
            // version ?:
            titre = (radHomme.Checked == true) ? "Monsieur " : "Madame ";

            // recuperer le nom
            nom = txtNom.Text;

            // recuperer la note
            note =Convert.ToSingle( txtNote.Text);

            // trouver la note alpha
            if (note >= 90 && note <= 100)
            {   noteAlpha = "A"; }
             else if (note >= 80 && note < 90)
            {   noteAlpha = "B"; }
            else if (note >= 70 && note < 80)
            {   noteAlpha = "C"; }
            else if (note >= 60 && note < 70)
            {   noteAlpha = "D"; }
            else if (note >= 0 && note < 60)
            {   
                noteAlpha = "E";
                result = "Vous ECHOUEZ.";
            }
            else 
            {   
                noteAlpha = "Invalide";
                result = "Votre resultat est Invalide.";
            }

             // afficher les resultats
            lblResultat.Text = titre + nom + ", \n";
            lblResultat.Text += "Avec votre note numerique de " + note + "/100, \n";
            lblResultat.Text += "Votre note alphabetique correspondante est " + noteAlpha + " , \n";
             lblResultat.Text += "Alors, " + result ;


        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Text = txtNote.Text = lblResultat.Text = "";
            txtNom.Focus();

        }
    }
}
