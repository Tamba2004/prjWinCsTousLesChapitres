using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsTousLesChapitres
{
    public partial class FrmCarnet : Form
    {
        public FrmCarnet()
        {
            InitializeComponent();
        }

        private void FrmCarnet_Load(object sender, EventArgs e)
        {
          txtNomPrenom.Focus();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {

            string nomcomplet, adresse, vpcp;
            string nom, prenom, numero, rue, ville, province, codepostal;
            int posV , posV1;
            nomcomplet = txtNomPrenom.Text;
            nomcomplet = nomcomplet.Trim();

            if (nomcomplet.Length == 0)
            {
                MessageBox.Show("veillez entrer  nom , prenom", "chaine vide");
                txtNomPrenom.Focus();
                return;
            }
            
            

            posV = nomcomplet.IndexOf(",");
            if (posV == -1)
            {
                MessageBox.Show("veillez entrer une vigule entre  nom , prenom", " vigule manquante ");
                txtNomPrenom.Focus();
                return;
            }    
            nom = nomcomplet.Substring(0, posV);
            nom = nom.Trim();
            if (nom.Length == 0)
            {
                MessageBox.Show("veillez entrer votre  nom ", " nom manquant ");
                txtNomPrenom.Focus();
                return;
            }
            prenom = nomcomplet.Substring(posV + 1);
            prenom = prenom.Trim();

            if (prenom.Length == 0)
            {
                MessageBox.Show("veillez entrer votre  prenom ", " prenom manquant ");
                txtNomPrenom.Focus();
                return;
            }
            //valide le nom complet

            adresse =txtAdresse.Text;
            adresse=adresse.Trim();
            if (adresse.Length == 0)
            {
                MessageBox.Show(" veillez entrer l adresse", "adresse manquante");
                txtAdresse.Focus();
                return;
            }
            posV =adresse.IndexOf(",");
            if (posV == -1)
            {
                MessageBox.Show("veillez entrer une vigule entre  numero , rue", " vigule manquante ");
                txtAdresse.Focus();
                return;
            }
            numero =adresse.Substring(0,posV);
            numero=numero.Trim();
            if (numero.Length == 0)
            {
                MessageBox.Show("veillez entrer entre  numero d appartement  ", " numero manquant ");
                txtAdresse.Focus();
                return;
            }
            rue =adresse.Substring(posV+1);
            rue=rue.Trim();
            if (rue.Length == 0)
            {
                MessageBox.Show("veillez entrer adresse de rue ", " rue manquant ");
                txtAdresse.Focus();
                return;
            }



            vpcp =txtVilleProvinPost.Text;
            vpcp = vpcp.Trim();

            if (vpcp.Length == 0) 
            {
                MessageBox.Show("veillez entrer un vpcp", "vpcp manquant");
                txtVilleProvinPost.Focus();
                return ;
            }

            posV=vpcp.IndexOf(",");
            if (posV ==-1)
            {
                MessageBox.Show("veillez mettre une virgule entre ville et province ", "vigule manquante");
                txtVilleProvinPost.Focus();
                return;
            }

            posV1 = vpcp.IndexOf(",",posV+1); 
            if (posV1 == -1)
            {
                MessageBox.Show("veillez entrer une vigule entre province et code postal", "vigule manquantes");
                txtVilleProvinPost.Focus();
                return;
            }
              
            ville=vpcp.Substring(0,posV);
            ville = ville.Trim();
            
            if (ville.Length == 0)
            {
                MessageBox.Show("veillez entrer une ville", "ville manquante");
                txtVilleProvinPost.Focus();
                return;
            }

            province = vpcp.Substring(posV + 1, posV1 - posV - 1);
            province = province.Trim();
            if (province.Length == 0)
            {
                MessageBox.Show("veillez entrer une province", "province manquante");
                txtVilleProvinPost.Focus();
                return;
            }
            
            codepostal =vpcp.Substring(posV1+1);
            codepostal=codepostal.Trim();
            if (codepostal.Length == 0)
            {
                MessageBox.Show("veillez entrer un code postal", "code postal manquant");
                txtVilleProvinPost.Focus();
                return;
            }

            nom = nom.Substring(0,1).ToUpper() + nom.Substring(1).ToLower();
            prenom = prenom.Substring(0, 1).ToUpper() + prenom.Substring(1).ToLower();
            rue = rue.Substring(0, 1).ToUpper() + rue.Substring(1).ToLower();
            ville = ville.Substring(0, 1).ToUpper() + ville.Substring(1).ToLower();
            province = province.Substring(0, 1).ToUpper() + province.Substring(1).ToLower();
            codepostal = codepostal.ToUpper();
          
            lblResulNom.Text = nom;
            lblResultPrenom.Text = prenom;
            lblResultAdresseNumero.Text = numero;
            lblResultAdresseRue.Text = rue;
            lblResultVille.Text=ville;
            lblResultProvince.Text = province;
            lblResultCodePostal.Text = codepostal;

            txtNomPrenom.Clear();
            txtAdresse.Clear();
            txtVilleProvinPost.Clear();

            txtNomPrenom.Focus();


        }
    }
}
