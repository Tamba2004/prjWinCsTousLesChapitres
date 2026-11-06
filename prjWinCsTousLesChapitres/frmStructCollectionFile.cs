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
    public partial class frmStructCollectionFile : Form
    {
        struct Etudient
        {
            public string Numero;
            public string Nom;
            public DateTime Naissance;
            public Single Note;

        }
        //colelction 
        List<Etudient> TousLesEtudiants = new List<Etudient>();

        int indiceCourant;

        string mode;
        public frmStructCollectionFile()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmStructCollectionFile_Load(object sender, EventArgs e)
        {
            LireFichierVersCollection();
            //situation de la form au demarrage
            if (TousLesEtudiants.Count == 0)
            {
                btnAjouter.Visible = true;
                btnModifier.Visible = btnSauvegarder.Visible = btnSupprimer.Visible = btnAnnuler.Visible = false;
                btnDernier.Visible = btnPremier.Visible = btnSuivant.Visible = btnPrecedent.Visible = false;
                lblInformation.Text = "Collection vide, cliquer sur Ajouter pour commencer";
                txtNumero.Text = txtNomPrenom.Text = "vide";
                btnAjouter.Focus();
            }
            else
            {

                ReinitialiserListeNumero();

            }




        }
        private void LireFichierVersCollection()
        {
            // ouvrir le fichier en lecture
            StreamReader monFichier = new StreamReader("etudiantsDB.txt");
            //tantque on a pas atteint la fin du fichier 
            while (monFichier.EndOfStream == false)
            {
                Etudient etud;
                etud.Numero = monFichier.ReadLine();
                etud.Nom = monFichier.ReadLine();            
                etud.Naissance = Convert.ToDateTime(monFichier.ReadLine());
                etud.Note = Convert.ToSingle(monFichier.ReadLine());
                //ajouter cet etudiant dans la collection
                TousLesEtudiants.Add(etud);
            }
            monFichier.Close();

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            //
            mode = "ajout";
            txtNumero.Focus();


            btnSauvegarder.Visible = btnAnnuler.Visible = true;
            btnAjouter.Visible = btnSupprimer.Visible = btnModifier.Visible = false;
            btnDernier.Visible = btnPremier.Visible = btnSuivant.Visible = btnPrecedent.Visible = false;
            lblInfoEtudiant.Text = "En mode Ajout, Entrez les données";
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if (mode == "ajout")
            {
                // en mode ajout, créer un etudiant et remplir ses informations avec
                Etudient unEtud;
                unEtud.Numero = txtNumero.Text;
                unEtud.Nom = txtNomPrenom.Text;
                unEtud.Naissance = datNaissance.Value;
                unEtud.Note = Convert.ToSingle(txtNoteFinale.Text);
                //ajouter cette etudiant dans la collection
                TousLesEtudiants.Add(unEtud);


                //


            }
            if (mode == "modif")
            {
                // en mode modif, créer un etudiant et remplir ses informations avec
                Etudient unEtud;
                unEtud.Numero = txtNumero.Text;
                unEtud.Nom = txtNomPrenom.Text;
                unEtud.Naissance = datNaissance.Value;
                unEtud.Note = Convert.ToSingle(txtNoteFinale.Text);
                // en suite ecraser ou inserer cet etudiant à la position de indice courant
                TousLesEtudiants[indiceCourant] = unEtud;
                // indice change pour afficher le dernier element
                indiceCourant = TousLesEtudiants.Count - 1;
            }
            //aficher
            btnSauvegarder.Visible = btnAnnuler.Visible = false;
            btnAjouter.Visible = btnSupprimer.Visible = btnModifier.Visible = true;
            btnDernier.Visible = btnPremier.Visible = btnSuivant.Visible = btnPrecedent.Visible = true;

            //
            ReinitialiserListeNumero();
            AfficherInfosEtudiant();
        }

        private void ReinitialiserListeNumero()
        {
            //vider la list box
            lstNumero.Items.Clear();

            //boucler dans la collection, recuperer et inserer le numero de chaque etudiant dans la listbox
            foreach (Etudient etud in TousLesEtudiants)
            {
                //lstNumero.Items.Add(etud.Numero+" - "+etud.Nom);
                lstNumero.Items.Add(etud.Numero);
            }

        }
        private void btnPremier_Click(object sender, EventArgs e)
        {
            indiceCourant = 0;
            AfficherInfosEtudiant();

        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indiceCourant > 0)
            {
                indiceCourant--;
                AfficherInfosEtudiant();
            }

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {


            if (indiceCourant < (TousLesEtudiants.Count - 1))
            {
                indiceCourant++;
                AfficherInfosEtudiant();
            }
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            indiceCourant = TousLesEtudiants.Count() - 1;
            AfficherInfosEtudiant();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            mode = "modif";
            txtNumero.Focus();

            //cacher les boutons
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = false;
            btnSauvegarder.Visible = btnAnnuler.Visible = true;
            btnPremier.Visible = btnPrecedent.Visible = btnSuivant.Visible = btnDernier.Visible = false;

            // afficher information
            lblInformation.Text = "En mode MODIFICATION, changez les donnees";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string msg = "Etes-vous sur de vouloir supprimer cet(te) etudiant(e) ?";
            string titre = "Attention : Suppression";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // tousLesEtudiants.Remove(tousLesEtudiants[indicecourant]);
                TousLesEtudiants.RemoveAt(indiceCourant);

                // apres suppresion, aller au premier si la collection n'est pas vide 
                if (TousLesEtudiants.Count > 0)
                {
                    btnPremier_Click(sender, e); // executer cette fonction
                    // mettre a jour la listebox apres suppression
                    ReinitialiserListeNumero();
                }
                else
                {
                    frmStructCollectionFile_Load(sender, e);
                }
            }

        }
        private void AfficherInfosEtudiant()
        {
            txtNumero.Text = TousLesEtudiants[indiceCourant].Numero;
            txtNomPrenom.Text = TousLesEtudiants[indiceCourant].Nom;
            txtNoteFinale.Text = TousLesEtudiants[indiceCourant].Note.ToString();
            datNaissance.Value = TousLesEtudiants[indiceCourant].Naissance;
            // afficher information
            lblInformation.Text = "Etudiant " + (indiceCourant + 1) +
            " sur un total de " + TousLesEtudiants.Count;
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            AfficherInfosEtudiant();

        }

        private void lstNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            //trouver un etudiant dont l'inde est selectionné et l'afficher dans le label
            // recuperer le numero choisi

            string numeroChoisi = lstNumero.SelectedItem.ToString();
            //boucler pour trouver l'etudiant avec ce numero dans la collection
            foreach (Etudient etud in TousLesEtudiants)
            {
                if (numeroChoisi == etud.Numero)
                {
                    int age = DateTime.Today.Year - etud.Naissance.Year;
                    string resultat = (etud.Note < 60) ? "Echec" : "Succes";
                    lblInfoEtudiant.Text = "Numéro:" + etud.Numero +
                        "\nNom : " + etud.Nom + "" +
                        "\nDate de naissance :" + etud.Naissance.ToShortDateString() + "" +
                        "\nNote:" + etud.Note + "" +
                        "\nAge : " + age + " ans" +
                        "\nRésultat : " + resultat;
                }
            }
        }

        private void frmStructCollectionFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ecrire le code pour ecrire la collection dans le fichier text
            ReinitialiserListeNumero();
            StreamWriter monFichier = new StreamWriter("etudiantsDB.txt");
            foreach (Etudient etud in TousLesEtudiants)
            {
                monFichier.WriteLine(etud.Numero);
                monFichier.WriteLine(etud.Nom);
                monFichier.WriteLine(etud.Naissance.ToShortDateString());
                monFichier.WriteLine(etud.Note);
            }
            monFichier.Close();
        }
    }
}


/*
 public partial class frmStructCollectionFile : Form
{
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
 
    public frmStructCollectionFile()
    {
        InitializeComponent();
    }
 
    private void frmStructCollectionFile_Load(object sender, EventArgs e)
    {
        // situation de la form a la premierer execution
        btnAjouter.Visible = true;
        btnModifier.Visible = btnSupprimer.Visible = btnSauvegarder.Visible = btnAnnuler.Visible = false;
        btnPremier.Visible = btnPrecedent.Visible = btnSuivant.Visible = btnDernier.Visible = false;
        lblInformation.Text = "Collection vide, Cliquer sur Ajouter pour commencer";
        txtNumero.Text = txtNote.Text = txtNom.Text = "Vide";
        btnAjouter.Focus();
 
    }
 
    private void btnAjouter_Click(object sender, EventArgs e)
    {
        mode = "ajout";
 
        // vider les textbox
        txtNumero.Text = txtNote.Text = txtNom.Text = "";
        txtNumero.Focus();
 
        //cacher les boutons
        btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = false;
        btnSauvegarder.Visible = btnAnnuler.Visible = true;
        btnPremier.Visible = btnPrecedent.Visible = btnSuivant.Visible = btnDernier.Visible = false;
 
        // afficher information
        lblInformation.Text = "En mode AJOUT, entrez les donnees";
    }
 
    private void btnSauvegarder_Click(object sender, EventArgs e)
    {
 
        if(mode == "ajout")
        {
            // en mode ajout, creer un etudiant et remplir ses informations avec les valeurs entrees
            Etudiant unEtud;
            unEtud.Numero = txtNumero.Text;
            unEtud.Nom = txtNom.Text;
            unEtud.Naissance = datNaissance.Value;
            unEtud.Note = Convert.ToSingle(txtNote.Text);
            // ajouter cet etudiant dans la collection
            tousLesEtudiants.Add(unEtud);
            // apres, indice courant change pour afficher le dernier elelment
            indicecourant = tousLesEtudiants.Count - 1;
        }
        if(mode == "modif")
        {
            // en mode modification, creer un etudiant et remplir ses informations avec les valeurs entrees
            Etudiant unEtud;
            unEtud.Numero = txtNumero.Text;
            unEtud.Nom = txtNom.Text;
            unEtud.Naissance = datNaissance.Value;
            unEtud.Note = Convert.ToSingle(txtNote.Text);
            // ensuite, ecraser (ou inserer) cet etudiant a la position de indice courant
            tousLesEtudiants[indicecourant]= unEtud;
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
        txtNumero.Text = tousLesEtudiants[indicecourant].Numero;
        txtNom.Text = tousLesEtudiants[indicecourant].Nom;
        txtNote.Text = tousLesEtudiants[indicecourant].Note.ToString();
        datNaissance.Value = tousLesEtudiants[indicecourant].Naissance;
        // afficher information
        lblInformation.Text = "Etudiant " + (indicecourant + 1) +
            " sur un total de " + tousLesEtudiants.Count;
    }
 
    private void btnPrecedent_Click(object sender, EventArgs e)
    {
        if(indicecourant > 0)
        {
            indicecourant = indicecourant - 1; // ou indicecourant-- ;
            txtNumero.Text = tousLesEtudiants[indicecourant].Numero;
            txtNom.Text = tousLesEtudiants[indicecourant].Nom;
            txtNote.Text = tousLesEtudiants[indicecourant].Note.ToString();
            datNaissance.Value = tousLesEtudiants[indicecourant].Naissance;
            // afficher information
            lblInformation.Text = "Etudiant " + (indicecourant + 1) +
            " sur un total de " + tousLesEtudiants.Count;
        }
    }
 
    private void btnSuivant_Click(object sender, EventArgs e)
    {
        if(indicecourant < (tousLesEtudiants.Count - 1))
        {
            indicecourant = indicecourant + 1; // ou indicecourant++ ;
            txtNumero.Text = tousLesEtudiants[indicecourant].Numero;
            txtNom.Text = tousLesEtudiants[indicecourant].Nom;
            txtNote.Text = tousLesEtudiants[indicecourant].Note.ToString();
            datNaissance.Value = tousLesEtudiants[indicecourant].Naissance;
            // afficher information
            lblInformation.Text = "Etudiant " + (indicecourant + 1) +
            " sur un total de " + tousLesEtudiants.Count;
        }
    }
 
    private void btnDernier_Click(object sender, EventArgs e)
    {
        indicecourant = tousLesEtudiants.Count  - 1; 
        txtNumero.Text = tousLesEtudiants[indicecourant].Numero;
        txtNom.Text = tousLesEtudiants[indicecourant].Nom;
        txtNote.Text = tousLesEtudiants[indicecourant].Note.ToString();
        datNaissance.Value = tousLesEtudiants[indicecourant].Naissance;
        // afficher information
        lblInformation.Text = "Etudiant " + (indicecourant + 1) +
            " sur un total de " + tousLesEtudiants.Count;
    }
 
    private void btnModifier_Click(object sender, EventArgs e)
    {
        mode = "modif";
        txtNumero.Focus();
 
        //cacher les boutons
        btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = false;
        btnSauvegarder.Visible = btnAnnuler.Visible = true;
        btnPremier.Visible = btnPrecedent.Visible = btnSuivant.Visible = btnDernier.Visible = false;
 
        // afficher information
        lblInformation.Text = "En mode MODIFICATION, changez les donnees";
 
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
            if(tousLesEtudiants.Count > 0)
            {
                btnPremier_Click(sender, e); // executer cette fonction
            }
            else
            {
                frmStructCollectionFile_Load(sender, e);
            }
        }
 
    }
 
 */