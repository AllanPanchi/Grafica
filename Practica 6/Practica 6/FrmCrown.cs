using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class FrmCrown : Form
    {

        Crown crown = new Crown();

        private static FrmCrown instance;

        public static FrmCrown GetInstance() {
            if (instance == null) { 
                instance = new FrmCrown();
            }

            return instance;
        }

        public FrmCrown()
        {
            InitializeComponent();
        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtMajorRadius.Text = "";
            txtMinorRadius.Text = "";
            picCanva.Refresh();
        }

        private void FrmCrown_Load(object sender, EventArgs e)
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

            bool validate;
            crown.ReadData(txtMajorRadius, txtMinorRadius);

            validate = crown.CheckCrown();

            if (validate == true)
            {
                crown.CalculateArea();
                crown.PlotShape(picCanva);
                crown.WriteData(txtArea);
            }
            else {
                MessageBox.Show("NO SE PUEDE CALCULAR");
            }

           
        }
    }
}
