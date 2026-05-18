namespace Supervisor.View
{
    partial class FrmInformations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformations));
            label4 = new Label();
            label2 = new Label();
            ligne4 = new Label();
            label1 = new Label();
            ligne2 = new Label();
            ligne1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(31, 209);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 17;
            label4.Text = "Calvin N'DIAYE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(31, 181);
            label2.Name = "label2";
            label2.Size = new Size(393, 25);
            label2.TabIndex = 15;
            label2.Text = "Épreuve E6 - BTS CIEL (option IR) - Session 2026";
            // 
            // ligne4
            // 
            ligne4.AutoSize = true;
            ligne4.ImeMode = ImeMode.NoControl;
            ligne4.Location = new Point(31, 127);
            ligne4.Name = "ligne4";
            ligne4.Size = new Size(335, 25);
            ligne4.TabIndex = 14;
            ligne4.Text = "Solution logicielle de supervision de logs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(31, 100);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 13;
            label1.Text = "Build : 20260518";
            // 
            // ligne2
            // 
            ligne2.AutoSize = true;
            ligne2.ImeMode = ImeMode.NoControl;
            ligne2.Location = new Point(31, 72);
            ligne2.Name = "ligne2";
            ligne2.Size = new Size(104, 25);
            ligne2.TabIndex = 12;
            ligne2.Text = "Version : 34";
            // 
            // ligne1
            // 
            ligne1.AutoSize = true;
            ligne1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ligne1.ForeColor = Color.DarkBlue;
            ligne1.ImeMode = ImeMode.NoControl;
            ligne1.Location = new Point(28, 28);
            ligne1.Name = "ligne1";
            ligne1.Size = new Size(116, 25);
            ligne1.TabIndex = 11;
            ligne1.Text = "Supervisor+";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_bleu;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(430, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(31, 154);
            label5.Name = "label5";
            label5.Size = new Size(285, 25);
            label5.TabIndex = 19;
            label5.Text = "Projet CA25 - Lycée Charles Poncet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(155, 260);
            label3.Name = "label3";
            label3.Size = new Size(344, 25);
            label3.TabIndex = 16;
            label3.Text = "Copyright © 2026  -  Tous droits réservés.";
            // 
            // FrmInformations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(628, 305);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ligne4);
            Controls.Add(label1);
            Controls.Add(ligne2);
            Controls.Add(ligne1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmInformations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informations - Supervisor+";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label2;
        private Label ligne4;
        private Label label1;
        private Label ligne2;
        private Label ligne1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label3;
    }
}