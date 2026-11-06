using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsTousLesChapitres
{
    public partial class FrmVideo : Form
    {
        public FrmVideo()
        {
            InitializeComponent();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            
            string info = "";
            string titre = "validation avant sauvegarde ";

            // recuperer les donnees 
            info = info + "Client :" + txtNom.Text + "\n";
            info = info + " votre date de naissance est :" + datNaissance.Value.ToString() + "\n";

            info = info + " adresse : " + txtAdresse.Text + "\n";
            if (chkIdentite.Checked)
            {
                info = info + " preuve ID : oui \n";
            }
            else
            {
                info = info + " preuve ID : \n ";
            }
             if(radCelibataire.Checked)
            {
                info = info + " statut : Celibataire \n";
            }
             else if (radConjoint.Checked)
            {
                info = info + " statut : Conjoint \n";
            }
             else if (radMarie.Checked)
            {
                info = info + " statut : Marie(e) \n";
            }
            else if (radSepare.Checked)
            {
                info = info + " statut : Separe (e) \n";
            }
            else
            {
                info = info + " statut : invalid \n";
            }

            if (radVisa.Checked)
            {
                info = info + " Carte : Visa \n";
            }
            else if (radMastercard.Checked)
            {
                info = info + " Carte : mastercard \n";
            }
            else if (radAmex.Checked)
            {
                info = info + " Carte : American express \n";
            }
            else
            {
                info = info + " Carte : invalid \n";
            }
            info = info + " numero " +txtCard.Text + "\n";

            info = info + " \n les films loues : \n";

            //for (int i = 0; i < lstFilms.Items.Count; i++)
            //{
              //  info = info + " - " + lstFilms.Items[i] + " \n ";

            //}
            foreach(string film in lstFilms.Items)
            {
                info = info + " - " + film + "\n";
            }

            info = info + " Special du jour : " + cboSpecial.SelectedItem + "\n";

            // calcul de la facture

            int nbFilms=lstFilms.Items.Count;
            decimal facture ;
            if (cboSpecial.SelectedItem.ToString()=="Regulier"|| 
                cboSpecial.SelectedItem.ToString() == "PopCorn gratuit")

            {
                facture = nbFilms * 4;
            }
            else // pour le 2 pour 1
            {
                facture=(nbFilms+1)/2 * 4;
                // home work 
                // trouver la formule mathematique
            }

            info = info + " La facture est : " + facture + " $ \n";


            info = info + "\n\n les informations sont-elles exactes ?";
            MessageBox.Show(info, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void FrmVideo_Load(object sender, EventArgs e)
        {
           radCelibataire.Checked = true;
            radVisa.Checked = true;
            btnLouer.Visible = false;
            lblTitre.Visible = btnAjouter.Visible = txtTitre.Visible = false;
            // remplir le combo box avec les speciaux
            cboSpecial.Items.Add("Regulier");
            cboSpecial.Items.Add("PopCorn gratuit");
            cboSpecial.Items.Add("2 pour 1");
            btnRetourner.Visible = false;

            // selectionner le premier element (Regulier)par defaut 
            cboSpecial.SelectedIndex = 0;


        }
        private void chkIdentite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIdentite.Checked==true)
            {
                btnLouer.Show();
            }
            else
            {
                btnLouer.Hide();
                lblTitre.Hide();
                txtTitre.Hide();
                btnAjouter.Hide();
            }
        }
        private void btnLouer_Click(object sender, EventArgs e)
        {
           lblTitre.Show();
            txtTitre.Show();
            btnAjouter.Show();
            txtTitre.Focus();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lstFilms.Items.Add(txtTitre.Text);
            txtTitre.Text = "";
            txtTitre.Focus();
        }

        private void radSepare_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //montrer le bouton retourner :
            if(lstFilms.SelectedIndex != -1)
            {
                btnRetourner.Show();
            }
            else { btnRetourner.Hide();}
        }

        private void btnRetourner_Click(object sender, EventArgs e)
        {
            //lstFilms.Items.Remove(lstFilms.SelectedItem);

            lstFilms.Items.RemoveAt(lstFilms.SelectedIndex);
            btnRetourner.Visible = false;
        }
    }
}
