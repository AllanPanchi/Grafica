using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_10__Triangulación_de_poligonos_
{
    public partial class Form1 : Form
    {

        PoligonDraw pentagon = new PoligonDraw();

        public Form1()
        {
            InitializeComponent();
        }

        public void InitializeData() 
        {
            txtVertix.Text = "";
            picCanva.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            pentagon.ReadData(txtVertix);
            pentagon.DrawPentagon(picCanva);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
