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
    public partial class frmConditions : Form
    {
        public frmConditions()
        {
            InitializeComponent();
        }

        private void btnEvaluer_Click(object sender, EventArgs e)
        {
            string nom, titre, result;
            Single note;

            nom = txtNom.Text;
            note = Convert.ToSingle(txtNote.Text);

            if (radHomme.Checked == true)
            {
                titre = "Monsieur";
            }
            else if (radFemme.Checked == true)
            {
                titre = "Madame";
            }
            else
            {
                titre = "Monsieur ou Madame";
            }
            //trouver resultat

            if (note >= 60 && note <= 100)
            {
                result = "Vous passer";
            }
            else if (note >= 0 && note < 60)
            {
                result = "Vous couler";
            }
            else
            {
                result = "Note invalide";
            }
            // afficher resultats
            lblResultat.Text = titre + nom + ",\n" +
                 "Votre note est " + note + ", \n" + result;
        }
    }
}
