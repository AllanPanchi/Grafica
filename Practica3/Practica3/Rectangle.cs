using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    internal class Rectangle
    {

        private float mHeight;
        private float mWidth;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20f;

        public Rectangle()
        {
            mHeight = 0.0f;
            mWidth = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtHeight, TextBox txtWidth) 
        {

            try
            {
                mHeight = float.Parse(txtHeight.Text);
                mWidth = float.Parse(txtWidth.Text);
            }
            catch {
                MessageBox.Show("Datos Incorrectos");
            }
            
        }

        public void PerimeterR() { 

            mPerimeter = 2 * mHeight + 2 * mWidth;
        
        }

        public void AreaR() { 

            mArea = mHeight * mWidth;
        
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea) 
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void PlotShow(PictureBox picCanvas) 
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);


        }


    }
}
