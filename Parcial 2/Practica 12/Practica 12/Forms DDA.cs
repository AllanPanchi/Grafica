using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_12
{
    public partial class Forms_DDA : Form
    {

        DDA dda = new DDA();
        private static Forms_DDA instance;

        public Forms_DDA()
        {
            InitializeComponent();
        }

        public void InitializeData() {
            txtFinalX.Text = "";
            txtFinalY.Text = "";
            txtXIncrease.Text = "";
            txtYIncrease.Text = "";
            txtX0.Text = "";
            txtY0.Text = "";
            picCanva.Refresh();
        }

        public static Forms_DDA GetInstance()
        {
            if (instance == null)
            {
                instance = new Forms_DDA();
            }

            return instance;
        }

        private void Forms_DDA_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            dda.ReadData(txtX0, txtY0, txtFinalX, txtFinalY);
            dda.PlotShape(picCanva);
            dda.WriteData(txtXIncrease, txtYIncrease);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
