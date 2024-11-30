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
    public partial class FrmTriangle : Form
    {

        Triangle triangle = new Triangle();

        private static FrmTriangle instance;

        public FrmTriangle()
        {
            InitializeComponent();
        }

        public static FrmTriangle GetInstance() {
            if (instance == null) { 
                instance = new FrmTriangle();
            }

            return instance;
        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtSide1.Text = "";
            txtSide2.Text = "";
            txtSide3.Text = "";
            picCanva.Refresh();
        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            bool validate;
            triangle.ReadData(txtSide1, txtSide2, txtSide3);

            validate = triangle.CheckTriangle();

            if (validate == true)
            {
                triangle.CalculatePerimeter();
                triangle.CalculateArea();
                triangle.PlotShape(picCanva);
                triangle.WriteData(txtPerimeter, txtArea);
            }
            else {
                MessageBox.Show("NO PUEDES CALCULAR EL TRIANGULO");
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
