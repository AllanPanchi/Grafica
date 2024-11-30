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
    public partial class FrmComet : Form
    {

        Comet comet = new Comet();

        private static FrmComet instance;

        public FrmComet()
        {
            InitializeComponent();
        }

        public static FrmComet GetInstance()
        {

            if (instance == null) { 
                instance = new FrmComet();
            }

            return instance;

        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtMajorDiagonal.Text = "";
            txtMinorDiagonal.Text = "";
            txtMinorSide.Text = "";
            txtMajorSide.Text = "";
        }

        private void FrmComet_Load(object sender, EventArgs e)
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
            comet.ReadData(txtMajorDiagonal, txtMinorDiagonal, txtMinorSide, txtMajorSide);
            comet.CalculatePerimeter();
            comet.CalculateArea();
            comet.WriteData(txtPerimeter, txtArea);
        }
    }
}
