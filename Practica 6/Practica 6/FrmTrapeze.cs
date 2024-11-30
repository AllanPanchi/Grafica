using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class FrmTrapeze : Form
    {

        Trapeze trapeze = new Trapeze();

        private static FrmTrapeze instance;

        public FrmTrapeze()
        {
            InitializeComponent();
        }

        public static FrmTrapeze GetInstance() {
            if (instance == null) { 
                instance = new FrmTrapeze();
            }

            return instance;
        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtSide1.Text = "";
            txtSide2.Text = "";
            txtMinorBase.Text = "";
            txtMajorBase.Text = "";
            txtHeight.Text = "";
            picCanva.Refresh();
        }

        private void FrmTrapeze_Load(object sender, EventArgs e)
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
            trapeze.ReadData(txtMajorBase, txtMinorBase, txtSide1, txtSide2, txtHeight);
            trapeze.CalculatePerimeter();
            trapeze.CalculateArea();
            trapeze.PlotShape(picCanva);
            trapeze.WriteData(txtPerimeter, txtArea);
        }
    }
}
