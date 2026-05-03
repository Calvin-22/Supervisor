namespace Supervisor.View
{
    partial class FrmMenuPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            dgvlogs = new DataGridView();
            grbox = new GroupBox();
            pictureBox1 = new PictureBox();
            siticoneGroupBox1 = new SiticoneNetCoreUI.SiticoneGroupBox();
            siticoneGroupBox2 = new SiticoneNetCoreUI.SiticoneGroupBox();
            label4 = new Label();
            lblidentifiant = new Label();
            label3 = new Label();
            label1 = new Label();
            BtnSeConnecter = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            siticoneGroupBox3 = new SiticoneNetCoreUI.SiticoneGroupBox();
            siticoneButtonAdvanced1 = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvlogs).BeginInit();
            grbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            siticoneGroupBox2.SuspendLayout();
            siticoneGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvlogs
            // 
            dgvlogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvlogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvlogs.BackgroundColor = Color.White;
            dgvlogs.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvlogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvlogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvlogs.DefaultCellStyle = dataGridViewCellStyle2;
            dgvlogs.EnableHeadersVisualStyles = false;
            dgvlogs.Location = new Point(6, 33);
            dgvlogs.MultiSelect = false;
            dgvlogs.Name = "dgvlogs";
            dgvlogs.ReadOnly = true;
            dgvlogs.RowHeadersVisible = false;
            dgvlogs.RowHeadersWidth = 62;
            dgvlogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlogs.Size = new Size(1294, 618);
            dgvlogs.TabIndex = 0;
            // 
            // grbox
            // 
            grbox.Controls.Add(dgvlogs);
            grbox.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbox.Location = new Point(12, 25);
            grbox.Name = "grbox";
            grbox.Size = new Size(1306, 657);
            grbox.TabIndex = 1;
            grbox.TabStop = false;
            grbox.Text = "Logs";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1430, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 359);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // siticoneGroupBox1
            // 
            siticoneGroupBox1.BackColor = Color.Transparent;
            siticoneGroupBox1.BadgeColor = Color.Red;
            siticoneGroupBox1.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            siticoneGroupBox1.BadgeLeftPadding = 12;
            siticoneGroupBox1.BadgeValue = 0;
            siticoneGroupBox1.BadgeVisible = false;
            siticoneGroupBox1.BlinkInterval = 500;
            siticoneGroupBox1.BlinkMinOpacity = 0.3F;
            siticoneGroupBox1.BlinkOpacityStep = 0.05F;
            siticoneGroupBox1.BorderColor = Color.FromArgb(220, 222, 224);
            siticoneGroupBox1.BorderWidth = 3F;
            siticoneGroupBox1.ChevronColor = Color.FromArgb(90, 90, 90);
            siticoneGroupBox1.ChevronLeftSpacing = 4F;
            siticoneGroupBox1.ChevronSize = 10F;
            siticoneGroupBox1.ChevronThickness = 2F;
            siticoneGroupBox1.ContentPadding = 5;
            siticoneGroupBox1.CornerRadius = 15;
            siticoneGroupBox1.EnableBlinking = false;
            siticoneGroupBox1.EnableHoverAnimation = true;
            siticoneGroupBox1.EnableHoverHighlight = true;
            siticoneGroupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            siticoneGroupBox1.GradientEndColor = Color.LightGray;
            siticoneGroupBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox1.GradientStartColor = Color.White;
            siticoneGroupBox1.GroupTitle = "Informations";
            siticoneGroupBox1.HoveredBorderColor = Color.Green;
            siticoneGroupBox1.HoveredTitleColor = Color.Black;
            siticoneGroupBox1.IsCollapsible = false;
            siticoneGroupBox1.Location = new Point(12, 724);
            siticoneGroupBox1.MaxBlinkCount = 3;
            siticoneGroupBox1.Name = "siticoneGroupBox1";
            siticoneGroupBox1.PressedBorderColor = Color.FromArgb(0, 84, 153);
            siticoneGroupBox1.ShadowColor = Color.FromArgb(20, 0, 0, 0);
            siticoneGroupBox1.ShadowDepth = 1;
            siticoneGroupBox1.ShowShadow = true;
            siticoneGroupBox1.Size = new Size(526, 288);
            siticoneGroupBox1.SolidFillColor = Color.FromArgb(249, 249, 249);
            siticoneGroupBox1.StatusIcon = null;
            siticoneGroupBox1.StatusText = "";
            siticoneGroupBox1.TabIndex = 3;
            siticoneGroupBox1.TitleBackColor = Color.Transparent;
            siticoneGroupBox1.TitleColor = Color.FromArgb(30, 30, 30);
            siticoneGroupBox1.TitlePadding = new Padding(10, 8, 10, 12);
            siticoneGroupBox1.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox1.UseGradient = false;
            // 
            // siticoneGroupBox2
            // 
            siticoneGroupBox2.BackColor = Color.Transparent;
            siticoneGroupBox2.BadgeColor = Color.Red;
            siticoneGroupBox2.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            siticoneGroupBox2.BadgeLeftPadding = 12;
            siticoneGroupBox2.BadgeValue = 0;
            siticoneGroupBox2.BadgeVisible = false;
            siticoneGroupBox2.BlinkInterval = 500;
            siticoneGroupBox2.BlinkMinOpacity = 0.3F;
            siticoneGroupBox2.BlinkOpacityStep = 0.05F;
            siticoneGroupBox2.BorderColor = Color.FromArgb(220, 222, 224);
            siticoneGroupBox2.BorderWidth = 3F;
            siticoneGroupBox2.ChevronColor = Color.FromArgb(90, 90, 90);
            siticoneGroupBox2.ChevronLeftSpacing = 4F;
            siticoneGroupBox2.ChevronSize = 10F;
            siticoneGroupBox2.ChevronThickness = 2F;
            siticoneGroupBox2.ContentPadding = 5;
            siticoneGroupBox2.Controls.Add(label4);
            siticoneGroupBox2.CornerRadius = 15;
            siticoneGroupBox2.EnableBlinking = false;
            siticoneGroupBox2.EnableHoverAnimation = true;
            siticoneGroupBox2.EnableHoverHighlight = true;
            siticoneGroupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            siticoneGroupBox2.GradientEndColor = Color.LightGray;
            siticoneGroupBox2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox2.GradientStartColor = Color.White;
            siticoneGroupBox2.GroupTitle = "Outils système";
            siticoneGroupBox2.HoveredBorderColor = Color.Crimson;
            siticoneGroupBox2.HoveredTitleColor = Color.Black;
            siticoneGroupBox2.IsCollapsible = false;
            siticoneGroupBox2.Location = new Point(1430, 724);
            siticoneGroupBox2.MaxBlinkCount = 3;
            siticoneGroupBox2.Name = "siticoneGroupBox2";
            siticoneGroupBox2.PressedBorderColor = Color.FromArgb(0, 84, 153);
            siticoneGroupBox2.ShadowColor = Color.FromArgb(20, 0, 0, 0);
            siticoneGroupBox2.ShadowDepth = 3;
            siticoneGroupBox2.ShowShadow = true;
            siticoneGroupBox2.Size = new Size(456, 288);
            siticoneGroupBox2.SolidFillColor = Color.FromArgb(249, 249, 249);
            siticoneGroupBox2.StatusIcon = null;
            siticoneGroupBox2.StatusText = "";
            siticoneGroupBox2.TabIndex = 4;
            siticoneGroupBox2.TitleBackColor = Color.Transparent;
            siticoneGroupBox2.TitleColor = Color.FromArgb(30, 30, 30);
            siticoneGroupBox2.TitlePadding = new Padding(10, 8, 10, 12);
            siticoneGroupBox2.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox2.UseGradient = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 95);
            label4.Name = "label4";
            label4.Size = new Size(192, 27);
            label4.TabIndex = 10;
            label4.Text = "Exporter vers PDF :";
            // 
            // lblidentifiant
            // 
            lblidentifiant.AutoSize = true;
            lblidentifiant.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidentifiant.Location = new Point(1502, 417);
            lblidentifiant.Name = "lblidentifiant";
            lblidentifiant.Size = new Size(266, 27);
            lblidentifiant.TabIndex = 5;
            lblidentifiant.Text = "Bienvenue sur Supervisor+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSlateGray;
            label3.Location = new Point(1430, 448);
            label3.Name = "label3";
            label3.Size = new Size(302, 27);
            label3.TabIndex = 6;
            label3.Text = "Outil de supervision, d'analyse";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSlateGray;
            label1.Location = new Point(1430, 475);
            label1.Name = "label1";
            label1.Size = new Size(427, 27);
            label1.TabIndex = 7;
            label1.Text = "et d’exploitation avancée du système CA25.";
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
            BtnSeConnecter.Location = new Point(714, 200);
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
            BtnSeConnecter.TabIndex = 1;
            BtnSeConnecter.Text = "Se connecter";
            BtnSeConnecter.TextAlign = ContentAlignment.MiddleCenter;
            BtnSeConnecter.TextPaddingBottom = 0;
            BtnSeConnecter.TextPaddingLeft = 0;
            BtnSeConnecter.TextPaddingRight = 0;
            BtnSeConnecter.TextPaddingTop = 0;
            BtnSeConnecter.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            BtnSeConnecter.TextShadowOffsetX = 1;
            BtnSeConnecter.TextShadowOffsetY = 1;
            // 
            // siticoneGroupBox3
            // 
            siticoneGroupBox3.BackColor = Color.Transparent;
            siticoneGroupBox3.BadgeColor = Color.Red;
            siticoneGroupBox3.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            siticoneGroupBox3.BadgeLeftPadding = 12;
            siticoneGroupBox3.BadgeValue = 0;
            siticoneGroupBox3.BadgeVisible = false;
            siticoneGroupBox3.BlinkInterval = 500;
            siticoneGroupBox3.BlinkMinOpacity = 0.3F;
            siticoneGroupBox3.BlinkOpacityStep = 0.05F;
            siticoneGroupBox3.BorderColor = Color.FromArgb(220, 222, 224);
            siticoneGroupBox3.BorderWidth = 3F;
            siticoneGroupBox3.ChevronColor = Color.FromArgb(90, 90, 90);
            siticoneGroupBox3.ChevronLeftSpacing = 4F;
            siticoneGroupBox3.ChevronSize = 10F;
            siticoneGroupBox3.ChevronThickness = 2F;
            siticoneGroupBox3.ContentPadding = 5;
            siticoneGroupBox3.Controls.Add(siticoneButtonAdvanced1);
            siticoneGroupBox3.Controls.Add(label2);
            siticoneGroupBox3.Controls.Add(textBox1);
            siticoneGroupBox3.Controls.Add(BtnSeConnecter);
            siticoneGroupBox3.CornerRadius = 15;
            siticoneGroupBox3.EnableBlinking = false;
            siticoneGroupBox3.EnableHoverAnimation = true;
            siticoneGroupBox3.EnableHoverHighlight = true;
            siticoneGroupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            siticoneGroupBox3.GradientEndColor = Color.LightGray;
            siticoneGroupBox3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox3.GradientStartColor = Color.White;
            siticoneGroupBox3.GroupTitle = "Interagir avec les logs";
            siticoneGroupBox3.HoveredBorderColor = Color.DarkBlue;
            siticoneGroupBox3.HoveredTitleColor = Color.Black;
            siticoneGroupBox3.IsCollapsible = false;
            siticoneGroupBox3.Location = new Point(538, 724);
            siticoneGroupBox3.MaxBlinkCount = 3;
            siticoneGroupBox3.Name = "siticoneGroupBox3";
            siticoneGroupBox3.PressedBorderColor = Color.FromArgb(0, 84, 153);
            siticoneGroupBox3.ShadowColor = Color.FromArgb(20, 0, 0, 0);
            siticoneGroupBox3.ShadowDepth = 1;
            siticoneGroupBox3.ShowShadow = true;
            siticoneGroupBox3.Size = new Size(886, 288);
            siticoneGroupBox3.SolidFillColor = Color.FromArgb(249, 249, 249);
            siticoneGroupBox3.StatusIcon = null;
            siticoneGroupBox3.StatusText = "";
            siticoneGroupBox3.TabIndex = 4;
            siticoneGroupBox3.TitleBackColor = Color.Transparent;
            siticoneGroupBox3.TitleColor = Color.FromArgb(30, 30, 30);
            siticoneGroupBox3.TitlePadding = new Padding(10, 8, 10, 12);
            siticoneGroupBox3.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox3.UseGradient = false;
            // 
            // siticoneButtonAdvanced1
            // 
            siticoneButtonAdvanced1.BackColor = Color.Transparent;
            siticoneButtonAdvanced1.BadgeBackColor = Color.Red;
            siticoneButtonAdvanced1.BadgeForeColor = Color.White;
            siticoneButtonAdvanced1.BadgeRadius = 8;
            siticoneButtonAdvanced1.BadgeRightMargin = 10;
            siticoneButtonAdvanced1.BadgeValue = 0;
            siticoneButtonAdvanced1.BorderColor = Color.FromArgb(150, 255, 255, 255);
            siticoneButtonAdvanced1.BorderColorEnd = Color.Gray;
            siticoneButtonAdvanced1.BorderColorStart = Color.White;
            siticoneButtonAdvanced1.BorderRadiusBottomLeft = 35;
            siticoneButtonAdvanced1.BorderRadiusBottomRight = 35;
            siticoneButtonAdvanced1.BorderRadiusTopLeft = 35;
            siticoneButtonAdvanced1.BorderRadiusTopRight = 35;
            siticoneButtonAdvanced1.BorderThickness = 1;
            siticoneButtonAdvanced1.ButtonColorEnd = Color.DarkBlue;
            siticoneButtonAdvanced1.ButtonColorStart = Color.RoyalBlue;
            siticoneButtonAdvanced1.ButtonImage = null;
            siticoneButtonAdvanced1.CanBeep = false;
            siticoneButtonAdvanced1.CanShake = false;
            siticoneButtonAdvanced1.ClickSoundPath = null;
            siticoneButtonAdvanced1.DisabledOverlayOpacity = 0.5F;
            siticoneButtonAdvanced1.EnableBorderGradient = false;
            siticoneButtonAdvanced1.EnableClickSound = false;
            siticoneButtonAdvanced1.EnableFocusBorder = false;
            siticoneButtonAdvanced1.EnableHoverSound = false;
            siticoneButtonAdvanced1.EnablePressScale = false;
            siticoneButtonAdvanced1.EnableTextShadow = false;
            siticoneButtonAdvanced1.FocusBorderColor = Color.FromArgb(100, 150, 255);
            siticoneButtonAdvanced1.FocusBorderThickness = 2;
            siticoneButtonAdvanced1.Font = new Font("Segoe UI", 9F);
            siticoneButtonAdvanced1.ForeColor = Color.White;
            siticoneButtonAdvanced1.HoverColor = Color.FromArgb(20, 0, 0, 0);
            siticoneButtonAdvanced1.HoverSoundPath = null;
            siticoneButtonAdvanced1.HoverTransitionSpeed = 0.08F;
            siticoneButtonAdvanced1.ImageAlign = ContentAlignment.MiddleLeft;
            siticoneButtonAdvanced1.ImageLeftMargin = 5;
            siticoneButtonAdvanced1.ImageRightMargin = 8;
            siticoneButtonAdvanced1.ImageSize = 24;
            siticoneButtonAdvanced1.IsReadOnly = false;
            siticoneButtonAdvanced1.Location = new Point(714, 142);
            siticoneButtonAdvanced1.MakeRadial = false;
            siticoneButtonAdvanced1.Name = "siticoneButtonAdvanced1";
            siticoneButtonAdvanced1.PressAnimationSpeed = 0.2F;
            siticoneButtonAdvanced1.PressDepth = 1;
            siticoneButtonAdvanced1.RippleColor = Color.FromArgb(60, 255, 255, 255);
            siticoneButtonAdvanced1.RippleExpandSpeedFactor = 0.05F;
            siticoneButtonAdvanced1.RippleFadeSpeedFactor = 0.03F;
            siticoneButtonAdvanced1.ShadowBlurFactor = 0.85F;
            siticoneButtonAdvanced1.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            siticoneButtonAdvanced1.ShadowOffsetX = 3;
            siticoneButtonAdvanced1.ShadowOffsetY = 3;
            siticoneButtonAdvanced1.Size = new Size(145, 52);
            siticoneButtonAdvanced1.TabIndex = 9;
            siticoneButtonAdvanced1.Text = "Statistiques";
            siticoneButtonAdvanced1.TextAlign = ContentAlignment.MiddleCenter;
            siticoneButtonAdvanced1.TextPaddingBottom = 0;
            siticoneButtonAdvanced1.TextPaddingLeft = 0;
            siticoneButtonAdvanced1.TextPaddingRight = 0;
            siticoneButtonAdvanced1.TextPaddingTop = 0;
            siticoneButtonAdvanced1.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            siticoneButtonAdvanced1.TextShadowOffsetX = 1;
            siticoneButtonAdvanced1.TextShadowOffsetY = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 96);
            label2.Name = "label2";
            label2.Size = new Size(128, 27);
            label2.TabIndex = 8;
            label2.Text = "Rechercher :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(siticoneGroupBox3);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lblidentifiant);
            Controls.Add(siticoneGroupBox2);
            Controls.Add(siticoneGroupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(grbox);
            Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supervisor";
            ((System.ComponentModel.ISupportInitialize)dgvlogs).EndInit();
            grbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            siticoneGroupBox2.ResumeLayout(false);
            siticoneGroupBox2.PerformLayout();
            siticoneGroupBox3.ResumeLayout(false);
            siticoneGroupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvlogs;
        private GroupBox grbox;
        private PictureBox pictureBox1;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox1;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox2;
        private Label lblidentifiant;
        private Label label3;
        private Label label1;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnSeConnecter;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox3;
        private Label label4;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced siticoneButtonAdvanced1;
        private Label label2;
        private TextBox textBox1;
    }
}