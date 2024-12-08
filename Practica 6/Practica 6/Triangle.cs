using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class Triangle
    {
        private float mSide1;
        private float mSide2;
        private float mSide3;
        private float mPerimeter;
        private float mArea;
        private float mAngle;
        private const float SF = 15.0F;
        private Graphics mGraph;
        private Pen mPen;
        private PointF A, B, C;

        public Triangle()
        {
            mSide1 = 0.0F;
            mSide2 = 0.0F;
            mSide3 = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;
            mAngle = 0.0F;
        }

        public void ReadData(TextBox txtSide1, TextBox txtSide2, TextBox txtSide3)
        {
            try
            {
                mSide1 = float.Parse(txtSide1.Text);
                mSide2 = float.Parse(txtSide2.Text);
                mSide3 = float.Parse(txtSide3.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public float CalculateSemiPerimeter()
        {
            return ((mSide1 + mSide2 + mSide3) / 2) ;
        }

        public void CalculatePerimeter()
        {
            mPerimeter = 2 * CalculateSemiPerimeter();
        }

        public void CalculateArea()
        {
            float s = CalculateSemiPerimeter();
            mArea = (float)Math.Sqrt(s * (s - mSide1) * (s - mSide2) * (s - mSide3));

        }

        public bool CheckTriangle() {

            if ((mSide1 + mSide2 > mSide3) && (mSide1 + mSide3 > mSide2) && (mSide2 + mSide3 > mSide1))
            {
                return (true);
            }
            else // !((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
                return (false);
        }

        private void CalculateAngleA()
        {
            mAngle = (float)Math.Acos((mSide2 * mSide2 + mSide3 * mSide3 - mSide1 * mSide1) / (2 * mSide2 * mSide3));
        }

        private void CalculateVertex()
        {
            A.X = 0.0f; A.Y = 0.0f;
            B.X = mSide3; B.Y = 0.0f;
            CalculateAngleA();
            C.X = mSide2 * (float)Math.Cos(mAngle);
            C.Y = mSide2 * (float)Math.Sin(mAngle);
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            CalculateVertex();
            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, B.X * SF, B.Y * SF);
            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, C.X * SF, C.Y * SF);
            mGraph.DrawLine(mPen, B.X * SF, B.Y * SF, C.X * SF, C.Y * SF);
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
    }
}
