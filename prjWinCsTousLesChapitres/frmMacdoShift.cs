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
    public partial class frmMacdoShift : Form
    {
        public frmMacdoShift()
        {
            InitializeComponent();
        }

        private void frmMacdoShift_Load(object sender, EventArgs e)
        {
            //lblResultat.Text = DateTime.Now.Month.ToString();
            lblResultat.Text = DateTime.Today.Month.ToString();
        }
    }
}
