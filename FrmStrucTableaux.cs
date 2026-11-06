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
    public partial class FrmStrucTableaux : Form
    {

        struct Etudiant
        {
            public string nom;
            public DateTime Naissance;
            public Single Note;
        }
        // le seul tableau de types struct etudiant 
        Etudiant[] tabEtudiants = new Etudiant[25];
        
        int nbEtud = 0;


        public FrmStrucTableaux()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (nbEtud < 25)


            {
                int indexcourant;



                indexcourant = nbEtud;
                tabEtudiants[indexcourant].nom = txtNonPrenom.Text;
                tabEtudiants[indexcourant].Naissance = datNaissance.Value;
                tabEtudiants[indexcourant].Note = Convert.ToSingle(txtNote.Text);
                nbEtud++;
                MessageBox.Show("etudiant" + nbEtud + "ajouter avec success", "confirmation d ajout");

                txtNonPrenom.Clear();
                txtNote.Clear();
                datNaissance.ResetText();
                txtNote.Focus();
            }
        }
    }
}
