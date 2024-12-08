namespace Practica_6
{
    partial class FrmSquare
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
            this.txtSide = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbCanva = new System.Windows.Forms.GroupBox();
            this.picCanva = new System.Windows.Forms.PictureBox();
            this.grbRotation = new System.Windows.Forms.GroupBox();
            this.trckbSize = new System.Windows.Forms.TrackBar();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbCanva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).BeginInit();
            this.grbRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbSize)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtSide);
            this.grbInputs.Controls.Add(this.lblSide);
            this.grbInputs.Location = new System.Drawing.Point(32, 41);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(4);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(4);
            this.grbInputs.Size = new System.Drawing.Size(353, 95);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            this.grbInputs.UseWaitCursor = true;
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(77, 43);
            this.txtSide.Margin = new System.Windows.Forms.Padding(4);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(253, 22);
            this.txtSide.TabIndex = 1;
            this.txtSide.UseWaitCursor = true;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(8, 47);
            this.lblSide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(38, 16);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Lado";
            this.lblSide.UseWaitCursor = true;
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(32, 307);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(4);
            this.grbProcess.Size = new System.Drawing.Size(353, 108);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Procesos";
            this.grbProcess.UseWaitCursor = true;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnExit.Location = new System.Drawing.Point(245, 43);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Regresar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(128, 43);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 33);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.UseWaitCursor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 43);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 33);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.UseWaitCursor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Location = new System.Drawing.Point(32, 423);
            this.grbOutputs.Margin = new System.Windows.Forms.Padding(4);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Padding = new System.Windows.Forms.Padding(4);
            this.grbOutputs.Size = new System.Drawing.Size(353, 106);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            this.grbOutputs.UseWaitCursor = true;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(97, 73);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(232, 22);
            this.txtArea.TabIndex = 3;
            this.txtArea.UseWaitCursor = true;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(97, 33);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(232, 22);
            this.txtPerimeter.TabIndex = 2;
            this.txtPerimeter.UseWaitCursor = true;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(25, 68);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area";
            this.lblArea.UseWaitCursor = true;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(12, 36);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(65, 16);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro";
            this.lblPerimeter.UseWaitCursor = true;
            // 
            // grbCanva
            // 
            this.grbCanva.Controls.Add(this.picCanva);
            this.grbCanva.Location = new System.Drawing.Point(395, 41);
            this.grbCanva.Margin = new System.Windows.Forms.Padding(4);
            this.grbCanva.Name = "grbCanva";
            this.grbCanva.Padding = new System.Windows.Forms.Padding(4);
            this.grbCanva.Size = new System.Drawing.Size(664, 507);
            this.grbCanva.TabIndex = 3;
            this.grbCanva.TabStop = false;
            this.grbCanva.Text = "Gráfico";
            this.grbCanva.UseWaitCursor = true;
            // 
            // picCanva
            // 
            this.picCanva.Location = new System.Drawing.Point(8, 23);
            this.picCanva.Margin = new System.Windows.Forms.Padding(4);
            this.picCanva.Name = "picCanva";
            this.picCanva.Size = new System.Drawing.Size(647, 484);
            this.picCanva.TabIndex = 0;
            this.picCanva.TabStop = false;
            this.picCanva.UseWaitCursor = true;
            // 
            // grbRotation
            // 
            this.grbRotation.Controls.Add(this.trckbSize);
            this.grbRotation.Controls.Add(this.btnRotateRight);
            this.grbRotation.Controls.Add(this.btnRotateLeft);
            this.grbRotation.Location = new System.Drawing.Point(32, 143);
            this.grbRotation.Name = "grbRotation";
            this.grbRotation.Size = new System.Drawing.Size(345, 157);
            this.grbRotation.TabIndex = 3;
            this.grbRotation.TabStop = false;
            this.grbRotation.Text = "Rotación";
            this.grbRotation.UseWaitCursor = true;
            // 
            // trckbSize
            // 
            this.trckbSize.Location = new System.Drawing.Point(18, 41);
            this.trckbSize.Maximum = 15;
            this.trckbSize.Minimum = 1;
            this.trckbSize.Name = "trckbSize";
            this.trckbSize.Size = new System.Drawing.Size(311, 56);
            this.trckbSize.TabIndex = 2;
            this.trckbSize.UseWaitCursor = true;
            this.trckbSize.Value = 1;
            this.trckbSize.Scroll += new System.EventHandler(this.trckbSize_Scroll);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Location = new System.Drawing.Point(179, 103);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(93, 36);
            this.btnRotateRight.TabIndex = 1;
            this.btnRotateRight.Text = "Derecha";
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.UseWaitCursor = true;
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Location = new System.Drawing.Point(15, 103);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(104, 36);
            this.btnRotateLeft.TabIndex = 0;
            this.btnRotateLeft.Text = "Izquierda";
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.UseWaitCursor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // FrmSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 561);
            this.ControlBox = false;
            this.Controls.Add(this.grbRotation);
            this.Controls.Add(this.grbCanva);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSquare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadrado";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FrmSquare_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbCanva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).EndInit();
            this.grbRotation.ResumeLayout(false);
            this.grbRotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.GroupBox grbCanva;
        private System.Windows.Forms.PictureBox picCanva;
        private System.Windows.Forms.GroupBox grbRotation;
        private System.Windows.Forms.TrackBar trckbSize;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnRotateLeft;
    }
}