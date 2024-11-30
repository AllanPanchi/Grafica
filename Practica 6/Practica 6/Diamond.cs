using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class Diamond
    {
        private float mMajorDiagonal;
        private float mMinorDiagonal;
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;

        public Diamond()
        {
            mMajorDiagonal = 0.0F;
            mMinorDiagonal = 0.0F;
            mSide = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtMajorDiagonal, TextBox txtMinorDiagonal, TextBox txtSide)
        {
            try
            {
                mMajorDiagonal = float.Parse(txtMajorDiagonal.Text);
                mMinorDiagonal = float.Parse(txtMinorDiagonal.Text);
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public bool CheckDiamond() {
            if (Math.Pow(mSide, 2) != Math.Pow(mMajorDiagonal / 2, 2) + Math.Pow(mMinorDiagonal / 2, 2))
            {
                return (true);
            }
            else {
                return (false);
            }


        }
        
        public void CalculatePerimeter()
        {
            mPerimeter = 4 * mSide;
        }

        public void CalculateArea()
        {
            mArea = (mMinorDiagonal * mMajorDiagonal) / 2;
        }

        public void PlotShape(PictureBox picCanva) {
            float centerX = picCanva.Width / 2;
            float centerY = picCanva.Height / 2;

            PointF A = new PointF(centerX, centerY - mMajorDiagonal / 2);
            PointF B = new PointF(centerX + mMinorDiagonal / 2, centerY);
            PointF C = new PointF(centerX, centerY + mMajorDiagonal / 2);
            PointF D = new PointF(centerX - mMinorDiagonal / 2, centerY);

            PointF[] diamondVertix ={A, B, C, D};

            using (mGraph = picCanva.CreateGraphics()) {
                mPen = new Pen(Color.Red, 2);

                mGraph.DrawPolygon(mPen, diamondVertix);
            }

        }
        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }


    }
}
