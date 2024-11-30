using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class Comet
    {

        private float mMajorDiagonal;
        private float mMinorDiagonal;
        private float mMinorSide;
        private float mMajorSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 10.0f;

        public Comet()
        {
            mMajorDiagonal = 0.0F;
            mMinorDiagonal = 0.0F;
            mMajorSide = 0.0F;
            mMinorSide = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtMajorDiagonal, TextBox txtMinorDiagonal, TextBox txtMinorSide, TextBox txtMajorSide)
        {
            try
            {
                mMajorDiagonal = float.Parse(txtMajorDiagonal.Text);
                mMinorDiagonal = float.Parse(txtMinorDiagonal.Text);
                mMinorSide = float.Parse(txtMinorSide.Text);
                mMajorSide = float.Parse(txtMajorSide.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (mMajorSide + mMinorSide);
        }

        public void CalculateArea()
        {
            mArea = (mMinorDiagonal * mMajorDiagonal) / 2;
        }

        public void PlotShape(PictureBox picCanva) 
        { 
            float centerX = picCanva.Width / 2;
            float centerY = picCanva.Height / 2;
            
            float mMinorDiagonal2 = mMinorDiagonal * SF;
            float mMajorDiagonal2 = mMajorDiagonal * SF;
            float mMajorSide2 = mMajorSide * SF;
            float mMinorSide2 = mMinorSide * SF;

            PointF top = new PointF(centerX, centerY - mMajorDiagonal2 / 2);
            PointF min = new PointF(centerX, centerY + mMajorDiagonal2 / 2);

            float dx = (float)Math.Sqrt(Math.Pow(mMajorSide2, 2) - Math.Pow(mMinorSide2, 2));
            PointF right = new PointF(centerX - dx, centerY);
            PointF left = new PointF(centerX + dx, centerY);

            PointF[] comet = { top, min, right, left };

            using (mGraph = picCanva.CreateGraphics())
            {
                mPen = new Pen(Color.Red, 2);

                mGraph.DrawPolygon(mPen, comet);
            }
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
