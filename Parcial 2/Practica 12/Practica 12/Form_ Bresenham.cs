using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_12
{
    public partial class Form__Bresenham : Form
    {

        DDA dda = new DDA();

        public Form__Bresenham()
        {
            InitializeComponent();
        }

        private static Form__Bresenham instance;

        public void InitializeData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            pictureBox1.Refresh();
        }

        public static Form__Bresenham GetInstance()
        {
            if (instance == null)
            {
                instance = new Form__Bresenham();
            }

            return instance;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void Form__Bresenham_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dda.ReadData(textBox1, textBox2, textBox3, textBox4);
        }
    }
}
