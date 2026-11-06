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
    public partial class frmPrincipale : Form
    {
        public frmPrincipale()
        {
            InitializeComponent();
        }

        private void connexionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            string msg = "Voulez-vous vraiment quitter ce programme?";
            string titre = "Fermeture de l'application";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();

            }

            /* 
             DialogResult result= MessageBox.Show("Voulez-vous m'epouser ?","Demande en marriage",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }*/
        }

        private void mnuConditions_Click(object sender, EventArgs e)
        {
            frmConditions frmC = new frmConditions();
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void mnuVideo_Click(object sender, EventArgs e)
        {
            frmVideo fv = new frmVideo();
            fv.MdiParent = this;
            fv.Show();
        }
    }
}
