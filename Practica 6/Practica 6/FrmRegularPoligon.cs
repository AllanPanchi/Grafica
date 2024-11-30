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
    public partial class FrmRegularPoligon : Form
    {

        RegularPoligon regularPoligon = new RegularPoligon();

        private static FrmRegularPoligon instance;

        public FrmRegularPoligon()
        {
            InitializeComponent();
        }

        public static FrmRegularPoligon GetInstance() {
            if (instance == null) { 
                instance = new FrmRegularPoligon();
            }

            return instance;
        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtSide.Text = "";
            txtApotema.Text = "";
            txtSideNumber.Text = "";
        }
        private void FrmRegularPoligon_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            regularPoligon.ReadData(txtApotema, txtSide, txtSideNumber);
            regularPoligon.CalculatePerimeter();
            regularPoligon.CalculateArea();
            regularPoligon.WriteData(txtPerimeter, txtArea);
        }
    }
}
