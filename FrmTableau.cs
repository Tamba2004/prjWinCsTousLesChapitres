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
    public partial class FrmTableau : Form
    {
        string[] tabNoms = new string[25];
        DateTime[] tabNaissances = new DateTime[25];
        Single[] tabNotes = new Single[25];

        int nbEtud =0;
        public FrmTableau()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int indexcourant;



            indexcourant = nbEtud;
            tabNoms[indexcourant] = txtNonPrenom.Text;
            tabNaissances[indexcourant] = datNaissance.Value;
            tabNotes[indexcourant] = Convert.ToSingle(txtNote.Text);
            nbEtud++;
            MessageBox.Show("etudiant" + nbEtud + "ajouter avec success", "confirmation d ajout");

            txtNonPrenom.Clear();
            txtNote.Clear();
            datNaissance.ResetText();
            txtNote.Focus();


        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            lstResultat.Items.Clear();
            lstResultat.Items.Add("Nom Complet \t Naissances \t Notes \t Ages \t Resultats");
        }
    }
}
