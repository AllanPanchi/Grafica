using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class FrmTriangle : Form
    {

        private Triangle triangle = new Triangle();

        public FrmTriangle()
        {
            InitializeComponent();
        }

        public void InitializeData() {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtSideA.Text = "";
            txtSideB.Text = "";
            txtSideC.Text = "";
            picCanva.Refresh();
        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool validate;

            triangle.ReadData(txtSideA, txtSideB, txtSideC);
            validate = triangle.CheckTriangle();
            if (validate == true)
            {
                triangle.CalcularPerimeter();
                triangle.CalculateArea();
                triangle.WriteData(txtPerimeter, txtArea);
                triangle.PlotShape(picCanva);
            }
            else {
                MessageBox.Show("Error");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
