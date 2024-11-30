using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCanva_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawLine(Pens.Black, 0, 0, 0, 300);
            graphics.DrawLine(Pens.Black, 0, 300, 300, 300);

            int steps = 1;
            int start = 0;

            for (int i = 0; i < 100; i ++)
            {

                graphics.DrawLine(Pens.Red, 0, start, (i + 1) * steps, 300);
                start += 20;   
            
            }


        }

        public void Draw_Bezier(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            
        }
    }
}
