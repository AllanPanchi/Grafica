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
    public partial class FrmCircle : Form
    {

        Circle circle = new Circle();

        private static FrmCircle instance;

        public FrmCircle()
        {
            InitializeComponent();
        }

        public static FrmCircle GetInstance() {
            if (instance == null) { 
                instance = new FrmCircle();
            }

            return instance;
        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtRadius.Text = "";
            picCanva.Refresh();
        }

        private void FrmCircle_Load(object sender, EventArgs e)
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
            circle.ReadData(txtRadius);
            circle.CalculatePerimeter();
            circle.CalculateArea();
            circle.PlotShape(picCanva);
            circle.WriteData(txtPerimeter, txtArea);
        }
    }
}
