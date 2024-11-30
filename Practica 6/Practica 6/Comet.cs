using System;
using System.Collections.Generic;
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

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
