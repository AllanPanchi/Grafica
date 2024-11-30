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
    public partial class Rectangulo : Form
    {

        Menu menu1 = new Menu();

        Rectangle objRectangle;

        public Rectangulo()
        {
            InitializeComponent();
        }

        public void InitializeData() 
        {
            txtArea.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtWidth.Text = "";
            picCanvas.Refresh();
            txtHeight.Focus();
        }

        private void Rectangulo_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRectangle = new Rectangle();
            objRectangle.ReadData(txtHeight, txtWidth);
            objRectangle.PerimeterR();
            objRectangle.AreaR();
            objRectangle.PrintData(txtPerimeter, txtArea);
            objRectangle.PlotShow(picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu1.Show();
            this.Close();
        }
    }
}
