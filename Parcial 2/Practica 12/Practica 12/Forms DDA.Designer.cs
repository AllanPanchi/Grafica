namespace Practica_12
{
    partial class Forms_DDA
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtFinalY = new System.Windows.Forms.TextBox();
            this.txtFinalX = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.lblY_n = new System.Windows.Forms.Label();
            this.lblX_n = new System.Windows.Forms.Label();
            this.lblY0 = new System.Windows.Forms.Label();
            this.lblX0 = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtYIncrease = new System.Windows.Forms.TextBox();
            this.txtXIncrease = new System.Windows.Forms.TextBox();
            this.lblYIncrease = new System.Windows.Forms.Label();
            this.lblXIncrease = new System.Windows.Forms.Label();
            this.grbCanva = new System.Windows.Forms.GroupBox();
            this.picCanva = new System.Windows.Forms.PictureBox();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbCanva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtY0);
            this.grbInputs.Controls.Add(this.txtFinalY);
            this.grbInputs.Controls.Add(this.txtFinalX);
            this.grbInputs.Controls.Add(this.txtX0);
            this.grbInputs.Controls.Add(this.lblY_n);
            this.grbInputs.Controls.Add(this.lblX_n);
            this.grbInputs.Controls.Add(this.lblY0);
            this.grbInputs.Controls.Add(this.lblX0);
            this.grbInputs.Location = new System.Drawing.Point(6, 7);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(266, 122);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(67, 44);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(100, 20);
            this.txtY0.TabIndex = 8;
            // 
            // txtFinalY
            // 
            this.txtFinalY.Location = new System.Drawing.Point(67, 95);
            this.txtFinalY.Name = "txtFinalY";
            this.txtFinalY.Size = new System.Drawing.Size(100, 20);
            this.txtFinalY.TabIndex = 7;
            // 
            // txtFinalX
            // 
            this.txtFinalX.Location = new System.Drawing.Point(67, 69);
            this.txtFinalX.Name = "txtFinalX";
            this.txtFinalX.Size = new System.Drawing.Size(100, 20);
            this.txtFinalX.TabIndex = 6;
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(67, 17);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(100, 20);
            this.txtX0.TabIndex = 4;
            // 
            // lblY_n
            // 
            this.lblY_n.AutoSize = true;
            this.lblY_n.Location = new System.Drawing.Point(17, 93);
            this.lblY_n.Name = "lblY_n";
            this.lblY_n.Size = new System.Drawing.Size(39, 13);
            this.lblY_n.TabIndex = 3;
            this.lblY_n.Text = "Final Y";
            // 
            // lblX_n
            // 
            this.lblX_n.AutoSize = true;
            this.lblX_n.Location = new System.Drawing.Point(17, 69);
            this.lblX_n.Name = "lblX_n";
            this.lblX_n.Size = new System.Drawing.Size(39, 13);
            this.lblX_n.TabIndex = 2;
            this.lblX_n.Text = "Final X";
            // 
            // lblY0
            // 
            this.lblY0.AutoSize = true;
            this.lblY0.Location = new System.Drawing.Point(17, 44);
            this.lblY0.Name = "lblY0";
            this.lblY0.Size = new System.Drawing.Size(44, 13);
            this.lblY0.TabIndex = 1;
            this.lblY0.Text = "Inicial Y";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Location = new System.Drawing.Point(17, 20);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(44, 13);
            this.lblX0.TabIndex = 0;
            this.lblX0.Text = "Inicial X";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnDraw);
            this.grbProcess.Location = new System.Drawing.Point(6, 142);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(265, 112);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Procesos";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(76, 66);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(131, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(20, 28);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Gráficar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtYIncrease);
            this.grbOutputs.Controls.Add(this.txtXIncrease);
            this.grbOutputs.Controls.Add(this.lblYIncrease);
            this.grbOutputs.Controls.Add(this.lblXIncrease);
            this.grbOutputs.Location = new System.Drawing.Point(6, 275);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(265, 97);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtYIncrease
            // 
            this.txtYIncrease.Enabled = false;
            this.txtYIncrease.Location = new System.Drawing.Point(103, 58);
            this.txtYIncrease.Name = "txtYIncrease";
            this.txtYIncrease.Size = new System.Drawing.Size(100, 20);
            this.txtYIncrease.TabIndex = 3;
            // 
            // txtXIncrease
            // 
            this.txtXIncrease.Enabled = false;
            this.txtXIncrease.Location = new System.Drawing.Point(103, 25);
            this.txtXIncrease.Name = "txtXIncrease";
            this.txtXIncrease.Size = new System.Drawing.Size(100, 20);
            this.txtXIncrease.TabIndex = 2;
            // 
            // lblYIncrease
            // 
            this.lblYIncrease.AutoSize = true;
            this.lblYIncrease.Location = new System.Drawing.Point(28, 61);
            this.lblYIncrease.Name = "lblYIncrease";
            this.lblYIncrease.Size = new System.Drawing.Size(70, 13);
            this.lblYIncrease.TabIndex = 1;
            this.lblYIncrease.Text = "Incremento Y";
            // 
            // lblXIncrease
            // 
            this.lblXIncrease.AutoSize = true;
            this.lblXIncrease.Location = new System.Drawing.Point(27, 28);
            this.lblXIncrease.Name = "lblXIncrease";
            this.lblXIncrease.Size = new System.Drawing.Size(70, 13);
            this.lblXIncrease.TabIndex = 0;
            this.lblXIncrease.Text = "Incremento X";
            // 
            // grbCanva
            // 
            this.grbCanva.Controls.Add(this.picCanva);
            this.grbCanva.Location = new System.Drawing.Point(277, 7);
            this.grbCanva.Name = "grbCanva";
            this.grbCanva.Size = new System.Drawing.Size(521, 364);
            this.grbCanva.TabIndex = 3;
            this.grbCanva.TabStop = false;
            this.grbCanva.Text = "Gráfico";
            // 
            // picCanva
            // 
            this.picCanva.Location = new System.Drawing.Point(8, 17);
            this.picCanva.Name = "picCanva";
            this.picCanva.Size = new System.Drawing.Size(512, 346);
            this.picCanva.TabIndex = 0;
            this.picCanva.TabStop = false;
            // 
            // Forms_DDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.ControlBox = false;
            this.Controls.Add(this.grbCanva);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "Forms_DDA";
            this.Text = "Forms_DDA";
            this.Load += new System.EventHandler(this.Forms_DDA_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbCanva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.GroupBox grbCanva;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label lblY_n;
        private System.Windows.Forms.Label lblX_n;
        private System.Windows.Forms.Label lblY0;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Label lblYIncrease;
        private System.Windows.Forms.Label lblXIncrease;
        private System.Windows.Forms.TextBox txtFinalY;
        private System.Windows.Forms.TextBox txtFinalX;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtYIncrease;
        private System.Windows.Forms.TextBox txtXIncrease;
        private System.Windows.Forms.PictureBox picCanva;
        private System.Windows.Forms.TextBox txtY0;
    }
}