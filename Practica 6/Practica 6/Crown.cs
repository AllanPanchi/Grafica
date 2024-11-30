using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class Crown
    {

        private float mMajorRadius;
        private float mMinorRadius;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private Brush mBrush;
        private const float SF = 15.0f;

        public Crown()
        {
            mMajorRadius = 0.0F;
            mMinorRadius = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtMajorRadius, TextBox txtMinorRadius)
        {
            try
            {
                mMajorRadius = float.Parse(txtMajorRadius.Text);
                mMinorRadius = float.Parse(txtMinorRadius.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculateArea()
        {
            mArea = (float)Math.PI * ((float)Math.Pow(mMajorRadius, 2.0f) - (float)Math.Pow(mMinorRadius, 2.0f));
        }

        public bool CheckCrown() {
            if (mMajorRadius >= mMinorRadius)
            {
                return (true);
            }
            else {
                return (false);
            }
        }

        public void PlotShape(PictureBox picCanva) 
        {
            int centerX = picCanva.Width / 2;
            int centerY = picCanva.Height / 2;

            float outerX = centerX - mMajorRadius;
            float outerY = centerY - mMajorRadius;
            float outerDiameter = mMajorRadius * 2;

            float innerX = centerX - mMinorRadius;
            float innerY = centerY - mMinorRadius;
            float innerDiameter = mMinorRadius * 2;

            using (mGraph = picCanva.CreateGraphics())
            {
                mPen = new Pen(Color.Red, 2);
                mBrush = new SolidBrush(Color.Gold);

                mGraph.FillEllipse(mBrush, outerX, outerY, outerDiameter, outerDiameter);

                mGraph.DrawEllipse(mPen, outerX, outerY, outerDiameter, outerDiameter);
                mGraph.DrawEllipse(mPen, innerX, innerY, innerDiameter * SF, innerDiameter * SF);

            }
        }

        public void WriteData(TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
        }


    }
}
