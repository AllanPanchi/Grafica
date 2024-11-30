namespace Practica_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbCanva = new GroupBox();
            picCanva = new PictureBox();
            grbInputs = new GroupBox();
            btnDraw = new Button();
            txtSteps = new TextBox();
            lblSteps = new Label();
            grbCanva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanva).BeginInit();
            grbInputs.SuspendLayout();
            SuspendLayout();
            // 
            // grbCanva
            // 
            grbCanva.Controls.Add(picCanva);
            grbCanva.Location = new Point(234, 14);
            grbCanva.Name = "grbCanva";
            grbCanva.Size = new Size(557, 430);
            grbCanva.TabIndex = 0;
            grbCanva.TabStop = false;
            grbCanva.Text = "Gráfico";
            // 
            // picCanva
            // 
            picCanva.Location = new Point(6, 19);
            picCanva.Name = "picCanva";
            picCanva.Size = new Size(545, 405);
            picCanva.TabIndex = 0;
            picCanva.TabStop = false;
            picCanva.Paint += picCanva_Paint;
            // 
            // grbInputs
            // 
            grbInputs.Controls.Add(btnDraw);
            grbInputs.Controls.Add(txtSteps);
            grbInputs.Controls.Add(lblSteps);
            grbInputs.Location = new Point(12, 183);
            grbInputs.Name = "grbInputs";
            grbInputs.Size = new Size(206, 112);
            grbInputs.TabIndex = 1;
            grbInputs.TabStop = false;
            grbInputs.Text = "Datos";
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(55, 74);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(75, 23);
            btnDraw.TabIndex = 2;
            btnDraw.Text = "Dibujar";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // txtSteps
            // 
            txtSteps.Location = new Point(10, 45);
            txtSteps.Name = "txtSteps";
            txtSteps.Size = new Size(191, 23);
            txtSteps.TabIndex = 1;
            // 
            // lblSteps
            // 
            lblSteps.AutoSize = true;
            lblSteps.Location = new Point(10, 27);
            lblSteps.Name = "lblSteps";
            lblSteps.Size = new Size(38, 15);
            lblSteps.TabIndex = 0;
            lblSteps.Text = "Saltos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbInputs);
            Controls.Add(grbCanva);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            grbCanva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCanva).EndInit();
            grbInputs.ResumeLayout(false);
            grbInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbCanva;
        private PictureBox picCanva;
        private GroupBox grbInputs;
        private TextBox txtSteps;
        private Label lblSteps;
        private Button btnDraw;
    }
}
