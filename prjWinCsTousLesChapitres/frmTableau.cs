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
    public partial class frmTableau : Form
    {
        //
        //
        string[] tabNoms = new string[25];
        DateTime[] tabNaissances = new DateTime[25];
        Single[] tabNote = new Single[25];
        int nbEtud = 0;

        public frmTableau()
        {
            InitializeComponent();
        }

        private void frmTableau_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (nbEtud>25)
            {
                int indexCourant;
                indexCourant = nbEtud;
                tabNoms[indexCourant] = txtNomPrenom.Text;
                tabNaissances[indexCourant] = datNaissance.Value;
                tabNote[indexCourant] = Convert.ToSingle(txtNoteFinale.Text);
                //
                nbEtud++;
                //
                MessageBox.Show("Etudiant " + nbEtud + " ajouté avec succès", "confirmation d'ajout");
                //
                txtNomPrenom.Text = txtNoteFinale.Text = "";
                datNaissance.ResetText();
                txtNomPrenom.Focus();
            }
            else
            {
                MessageBox.Show("Desole, on ne peut plus ajouter d'etudiant !",
                "Limite atteinte");
            }

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            // Vider la liste d'affichage des résultats
            lstResultat.Items.Clear();

            // Afficher les titres (entêtes) des colonnes
            lstResultat.Items.Add("Noms Complets \t Naissances \t Notes \t Ages \t Resultats");
            lstResultat.Items.Add("=============== \t =========== \t ===== \t ===== \t =========");

            // Boucler dans les 3 tableaux pour afficher leur contenu dans le ListBox
            for (int i = 0; i < nbEtud; i++)
            {
                // Calculer l'âge de chaque étudiant
                int age = DateTime.Today.Year - tabNaissances[i].Year;

                // Trouver le résultat en fonction de la note
                string result = "Invalide";
                if (tabNote[i] >= 60 && tabNote[i] <= 100)
                {
                    result = "Succès";
                }
                else if (tabNote[i] >= 0 && tabNote[i] < 60)
                {
                    result = "Échec";
                }

                // Afficher les données formatées dans le ListBox
                lstResultat.Items.Add(
                    tabNoms[i] + "\t" +
                    tabNaissances[i].ToShortDateString() + "\t" +
                    tabNote[i] + "\t" +
                    age + "\t" +
                    result
                );
            }
        }
    }
}
