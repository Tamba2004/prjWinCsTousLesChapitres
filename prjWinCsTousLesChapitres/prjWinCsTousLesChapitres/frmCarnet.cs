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
    public partial class frmCarnet : Form
    {
        public frmCarnet()
        {
            InitializeComponent();
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {

          
        
        
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            // variables
            // valeurs echangees ?
            string nomcomplet, adresse, vpcp;
            // valeurs calculees ?
            string nom, prenom, numero, rue, ville, province, codepostal;
            int posV, posEspace, posV1, posV2;

            // ====== Recuperation nom et Prenom ======
            
            // recuperer nomcomplet
            nomcomplet = txtNomPrenom.Text;
            // enlever les espaces
            nomcomplet = nomcomplet.Trim();

            //valider nom, prenom
            if(nomcomplet.Length == 0)
            {
                MessageBox.Show("Veuillez entrer Nom, Prenom !", "Chaine vide");
                txtNomPrenom.Focus();
                return;
            }

            // trouver position de la virgule
            posV = nomcomplet.IndexOf(",");
            //valider la virgule
            if (posV == -1)
            {
                MessageBox.Show("Veuillez entrer une virgule entre Nom et Prenom !", "Virgule manquante");
                txtNomPrenom.Focus();
                return;
            }


            // trouver le nom
            nom = nomcomplet.Substring(0, posV);
            nom = nom.Trim();
            //valider nom
            if (nom.Length == 0)
            {
                MessageBox.Show("Veuillez entrer un Nom !", "Nom manquant");
                txtNomPrenom.Focus();
                return;
            }

            // trouver le prenom
            prenom = nomcomplet.Substring(posV + 1);
            prenom = prenom.Trim();

            //valider prenom
            if (prenom.Length == 0)
            {
                MessageBox.Show("Veuillez entrer un Prenom !", "Prenom manquant");
                txtNomPrenom.Focus();
                return;
            }

            // ====== Recuperation Numero et Rue ======

            // recupere adresse
            adresse = txtAdresse.Text.Trim();
            //valider adresse
            if (adresse.Length == 0)
            {
                MessageBox.Show("Veuillez entrer une adresse !", "Adresse vide");
                txtAdresse.Focus();
                return;
            }
            // recuperer position espace
            posEspace = adresse.IndexOf(" ");
            // valider position espace
            if (posEspace == -1)
            {
                MessageBox.Show("Veuillez entrer un espace entre Numero et Rue !", "Espace manquant");
                txtAdresse.Focus();
                return;
            }

            // recuperer numero
            numero = adresse.Substring(0, posEspace);
            numero = numero.Trim();
            // valider numero
            if (numero.Length == 0)
            {
                MessageBox.Show("Veuillez entrer un numero dans adresse !", "Numero manquant");
                txtAdresse.Focus();
                return;
            }

            // recuperer rue
            rue = adresse.Substring(posEspace + 1);
            rue = rue.Trim();
            // valider rue
            if (rue.Length == 0)
            {
                MessageBox.Show("Veuillez entrer une rue dans adresse !", "Rue manquante");
                txtAdresse.Focus();
                return;
            }

            // ====== Recuperation Ville, Porvince et Code postal ======

            vpcp = txtVPCP.Text.Trim();
            // trouver position virgule 1
            posV1 = vpcp.IndexOf(",");
            // trouver ville
            ville = vpcp.Substring(0, posV1);
            ville = ville.Trim();
           // trouver position virgule 2
            posV2 = vpcp.IndexOf(",", posV1 + 1);
            // trouver province
            province = vpcp.Substring(posV1 + 1, posV2 - posV1 - 1);
            province = province.Trim();
            // trouver CODE POSTAL
           codepostal = vpcp.Substring(posV2 + 1);
            codepostal = codepostal.Trim();


            // ==== Transformer Majuscule et Minuscule  ===========
            nom = nom.Substring(0, 1).ToUpper() + nom.Substring(1).ToLower();
            prenom = prenom.Substring(0, 1).ToUpper() + prenom.Substring(1).ToLower();
            rue = rue.Substring(0, 1).ToUpper() + rue.Substring(1).ToLower();
            ville = ville.Substring(0, 1).ToUpper() + ville.Substring(1).ToLower();
            province = province.Substring(0, 1).ToUpper() + province.Substring(1).ToLower();
            codepostal = codepostal.ToUpper();


             // afficher dans les labels
            lblNom.Text = nom;
            lblPrenom.Text = prenom;
            lblAdresseNumero.Text = numero;
            lblAdresseRue.Text = rue;
            lblVille.Text = ville;
            lblProvince.Text = province;
            lblCodePostal.Text = codepostal;
        }

        
    }
}
