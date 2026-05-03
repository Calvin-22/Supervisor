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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            dgvlogs = new DataGridView();
            grbox = new GroupBox();
            pictureBox1 = new PictureBox();
            siticoneGroupBox1 = new SiticoneNetCoreUI.SiticoneGroupBox();
            lblAccesRefuses = new Label();
            lblAccesAutorise = new Label();
            lblTotalTentatives = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            siticoneGroupBox2 = new SiticoneNetCoreUI.SiticoneGroupBox();
            label4 = new Label();
            siticoneButtonAdvanced1 = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            BtnSeConnecter = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            lblidentifiant = new Label();
            label3 = new Label();
            label1 = new Label();
            siticoneGroupBox3 = new SiticoneNetCoreUI.SiticoneGroupBox();
            BtnReset = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btnFiltrerDates = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label10 = new Label();
            dtpFin = new DateTimePicker();
            dtpDebut = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            cbResultat = new ComboBox();
            siticoneButtonAdvanced2 = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvlogs).BeginInit();
            grbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            siticoneGroupBox1.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvlogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvlogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvlogs.DefaultCellStyle = dataGridViewCellStyle4;
            dgvlogs.EnableHeadersVisualStyles = false;
            dgvlogs.Location = new Point(6, 33);
            dgvlogs.MultiSelect = false;
            dgvlogs.Name = "dgvlogs";
            dgvlogs.ReadOnly = true;
            dgvlogs.RowHeadersVisible = false;
            dgvlogs.RowHeadersWidth = 62;
            dgvlogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlogs.Size = new Size(1353, 618);
            dgvlogs.TabIndex = 0;
            // 
            // grbox
            // 
            grbox.Controls.Add(dgvlogs);
            grbox.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbox.Location = new Point(12, 25);
            grbox.Name = "grbox";
            grbox.Size = new Size(1365, 657);
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
            siticoneGroupBox1.Controls.Add(lblAccesRefuses);
            siticoneGroupBox1.Controls.Add(lblAccesAutorise);
            siticoneGroupBox1.Controls.Add(lblTotalTentatives);
            siticoneGroupBox1.Controls.Add(label7);
            siticoneGroupBox1.Controls.Add(label6);
            siticoneGroupBox1.Controls.Add(label5);
            siticoneGroupBox1.CornerRadius = 15;
            siticoneGroupBox1.EnableBlinking = false;
            siticoneGroupBox1.EnableHoverAnimation = true;
            siticoneGroupBox1.EnableHoverHighlight = true;
            siticoneGroupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            siticoneGroupBox1.GradientEndColor = Color.LightGray;
            siticoneGroupBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox1.GradientStartColor = Color.White;
            siticoneGroupBox1.GroupTitle = "Informations générales";
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
            siticoneGroupBox1.SolidFillColor = Color.White;
            siticoneGroupBox1.StatusIcon = null;
            siticoneGroupBox1.StatusText = "";
            siticoneGroupBox1.TabIndex = 3;
            siticoneGroupBox1.TitleBackColor = Color.Transparent;
            siticoneGroupBox1.TitleColor = Color.FromArgb(30, 30, 30);
            siticoneGroupBox1.TitlePadding = new Padding(10, 8, 10, 12);
            siticoneGroupBox1.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox1.UseGradient = false;
            // 
            // lblAccesRefuses
            // 
            lblAccesRefuses.AutoSize = true;
            lblAccesRefuses.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccesRefuses.Location = new Point(265, 145);
            lblAccesRefuses.Name = "lblAccesRefuses";
            lblAccesRefuses.Size = new Size(23, 27);
            lblAccesRefuses.TabIndex = 12;
            lblAccesRefuses.Text = "a";
            // 
            // lblAccesAutorise
            // 
            lblAccesAutorise.AutoSize = true;
            lblAccesAutorise.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccesAutorise.Location = new Point(282, 109);
            lblAccesAutorise.Name = "lblAccesAutorise";
            lblAccesAutorise.Size = new Size(23, 27);
            lblAccesAutorise.TabIndex = 11;
            lblAccesAutorise.Text = "a";
            // 
            // lblTotalTentatives
            // 
            lblTotalTentatives.AutoSize = true;
            lblTotalTentatives.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTentatives.Location = new Point(329, 70);
            lblTotalTentatives.Name = "lblTotalTentatives";
            lblTotalTentatives.Size = new Size(23, 27);
            lblTotalTentatives.TabIndex = 8;
            lblTotalTentatives.Text = "a";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 145);
            label7.Name = "label7";
            label7.Size = new Size(240, 27);
            label7.TabIndex = 10;
            label7.Text = "Nombre d'accès refusé :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 109);
            label6.Name = "label6";
            label6.Size = new Size(258, 27);
            label6.TabIndex = 9;
            label6.Text = "Nombre d'accès autorisé :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 71);
            label5.Name = "label5";
            label5.Size = new Size(311, 27);
            label5.TabIndex = 8;
            label5.Text = "Nombre de tentatives d'accès : ";
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
            siticoneGroupBox2.Controls.Add(siticoneButtonAdvanced1);
            siticoneGroupBox2.Controls.Add(BtnSeConnecter);
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
            siticoneGroupBox2.ShadowDepth = 1;
            siticoneGroupBox2.ShowShadow = true;
            siticoneGroupBox2.Size = new Size(456, 288);
            siticoneGroupBox2.SolidFillColor = Color.White;
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
            siticoneButtonAdvanced1.Location = new Point(53, 161);
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
            BtnSeConnecter.Location = new Point(72, 219);
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
            siticoneGroupBox3.Controls.Add(BtnReset);
            siticoneGroupBox3.Controls.Add(btnFiltrerDates);
            siticoneGroupBox3.Controls.Add(label10);
            siticoneGroupBox3.Controls.Add(dtpFin);
            siticoneGroupBox3.Controls.Add(dtpDebut);
            siticoneGroupBox3.Controls.Add(label9);
            siticoneGroupBox3.Controls.Add(label8);
            siticoneGroupBox3.Controls.Add(cbResultat);
            siticoneGroupBox3.Controls.Add(siticoneButtonAdvanced2);
            siticoneGroupBox3.Controls.Add(label2);
            siticoneGroupBox3.Controls.Add(textBox1);
            siticoneGroupBox3.CornerRadius = 15;
            siticoneGroupBox3.EnableBlinking = false;
            siticoneGroupBox3.EnableHoverAnimation = true;
            siticoneGroupBox3.EnableHoverHighlight = true;
            siticoneGroupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            siticoneGroupBox3.GradientEndColor = Color.White;
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
            siticoneGroupBox3.ShadowColor = Color.White;
            siticoneGroupBox3.ShadowDepth = 1;
            siticoneGroupBox3.ShowShadow = true;
            siticoneGroupBox3.Size = new Size(886, 288);
            siticoneGroupBox3.SolidFillColor = Color.White;
            siticoneGroupBox3.StatusIcon = null;
            siticoneGroupBox3.StatusText = "";
            siticoneGroupBox3.TabIndex = 4;
            siticoneGroupBox3.TitleBackColor = Color.Transparent;
            siticoneGroupBox3.TitleColor = Color.FromArgb(30, 30, 30);
            siticoneGroupBox3.TitlePadding = new Padding(10, 8, 10, 12);
            siticoneGroupBox3.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox3.UseGradient = false;
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.Transparent;
            BtnReset.BackgroundImage = (Image)resources.GetObject("BtnReset.BackgroundImage");
            BtnReset.BackgroundImageLayout = ImageLayout.Zoom;
            BtnReset.BadgeBackColor = Color.Red;
            BtnReset.BadgeForeColor = Color.White;
            BtnReset.BadgeRadius = 8;
            BtnReset.BadgeRightMargin = 10;
            BtnReset.BadgeValue = 0;
            BtnReset.BorderColor = Color.FromArgb(150, 255, 255, 255);
            BtnReset.BorderColorEnd = Color.Gray;
            BtnReset.BorderColorStart = Color.White;
            BtnReset.BorderRadiusBottomLeft = 35;
            BtnReset.BorderRadiusBottomRight = 35;
            BtnReset.BorderRadiusTopLeft = 35;
            BtnReset.BorderRadiusTopRight = 35;
            BtnReset.BorderThickness = 1;
            BtnReset.ButtonColorEnd = Color.Transparent;
            BtnReset.ButtonColorStart = Color.Transparent;
            BtnReset.ButtonImage = null;
            BtnReset.CanBeep = false;
            BtnReset.CanShake = false;
            BtnReset.ClickSoundPath = null;
            BtnReset.DisabledOverlayOpacity = 0.5F;
            BtnReset.EnableBorderGradient = false;
            BtnReset.EnableClickSound = false;
            BtnReset.EnableFocusBorder = false;
            BtnReset.EnableHoverSound = false;
            BtnReset.EnablePressScale = false;
            BtnReset.EnableTextShadow = false;
            BtnReset.FocusBorderColor = Color.FromArgb(100, 150, 255);
            BtnReset.FocusBorderThickness = 2;
            BtnReset.Font = new Font("Segoe UI", 9F);
            BtnReset.ForeColor = Color.White;
            BtnReset.HoverColor = Color.FromArgb(20, 0, 0, 0);
            BtnReset.HoverSoundPath = null;
            BtnReset.HoverTransitionSpeed = 0.08F;
            BtnReset.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReset.ImageLeftMargin = 5;
            BtnReset.ImageRightMargin = 8;
            BtnReset.ImageSize = 24;
            BtnReset.IsReadOnly = false;
            BtnReset.Location = new Point(791, 164);
            BtnReset.MakeRadial = false;
            BtnReset.Name = "BtnReset";
            BtnReset.PressAnimationSpeed = 0.2F;
            BtnReset.PressDepth = 1;
            BtnReset.RippleColor = Color.Transparent;
            BtnReset.RippleExpandSpeedFactor = 0.05F;
            BtnReset.RippleFadeSpeedFactor = 0.03F;
            BtnReset.ShadowBlurFactor = 0.85F;
            BtnReset.ShadowColor = Color.Transparent;
            BtnReset.ShadowOffsetX = 3;
            BtnReset.ShadowOffsetY = 3;
            BtnReset.Size = new Size(79, 46);
            BtnReset.TabIndex = 18;
            BtnReset.TextAlign = ContentAlignment.MiddleCenter;
            BtnReset.TextPaddingBottom = 0;
            BtnReset.TextPaddingLeft = 0;
            BtnReset.TextPaddingRight = 0;
            BtnReset.TextPaddingTop = 0;
            BtnReset.TextShadowColor = Color.Transparent;
            BtnReset.TextShadowOffsetX = 1;
            BtnReset.TextShadowOffsetY = 1;
            BtnReset.Click += BtnReset_Click;
            // 
            // btnFiltrerDates
            // 
            btnFiltrerDates.BackColor = Color.Transparent;
            btnFiltrerDates.BadgeBackColor = Color.Red;
            btnFiltrerDates.BadgeForeColor = Color.White;
            btnFiltrerDates.BadgeRadius = 8;
            btnFiltrerDates.BadgeRightMargin = 10;
            btnFiltrerDates.BadgeValue = 0;
            btnFiltrerDates.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btnFiltrerDates.BorderColorEnd = Color.Gray;
            btnFiltrerDates.BorderColorStart = Color.White;
            btnFiltrerDates.BorderRadiusBottomLeft = 35;
            btnFiltrerDates.BorderRadiusBottomRight = 35;
            btnFiltrerDates.BorderRadiusTopLeft = 35;
            btnFiltrerDates.BorderRadiusTopRight = 35;
            btnFiltrerDates.BorderThickness = 1;
            btnFiltrerDates.ButtonColorEnd = Color.Green;
            btnFiltrerDates.ButtonColorStart = Color.LimeGreen;
            btnFiltrerDates.ButtonImage = null;
            btnFiltrerDates.CanBeep = false;
            btnFiltrerDates.CanShake = false;
            btnFiltrerDates.ClickSoundPath = null;
            btnFiltrerDates.DisabledOverlayOpacity = 0.5F;
            btnFiltrerDates.EnableBorderGradient = false;
            btnFiltrerDates.EnableClickSound = false;
            btnFiltrerDates.EnableFocusBorder = false;
            btnFiltrerDates.EnableHoverSound = false;
            btnFiltrerDates.EnablePressScale = false;
            btnFiltrerDates.EnableTextShadow = false;
            btnFiltrerDates.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnFiltrerDates.FocusBorderThickness = 2;
            btnFiltrerDates.Font = new Font("Segoe UI", 9F);
            btnFiltrerDates.ForeColor = Color.White;
            btnFiltrerDates.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btnFiltrerDates.HoverSoundPath = null;
            btnFiltrerDates.HoverTransitionSpeed = 0.08F;
            btnFiltrerDates.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrerDates.ImageLeftMargin = 5;
            btnFiltrerDates.ImageRightMargin = 8;
            btnFiltrerDates.ImageSize = 24;
            btnFiltrerDates.IsReadOnly = false;
            btnFiltrerDates.Location = new Point(586, 161);
            btnFiltrerDates.MakeRadial = false;
            btnFiltrerDates.Name = "btnFiltrerDates";
            btnFiltrerDates.PressAnimationSpeed = 0.2F;
            btnFiltrerDates.PressDepth = 1;
            btnFiltrerDates.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btnFiltrerDates.RippleExpandSpeedFactor = 0.05F;
            btnFiltrerDates.RippleFadeSpeedFactor = 0.03F;
            btnFiltrerDates.ShadowBlurFactor = 0.85F;
            btnFiltrerDates.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnFiltrerDates.ShadowOffsetX = 3;
            btnFiltrerDates.ShadowOffsetY = 3;
            btnFiltrerDates.Size = new Size(203, 52);
            btnFiltrerDates.TabIndex = 17;
            btnFiltrerDates.Text = "Filtrer par dates";
            btnFiltrerDates.TextAlign = ContentAlignment.MiddleCenter;
            btnFiltrerDates.TextPaddingBottom = 0;
            btnFiltrerDates.TextPaddingLeft = 0;
            btnFiltrerDates.TextPaddingRight = 0;
            btnFiltrerDates.TextPaddingTop = 0;
            btnFiltrerDates.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnFiltrerDates.TextShadowOffsetX = 1;
            btnFiltrerDates.TextShadowOffsetY = 1;
            btnFiltrerDates.Click += btnFiltrerDates_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(320, 176);
            label10.Name = "label10";
            label10.Size = new Size(100, 27);
            label10.TabIndex = 16;
            label10.Text = "Date fin :";
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(426, 173);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(150, 31);
            dtpFin.TabIndex = 15;
            // 
            // dtpDebut
            // 
            dtpDebut.Location = new Point(162, 173);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(150, 31);
            dtpDebut.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 173);
            label9.Name = "label9";
            label9.Size = new Size(129, 27);
            label9.TabIndex = 13;
            label9.Text = "Date début :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 121);
            label8.Name = "label8";
            label8.Size = new Size(117, 27);
            label8.TabIndex = 12;
            label8.Text = "Filtrer par :";
            // 
            // cbResultat
            // 
            cbResultat.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbResultat.FormattingEnabled = true;
            cbResultat.Location = new Point(162, 120);
            cbResultat.Name = "cbResultat";
            cbResultat.Size = new Size(150, 35);
            cbResultat.TabIndex = 11;
            // 
            // siticoneButtonAdvanced2
            // 
            siticoneButtonAdvanced2.BackColor = Color.Transparent;
            siticoneButtonAdvanced2.BadgeBackColor = Color.Red;
            siticoneButtonAdvanced2.BadgeForeColor = Color.White;
            siticoneButtonAdvanced2.BadgeRadius = 8;
            siticoneButtonAdvanced2.BadgeRightMargin = 10;
            siticoneButtonAdvanced2.BadgeValue = 0;
            siticoneButtonAdvanced2.BorderColor = Color.FromArgb(150, 255, 255, 255);
            siticoneButtonAdvanced2.BorderColorEnd = Color.Gray;
            siticoneButtonAdvanced2.BorderColorStart = Color.White;
            siticoneButtonAdvanced2.BorderRadiusBottomLeft = 35;
            siticoneButtonAdvanced2.BorderRadiusBottomRight = 35;
            siticoneButtonAdvanced2.BorderRadiusTopLeft = 35;
            siticoneButtonAdvanced2.BorderRadiusTopRight = 35;
            siticoneButtonAdvanced2.BorderThickness = 1;
            siticoneButtonAdvanced2.ButtonColorEnd = Color.DimGray;
            siticoneButtonAdvanced2.ButtonColorStart = Color.LightGray;
            siticoneButtonAdvanced2.ButtonImage = null;
            siticoneButtonAdvanced2.CanBeep = false;
            siticoneButtonAdvanced2.CanShake = false;
            siticoneButtonAdvanced2.ClickSoundPath = null;
            siticoneButtonAdvanced2.DisabledOverlayOpacity = 0.5F;
            siticoneButtonAdvanced2.EnableBorderGradient = false;
            siticoneButtonAdvanced2.EnableClickSound = false;
            siticoneButtonAdvanced2.EnableFocusBorder = false;
            siticoneButtonAdvanced2.EnableHoverSound = false;
            siticoneButtonAdvanced2.EnablePressScale = false;
            siticoneButtonAdvanced2.EnableTextShadow = false;
            siticoneButtonAdvanced2.FocusBorderColor = Color.FromArgb(100, 150, 255);
            siticoneButtonAdvanced2.FocusBorderThickness = 2;
            siticoneButtonAdvanced2.Font = new Font("Segoe UI", 9F);
            siticoneButtonAdvanced2.ForeColor = Color.White;
            siticoneButtonAdvanced2.HoverColor = Color.FromArgb(20, 0, 0, 0);
            siticoneButtonAdvanced2.HoverSoundPath = null;
            siticoneButtonAdvanced2.HoverTransitionSpeed = 0.08F;
            siticoneButtonAdvanced2.ImageAlign = ContentAlignment.MiddleLeft;
            siticoneButtonAdvanced2.ImageLeftMargin = 5;
            siticoneButtonAdvanced2.ImageRightMargin = 8;
            siticoneButtonAdvanced2.ImageSize = 24;
            siticoneButtonAdvanced2.IsReadOnly = false;
            siticoneButtonAdvanced2.Location = new Point(328, 59);
            siticoneButtonAdvanced2.MakeRadial = false;
            siticoneButtonAdvanced2.Name = "siticoneButtonAdvanced2";
            siticoneButtonAdvanced2.PressAnimationSpeed = 0.2F;
            siticoneButtonAdvanced2.PressDepth = 1;
            siticoneButtonAdvanced2.RippleColor = Color.FromArgb(60, 255, 255, 255);
            siticoneButtonAdvanced2.RippleExpandSpeedFactor = 0.05F;
            siticoneButtonAdvanced2.RippleFadeSpeedFactor = 0.03F;
            siticoneButtonAdvanced2.ShadowBlurFactor = 0.85F;
            siticoneButtonAdvanced2.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            siticoneButtonAdvanced2.ShadowOffsetX = 3;
            siticoneButtonAdvanced2.ShadowOffsetY = 3;
            siticoneButtonAdvanced2.Size = new Size(145, 52);
            siticoneButtonAdvanced2.TabIndex = 10;
            siticoneButtonAdvanced2.Text = "Chercher";
            siticoneButtonAdvanced2.TextAlign = ContentAlignment.MiddleCenter;
            siticoneButtonAdvanced2.TextPaddingBottom = 0;
            siticoneButtonAdvanced2.TextPaddingLeft = 0;
            siticoneButtonAdvanced2.TextPaddingRight = 0;
            siticoneButtonAdvanced2.TextPaddingTop = 0;
            siticoneButtonAdvanced2.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            siticoneButtonAdvanced2.TextShadowOffsetX = 1;
            siticoneButtonAdvanced2.TextShadowOffsetY = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 71);
            label2.Name = "label2";
            label2.Size = new Size(128, 27);
            label2.TabIndex = 8;
            label2.Text = "Rechercher :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 70);
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
            siticoneGroupBox1.ResumeLayout(false);
            siticoneGroupBox1.PerformLayout();
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
        private Label lblAccesRefuses;
        private Label lblAccesAutorise;
        private Label lblTotalTentatives;
        private Label label7;
        private Label label6;
        private Label label5;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced siticoneButtonAdvanced2;
        private ComboBox cbResultat;
        private Label label8;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnFiltrerDates;
        private Label label10;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpDebut;
        private Label label9;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnReset;
    }
}