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
    public partial class FrmRectangle : Form
    {

        Rectangle rectangle = new Rectangle();

        private static FrmRectangle instance;

        public FrmRectangle()
        {
            InitializeComponent();
        }

        public static FrmRectangle GetInstance() {
            if (instance == null) { 
                instance = new FrmRectangle();
            }

            return instance;
        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtWidth.Text = "";
            txtHeight.Text = "";
            picCanva.Refresh();
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
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
            rectangle.ReadData(txtWidth, txtHeight);
            rectangle.CalculatePerimeter();
            rectangle.CalculateArea();
            rectangle.PlotShape(picCanva);
            rectangle.WriteData(txtPerimeter, txtArea);
        }
    }
}
