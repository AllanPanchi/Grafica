using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_11
{
    internal class Circle
    {
        private float mRadius;
        private Graphics mGraph;
        private Pen mPen;

        public Circle(){
            mRadius = 0.0f;
        }

        public void ReadData(TextBox txtRadius) 
        {
        }

        public void PlotShape(PictureBox picCanva) {
            float centerX = picCanva.Width / 2;
            float centerY = picCanva.Height / 2;

            using (mGraph = picCanva.CreateGraphics()) 
            {
                mPen = new Pen(Color.Red, 2);

                mGraph.DrawEllipse(mPen, centerX - mRadius, centerY - mRadius, mRadius * 2, mRadius * 2);

            }
        }

    }
}
