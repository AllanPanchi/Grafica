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
    public partial class FrmDiamond : Form
    {

        Diamond diamond = new Diamond();

        private static FrmDiamond instance;
        public FrmDiamond()
        {
            InitializeComponent();
        }

        public static FrmDiamond GetInstance() {
            if (instance == null) { 
                instance = new FrmDiamond();
            }

            return instance;
        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtMajorDiagonal.Text = "";
            txtMinorDiagonal.Text = "";
            txtSide.Text = "";
            picCanva.Refresh();
        }

        private void FrmDiamond_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            bool validate;
            diamond.ReadData(txtMajorDiagonal, txtMinorDiagonal, txtSide);

            validate = diamond.CheckDiamond();

            if (validate == true)
            {
                diamond.CalculatePerimeter();
                diamond.CalculateArea();
                diamond.PlotShape(picCanva);
                diamond.WriteData(txtPerimeter, txtArea);
            }
            else {
                MessageBox.Show("No se puede calcular");
            }

            
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
    }
}
