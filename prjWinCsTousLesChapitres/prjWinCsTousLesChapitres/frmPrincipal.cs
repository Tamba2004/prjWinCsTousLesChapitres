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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            string msg = "Voulez vous vraiment quitter ce programme ?";
            string titre = "Fermeture de l'application";
            if(MessageBox.Show(msg,titre, MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            
            
        }

        private void mnuConditions_Click(object sender, EventArgs e)
        {
            frmConditions FC = new frmConditions();
            FC.MdiParent = this;
            FC.Show();
        }

        private void mnuVideo_Click(object sender, EventArgs e)
        {
            frmVideo FV = new frmVideo();
            FV.MdiParent = this;
            FV.Show();
        }
    }
}
