using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    internal class StarBezier
    {

        Graphics mGraph;
        private int x1;
        private int x2;
        private int y1;
        private int y2;
        private int steps;
        private const int size = 500;

        public StarBezier() {
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
            steps = 0;
        }

        public void ReadData(TextBox txtSteps) {
            try
            {
                steps = int.Parse(txtSteps.Text);
            }
            catch 
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        public void DrawStar(PictureBox picCanva) {

            mGraph = picCanva.CreateGraphics();
            int Xcenter = picCanva.Width / 2;
            int Ycenter = picCanva.Height / 2;

            x1 = Xcenter;
            y1 = Ycenter - 500;

            for (int i = 0; i <= 500; i += steps)
            {
                x2 = Xcenter + i;
                float x3 = Ycenter - i;

                mGraph.DrawLine(Pens.Red, x1, y1, x2, Ycenter);        // Derecha superior
                mGraph.DrawLine(Pens.Red, x1, y1 + size, x3, Ycenter);

                mGraph.DrawLine(Pens.Red, x1, y1, x3, Ycenter);        // Izquierda superior
                mGraph.DrawLine(Pens.Red, x1, y1 + size, x2, Ycenter);

                y1 += steps;
            
            }


        }


    }
}
