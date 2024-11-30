using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class Trapeze
    {

        private float mSide1;
        private float mSide2;
        private float mMajorBase;
        private float mMinorBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private const float SF = 15.0f;
        private Graphics mGraph;
        private Pen mPen;

        public Trapeze()
        {
            mSide1 = 0.0F;
            mSide2 = 0.0F;
            mMajorBase = 0.0F;
            mMinorBase = 0.0F;
            mHeight = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtMajorBase, TextBox txtMinorBase,  
            TextBox txtSide1, TextBox txtSide2, TextBox txtHeight)
        {
            try
            {
                mMajorBase = float.Parse(txtMajorBase.Text);
                mMinorBase = float.Parse(txtMinorBase.Text);
                mSide1 = float.Parse(txtSide1.Text);
                mSide2 = float.Parse(txtSide2.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = mSide1 + mSide2 + mMinorBase + mMajorBase;
        }

        public void CalculateArea()
        {
            mArea = ((mMajorBase + mMinorBase) * mHeight) / 2;
        }

        public void PlotShape(PictureBox picCanva) 
        { 
            float centerX = picCanva.Width / 2;
            float centerY = picCanva.Height / 2;

            float mMajorBase2 = mMajorBase * SF;
            float mMinorBase2 = mMinorBase * SF;
            float mHeight2 = mHeight + SF;

            float offset = 50;

            PointF A = new PointF(centerX - mMajorBase2 / 2 + offset, centerY - mHeight2 / 2);
            PointF B = new PointF(centerX + mMajorBase2 / 2 + offset, centerY - mHeight2 / 2);
            PointF C = new PointF(centerX + mMinorBase2 / 2, centerY + mHeight2 / 2);
            PointF D = new PointF(centerX - mMinorBase2 / 2, centerY + mHeight2 / 2);

            PointF[] trapeze = { A, B, C, D };

            using (mGraph = picCanva.CreateGraphics()) {
                mPen = new Pen(Color.Red, 2);

                mGraph.DrawPolygon(mPen, trapeze);
            }
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
