using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    internal class CircleSector
    {

        private float mRadius;
        private float mGrade;
        private float mArea;
        private const float pi = 3.1416F;

        public CircleSector()
        {
            mRadius = 0.0F;
            mGrade = 0.0F;
            mArea = 0.0F;
        }

        public void ReadData(TextBox txtRadius, TextBox txtGrade)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
                mGrade = float.Parse(txtGrade.Text);
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        public void CalculateArea()
        {
            mArea = (pi * mRadius * mRadius * mGrade) / 360;
        }

        public void WriteData(TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
        }
    }
}
