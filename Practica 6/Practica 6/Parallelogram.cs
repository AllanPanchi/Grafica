using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class Parallelogram
    {
        private float mBase;
        private float mHeight;
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private const float SF = 15.0f;
        private Graphics mGraph;
        private Pen mPen;

        public Parallelogram()
        {
            mBase = 0.0F;
            mHeight = 0.0F;
            mSide = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtBase, TextBox txtSide, TextBox txtHeight)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mSide = float.Parse(txtSide.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (mBase + mSide);
        }

        public void CalculateArea()
        {
            mArea = mBase * mHeight;
        }

        public void PlotShape(PictureBox picCanva) 
        { 
            int centerX = picCanva.Width / 2;
            int centerY = picCanva.Height / 2;

            float mBase2 = mBase * SF;
            float mSide2 = mSide * SF;
            float offset = 50.0F;

            PointF A = new PointF(centerX - mBase2 / 2, centerY - mSide2 / 2);
            PointF B = new PointF(centerX + mBase2 / 2, centerY - mSide2 / 2);
            PointF C = new PointF(centerX + mBase2 / 2 + offset, centerY + mSide2 / 2);
            PointF D = new PointF(centerX - mBase2 / 2 + offset, centerY + mSide2 / 2);

            PointF[] parallelogram = { A, B, C, D };

            using (mGraph = picCanva.CreateGraphics()) {
                mPen = new Pen(Color.Red, 2);

                mGraph.DrawPolygon(mPen, parallelogram);
            }
        }


        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
