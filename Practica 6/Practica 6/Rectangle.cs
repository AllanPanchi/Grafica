using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class Rectangle
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Pen mPen;
        private Graphics mGraph;

        public Rectangle()
        {
            mWidth = 0.0F;
            mHeight = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (mWidth + mHeight);
        }

        public void CalculateArea()
        {
            mArea = mWidth * mHeight;
        }

        public void PlotShape(PictureBox picCanva) {
            using (mGraph = picCanva.CreateGraphics()) {
                mPen = new Pen(Color.Red, 2);

                mGraph.DrawRectangle(mPen, 0, 0, mWidth, mPerimeter);
            }


        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
