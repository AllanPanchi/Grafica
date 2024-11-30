using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class RegularPoligon
    {

        private float mSide;
        private float mApotema;
        private int mSideNumber;
        private float mPerimeter;
        private float mArea;
        private const float SF = 15.0f;
        private Graphics mGraph;
        private Pen mPen;

        public RegularPoligon()
        {
            mSide = 0.0F;
            mApotema = 0.0F;
            mSideNumber = 0;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtApotema, TextBox txtSide, TextBox txtSideNumber)
        {
            try
            {
                mApotema = float.Parse(txtApotema.Text);
                mSide = float.Parse(txtSide.Text);
                mSideNumber = int.Parse(txtSideNumber.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = mSideNumber * mSide;
        }

        public void CalculateArea()
        {
            mArea = (mPerimeter * mApotema) / 2;
        }

        public void PlotShape(PictureBox picCanva) 
        {
            float centerX = picCanva.Width / 2;
            float centerY = picCanva.Height / 2;

            float mRadius = mSide * SF;

            PointF[] point = new PointF[mSideNumber];

            for (int i = 0; i < mSideNumber; i++)
            {
                float angle = (float)(i * 2 * Math.PI / mSideNumber - Math.PI / 2); // Ángulo en radianes
                float x = centerX + mRadius * (float)Math.Cos(angle);
                float y = centerY + mRadius * (float)Math.Sin(angle);
                point[i] = new PointF(x, y);
            }

            using (mGraph = picCanva.CreateGraphics())
            {
                mPen = new Pen(Color.Red, 2);
                mGraph.DrawPolygon(mPen, point);
            }
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
