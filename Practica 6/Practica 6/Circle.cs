using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class Circle
    {

        private float mRadius;
        private float mPerimeter;
        private float mArea;
        private const float SF = 20.0F;
        private Graphics mGraph;
        private Pen mPen;

        public Circle()
        {
            mRadius = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        public void CalculateArea()
        {
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2.0f);
        }

        public void PlotShape(PictureBox picCanva) 
        {
            using (mGraph = picCanva.CreateGraphics()) 
            {
                mPen = new Pen(Color.Red, 2);

                mGraph.DrawEllipse(mPen, 0, 0, 2 * mRadius * SF, 2 * SF * mRadius);

            }
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
