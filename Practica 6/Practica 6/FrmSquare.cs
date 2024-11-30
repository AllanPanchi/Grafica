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
    public partial class FrmSquare : Form
    {

        Square square = new Square();

        private static FrmSquare instance;

        public FrmSquare()
        {
            InitializeComponent();
        }

        public static FrmSquare GetInstance() {
            if (instance == null) { 
                instance = new FrmSquare();
            }
            return instance;
        }

        public void InitializeData() 
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtSide.Text = "";
            picCanva.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();   
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            square.ReadData(txtSide);
            square.CalculatePerimeter();
            square.CalculateArea();
            square.PlotShape(picCanva);
            square.WriteData(txtPerimeter, txtArea);
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}
