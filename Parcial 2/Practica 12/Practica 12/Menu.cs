﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_12
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void algoritmoDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms_DDA form = Forms_DDA.GetInstance();
            form.MdiParent = this;
            form.Show();
        }
    }
}