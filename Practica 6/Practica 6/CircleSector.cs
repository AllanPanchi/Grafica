using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20.0f;

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
            mArea = ((float)Math.PI * mRadius * mRadius * mGrade) / 360;
        }

        public void PlotShape(PictureBox picCanva) 
        {
            float centerX = picCanva.Width / 2;
            float centerY = picCanva.Height / 2;

            float startAngle = 0.0f;

            int steps = 100;

            PointF[] puntos = new PointF[steps + 2];
            puntos[0] = new PointF(centerX, centerY);

            for (int i = 0; i <= steps; i++)
            {
                float angle = startAngle + (float)mGrade / steps * i;
                float radian = angle * (float)Math.PI / 180; // Convertir a radianes

                float x = centerX + mRadius * (float)Math.Cos(radian);
                float y = centerY - mRadius * (float)Math.Sin(radian); // Invertir Y para sistema gráfico
                puntos[i + 1] = new PointF(x, y);
            }

            using (mGraph = picCanva.CreateGraphics())
            {
                Brush sectorBrush = new SolidBrush(Color.Gold);
                mGraph.FillPolygon(sectorBrush, puntos);

                Pen pen = new Pen(Color.Black, 2);
                mGraph.DrawEllipse(pen, centerX - mRadius, centerY - mRadius, mRadius * 2, mRadius * 2);
            }

        }


        public void WriteData(TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
        }
    }
}
