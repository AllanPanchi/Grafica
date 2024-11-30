using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    internal class Rectangle
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;

        public Rectangle()
        {
            mWidth = 0f;
            mHeight = 0f;
            mPerimeter = 0f;
            mArea = 0f;
        }

        public void ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch {
                MessageBox.Show("Error, no son datos correctos");
            }
        }

        public void PerimeterR() {
            mPerimeter = mWidth * 2 + 2 * mHeight;
        }

        public void AreaR() {
            mArea = mWidth * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea) {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void PlotShape(PictureBox picCanvas) {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Dibujar el rectangulo
            mGraph.DrawRectangle(mPen, 0, 0, mWidth, mHeight);
        }





    }
}
