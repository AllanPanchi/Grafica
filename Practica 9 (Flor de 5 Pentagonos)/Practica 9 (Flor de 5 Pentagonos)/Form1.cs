using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_9__Flor_de_5_Pentagonos_
{
    public partial class Form1 : Form
    {

        PentagonoFlower flower = new PentagonoFlower();

        public Form1()
        {
            InitializeComponent();
        }

        public void InitializeData() 
        {
            txtSide.Text = "";
            picCanva.Refresh();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            flower.ReadData(txtSide);
            flower.CalculateAuxiliarySegmentsVertex(picCanva);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picCanva_Click(object sender, EventArgs e)
        {

        }

        private void picCanva_Paint(object sender, PaintEventArgs e)
        {
            flower.FillPolygonPointF(e);
        }
    }
}
