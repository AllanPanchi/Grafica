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
{    public partial class FrmParallelogram : Form
    {

        Parallelogram parallelogram = new Parallelogram();

        private static FrmParallelogram instance;

        public FrmParallelogram()
        {
            InitializeComponent();
        }

        public static FrmParallelogram GetInstance() {
            if (instance == null) { 
                instance = new FrmParallelogram();
            }
            
            return instance;
        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtSide.Text = "";
            txtBase.Text = "";
            txtHeight.Text = "";
        }

        private void grbInputs_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            parallelogram.ReadData(txtBase, txtSide, txtHeight);
            parallelogram.CalculatePerimeter();
            parallelogram.CalculateArea();
            parallelogram.WriteData(txtArea, txtPerimeter);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void FrmParallelogram_Load(object sender, EventArgs e)
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
