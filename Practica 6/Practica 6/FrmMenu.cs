using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSquare square = FrmSquare.GetInstance();
            square.MdiParent = this;
            square.Show();
            square.BringToFront();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCircle circle = FrmCircle.GetInstance();
            circle.MdiParent = this;
            circle.Show();
            circle.BringToFront();
        }

        private void sectorCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCircleSector circleSector = FrmCircleSector.GetInstance();
            circleSector.MdiParent = this;
            circleSector.Show();
            circleSector.BringToFront();

        }

        private void cometaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComet comet = FrmComet.GetInstance();
            comet.MdiParent = this;
            comet.Show();
            comet.BringToFront();
        }

        private void coronaCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrown crown = FrmCrown.GetInstance();
            crown.MdiParent = this;
            crown.Show();
            crown.BringToFront();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapeze trapecio = FrmTrapeze.GetInstance();
            trapecio.MdiParent = this;
            trapecio.Show();
            trapecio.BringToFront();
        }

        private void paralelogramoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParallelogram parallelogram = FrmParallelogram.GetInstance();
            parallelogram.MdiParent = this;
            parallelogram.Show();
            parallelogram.BringToFront();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangle rectangle = FrmRectangle.GetInstance();
            rectangle.MdiParent = this;
            rectangle.Show();
            rectangle.BringToFront();
        }

        private void poligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegularPoligon poligono = FrmRegularPoligon.GetInstance();   
            poligono.MdiParent = this;
            poligono.Show();
            poligono.BringToFront();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangle triangulo = FrmTriangle.GetInstance();
            triangulo.MdiParent = this;
            triangulo.Show();
            triangulo.BringToFront();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiamond diamond = FrmDiamond.GetInstance();
            diamond.MdiParent = this;
            diamond.Show();
            diamond.BringToFront();
        }
    }
}
