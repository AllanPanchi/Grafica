using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_12
{
    internal class DDA
    {

        private float increaseX;
        private float increaseY;
        private float steps;
        private float stepsX;
        private float stepsY;
        private const int SF = 15;
        private Point pointX;
        private Point pointY;
        Graphics mGraph;
        Pen mPen;

        public DDA() {
            increaseX = 0.0f; increaseY = 0.0f;
            stepsX = 0.0f; stepsY = 0.0f;
            pointX.X = 0; pointX.Y = 0;
            pointY.X = 0; pointY.Y = 0;
        }

        public void ReadData(TextBox txtXi, TextBox txtXf, TextBox txtYi, TextBox txtYf) 
        {
            try
            {
                pointX.X = int.Parse(txtXi.Text);
                pointX.Y = int.Parse(txtXf.Text);
                pointY.X = int.Parse(txtYi.Text);
                pointY.Y = int.Parse(txtYf.Text);
            }
            catch  
            {
                MessageBox.Show("No se pudieron capturar los valores", "Error");
            }
        }

        public void calculateData() 
        {
            increaseX = Math.Abs(pointY.X - pointX.X);
            increaseY = Math.Abs(pointY.Y - pointX.Y);
            steps = Math.Max(increaseX, increaseY);
            stepsX = (float)Math.Round(increaseX / steps, 2) * SF;
            stepsY = (float)Math.Round(increaseY / steps, 2) * SF;
        }

        public void PlotShape(PictureBox picCanva) 
        {

            calculateData();
            float currentX = pointX.X;
            float currentY = pointX.Y;

            using (mGraph = picCanva.CreateGraphics())
            {
                for (int i = 0; i <= steps; i++)
                {
                    // Dibujar el punto redondeado
                    using (mPen = new Pen(Color.Black, 1))
                    {
                        mGraph.DrawLine(mPen, (int)Math.Round(currentX), (int)Math.Round(currentY), 1, 1);
                    }

                    // Incrementar las posiciones
                    currentX += stepsX;
                    currentY += stepsY;
                }
            }
        }

        public void WriteData(TextBox txtXincrease, TextBox txtYincrease) 
        {
            txtXincrease.Text = stepsX.ToString();
            txtYincrease.Text = stepsY.ToString();
        }
    }
}
