﻿namespace Practica_12
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoBeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDDAToolStripMenuItem,
            this.algoritmoBeToolStripMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algoritmoToolStripMenuItem.Text = "Algoritmo";
            // 
            // algoritmoDDAToolStripMenuItem
            // 
            this.algoritmoDDAToolStripMenuItem.Name = "algoritmoDDAToolStripMenuItem";
            this.algoritmoDDAToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.algoritmoDDAToolStripMenuItem.Text = "Algoritmo DDA";
            this.algoritmoDDAToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDDAToolStripMenuItem_Click);
            // 
            // algoritmoBeToolStripMenuItem
            // 
            this.algoritmoBeToolStripMenuItem.Name = "algoritmoBeToolStripMenuItem";
            this.algoritmoBeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.algoritmoBeToolStripMenuItem.Text = "Algoritmo Bresenham";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 487);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoBeToolStripMenuItem;
    }
}