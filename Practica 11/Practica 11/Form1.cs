using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_11
{
    public partial class Form1 : Form
    {

        Circle circle = new Circle();
        public Form1()
        {
            InitializeComponent();
        }

        public void InitializeData() 
        {
            picCanva.Refresh();
            txtRadius.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            InitializeData();
            circle.ReadData(txtRadius);
            circle.PlotShape(picCanva);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}
