using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_7
{
    internal class DrawLine
    {
        private Graphics mGraph;
        private Point mStartPoint;
        private Point mEndPoint;
        Pen mline;
        Pen mCircle;

        public DrawLine() {
            mStartPoint = new Point(0, 0);
            mStartPoint = new Point(0, 0);
        }

        public void InitializeData(PictureBox picCanva) {
            mStartPoint.X = 0;
            mStartPoint.Y = 0;
            mEndPoint.X = 0;    
            mEndPoint.Y = 0;
            picCanva.Refresh();
        }

        public void DrawLineContinous(MouseEventArgs e, PictureBox picCanva) {

            mGraph = picCanva.CreateGraphics();

            mline = new Pen(Color.Black, 3);
            mCircle = new Pen(Color.Red, 3);

            mStartPoint = mEndPoint;
            mEndPoint = new Point(e.X, e.Y);

            mGraph.DrawLine(mline, mStartPoint, mEndPoint);
            mGraph.DrawEllipse(mCircle, e.X - 1, e.Y - 1, 4, 4);

        }



    }
}
