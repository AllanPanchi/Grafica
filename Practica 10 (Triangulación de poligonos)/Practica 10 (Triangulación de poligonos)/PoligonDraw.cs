using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_10__Triangulación_de_poligonos_
{
    internal class PoligonDraw
    {
        private float mRadius;
        private Graphics mGraph;
        private Pen mPen;

        public PoligonDraw() {
            mRadius = 0.0f;
        }

        public void ReadData(TextBox txtVertix)
        {
            try
            {
                mRadius = float.Parse(txtVertix.Text);
            }
            catch
            {
                MessageBox.Show("Valores no Validos");
            }
        }

        public void DrawPentagon(PictureBox picCanva) 
        {
            mGraph = picCanva.CreateGraphics();
            float centerX = picCanva.Width / 2;
            float centerY = picCanva.Height / 2;

            PointF[] point = new PointF[5];

            for (int i = 0; i < 5; i++)
            {
                float angle = (float)(i * 2 * Math.PI / 5 - Math.PI / 2); // Ángulo en radianes
                float x = centerX + mRadius * (float)Math.Cos(angle);
                float y = centerY + mRadius * (float)Math.Sin(angle);
                point[i] = new PointF(x, y);
            }

            using (mPen = new Pen(Color.Black, 2)) 
            {
                mGraph.DrawPolygon(mPen, point);
            }

            Color[] colors = { Color.Red, Color.Blue, Color.Green };

            for (int i = 0; i < 3; i++)
            {
                using (SolidBrush mBrush = new SolidBrush(colors[i]))
                {
                    PointF[] points = { point[0], point[i + 1], point[i + 2], point[0] };
                    mGraph.FillPolygon(mBrush, points);
                }
            }

        }
    }
}
