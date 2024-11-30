using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {

        Rectangle objRectangle;

        public Form1()
        {
            InitializeComponent();
        }

        public void InitilizeData() {
            txtWidth.Text = "";
            txtHeight.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            picCanvas.Refresh();
            txtWidth.Focus();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitilizeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRectangle = new Rectangle();
            objRectangle.ReadData(txtWidth, txtHeight);
            objRectangle.PerimeterR();
            objRectangle.AreaR();
            objRectangle.PrintData(txtPerimeter, txtArea);
            objRectangle.PlotShape(picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitilizeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
