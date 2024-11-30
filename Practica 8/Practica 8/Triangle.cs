using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
{
    
    internal class Triangle
    {

        private float mSideA;
        private float mSideB;
        private float mSideC;
        private float mAngleA;
        private float mPerimeter;
        private float mArea;
        private const float SF = 10.0f;
        private PointF mPointA;
        private PointF mPointB;
        private PointF mPointC;

        private Graphics mGraph;
        private Pen mPen;

        public Triangle() {

            mSideA = 0.0F;
            mSideB = 0.0F;
            mSideC = 0.0F;
            mAngleA = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;

        }

        public void ReadData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC)
        {
            try
            {

                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
                mSideC = float.Parse(txtSideC.Text);

            }
            catch
            {

                MessageBox.Show("Error al obtener datos");

            }
        }

        public float CalculateSemiPerimeter() 
        {
            return ((mSideA + mSideB + mSideC) / 2);
        }

        public void CalcularPerimeter() 
        {
            float semiPerimeter = CalculateSemiPerimeter();
            mPerimeter = 2 * semiPerimeter;
        }

        public void CalculateArea() 
        {
            float semiPerimeter = CalculateSemiPerimeter();
            mArea = (float)Math.Sqrt(semiPerimeter * (semiPerimeter - mSideA) * (semiPerimeter - mSideB) * (semiPerimeter - mSideC));
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea) 
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public bool CheckTriangle() 
        {
            if ((mSideA + mSideB > mSideC) && (mSideA + mSideC > mSideB) && (mSideB + mSideC > mSideA))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void CalculateAngleA()
        {
            mAngleA = (float)Math.Acos((mSideB * mSideB + mSideC * mSideC - mSideA * mSideA) / (2 * mSideB * mSideC));
        }

        private void CalculateVertex()
        {
            mPointA.X = 0.0f; mPointA.Y = 0.0f;
            mPointB.X = mSideC; mPointB.Y = 0.0f;
            CalculateAngleA();
            mPointC.X = mSideB * (float)Math.Cos(mAngleA);
            mPointC.Y = mSideB * (float)Math.Sin(mAngleA);
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            CalculateVertex();
            // Graficar las tres líneas que conforman un triángulo.
            mGraph.DrawLine(mPen, mPointA.X * SF, mPointA.Y * SF, mPointB.X * SF, mPointB.Y * SF);
            mGraph.DrawLine(mPen, mPointA.X * SF, mPointA.Y * SF, mPointC.X * SF, mPointC.Y * SF);
            mGraph.DrawLine(mPen, mPointB.X * SF, mPointB.Y * SF, mPointC.X * SF, mPointC.Y * SF);
        }


    }
}   
