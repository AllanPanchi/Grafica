using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private const float SF = 20.0f;
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

        public void setSize(float size) 
        {
            if (size > 0) {
                mSide = size;
            }
        }

        private PointF[] CalculateVertices(float centerX, float centerY)
        {
            float halfSide = (mSide * SF) / 2.0f;

            // Vértices sin rotación (en sentido horario)
            PointF[] vertices = new PointF[]
            {
            new PointF(centerX - halfSide, centerY - halfSide), // Superior izquierda
            new PointF(centerX + halfSide, centerY - halfSide), // Superior derecha
            new PointF(centerX + halfSide, centerY + halfSide), // Inferior derecha
            new PointF(centerX - halfSide, centerY + halfSide)  // Inferior izquierda
            };

            return vertices;
        }

        private PointF[] RotateVertices(PointF[] vertices, float centerX, float centerY, float angle)
        {
            PointF[] rotatedVertices = new PointF[vertices.Length];
            float radians = angle * (float)(Math.PI / 180.0); // Convertir a radianes

            for (int i = 0; i < vertices.Length; i++)
            {
                // Trasladar el vértice al origen
                float x = vertices[i].X - centerX;
                float y = vertices[i].Y - centerY;

                // Aplicar la matriz de rotación
                float rotatedX = x * (float)Math.Cos(radians) - y * (float)Math.Sin(radians);
                float rotatedY = x * (float)Math.Sin(radians) + y * (float)Math.Cos(radians);

                // Trasladar de vuelta al centro original
                rotatedVertices[i] = new PointF(rotatedX + centerX, rotatedY + centerY);
            }

            return rotatedVertices;
        }

        public void CalculatePerimeter() {
            mPerimeter = 4 * mSide;
        }

        public void CalculateArea() {
            mArea = mSide * mSide;
        }

        public void PlotShape(PictureBox picCanva, float angle)
        {
            // Calcular el centro del PictureBox
            float centerX = picCanva.Width / 2f;
            float centerY = picCanva.Height / 2f;

            // Calcular los vértices del cuadrado
            PointF[] vertices = CalculateVertices(centerX, centerY);

            // Aplicar rotación
            PointF[] rotatedVertices = RotateVertices(vertices, centerX, centerY, angle);

            // Limpiar el PictureBox antes de dibujar
            picCanva.Refresh();

            // Dibujar el cuadrado rotado
            using (Graphics mGraph = picCanva.CreateGraphics())
            {
                mPen = new Pen(Color.Red, 2);
                mGraph.DrawPolygon(mPen, rotatedVertices);
            }
        }

        public void WriteData(TextBox txtPerimeter, TextBox txtArea) { 
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
