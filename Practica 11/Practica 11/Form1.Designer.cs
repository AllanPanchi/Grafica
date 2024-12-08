namespace Practica_11
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.trkbEscalado = new System.Windows.Forms.TrackBar();
            this.grbCanva = new System.Windows.Forms.GroupBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.picCanva = new System.Windows.Forms.PictureBox();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkbEscalado)).BeginInit();
            this.grbCanva.SuspendLayout();
            this.grbProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).BeginInit();
            this.grbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkbEscalado
            // 
            this.trkbEscalado.Location = new System.Drawing.Point(501, 382);
            this.trkbEscalado.Name = "trkbEscalado";
            this.trkbEscalado.Size = new System.Drawing.Size(144, 56);
            this.trkbEscalado.TabIndex = 0;
            // 
            // grbCanva
            // 
            this.grbCanva.Controls.Add(this.picCanva);
            this.grbCanva.Location = new System.Drawing.Point(5, 8);
            this.grbCanva.Name = "grbCanva";
            this.grbCanva.Size = new System.Drawing.Size(790, 346);
            this.grbCanva.TabIndex = 1;
            this.grbCanva.TabStop = false;
            this.grbCanva.Text = "Gráfico";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnDraw);
            this.grbProcess.Location = new System.Drawing.Point(257, 375);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(238, 63);
            this.grbProcess.TabIndex = 2;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Procesos";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(27, 34);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(124, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picCanva
            // 
            this.picCanva.Location = new System.Drawing.Point(11, 22);
            this.picCanva.Name = "picCanva";
            this.picCanva.Size = new System.Drawing.Size(778, 323);
            this.picCanva.TabIndex = 0;
            this.picCanva.TabStop = false;
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtRadius);
            this.grbInput.Controls.Add(this.lblRadius);
            this.grbInput.Location = new System.Drawing.Point(16, 382);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(235, 56);
            this.grbInput.TabIndex = 3;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Entrada";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(27, 27);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(44, 16);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radio";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(89, 27);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(129, 22);
            this.txtRadius.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbCanva);
            this.Controls.Add(this.trkbEscalado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkbEscalado)).EndInit();
            this.grbCanva.ResumeLayout(false);
            this.grbProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).EndInit();
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkbEscalado;
        private System.Windows.Forms.GroupBox grbCanva;
        private System.Windows.Forms.PictureBox picCanva;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
    }
}

