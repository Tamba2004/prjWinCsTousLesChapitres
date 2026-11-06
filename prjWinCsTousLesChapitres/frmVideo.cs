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
    public partial class frmVideo : Form
    {
        public frmVideo()
        {
            InitializeComponent();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            //Déclaration des variable et affectations
            string info = "";
            string titre = "Validation avant sauvegarde";
            string client = txtNom.Text;
            string adresse = txtAdresse.Text;
            string pvID = chkIdentite.Checked ? "Oui" : "Non";
            string statut, carte;
            string numCarte = txtCarte.Text;
            DateTime date = datNaissance.Value;
            string filmLoue = "";
            string special = cboSpecial.SelectedItem.ToString();
            int nbrFilm = lstFilm.Items.Count;
            decimal facture = 0;



            // calcul facture

            if (cboSpecial.SelectedItem.ToString()=="Regulier"|| cboSpecial.SelectedItem.ToString() == "Popcorn gratuit")
            {
                facture = nbrFilm * 4;
            }
            else
            {
                facture = ((nbrFilm % 2) * 4 )+ ((nbrFilm / 2) * 4) ;
            }

            // boucle for, collection 
            for (int i = 0; i < lstFilm.Items.Count; i++)
            {
                filmLoue += lstFilm.Items[i] + "\n";
            }
            

            //calcul d'âge  et conditions

            //age
            Int32 age = DateTime.Now.Year - date.Year; 

            //statut
            if (radCelibataire.Checked)
                statut = "Celibaire";
            else if (radMarie.Checked)
                statut = "Marié(e)";
            else if (radSepare.Checked)
                statut = "Separé(e)";
            else
                statut = "Conjoint(e)";



            //carte
            if (radVisa.Checked)
                carte = "Visa";
            else if (radMastercard.Checked)
                carte = "Mastercard";
            else
                carte = "Amrican Express";




            //affectations finales et affichage
            
            
            info = "Client :" + client
                + "\nDate de naissance: " + date.DayOfWeek + ", Le " + date.ToLongDateString()
                + "\nAge du client: " + age + " ans"
                + "\nAdresse du client: " + adresse
                + "\nPreuve ID: " + pvID
                + "\nStatut: " + statut
                + "\nCarte: " + carte
                + "\nNuméro: " + numCarte
                + "\nFilms loué: \n" + filmLoue
                +"\nSpécial du jour:"+special 
                +"\nFacture: "+facture
                + "\n\nLes informations sont-elles exactes?";
            MessageBox.Show(info, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        

        private void frmVideo_Load(object sender, EventArgs e)
        {
            radVisa.Checked = true;
            radCelibataire.Checked = true;
            btnLouer.Visible = false;
            lblTitre.Visible = false;
            txtTitre.Visible = false;
            btnAjouter.Visible = false;
            btnRetourner.Visible = false;
            //
            cboSpecial.Items.Add("Regulier");
            cboSpecial.Items.Add("PopCorn gratuit");
            cboSpecial.Items.Add("2 Pour 1");
            // select first element who's "regulier"
            cboSpecial.SelectedIndex = 0;
            MessageBox.Show(cboSpecial.SelectedItem.ToString());

        }

        private void chkIdentite_CheckedChanged(object sender, EventArgs e)
        {
            //ren
            //if (chkIdentite.Checked)
            //    btnLouer.Visible = true;
            //else
            //    btnLouer.Visible = false;
            btnLouer.Visible = (chkIdentite.Checked) ? true : false;
        }

        private void btnLouer_Click(object sender, EventArgs e)
        {
            lblTitre.Visible = true;
            txtTitre.Visible = true;
            btnAjouter.Visible = true;
            txtTitre.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lstFilm.Items.Add(txtTitre.Text);
            txtTitre.Text = "";
            lblTitre.Visible = false;
            txtTitre.Visible = false;
            btnAjouter.Visible = false;
        }

        private void lstFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilm.SelectedIndex != -1)
                btnRetourner.Visible = true; 
            else
                btnRetourner.Visible = false;
        }

        private void btnRetourner_Click(object sender, EventArgs e)
        {
            lstFilm.Items.Remove(lstFilm.SelectedItem);

            btnRetourner.Visible=false;

            //lstFilm.Items.Remove(lstFilm.SelectedIndex);
        }
    }
}
