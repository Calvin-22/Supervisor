namespace Supervisor.View
{
    partial class FrmAuthentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthentification));
            txtIdentifiant = new TextBox();
            txtMdp = new TextBox();
            lblidentifiant = new Label();
            lblmotdepasse = new Label();
            label3 = new Label();
            fakebutton = new Button();
            pictureBox1 = new PictureBox();
            modernButton1 = new ModernButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Location = new Point(216, 287);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(210, 31);
            txtIdentifiant.TabIndex = 1;
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(216, 336);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(210, 31);
            txtMdp.TabIndex = 2;
            txtMdp.UseSystemPasswordChar = true;
            // 
            // lblidentifiant
            // 
            lblidentifiant.AutoSize = true;
            lblidentifiant.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidentifiant.Location = new Point(25, 291);
            lblidentifiant.Name = "lblidentifiant";
            lblidentifiant.Size = new Size(129, 27);
            lblidentifiant.TabIndex = 3;
            lblidentifiant.Text = "Identifiant : ";
            // 
            // lblmotdepasse
            // 
            lblmotdepasse.AutoSize = true;
            lblmotdepasse.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmotdepasse.Location = new Point(25, 340);
            lblmotdepasse.Name = "lblmotdepasse";
            lblmotdepasse.Size = new Size(149, 27);
            lblmotdepasse.TabIndex = 4;
            lblmotdepasse.Text = "Mot de passe :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSlateGray;
            label3.Location = new Point(25, 239);
            label3.Name = "label3";
            label3.Size = new Size(272, 27);
            label3.TabIndex = 5;
            label3.Text = "Veuillez vous authentifier : ";
            // 
            // fakebutton
            // 
            fakebutton.FlatStyle = FlatStyle.Flat;
            fakebutton.ForeColor = Color.White;
            fakebutton.Location = new Point(13, 444);
            fakebutton.Name = "fakebutton";
            fakebutton.Size = new Size(10, 11);
            fakebutton.TabIndex = 6;
            fakebutton.UseVisualStyleBackColor = true;
            fakebutton.Click += FakeAcceptButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supervisor___logo_complet;
            pictureBox1.Location = new Point(0, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // modernButton1
            // 
            modernButton1.BorderRadius = 20;
            modernButton1.EndColor = Color.MidnightBlue;
            modernButton1.FlatAppearance.BorderSize = 0;
            modernButton1.FlatAppearance.MouseDownBackColor = Color.White;
            modernButton1.FlatAppearance.MouseOverBackColor = Color.White;
            modernButton1.FlatStyle = FlatStyle.Flat;
            modernButton1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modernButton1.ForeColor = Color.White;
            modernButton1.Location = new Point(266, 392);
            modernButton1.Name = "modernButton1";
            modernButton1.Size = new Size(160, 39);
            modernButton1.StartColor = Color.Blue;
            modernButton1.TabIndex = 38;
            modernButton1.Text = "Se connecter";
            modernButton1.UseVisualStyleBackColor = true;
            // 
            // FrmAuthentification
            // 
            AcceptButton = fakebutton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(449, 453);
            Controls.Add(modernButton1);
            Controls.Add(pictureBox1);
            Controls.Add(fakebutton);
            Controls.Add(label3);
            Controls.Add(lblmotdepasse);
            Controls.Add(lblidentifiant);
            Controls.Add(txtMdp);
            Controls.Add(txtIdentifiant);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAuthentification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supervisor+";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIdentifiant;
        private TextBox txtMdp;
        private Label lblidentifiant;
        private Label lblmotdepasse;
        private Label label3;
        private Button fakebutton;
        private PictureBox pictureBox1;
        private ModernButton modernButton1;
        private Button BtnSeConnecter;
    }
}