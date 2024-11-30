using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    public partial class Form1 : Form
    {

        StarBezier star = new StarBezier();

        public Form1()
        {
            InitializeComponent();
        }


        public void InitializeData() 
        {
            txtSteps.Text = "";
            picCanva.Refresh();
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            InitializeData();

            star.ReadData(txtSteps);
            star.DrawStar(picCanva);




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
