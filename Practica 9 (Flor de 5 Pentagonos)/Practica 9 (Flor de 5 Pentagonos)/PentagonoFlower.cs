using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Practica_9__Flor_de_5_Pentagonos_
{
    internal class PentagonoFlower
    {

        private float mSide;
        private float a, b, c, d;
        private float angle1, angle2;
        private float mAD;
        private float mBE;
        private Graphics mGraph;
        private SolidBrush mSolidBrush;
        private const float SF = 20.0f;
        private PointF A, B, C, D, E;
        private PointF F, G, H, I, J;
        private PointF K, L, M, N, T, U, V, W, X, Y;
        private PointF P, Q, R, S;

        public PentagonoFlower() {
            mSide = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
            } catch
            {
                MessageBox.Show("Error al Obtener Datos");
            }
        }
        private void CalculateMainVertix()
        {
            angle1 = 36.0f * (float)Math.PI / 180.0f;
            angle2 = 72.0f * (float)Math.PI / 180.0f;

            a = mSide * (float)Math.Cos(angle1);
            b = mSide * (float)Math.Sin(angle1);
            c = mSide * (float)Math.Cos(angle2);
            d = mSide * (float)Math.Sin(angle2);

            A.X = a; A.Y = 0.0f;
            B.X = 0.0f; B.Y = b;
            C.X = 2 * a; C.Y = b;
            D.X = d; D.Y = b + c;
            E.X = d + mSide; E.Y = b + c;
        }
        private void CalculateSlopes()
        {
            mAD = (b + c) / (d - a);
            mBE = c / (d + mSide);
        }
        public void CalculateAuxiliarySegmentsVertex(PictureBox picCanva)
        {
            mGraph = picCanva.CreateGraphics();

            CalculateMainVertix();
            CalculateSlopes();

            F.X = (b + a * mAD) / (mAD); F.Y = b;
            H.X = (a * mAD + b) / (mAD - mBE); H.Y = H.X * mBE + b;

            float FH = (float)Math.Sqrt((float)Math.Pow(H.X - F.X, 2)
                        + (float)Math.Pow(H.Y - F.Y, 2));
            float BL = FH;
            float KF = FH;
            float BO = BL * (float)Math.Cos(angle1);
            float LO = BL * (float)Math.Sin(angle1);
            float BF = 2 * BO;
            float ZF = KF * (float)Math.Cos(angle2);
            float KZ = KF * (float)Math.Sin(angle2);

            L.X = BO; L.Y = b - LO; K.X = BF - ZF; K.Y = b - KZ;
            M.X = BF + FH + ZF; M.Y = b - KZ;
            N.X = BF + FH + BO; N.Y = b - LO;
            P.X = ZF; P.Y = b + KZ;
            R.X = d - ZF; R.Y = b + c - KZ;
            Q.X = ZF + 2 * FH + BF; Q.Y = b + KZ;
            S.X = d + mSide + ZF; S.Y = b + c - KZ;
            T.X = d + FH; T.Y = b + c;
            U.X = d + FH + 2 * ZF; U.Y = b + c;

            G.X = BF + FH; G.Y = b;
            I.X = BF + FH + ZF; I.Y = b + KZ;
            J.X = d + FH + ZF; J.Y = b + c - KZ;
        }
        public void FillPolygonPointF(PaintEventArgs e) 
        {
            mGraph = e.Graphics;

            A.X = A.X * SF; A.Y = A.Y * SF;
            K.X = K.X * SF; K.Y = K.Y * SF;
            M.X = M.X * SF; M.Y = M.Y * SF;
            F.X = F.X * SF; F.Y = F.Y * SF;
            G.X = G.X * SF; G.Y = G.Y * SF;

            N.X = N.X * SF; N.Y = N.Y * SF;
            C.X = C.X * SF; C.Y = C.Y * SF;
            Q.X = Q.X * SF; Q.Y = Q.Y * SF;
            I.X = I.X * SF; I.Y = I.Y * SF;

            S.X = S.X * SF; S.Y = S.Y * SF;
            E.X = E.X * SF; E.Y = E.Y * SF;

            U.X = U.X * SF; U.Y = U.Y * SF;
            J.X = J.X * SF; J.Y = J.Y * SF;

            T.X = T.X * SF; T.Y = T.Y * SF;
            D.X = D.X * SF; D.Y = D.Y * SF;
            R.X = R.X * SF; R.Y = R.Y * SF;
            H.X = H.X * SF; H.Y = H.Y * SF;

            P.X = P.X * SF; P.Y = P.Y * SF;
            B.X = B.X * SF; B.Y = B.Y * SF;
            L.X = L.X * SF; L.Y = L.Y * SF;

            mSolidBrush = new SolidBrush(Color.Red);

            PointF[] polPoints1 = { A, M, G, F, K, A };
            mGraph.FillPolygon(mSolidBrush, polPoints1);

            PointF[] polPoints2 = { N, C, Q, I, G, N };
            mGraph.FillPolygon(mSolidBrush, polPoints2);

            PointF[] polPoints3 = { I, S, E, U, J, I };
            mGraph.FillPolygon(mSolidBrush, polPoints3);

            PointF[] polPoints4 = { H, J, T, D, R, H };
            mGraph.FillPolygon(mSolidBrush, polPoints4);

            PointF[] polPoints5 = { L, F, H, P, B, L };
            mGraph.FillPolygon(mSolidBrush, polPoints5);
        }

    }
}
