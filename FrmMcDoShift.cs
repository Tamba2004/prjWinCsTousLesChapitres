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
    public partial class FrmMcDoShift : Form
    {
        public FrmMcDoShift()
        {
            InitializeComponent();
        }

        private void FrmMcDoShift_Load(object sender, EventArgs e)
        {
            lblResultat.Text = DateTime.Today.ToLongDateString();
        }
    }
}
