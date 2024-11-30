using System;
using System.Collections.Generic;
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

        public void WriteData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
