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
    public partial class FrmStructCollectionsFiles : Form
    {
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Par exemple : lblInformation.Text = "Tu es dans le group box";
        }

        // declaration des structures de donnees
        // la structure Etudiant, nouveau type
        struct Etudiant
        {
            public string Numero;
            public string Nom;
            public DateTime Naissance;
            public Single Note;
        }
        // la collection List<> de type Etudiant
        List<Etudiant> tousLesEtudiants = new List<Etudiant>();

        // variables globales
        int indicecourant = 0;
        string mode = "";

        public FrmStructCollectionsFiles()
        {
            InitializeComponent();
        }

        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "ajout";

            // vider les textbox
            txtNumEtudiant.Text = txtNote.Text = txtNonPrenom.Text = "";
            txtNumEtudiant.Focus();

            //cacher les boutons
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = false;
            btnSauvegarder.Visible = btnAnnuler.Visible = true;
            btnPremier.Visible = btnPrecedent.Visible = btnSuivant.Visible = btnDernier.Visible = false;

            // afficher information
            lblInformation.Text = "En mode AJOUT, entrez les donnees";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            mode = "modif";
            txtNumEtudiant.Focus();

            //cacher les boutons
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = false;
            btnSauvegarder.Visible = btnAnnuler.Visible = true;
            btnPremier.Visible = btnPrecedent.Visible = btnSuivant.Visible = btnDernier.Visible = false;

            // afficher information
            lblInformation.Text = "En mode MODIFICATION, changez les donnees";


        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if (mode == "ajout")
            {
                // en mode ajout, creer un etudiant et remplir ses informations avec les valeurs entrees
                Etudiant unEtud;
                unEtud.Numero = txtNumEtudiant.Text;
                unEtud.Nom = txtNonPrenom.Text;
                unEtud.Naissance = datNaissance.Value;
                unEtud.Note = Convert.ToSingle(txtNote.Text);
                // ajouter cet etudiant dans la collection
                tousLesEtudiants.Add(unEtud);
                // apres, indice courant change pour afficher le dernier elelment
                indicecourant = tousLesEtudiants.Count - 1;
            }
            if (mode == "modif")
            {
                // en mode modification, creer un etudiant et remplir ses informations avec les valeurs entrees
                Etudiant unEtud;
                unEtud.Numero = txtNumEtudiant.Text;
                unEtud.Nom = txtNonPrenom.Text;
                unEtud.Naissance = datNaissance.Value;
                unEtud.Note = Convert.ToSingle(txtNote.Text);
                // ensuite, ecraser (ou inserer) cet etudiant a la position de indice courant
                tousLesEtudiants[indicecourant] = unEtud;
            }

            //cacher les boutons
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = true;
            btnSauvegarder.Visible = btnAnnuler.Visible = false;
            btnPremier.Visible = btnPrecedent.Visible = btnSuivant.Visible = btnDernier.Visible = true;

            // afficher information
            lblInformation.Text = "Etudiant " + (indicecourant + 1) +
                " sur un total de " + tousLesEtudiants.Count;
            mode = "";
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {

            indicecourant = 0;
            txtNumEtudiant.Text = tousLesEtudiants[indicecourant].Numero;
            txtNonPrenom.Text = tousLesEtudiants[indicecourant].Nom;
            txtNote.Text = tousLesEtudiants[indicecourant].Note.ToString();
            datNaissance.Value = tousLesEtudiants[indicecourant].Naissance;
            // afficher information
            lblInformation.Text = "Etudiant " + (indicecourant + 1) +
                " sur un total de " + tousLesEtudiants.Count;

        }

        private void FrmStructCollectionsFiles_Load(object sender, EventArgs e)
        {
            // situation de la form a la premierer execution
            btnAjouter.Visible = true;
            btnModifier.Visible = btnSupprimer.Visible = btnSauvegarder.Visible = btnAnnuler.Visible = false;
            btnPremier.Visible = btnPrecedent.Visible = btnSuivant.Visible = btnDernier.Visible = false;
            lblInformation.Text = "Collection vide, Cliquer sur Ajouter pour commencer";
            txtNumEtudiant.Text = txtNote.Text = txtNonPrenom.Text = "Vide";
            btnAjouter.Focus();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indicecourant > 0)
            {
                indicecourant = indicecourant - 1; // ou indicecourant-- ;
                txtNumEtudiant.Text = tousLesEtudiants[indicecourant].Numero;
                txtNonPrenom.Text = tousLesEtudiants[indicecourant].Nom;
                txtNote.Text = tousLesEtudiants[indicecourant].Note.ToString();
                datNaissance.Value = tousLesEtudiants[indicecourant].Naissance;
                // afficher information
                lblInformation.Text = "Etudiant " + (indicecourant + 1) +
                " sur un total de " + tousLesEtudiants.Count;
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (indicecourant < (tousLesEtudiants.Count - 1))
            {
                indicecourant = indicecourant + 1; // ou indicecourant++ ;
                txtNumEtudiant.Text = tousLesEtudiants[indicecourant].Numero;
                txtNonPrenom.Text = tousLesEtudiants[indicecourant].Nom;
                txtNote.Text = tousLesEtudiants[indicecourant].Note.ToString();
                datNaissance.Value = tousLesEtudiants[indicecourant].Naissance;
                // afficher information
                lblInformation.Text = "Etudiant " + (indicecourant + 1) +
                " sur un total de " + tousLesEtudiants.Count;
            }

        }
     

        private void btnDernier_Click(object sender, EventArgs e)
        {
            indicecourant = tousLesEtudiants.Count - 1;
            txtNumEtudiant.Text = tousLesEtudiants[indicecourant].Numero;
            txtNonPrenom.Text = tousLesEtudiants[indicecourant].Nom;
            txtNote.Text = tousLesEtudiants[indicecourant].Note.ToString();
            datNaissance.Value = tousLesEtudiants[indicecourant].Naissance;
            // afficher information
            lblInformation.Text = "Etudiant " + (indicecourant + 1) +
                " sur un total de " + tousLesEtudiants.Count;
        }

       

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string msg = "Etes-vous sur de vouloir supprimer cet(te) etudiant(e) ?";
            string titre = "Attention : Suppression";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // tousLesEtudiants.Remove(tousLesEtudiants[indicecourant]);
                tousLesEtudiants.RemoveAt(indicecourant);

                // apres suppresion, aller au premier si la collection n'est pas vide 
                if (tousLesEtudiants.Count > 0)
                {
                    btnPremier_Click(sender, e); // executer cette fonction
                }
                else
                {
                    FrmStructCollectionsFiles_Load(sender, e);
                }
            }
        }

       
    }
}
