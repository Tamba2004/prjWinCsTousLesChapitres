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
            radioButton2.Checked = true;
            // lblResultat.Text = "Bienvenue!";
            // string nom = "Joseph Ngamuna";
            //lblResultat.Text = Convert.ToString(nom.Length);
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            //declaration de v
            string nomcomplet, adresse, vpc;
            string nom, prenom, numero, avenue, ville, province, codeP;
            int pos_vir_nom, pos_espace_ad, pos_vir1vpc, pos_vir2vpc;

            nomcomplet = txtNomPrenom.Text.Trim();
            if (nomcomplet.Length==0)
            {
                MessageBox.Show("veuiller remplir le nom!"); 
                txtNomPrenom.Focus();
                return;
            }
           
          

            pos_vir_nom = nomcomplet.IndexOf(",");
            if (pos_vir_nom==-1)
            {
                MessageBox.Show("Veuiller introduire la virgule");
                txtNomPrenom.Focus();
                return;
            }

            nom = nomcomplet.Substring(0, pos_vir_nom);
            if (nom.Length == 0) {
                MessageBox.Show("veiller entrer le nom");
                txtNomPrenom.Focus();
                return;
            }
            prenom = nomcomplet.Substring(pos_vir_nom + 1);
            if (prenom.Length==0)
            {
                MessageBox.Show("veuiller entre le prenom");
                txtNomPrenom.Focus();
                return;
            }
            lblNom.Text = nom;
            lblPrenom.Text = prenom;


            adresse = txtAdresse.Text.Trim();
            if (adresse.Length==0)
            {
                MessageBox.Show("veuiller remplir le nom!");
                txtAdresse.Focus();
                return;
            }


            pos_espace_ad = adresse.IndexOf(" ");
            if (pos_espace_ad == -1)
            {
                MessageBox.Show("veiller mettre un espace entre le numero et la rue");
                txtAdresse.Focus();
                return;
            }

            numero = adresse.Substring(0, pos_espace_ad);
            
            avenue = adresse.Substring(pos_espace_ad + 1);

            lblRue.Text = avenue;
            lblNumero.Text = numero;





  
            vpc = txtLoocalisation.Text.Trim();
            if (vpc.Length == 0)
            {
                MessageBox.Show("veuiller remplir la ville, prov, CP");

            }
            pos_vir1vpc = vpc.IndexOf(",");
            pos_vir2vpc = vpc.IndexOf(",", pos_vir1vpc + 1);
            //lblVille.Text = pos_vir2vpc.ToString();
            ville = vpc.Substring(0, pos_vir1vpc);
            province = vpc.Substring(pos_vir1vpc + 1, pos_vir2vpc - pos_vir1vpc - 1);
            codeP = vpc.Substring(pos_vir2vpc + 1);

            lblVille.Text = ville;
            lblProvince.Text = province;
            lblCodeP.Text = codeP;




            

        }


        private void lblCodeP_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buuu= (radioButton2.Checked) ?"KO":"LKIUHJK";

           // MessageBox.Show(txt);
        }
    }
}
