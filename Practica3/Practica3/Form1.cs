using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form1 : Form
    {

        Menu menu = new Menu();

        Square objSquare;

        public Form1()
        {
            InitializeComponent();
        }

        public void InitializeData() {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtSide.Text = "";
            picCanvas.Refresh();
            txtSide.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objSquare = new Square();
            objSquare.ReadData(txtSide);
            objSquare.PerimeterS();
            objSquare.AreaS();
            objSquare.PrintData(txtPerimeter, txtArea);
            objSquare.PlotShow(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}
