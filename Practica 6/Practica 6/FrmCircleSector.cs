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
    public partial class FrmCircleSector : Form
    {

        CircleSector sector = new CircleSector();

        private static FrmCircleSector instance;

        public FrmCircleSector()
        {
            InitializeComponent();
        }

        public static FrmCircleSector GetInstance() {

            if (instance == null) { 
                instance = new FrmCircleSector();
            }

            return instance;

        }

        public void InitializeData()
        {
            txtArea.Text = "";
            txtRadius.Text = "";
            txtGrades.Text = "";
            picCanva.Refresh();
        }

        private void FrmCircleSector_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            sector.ReadData(txtRadius, txtGrades);
            sector.CalculateArea();
            sector.PlotShape(picCanva);
            sector.WriteData(txtArea);
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
