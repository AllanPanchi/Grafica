using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class Parallelogram
    {
        private float mBase;
        private float mHeight;
        private float mSide;
        private float mPerimeter;
        private float mArea;

        public Parallelogram()
        {
            mBase = 0.0F;
            mHeight = 0.0F;
            mSide = 0.0F;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtBase, TextBox txtSide, TextBox txtHeight)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mSide = float.Parse(txtSide.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (mBase + mSide);
        }

        public void CalculateArea()
        {
            mArea = mBase * mHeight;
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
