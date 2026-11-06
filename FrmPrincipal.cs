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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuquitter_Click(object sender, EventArgs e)
        {

            String msg = " voulez vous vraiment quitter ce programme ? ";
            string titre = " fermeture de l application ";
            if (MessageBox.Show(msg, titre,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)// pour le message box lorsque l on veux quitter et " ," pour le titre du text box

            {
                Application.Exit();
            }
        }

        private void mnuconditions_Click(object sender, EventArgs e)
        {
            FrmConditions FC = new FrmConditions();
            FC.MdiParent = this;
            FC.Show();

        }

        private void mnuvideotheque_Click(object sender, EventArgs e)
        {
            FrmVideo FV = new FrmVideo();
            FV.MdiParent = this;
            FV.Show();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
