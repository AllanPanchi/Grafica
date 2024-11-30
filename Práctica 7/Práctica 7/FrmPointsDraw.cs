using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_7
{
    public partial class FrmPointsDraw : Form
    {

        DrawLine line = new DrawLine();

        public FrmPointsDraw()
        {
            InitializeComponent();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {

            line.DrawLineContinous(e, picCanvas);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            line.InitializeData(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
