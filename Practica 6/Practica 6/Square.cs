using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Practica_6
{
    internal class Square
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private const float SF = 25.0f;
        private Graphics mGraph;
        private Pen mPen;

        public Square() {
            mSide = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtSide) {
            try
            {
                mSide = float.Parse(txtSide.Text);
            }
            catch {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculatePerimeter() {
            mPerimeter = 4 * mSide;
        }

        public void CalculateArea() {
            mArea = mSide * mSide;
        }

        public void PlotShape(PictureBox picCanva) {
            using (mGraph = picCanva.CreateGraphics()) {
                mPen = new Pen(Color.Red, 2);

                mGraph.DrawRectangle(mPen, 0, 0, mSide * SF, mSide * SF);
            }
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea) { 
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
