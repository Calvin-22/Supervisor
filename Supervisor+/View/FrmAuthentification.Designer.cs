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
            BtnSeConnecter = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            txtIdentifiant = new TextBox();
            txtMdp = new TextBox();
            lblidentifiant = new Label();
            lblmotdepasse = new Label();
            label3 = new Label();
            fakebutton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnSeConnecter
            // 
            BtnSeConnecter.BackColor = Color.Transparent;
            BtnSeConnecter.BadgeBackColor = Color.Red;
            BtnSeConnecter.BadgeForeColor = Color.White;
            BtnSeConnecter.BadgeRadius = 8;
            BtnSeConnecter.BadgeRightMargin = 10;
            BtnSeConnecter.BadgeValue = 0;
            BtnSeConnecter.BorderColor = Color.FromArgb(150, 255, 255, 255);
            BtnSeConnecter.BorderColorEnd = Color.Gray;
            BtnSeConnecter.BorderColorStart = Color.White;
            BtnSeConnecter.BorderRadiusBottomLeft = 35;
            BtnSeConnecter.BorderRadiusBottomRight = 35;
            BtnSeConnecter.BorderRadiusTopLeft = 35;
            BtnSeConnecter.BorderRadiusTopRight = 35;
            BtnSeConnecter.BorderThickness = 1;
            BtnSeConnecter.ButtonColorEnd = Color.DarkBlue;
            BtnSeConnecter.ButtonColorStart = Color.RoyalBlue;
            BtnSeConnecter.ButtonImage = null;
            BtnSeConnecter.CanBeep = false;
            BtnSeConnecter.CanShake = false;
            BtnSeConnecter.ClickSoundPath = null;
            BtnSeConnecter.DisabledOverlayOpacity = 0.5F;
            BtnSeConnecter.EnableBorderGradient = false;
            BtnSeConnecter.EnableClickSound = false;
            BtnSeConnecter.EnableFocusBorder = false;
            BtnSeConnecter.EnableHoverSound = false;
            BtnSeConnecter.EnablePressScale = false;
            BtnSeConnecter.EnableTextShadow = false;
            BtnSeConnecter.FocusBorderColor = Color.FromArgb(100, 150, 255);
            BtnSeConnecter.FocusBorderThickness = 2;
            BtnSeConnecter.Font = new Font("Segoe UI", 9F);
            BtnSeConnecter.ForeColor = Color.White;
            BtnSeConnecter.HoverColor = Color.FromArgb(20, 0, 0, 0);
            BtnSeConnecter.HoverSoundPath = null;
            BtnSeConnecter.HoverTransitionSpeed = 0.08F;
            BtnSeConnecter.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSeConnecter.ImageLeftMargin = 5;
            BtnSeConnecter.ImageRightMargin = 8;
            BtnSeConnecter.ImageSize = 24;
            BtnSeConnecter.IsReadOnly = false;
            BtnSeConnecter.Location = new Point(288, 384);
            BtnSeConnecter.MakeRadial = false;
            BtnSeConnecter.Name = "BtnSeConnecter";
            BtnSeConnecter.PressAnimationSpeed = 0.2F;
            BtnSeConnecter.PressDepth = 1;
            BtnSeConnecter.RippleColor = Color.FromArgb(60, 255, 255, 255);
            BtnSeConnecter.RippleExpandSpeedFactor = 0.05F;
            BtnSeConnecter.RippleFadeSpeedFactor = 0.03F;
            BtnSeConnecter.ShadowBlurFactor = 0.85F;
            BtnSeConnecter.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            BtnSeConnecter.ShadowOffsetX = 3;
            BtnSeConnecter.ShadowOffsetY = 3;
            BtnSeConnecter.Size = new Size(145, 52);
            BtnSeConnecter.TabIndex = 0;
            BtnSeConnecter.Text = "Se connecter";
            BtnSeConnecter.TextAlign = ContentAlignment.MiddleCenter;
            BtnSeConnecter.TextPaddingBottom = 0;
            BtnSeConnecter.TextPaddingLeft = 0;
            BtnSeConnecter.TextPaddingRight = 0;
            BtnSeConnecter.TextPaddingTop = 0;
            BtnSeConnecter.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            BtnSeConnecter.TextShadowOffsetX = 1;
            BtnSeConnecter.TextShadowOffsetY = 1;
            BtnSeConnecter.Click += BtnSeConnecter_Click;
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmAuthentification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(449, 453);
            Controls.Add(pictureBox1);
            Controls.Add(fakebutton);
            Controls.Add(label3);
            Controls.Add(lblmotdepasse);
            Controls.Add(lblidentifiant);
            Controls.Add(txtMdp);
            Controls.Add(txtIdentifiant);
            Controls.Add(BtnSeConnecter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAuthentification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supervisor+";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnSeConnecter;
        private TextBox txtIdentifiant;
        private TextBox txtMdp;
        private Label lblidentifiant;
        private Label lblmotdepasse;
        private Label label3;
        private Button fakebutton;
        private PictureBox pictureBox1;
    }
}