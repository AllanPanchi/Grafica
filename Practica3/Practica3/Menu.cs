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
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Form1 square = new Form1();
            square.Show();
            this.Hide();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Rectangulo rectangle = new Rectangulo();
            rectangle.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
