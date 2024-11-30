using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class FrmPrácticaMenu : Form
    {
        public FrmPrácticaMenu()
        {
            InitializeComponent();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSquare square = FrmSquare.GetInstance(); 
            square.MdiParent = this;
            square.Show();
            square.BringToFront();
        }
    }
}
