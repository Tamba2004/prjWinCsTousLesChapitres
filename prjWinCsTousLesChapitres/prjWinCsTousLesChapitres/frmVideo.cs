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
            string info = "";
            string titre = "Validation avant Sauvegarde";
            // recuperation des donnees
            info = info + "Client : " + txtNom.Text + "\n";
            info = info + "Date de Naisssance : " + datNaissance.Text + "\n";
            // calcul age
            int age = DateTime.Today.Year - datNaissance.Value.Year;
            info = info + "Age : " + age + " ans\n";

            info += "Adresse : " + txtAdresse.Text + "\n";

            //info += "Preuve ID : ";
            //if (chkIdentite.Checked == true)
            //{ info += "Oui \n"; }
            //else
            //{ info += "Non \n"; }

            info += "Preuve ID : " + ((chkIdentite.Checked == true) ? " Oui\n" : " Non\n");

            // trouver statut
            info += "Statut : ";
            if (radCelibataire.Checked == true)
            { info += " Celibataire \n"; }
            else if (radMarie.Checked == true)
            { info += " Marie(e) \n"; }
            else if (radSepare.Checked == true)
            { info += " Separe(e) \n"; }
            else
            { info += " Conjoint(e) \n"; }


            // trouver carte
            info += "Carte : ";
            if (radVisa.Checked == true)
            { info += " Visa \n"; }
            else if (radMastercard.Checked == true)
            { info += " Mastercard \n"; }
            else
            { info += " American Express \n"; }

            info += "N: " + txtCarte.Text + "\n";

            // afficher les films de la liste
            info += "\nLes films loues :\n";
            // boucler sur le listbox
            //// version for avec index
            //for(int i = 0; i < lstFilms.Items.Count ; i++)
            //{
            //    info += " - " + lstFilms.Items[i] + "\n";
            //}

            // version foreach
            foreach (string film in lstFilms.Items)
            {
                info += " - " + film + "\n";
            }

            // le special choisi
            info += "Special du jour : " + cboSpecial.SelectedItem + "\n";
            // calcul de la facture 
            int nbfilms = lstFilms.Items.Count;
            decimal facture = 0;
            if(cboSpecial.SelectedItem.ToString() == "Regulier" || 
                cboSpecial.SelectedItem.ToString() == "Popcorn gratuit")
            {
                facture = nbfilms * 4;
            }
            else // pour le "2 pour 1"
            {
               facture = (nbfilms + 1) / 2 * 4;
            }

            info += "La facture est : " + facture + " $ \n";


            info = info + "\n\nLes informations sont-elles exactes ?";

            MessageBox.Show(info, titre, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            // les radios coches par defaut au depart
            radCelibataire.Checked = true;
            radVisa.Checked = true;
            this.Height = 1540 / 2;
            btnLouer.Visible = false;
            lblTitre.Visible = txtTitre.Visible = btnAjouter.Visible = false;
            btnRetourner.Visible = false;
            // remplir le combobox avec les speciaux
            cboSpecial.Items.Add("Regulier");
            cboSpecial.Items.Add("Popcorn gratuit");
            cboSpecial.Items.Add("2 pour 1");
            // selectionner le premier element(Regulier) par defaut
            cboSpecial.SelectedIndex = 0;


        }

        private void chkIdentite_CheckedChanged(object sender, EventArgs e)
        {
            //  rendre visible btnLouer si coché et vice versa
            // if(chkIdentite.Checked == true) 
            //{
            //    btnLouer.Visible = true;
            //}
            //else //if(chkIdentite.Checked == false) 
            //{
            //    btnLouer.Visible = false;
            // }

            // btnLouer.Visible = (chkIdentite.Checked == true) ? true : false;

            btnLouer.Visible = chkIdentite.Checked;
         
        }

        private void btnLouer_Click(object sender, EventArgs e)
        {
            // afficher label, textbox et bouton pour entrer un titre
            lblTitre.Visible = txtTitre.Visible = btnAjouter.Visible = true;
            txtTitre.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //  ajouter le titre du film dans le listebox
            string titre;
            titre = txtTitre.Text;
            if(titre != "")
            {
                lstFilms.Items.Add(titre);
            }
            

            lblTitre.Visible = txtTitre.Visible = btnAjouter.Visible = false;
            txtTitre.Text = "";
        }

        private void lstFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // montrer le bouton retourner si un film est selectionne
            if(lstFilms.SelectedIndex != -1)
            {
                btnRetourner.Visible = true;
            }
            else { btnRetourner.Visible = false; }
        }

        private void btnRetourner_Click(object sender, EventArgs e)
        {
            //supprimer element selectionne dans lstFilms
            // version Remove
            //lstFilms.Items.Remove(lstFilms.SelectedItem);
            // version RemoveAt
           lstFilms.Items.RemoveAt(lstFilms.SelectedIndex);
            btnRetourner.Visible = false;
        }
    }
}
