using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class RegularPoligon
    {

        private float mSide;
        private float mApotema;
        private int mSideNumber;
        private float mPerimeter;
        private float mArea;

        public RegularPoligon()
        {
            mSide = 0.0F;
            mApotema = 0.0F;
            mSideNumber = 0;
            mPerimeter = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtApotema, TextBox txtSide, TextBox txtSideNumber)
        {
            try
            {
                mApotema = float.Parse(txtApotema.Text);
                mSide = float.Parse(txtSide.Text);
                mSideNumber = int.Parse(txtSideNumber.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = mSideNumber * mSide;
        }

        public void CalculateArea()
        {
            mArea = (mPerimeter * mApotema) / 2;
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
