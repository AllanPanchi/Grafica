using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    internal class Square
    {

        private float mSide;
        private float mArea;
        private float mPerimeter;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20f;

        public Square()
        {
            mSide = 0.0f;
            mArea = 0.0f;
            mPerimeter = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
            }
            catch {
                MessageBox.Show("Valores Invalidos");
            }
        }

        public void PerimeterS() 
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaS() 
        {
            mArea = mSide*mSide;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea) 
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void PlotShow(PictureBox picCanvas) {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawRectangle(mPen, 0, 0, mSide * SF, mSide * SF);
        }

    }

   
}
