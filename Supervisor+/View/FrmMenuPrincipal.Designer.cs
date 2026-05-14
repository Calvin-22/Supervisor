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
            logo_rouge = new PictureBox();
            LogoSupervisor = new PictureBox();
            siticoneGroupBox1 = new SiticoneNetCoreUI.SiticoneGroupBox();
            lblEtatSysteme = new Label();
            lblAccesRefuses = new Label();
            lblAccesAutorise = new Label();
            lblTotalTentatives = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            BtnStatistiques = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            siticoneGroupBox2 = new SiticoneNetCoreUI.SiticoneGroupBox();
            label16 = new Label();
            AjouterLogAleatoire = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            BtnRasberry = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            BtnDéconnexion = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            BtnImprimer = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label4 = new Label();
            lblidentifiant = new Label();
            label3 = new Label();
            label1 = new Label();
            siticoneGroupBox3 = new SiticoneNetCoreUI.SiticoneGroupBox();
            label11 = new Label();
            switchCouleur = new SiticoneNetCoreUI.SiticoneiOSSwitch();
            BtnReset = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btnFiltrerDates = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label10 = new Label();
            dtpFin = new DateTimePicker();
            dtpDebut = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            cbResultat = new ComboBox();
            BtnRechercher = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            label2 = new Label();
            txtRechercheUID = new TextBox();
            siticoneGroupBox4 = new SiticoneNetCoreUI.SiticoneGroupBox();
            ProgressBar = new ProgressBar();
            lblDernierEvenement = new Label();
            label17 = new Label();
            lblDernierResultat = new Label();
            label15 = new Label();
            lblDernierUID = new Label();
            label14 = new Label();
            lblPresence = new Label();
            lblPorte = new Label();
            label12 = new Label();
            label13 = new Label();
            logo_bleu = new PictureBox();
            logo_jaune = new PictureBox();
            BtnInformations = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            ((System.ComponentModel.ISupportInitialize)dgvlogs).BeginInit();
            grbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_rouge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoSupervisor).BeginInit();
            siticoneGroupBox1.SuspendLayout();
            siticoneGroupBox2.SuspendLayout();
            siticoneGroupBox3.SuspendLayout();
            siticoneGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_bleu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_jaune).BeginInit();
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
            dgvlogs.Size = new Size(1353, 618);
            dgvlogs.TabIndex = 0;
            // 
            // grbox
            // 
            grbox.Controls.Add(dgvlogs);
            grbox.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbox.Location = new Point(12, 27);
            grbox.Name = "grbox";
            grbox.Size = new Size(1365, 657);
            grbox.TabIndex = 1;
            grbox.TabStop = false;
            grbox.Text = "Logs";
            // 
            // logo_rouge
            // 
            logo_rouge.Image = (Image)resources.GetObject("logo_rouge.Image");
            logo_rouge.Location = new Point(1430, 39);
            logo_rouge.Name = "logo_rouge";
            logo_rouge.Size = new Size(409, 359);
            logo_rouge.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_rouge.TabIndex = 22;
            logo_rouge.TabStop = false;
            // 
            // LogoSupervisor
            // 
            LogoSupervisor.Image = (Image)resources.GetObject("LogoSupervisor.Image");
            LogoSupervisor.Location = new Point(1430, 28);
            LogoSupervisor.Name = "LogoSupervisor";
            LogoSupervisor.Size = new Size(409, 359);
            LogoSupervisor.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoSupervisor.TabIndex = 2;
            LogoSupervisor.TabStop = false;
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
            siticoneGroupBox1.Controls.Add(lblEtatSysteme);
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
            siticoneGroupBox1.Location = new Point(12, 736);
            siticoneGroupBox1.MaxBlinkCount = 3;
            siticoneGroupBox1.Name = "siticoneGroupBox1";
            siticoneGroupBox1.PressedBorderColor = Color.FromArgb(0, 84, 153);
            siticoneGroupBox1.ShadowColor = Color.FromArgb(20, 0, 0, 0);
            siticoneGroupBox1.ShadowDepth = 1;
            siticoneGroupBox1.ShowShadow = true;
            siticoneGroupBox1.Size = new Size(473, 288);
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
            // lblEtatSysteme
            // 
            lblEtatSysteme.AutoSize = true;
            lblEtatSysteme.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEtatSysteme.Location = new Point(26, 75);
            lblEtatSysteme.Name = "lblEtatSysteme";
            lblEtatSysteme.Size = new Size(23, 27);
            lblEtatSysteme.TabIndex = 25;
            lblEtatSysteme.Text = "a";
            // 
            // lblAccesRefuses
            // 
            lblAccesRefuses.AutoSize = true;
            lblAccesRefuses.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccesRefuses.Location = new Point(265, 212);
            lblAccesRefuses.Name = "lblAccesRefuses";
            lblAccesRefuses.Size = new Size(23, 27);
            lblAccesRefuses.TabIndex = 12;
            lblAccesRefuses.Text = "a";
            // 
            // lblAccesAutorise
            // 
            lblAccesAutorise.AutoSize = true;
            lblAccesAutorise.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccesAutorise.Location = new Point(282, 170);
            lblAccesAutorise.Name = "lblAccesAutorise";
            lblAccesAutorise.Size = new Size(23, 27);
            lblAccesAutorise.TabIndex = 11;
            lblAccesAutorise.Text = "a";
            // 
            // lblTotalTentatives
            // 
            lblTotalTentatives.AutoSize = true;
            lblTotalTentatives.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTentatives.Location = new Point(329, 127);
            lblTotalTentatives.Name = "lblTotalTentatives";
            lblTotalTentatives.Size = new Size(23, 27);
            lblTotalTentatives.TabIndex = 8;
            lblTotalTentatives.Text = "a";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 212);
            label7.Name = "label7";
            label7.Size = new Size(240, 27);
            label7.TabIndex = 10;
            label7.Text = "Nombre d'accès refusé :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 170);
            label6.Name = "label6";
            label6.Size = new Size(258, 27);
            label6.TabIndex = 9;
            label6.Text = "Nombre d'accès autorisé :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 128);
            label5.Name = "label5";
            label5.Size = new Size(311, 27);
            label5.TabIndex = 8;
            label5.Text = "Nombre de tentatives d'accès : ";
            // 
            // BtnStatistiques
            // 
            BtnStatistiques.BackColor = Color.Transparent;
            BtnStatistiques.BadgeBackColor = Color.Red;
            BtnStatistiques.BadgeForeColor = Color.White;
            BtnStatistiques.BadgeRadius = 8;
            BtnStatistiques.BadgeRightMargin = 10;
            BtnStatistiques.BadgeValue = 0;
            BtnStatistiques.BorderColor = Color.FromArgb(150, 255, 255, 255);
            BtnStatistiques.BorderColorEnd = Color.Gray;
            BtnStatistiques.BorderColorStart = Color.White;
            BtnStatistiques.BorderRadiusBottomLeft = 35;
            BtnStatistiques.BorderRadiusBottomRight = 35;
            BtnStatistiques.BorderRadiusTopLeft = 35;
            BtnStatistiques.BorderRadiusTopRight = 35;
            BtnStatistiques.BorderThickness = 1;
            BtnStatistiques.ButtonColorEnd = Color.DarkViolet;
            BtnStatistiques.ButtonColorStart = Color.Violet;
            BtnStatistiques.ButtonImage = null;
            BtnStatistiques.CanBeep = false;
            BtnStatistiques.CanShake = false;
            BtnStatistiques.ClickSoundPath = null;
            BtnStatistiques.DisabledOverlayOpacity = 0.5F;
            BtnStatistiques.EnableBorderGradient = false;
            BtnStatistiques.EnableClickSound = false;
            BtnStatistiques.EnableFocusBorder = false;
            BtnStatistiques.EnableHoverSound = false;
            BtnStatistiques.EnablePressScale = false;
            BtnStatistiques.EnableTextShadow = false;
            BtnStatistiques.FocusBorderColor = Color.FromArgb(100, 150, 255);
            BtnStatistiques.FocusBorderThickness = 2;
            BtnStatistiques.Font = new Font("Segoe UI", 9F);
            BtnStatistiques.ForeColor = Color.White;
            BtnStatistiques.HoverColor = Color.FromArgb(20, 0, 0, 0);
            BtnStatistiques.HoverSoundPath = null;
            BtnStatistiques.HoverTransitionSpeed = 0.08F;
            BtnStatistiques.ImageAlign = ContentAlignment.MiddleLeft;
            BtnStatistiques.ImageLeftMargin = 5;
            BtnStatistiques.ImageRightMargin = 8;
            BtnStatistiques.ImageSize = 24;
            BtnStatistiques.IsReadOnly = false;
            BtnStatistiques.Location = new Point(586, 215);
            BtnStatistiques.MakeRadial = false;
            BtnStatistiques.Name = "BtnStatistiques";
            BtnStatistiques.PressAnimationSpeed = 0.2F;
            BtnStatistiques.PressDepth = 1;
            BtnStatistiques.RippleColor = Color.FromArgb(60, 255, 255, 255);
            BtnStatistiques.RippleExpandSpeedFactor = 0.05F;
            BtnStatistiques.RippleFadeSpeedFactor = 0.03F;
            BtnStatistiques.ShadowBlurFactor = 0.85F;
            BtnStatistiques.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            BtnStatistiques.ShadowOffsetX = 3;
            BtnStatistiques.ShadowOffsetY = 3;
            BtnStatistiques.Size = new Size(203, 52);
            BtnStatistiques.TabIndex = 23;
            BtnStatistiques.Text = "Statistiques";
            BtnStatistiques.TextAlign = ContentAlignment.MiddleCenter;
            BtnStatistiques.TextPaddingBottom = 0;
            BtnStatistiques.TextPaddingLeft = 0;
            BtnStatistiques.TextPaddingRight = 0;
            BtnStatistiques.TextPaddingTop = 0;
            BtnStatistiques.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            BtnStatistiques.TextShadowOffsetX = 1;
            BtnStatistiques.TextShadowOffsetY = 1;
            BtnStatistiques.Click += BtnStatistiques_Click;
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
            siticoneGroupBox2.Controls.Add(label16);
            siticoneGroupBox2.Controls.Add(AjouterLogAleatoire);
            siticoneGroupBox2.Controls.Add(BtnRasberry);
            siticoneGroupBox2.Controls.Add(BtnDéconnexion);
            siticoneGroupBox2.Controls.Add(BtnImprimer);
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
            siticoneGroupBox2.Location = new Point(1383, 736);
            siticoneGroupBox2.MaxBlinkCount = 3;
            siticoneGroupBox2.Name = "siticoneGroupBox2";
            siticoneGroupBox2.PressedBorderColor = Color.FromArgb(0, 84, 153);
            siticoneGroupBox2.ShadowColor = Color.FromArgb(20, 0, 0, 0);
            siticoneGroupBox2.ShadowDepth = 1;
            siticoneGroupBox2.ShowShadow = true;
            siticoneGroupBox2.Size = new Size(503, 288);
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
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(34, 161);
            label16.Name = "label16";
            label16.Size = new Size(252, 27);
            label16.TabIndex = 24;
            label16.Text = "Vérifier état du matériel :";
            // 
            // AjouterLogAleatoire
            // 
            AjouterLogAleatoire.BackColor = Color.Transparent;
            AjouterLogAleatoire.BadgeBackColor = Color.Red;
            AjouterLogAleatoire.BadgeForeColor = Color.White;
            AjouterLogAleatoire.BadgeRadius = 8;
            AjouterLogAleatoire.BadgeRightMargin = 10;
            AjouterLogAleatoire.BadgeValue = 0;
            AjouterLogAleatoire.BorderColor = Color.FromArgb(150, 255, 255, 255);
            AjouterLogAleatoire.BorderColorEnd = Color.Gray;
            AjouterLogAleatoire.BorderColorStart = Color.White;
            AjouterLogAleatoire.BorderRadiusBottomLeft = 35;
            AjouterLogAleatoire.BorderRadiusBottomRight = 35;
            AjouterLogAleatoire.BorderRadiusTopLeft = 35;
            AjouterLogAleatoire.BorderRadiusTopRight = 35;
            AjouterLogAleatoire.BorderThickness = 1;
            AjouterLogAleatoire.ButtonColorEnd = Color.DimGray;
            AjouterLogAleatoire.ButtonColorStart = Color.LightGray;
            AjouterLogAleatoire.ButtonImage = null;
            AjouterLogAleatoire.CanBeep = false;
            AjouterLogAleatoire.CanShake = false;
            AjouterLogAleatoire.ClickSoundPath = null;
            AjouterLogAleatoire.DisabledOverlayOpacity = 0.5F;
            AjouterLogAleatoire.EnableBorderGradient = false;
            AjouterLogAleatoire.EnableClickSound = false;
            AjouterLogAleatoire.EnableFocusBorder = false;
            AjouterLogAleatoire.EnableHoverSound = false;
            AjouterLogAleatoire.EnablePressScale = false;
            AjouterLogAleatoire.EnableTextShadow = false;
            AjouterLogAleatoire.FocusBorderColor = Color.FromArgb(100, 150, 255);
            AjouterLogAleatoire.FocusBorderThickness = 2;
            AjouterLogAleatoire.Font = new Font("Segoe UI", 9F);
            AjouterLogAleatoire.ForeColor = Color.White;
            AjouterLogAleatoire.HoverColor = Color.FromArgb(20, 0, 0, 0);
            AjouterLogAleatoire.HoverSoundPath = null;
            AjouterLogAleatoire.HoverTransitionSpeed = 0.08F;
            AjouterLogAleatoire.ImageAlign = ContentAlignment.MiddleLeft;
            AjouterLogAleatoire.ImageLeftMargin = 5;
            AjouterLogAleatoire.ImageRightMargin = 8;
            AjouterLogAleatoire.ImageSize = 24;
            AjouterLogAleatoire.IsReadOnly = false;
            AjouterLogAleatoire.Location = new Point(34, 215);
            AjouterLogAleatoire.MakeRadial = false;
            AjouterLogAleatoire.Name = "AjouterLogAleatoire";
            AjouterLogAleatoire.PressAnimationSpeed = 0.2F;
            AjouterLogAleatoire.PressDepth = 1;
            AjouterLogAleatoire.RippleColor = Color.FromArgb(60, 255, 255, 255);
            AjouterLogAleatoire.RippleExpandSpeedFactor = 0.05F;
            AjouterLogAleatoire.RippleFadeSpeedFactor = 0.03F;
            AjouterLogAleatoire.ShadowBlurFactor = 0.85F;
            AjouterLogAleatoire.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            AjouterLogAleatoire.ShadowOffsetX = 3;
            AjouterLogAleatoire.ShadowOffsetY = 3;
            AjouterLogAleatoire.Size = new Size(259, 52);
            AjouterLogAleatoire.TabIndex = 21;
            AjouterLogAleatoire.Text = "Ajouter un faux log (test)";
            AjouterLogAleatoire.TextAlign = ContentAlignment.MiddleCenter;
            AjouterLogAleatoire.TextPaddingBottom = 0;
            AjouterLogAleatoire.TextPaddingLeft = 0;
            AjouterLogAleatoire.TextPaddingRight = 0;
            AjouterLogAleatoire.TextPaddingTop = 0;
            AjouterLogAleatoire.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            AjouterLogAleatoire.TextShadowOffsetX = 1;
            AjouterLogAleatoire.TextShadowOffsetY = 1;
            AjouterLogAleatoire.Click += AjouterLogAleatoire_Click;
            // 
            // BtnRasberry
            // 
            BtnRasberry.BackColor = Color.Transparent;
            BtnRasberry.BadgeBackColor = Color.Red;
            BtnRasberry.BadgeForeColor = Color.White;
            BtnRasberry.BadgeRadius = 8;
            BtnRasberry.BadgeRightMargin = 10;
            BtnRasberry.BadgeValue = 0;
            BtnRasberry.BorderColor = Color.FromArgb(150, 255, 255, 255);
            BtnRasberry.BorderColorEnd = Color.Gray;
            BtnRasberry.BorderColorStart = Color.White;
            BtnRasberry.BorderRadiusBottomLeft = 35;
            BtnRasberry.BorderRadiusBottomRight = 35;
            BtnRasberry.BorderRadiusTopLeft = 35;
            BtnRasberry.BorderRadiusTopRight = 35;
            BtnRasberry.BorderThickness = 1;
            BtnRasberry.ButtonColorEnd = Color.DarkOrange;
            BtnRasberry.ButtonColorStart = Color.SandyBrown;
            BtnRasberry.ButtonImage = null;
            BtnRasberry.CanBeep = false;
            BtnRasberry.CanShake = false;
            BtnRasberry.ClickSoundPath = null;
            BtnRasberry.DisabledOverlayOpacity = 0.5F;
            BtnRasberry.EnableBorderGradient = false;
            BtnRasberry.EnableClickSound = false;
            BtnRasberry.EnableFocusBorder = false;
            BtnRasberry.EnableHoverSound = false;
            BtnRasberry.EnablePressScale = false;
            BtnRasberry.EnableTextShadow = false;
            BtnRasberry.FocusBorderColor = Color.FromArgb(100, 150, 255);
            BtnRasberry.FocusBorderThickness = 2;
            BtnRasberry.Font = new Font("Segoe UI", 9F);
            BtnRasberry.ForeColor = Color.White;
            BtnRasberry.HoverColor = Color.FromArgb(20, 0, 0, 0);
            BtnRasberry.HoverSoundPath = null;
            BtnRasberry.HoverTransitionSpeed = 0.08F;
            BtnRasberry.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRasberry.ImageLeftMargin = 5;
            BtnRasberry.ImageRightMargin = 8;
            BtnRasberry.ImageSize = 24;
            BtnRasberry.IsReadOnly = false;
            BtnRasberry.Location = new Point(302, 151);
            BtnRasberry.MakeRadial = false;
            BtnRasberry.Name = "BtnRasberry";
            BtnRasberry.PressAnimationSpeed = 0.2F;
            BtnRasberry.PressDepth = 1;
            BtnRasberry.RippleColor = Color.FromArgb(60, 255, 255, 255);
            BtnRasberry.RippleExpandSpeedFactor = 0.05F;
            BtnRasberry.RippleFadeSpeedFactor = 0.03F;
            BtnRasberry.ShadowBlurFactor = 0.85F;
            BtnRasberry.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            BtnRasberry.ShadowOffsetX = 3;
            BtnRasberry.ShadowOffsetY = 3;
            BtnRasberry.Size = new Size(172, 52);
            BtnRasberry.TabIndex = 23;
            BtnRasberry.Text = "État Rasberry Pi";
            BtnRasberry.TextAlign = ContentAlignment.MiddleCenter;
            BtnRasberry.TextPaddingBottom = 0;
            BtnRasberry.TextPaddingLeft = 0;
            BtnRasberry.TextPaddingRight = 0;
            BtnRasberry.TextPaddingTop = 0;
            BtnRasberry.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            BtnRasberry.TextShadowOffsetX = 1;
            BtnRasberry.TextShadowOffsetY = 1;
            BtnRasberry.Click += BtnRasberry_Click;
            // 
            // BtnDéconnexion
            // 
            BtnDéconnexion.BackColor = Color.Transparent;
            BtnDéconnexion.BadgeBackColor = Color.Red;
            BtnDéconnexion.BadgeForeColor = Color.White;
            BtnDéconnexion.BadgeRadius = 8;
            BtnDéconnexion.BadgeRightMargin = 10;
            BtnDéconnexion.BadgeValue = 0;
            BtnDéconnexion.BorderColor = Color.FromArgb(150, 255, 255, 255);
            BtnDéconnexion.BorderColorEnd = Color.Gray;
            BtnDéconnexion.BorderColorStart = Color.White;
            BtnDéconnexion.BorderRadiusBottomLeft = 35;
            BtnDéconnexion.BorderRadiusBottomRight = 35;
            BtnDéconnexion.BorderRadiusTopLeft = 35;
            BtnDéconnexion.BorderRadiusTopRight = 35;
            BtnDéconnexion.BorderThickness = 1;
            BtnDéconnexion.ButtonColorEnd = Color.DarkRed;
            BtnDéconnexion.ButtonColorStart = Color.Red;
            BtnDéconnexion.ButtonImage = null;
            BtnDéconnexion.CanBeep = false;
            BtnDéconnexion.CanShake = false;
            BtnDéconnexion.ClickSoundPath = null;
            BtnDéconnexion.DisabledOverlayOpacity = 0.5F;
            BtnDéconnexion.EnableBorderGradient = false;
            BtnDéconnexion.EnableClickSound = false;
            BtnDéconnexion.EnableFocusBorder = false;
            BtnDéconnexion.EnableHoverSound = false;
            BtnDéconnexion.EnablePressScale = false;
            BtnDéconnexion.EnableTextShadow = false;
            BtnDéconnexion.FocusBorderColor = Color.FromArgb(100, 150, 255);
            BtnDéconnexion.FocusBorderThickness = 2;
            BtnDéconnexion.Font = new Font("Segoe UI", 9F);
            BtnDéconnexion.ForeColor = Color.White;
            BtnDéconnexion.HoverColor = Color.FromArgb(20, 0, 0, 0);
            BtnDéconnexion.HoverSoundPath = null;
            BtnDéconnexion.HoverTransitionSpeed = 0.08F;
            BtnDéconnexion.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDéconnexion.ImageLeftMargin = 5;
            BtnDéconnexion.ImageRightMargin = 8;
            BtnDéconnexion.ImageSize = 24;
            BtnDéconnexion.IsReadOnly = false;
            BtnDéconnexion.Location = new Point(302, 215);
            BtnDéconnexion.MakeRadial = false;
            BtnDéconnexion.Name = "BtnDéconnexion";
            BtnDéconnexion.PressAnimationSpeed = 0.2F;
            BtnDéconnexion.PressDepth = 1;
            BtnDéconnexion.RippleColor = Color.FromArgb(60, 255, 255, 255);
            BtnDéconnexion.RippleExpandSpeedFactor = 0.05F;
            BtnDéconnexion.RippleFadeSpeedFactor = 0.03F;
            BtnDéconnexion.ShadowBlurFactor = 0.85F;
            BtnDéconnexion.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            BtnDéconnexion.ShadowOffsetX = 3;
            BtnDéconnexion.ShadowOffsetY = 3;
            BtnDéconnexion.Size = new Size(177, 52);
            BtnDéconnexion.TabIndex = 22;
            BtnDéconnexion.Text = "Se déconnecter";
            BtnDéconnexion.TextAlign = ContentAlignment.MiddleCenter;
            BtnDéconnexion.TextPaddingBottom = 0;
            BtnDéconnexion.TextPaddingLeft = 0;
            BtnDéconnexion.TextPaddingRight = 0;
            BtnDéconnexion.TextPaddingTop = 0;
            BtnDéconnexion.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            BtnDéconnexion.TextShadowOffsetX = 1;
            BtnDéconnexion.TextShadowOffsetY = 1;
            BtnDéconnexion.Click += BtnDéconnexion_Click;
            // 
            // BtnImprimer
            // 
            BtnImprimer.BackColor = Color.Transparent;
            BtnImprimer.BadgeBackColor = Color.Red;
            BtnImprimer.BadgeForeColor = Color.White;
            BtnImprimer.BadgeRadius = 8;
            BtnImprimer.BadgeRightMargin = 10;
            BtnImprimer.BadgeValue = 0;
            BtnImprimer.BorderColor = Color.FromArgb(150, 255, 255, 255);
            BtnImprimer.BorderColorEnd = Color.Gray;
            BtnImprimer.BorderColorStart = Color.White;
            BtnImprimer.BorderRadiusBottomLeft = 35;
            BtnImprimer.BorderRadiusBottomRight = 35;
            BtnImprimer.BorderRadiusTopLeft = 35;
            BtnImprimer.BorderRadiusTopRight = 35;
            BtnImprimer.BorderThickness = 1;
            BtnImprimer.ButtonColorEnd = Color.DimGray;
            BtnImprimer.ButtonColorStart = Color.LightGray;
            BtnImprimer.ButtonImage = null;
            BtnImprimer.CanBeep = false;
            BtnImprimer.CanShake = false;
            BtnImprimer.ClickSoundPath = null;
            BtnImprimer.DisabledOverlayOpacity = 0.5F;
            BtnImprimer.EnableBorderGradient = false;
            BtnImprimer.EnableClickSound = false;
            BtnImprimer.EnableFocusBorder = false;
            BtnImprimer.EnableHoverSound = false;
            BtnImprimer.EnablePressScale = false;
            BtnImprimer.EnableTextShadow = false;
            BtnImprimer.FocusBorderColor = Color.FromArgb(100, 150, 255);
            BtnImprimer.FocusBorderThickness = 2;
            BtnImprimer.Font = new Font("Segoe UI", 9F);
            BtnImprimer.ForeColor = Color.White;
            BtnImprimer.HoverColor = Color.FromArgb(20, 0, 0, 0);
            BtnImprimer.HoverSoundPath = null;
            BtnImprimer.HoverTransitionSpeed = 0.08F;
            BtnImprimer.ImageAlign = ContentAlignment.MiddleLeft;
            BtnImprimer.ImageLeftMargin = 5;
            BtnImprimer.ImageRightMargin = 8;
            BtnImprimer.ImageSize = 24;
            BtnImprimer.IsReadOnly = false;
            BtnImprimer.Location = new Point(232, 82);
            BtnImprimer.MakeRadial = false;
            BtnImprimer.Name = "BtnImprimer";
            BtnImprimer.PressAnimationSpeed = 0.2F;
            BtnImprimer.PressDepth = 1;
            BtnImprimer.RippleColor = Color.FromArgb(60, 255, 255, 255);
            BtnImprimer.RippleExpandSpeedFactor = 0.05F;
            BtnImprimer.RippleFadeSpeedFactor = 0.03F;
            BtnImprimer.ShadowBlurFactor = 0.85F;
            BtnImprimer.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            BtnImprimer.ShadowOffsetX = 3;
            BtnImprimer.ShadowOffsetY = 3;
            BtnImprimer.Size = new Size(145, 52);
            BtnImprimer.TabIndex = 21;
            BtnImprimer.Text = "Imprimer";
            BtnImprimer.TextAlign = ContentAlignment.MiddleCenter;
            BtnImprimer.TextPaddingBottom = 0;
            BtnImprimer.TextPaddingLeft = 0;
            BtnImprimer.TextPaddingRight = 0;
            BtnImprimer.TextPaddingTop = 0;
            BtnImprimer.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            BtnImprimer.TextShadowOffsetX = 1;
            BtnImprimer.TextShadowOffsetY = 1;
            BtnImprimer.Click += BtnImprimer_Click;
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
            lblidentifiant.Location = new Point(1502, 397);
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
            label3.Location = new Point(1430, 428);
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
            label1.Location = new Point(1430, 455);
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
            siticoneGroupBox3.Controls.Add(BtnStatistiques);
            siticoneGroupBox3.Controls.Add(label11);
            siticoneGroupBox3.Controls.Add(switchCouleur);
            siticoneGroupBox3.Controls.Add(BtnReset);
            siticoneGroupBox3.Controls.Add(btnFiltrerDates);
            siticoneGroupBox3.Controls.Add(label10);
            siticoneGroupBox3.Controls.Add(dtpFin);
            siticoneGroupBox3.Controls.Add(dtpDebut);
            siticoneGroupBox3.Controls.Add(label9);
            siticoneGroupBox3.Controls.Add(label8);
            siticoneGroupBox3.Controls.Add(cbResultat);
            siticoneGroupBox3.Controls.Add(BtnRechercher);
            siticoneGroupBox3.Controls.Add(label2);
            siticoneGroupBox3.Controls.Add(txtRechercheUID);
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
            siticoneGroupBox3.Location = new Point(491, 736);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(28, 227);
            label11.Name = "label11";
            label11.Size = new Size(300, 27);
            label11.TabIndex = 20;
            label11.Text = "Activer les filtres de couleurs :";
            // 
            // switchCouleur
            // 
            switchCouleur.DisabledOffBackColor = Color.FromArgb(229, 229, 234);
            switchCouleur.DisabledOnBackColor = Color.FromArgb(174, 223, 189);
            switchCouleur.DisabledThumbColor = Color.FromArgb(240, 240, 240);
            switchCouleur.Location = new Point(330, 225);
            switchCouleur.Name = "switchCouleur";
            switchCouleur.OffBackColor = Color.FromArgb(229, 229, 234);
            switchCouleur.OnBackColor = Color.FromArgb(52, 199, 89);
            switchCouleur.ReadOnlyOffBackColor = Color.FromArgb(215, 215, 220);
            switchCouleur.ReadOnlyOnBackColor = Color.FromArgb(130, 210, 150);
            switchCouleur.ReadOnlyThumbColor = Color.FromArgb(245, 245, 245);
            switchCouleur.Size = new Size(76, 36);
            switchCouleur.TabIndex = 19;
            switchCouleur.Text = "siticoneiosSwitch1";
            switchCouleur.ThumbBorderColor = Color.Transparent;
            switchCouleur.ThumbColor = Color.White;
            switchCouleur.ThumbShadowColor = Color.FromArgb(60, 0, 0, 0);
            switchCouleur.StateChanged += switchCouleur_StateChanged;
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
            // BtnRechercher
            // 
            BtnRechercher.BackColor = Color.Transparent;
            BtnRechercher.BadgeBackColor = Color.Red;
            BtnRechercher.BadgeForeColor = Color.White;
            BtnRechercher.BadgeRadius = 8;
            BtnRechercher.BadgeRightMargin = 10;
            BtnRechercher.BadgeValue = 0;
            BtnRechercher.BorderColor = Color.FromArgb(150, 255, 255, 255);
            BtnRechercher.BorderColorEnd = Color.Gray;
            BtnRechercher.BorderColorStart = Color.White;
            BtnRechercher.BorderRadiusBottomLeft = 35;
            BtnRechercher.BorderRadiusBottomRight = 35;
            BtnRechercher.BorderRadiusTopLeft = 35;
            BtnRechercher.BorderRadiusTopRight = 35;
            BtnRechercher.BorderThickness = 1;
            BtnRechercher.ButtonColorEnd = Color.DarkBlue;
            BtnRechercher.ButtonColorStart = Color.Blue;
            BtnRechercher.ButtonImage = null;
            BtnRechercher.CanBeep = false;
            BtnRechercher.CanShake = false;
            BtnRechercher.ClickSoundPath = null;
            BtnRechercher.DisabledOverlayOpacity = 0.5F;
            BtnRechercher.EnableBorderGradient = false;
            BtnRechercher.EnableClickSound = false;
            BtnRechercher.EnableFocusBorder = false;
            BtnRechercher.EnableHoverSound = false;
            BtnRechercher.EnablePressScale = false;
            BtnRechercher.EnableTextShadow = false;
            BtnRechercher.FocusBorderColor = Color.FromArgb(100, 150, 255);
            BtnRechercher.FocusBorderThickness = 2;
            BtnRechercher.Font = new Font("Segoe UI", 9F);
            BtnRechercher.ForeColor = Color.White;
            BtnRechercher.HoverColor = Color.FromArgb(20, 0, 0, 0);
            BtnRechercher.HoverSoundPath = null;
            BtnRechercher.HoverTransitionSpeed = 0.08F;
            BtnRechercher.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRechercher.ImageLeftMargin = 5;
            BtnRechercher.ImageRightMargin = 8;
            BtnRechercher.ImageSize = 24;
            BtnRechercher.IsReadOnly = false;
            BtnRechercher.Location = new Point(586, 60);
            BtnRechercher.MakeRadial = false;
            BtnRechercher.Name = "BtnRechercher";
            BtnRechercher.PressAnimationSpeed = 0.2F;
            BtnRechercher.PressDepth = 1;
            BtnRechercher.RippleColor = Color.FromArgb(60, 255, 255, 255);
            BtnRechercher.RippleExpandSpeedFactor = 0.05F;
            BtnRechercher.RippleFadeSpeedFactor = 0.03F;
            BtnRechercher.ShadowBlurFactor = 0.85F;
            BtnRechercher.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            BtnRechercher.ShadowOffsetX = 3;
            BtnRechercher.ShadowOffsetY = 3;
            BtnRechercher.Size = new Size(145, 52);
            BtnRechercher.TabIndex = 10;
            BtnRechercher.Text = "Chercher";
            BtnRechercher.TextAlign = ContentAlignment.MiddleCenter;
            BtnRechercher.TextPaddingBottom = 0;
            BtnRechercher.TextPaddingLeft = 0;
            BtnRechercher.TextPaddingRight = 0;
            BtnRechercher.TextPaddingTop = 0;
            BtnRechercher.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            BtnRechercher.TextShadowOffsetX = 1;
            BtnRechercher.TextShadowOffsetY = 1;
            BtnRechercher.Click += BtnRechercher_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 71);
            label2.Name = "label2";
            label2.Size = new Size(315, 27);
            label2.TabIndex = 8;
            label2.Text = "Rechercher par identifiant NFC :";
            // 
            // txtRechercheUID
            // 
            txtRechercheUID.Location = new Point(349, 71);
            txtRechercheUID.Name = "txtRechercheUID";
            txtRechercheUID.Size = new Size(227, 31);
            txtRechercheUID.TabIndex = 2;
            // 
            // siticoneGroupBox4
            // 
            siticoneGroupBox4.BackColor = Color.Transparent;
            siticoneGroupBox4.BadgeColor = Color.Red;
            siticoneGroupBox4.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            siticoneGroupBox4.BadgeLeftPadding = 12;
            siticoneGroupBox4.BadgeValue = 0;
            siticoneGroupBox4.BadgeVisible = false;
            siticoneGroupBox4.BlinkInterval = 500;
            siticoneGroupBox4.BlinkMinOpacity = 0.3F;
            siticoneGroupBox4.BlinkOpacityStep = 0.05F;
            siticoneGroupBox4.BorderColor = Color.FromArgb(220, 222, 224);
            siticoneGroupBox4.BorderWidth = 3F;
            siticoneGroupBox4.ChevronColor = Color.FromArgb(90, 90, 90);
            siticoneGroupBox4.ChevronLeftSpacing = 4F;
            siticoneGroupBox4.ChevronSize = 10F;
            siticoneGroupBox4.ChevronThickness = 2F;
            siticoneGroupBox4.ContentPadding = 5;
            siticoneGroupBox4.Controls.Add(ProgressBar);
            siticoneGroupBox4.Controls.Add(lblDernierEvenement);
            siticoneGroupBox4.Controls.Add(label17);
            siticoneGroupBox4.Controls.Add(lblDernierResultat);
            siticoneGroupBox4.Controls.Add(label15);
            siticoneGroupBox4.Controls.Add(lblDernierUID);
            siticoneGroupBox4.Controls.Add(label14);
            siticoneGroupBox4.Controls.Add(lblPresence);
            siticoneGroupBox4.Controls.Add(lblPorte);
            siticoneGroupBox4.Controls.Add(label12);
            siticoneGroupBox4.Controls.Add(label13);
            siticoneGroupBox4.CornerRadius = 15;
            siticoneGroupBox4.EnableBlinking = false;
            siticoneGroupBox4.EnableHoverAnimation = true;
            siticoneGroupBox4.EnableHoverHighlight = true;
            siticoneGroupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            siticoneGroupBox4.GradientEndColor = Color.LightGray;
            siticoneGroupBox4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneGroupBox4.GradientStartColor = Color.White;
            siticoneGroupBox4.GroupTitle = "État du système (en live)";
            siticoneGroupBox4.HoveredBorderColor = Color.Gold;
            siticoneGroupBox4.HoveredTitleColor = Color.Black;
            siticoneGroupBox4.IsCollapsible = false;
            siticoneGroupBox4.Location = new Point(1383, 494);
            siticoneGroupBox4.MaxBlinkCount = 3;
            siticoneGroupBox4.Name = "siticoneGroupBox4";
            siticoneGroupBox4.PressedBorderColor = Color.FromArgb(0, 84, 153);
            siticoneGroupBox4.ShadowColor = Color.FromArgb(20, 0, 0, 0);
            siticoneGroupBox4.ShadowDepth = 1;
            siticoneGroupBox4.ShowShadow = true;
            siticoneGroupBox4.Size = new Size(503, 241);
            siticoneGroupBox4.SolidFillColor = Color.White;
            siticoneGroupBox4.StatusIcon = null;
            siticoneGroupBox4.StatusText = "";
            siticoneGroupBox4.TabIndex = 11;
            siticoneGroupBox4.TitleBackColor = Color.Transparent;
            siticoneGroupBox4.TitleColor = Color.FromArgb(30, 30, 30);
            siticoneGroupBox4.TitlePadding = new Padding(10, 8, 10, 12);
            siticoneGroupBox4.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            siticoneGroupBox4.UseGradient = false;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(238, 13);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(118, 20);
            ProgressBar.TabIndex = 20;
            // 
            // lblDernierEvenement
            // 
            lblDernierEvenement.AutoSize = true;
            lblDernierEvenement.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDernierEvenement.Location = new Point(270, 188);
            lblDernierEvenement.Name = "lblDernierEvenement";
            lblDernierEvenement.Size = new Size(23, 27);
            lblDernierEvenement.TabIndex = 19;
            lblDernierEvenement.Text = "a";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(25, 188);
            label17.Name = "label17";
            label17.Size = new Size(239, 27);
            label17.TabIndex = 18;
            label17.Text = "Plus récent évènement :";
            // 
            // lblDernierResultat
            // 
            lblDernierResultat.AutoSize = true;
            lblDernierResultat.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDernierResultat.Location = new Point(302, 154);
            lblDernierResultat.Name = "lblDernierResultat";
            lblDernierResultat.Size = new Size(23, 27);
            lblDernierResultat.TabIndex = 17;
            lblDernierResultat.Text = "a";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(24, 154);
            label15.Name = "label15";
            label15.Size = new Size(272, 27);
            label15.TabIndex = 16;
            label15.Text = "Dernière tentative d'accès :";
            // 
            // lblDernierUID
            // 
            lblDernierUID.AutoSize = true;
            lblDernierUID.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDernierUID.Location = new Point(242, 120);
            lblDernierUID.Name = "lblDernierUID";
            lblDernierUID.Size = new Size(23, 27);
            lblDernierUID.TabIndex = 15;
            lblDernierUID.Text = "a";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(24, 120);
            label14.Name = "label14";
            label14.Size = new Size(212, 27);
            label14.TabIndex = 14;
            label14.Text = "Dernier UID détecté :";
            // 
            // lblPresence
            // 
            lblPresence.AutoSize = true;
            lblPresence.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPresence.Location = new Point(138, 87);
            lblPresence.Name = "lblPresence";
            lblPresence.Size = new Size(23, 27);
            lblPresence.TabIndex = 13;
            lblPresence.Text = "a";
            // 
            // lblPorte
            // 
            lblPorte.AutoSize = true;
            lblPorte.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPorte.Location = new Point(148, 56);
            lblPorte.Name = "lblPorte";
            lblPorte.Size = new Size(23, 27);
            lblPorte.TabIndex = 12;
            lblPorte.Text = "a";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(25, 87);
            label12.Name = "label12";
            label12.Size = new Size(107, 27);
            label12.TabIndex = 11;
            label12.Text = "Présence :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(24, 56);
            label13.Name = "label13";
            label13.Size = new Size(118, 27);
            label13.TabIndex = 10;
            label13.Text = "État porte :";
            // 
            // logo_bleu
            // 
            logo_bleu.Image = (Image)resources.GetObject("logo_bleu.Image");
            logo_bleu.Location = new Point(1430, 39);
            logo_bleu.Name = "logo_bleu";
            logo_bleu.Size = new Size(409, 359);
            logo_bleu.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_bleu.TabIndex = 23;
            logo_bleu.TabStop = false;
            // 
            // logo_jaune
            // 
            logo_jaune.Image = (Image)resources.GetObject("logo_jaune.Image");
            logo_jaune.Location = new Point(1430, 39);
            logo_jaune.Name = "logo_jaune";
            logo_jaune.Size = new Size(409, 359);
            logo_jaune.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_jaune.TabIndex = 24;
            logo_jaune.TabStop = false;
            // 
            // BtnInformations
            // 
            BtnInformations.BackColor = Color.Transparent;
            BtnInformations.BackgroundImage = (Image)resources.GetObject("BtnInformations.BackgroundImage");
            BtnInformations.BackgroundImageLayout = ImageLayout.Zoom;
            BtnInformations.BadgeBackColor = Color.Red;
            BtnInformations.BadgeForeColor = Color.White;
            BtnInformations.BadgeRadius = 8;
            BtnInformations.BadgeRightMargin = 10;
            BtnInformations.BadgeValue = 0;
            BtnInformations.BorderColor = Color.FromArgb(150, 255, 255, 255);
            BtnInformations.BorderColorEnd = Color.Gray;
            BtnInformations.BorderColorStart = Color.White;
            BtnInformations.BorderRadiusBottomLeft = 35;
            BtnInformations.BorderRadiusBottomRight = 35;
            BtnInformations.BorderRadiusTopLeft = 35;
            BtnInformations.BorderRadiusTopRight = 35;
            BtnInformations.BorderThickness = 1;
            BtnInformations.ButtonColorEnd = Color.Transparent;
            BtnInformations.ButtonColorStart = Color.Transparent;
            BtnInformations.ButtonImage = null;
            BtnInformations.CanBeep = false;
            BtnInformations.CanShake = false;
            BtnInformations.ClickSoundPath = null;
            BtnInformations.DisabledOverlayOpacity = 0.5F;
            BtnInformations.EnableBorderGradient = false;
            BtnInformations.EnableClickSound = false;
            BtnInformations.EnableFocusBorder = false;
            BtnInformations.EnableHoverSound = false;
            BtnInformations.EnablePressScale = false;
            BtnInformations.EnableTextShadow = false;
            BtnInformations.FocusBorderColor = Color.FromArgb(100, 150, 255);
            BtnInformations.FocusBorderThickness = 2;
            BtnInformations.Font = new Font("Segoe UI", 9F);
            BtnInformations.ForeColor = Color.White;
            BtnInformations.HoverColor = Color.FromArgb(20, 0, 0, 0);
            BtnInformations.HoverSoundPath = null;
            BtnInformations.HoverTransitionSpeed = 0.08F;
            BtnInformations.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInformations.ImageLeftMargin = 5;
            BtnInformations.ImageRightMargin = 8;
            BtnInformations.ImageSize = 24;
            BtnInformations.IsReadOnly = false;
            BtnInformations.Location = new Point(1806, 12);
            BtnInformations.MakeRadial = false;
            BtnInformations.Name = "BtnInformations";
            BtnInformations.PressAnimationSpeed = 0.2F;
            BtnInformations.PressDepth = 1;
            BtnInformations.RippleColor = Color.Transparent;
            BtnInformations.RippleExpandSpeedFactor = 0.05F;
            BtnInformations.RippleFadeSpeedFactor = 0.03F;
            BtnInformations.ShadowBlurFactor = 0.85F;
            BtnInformations.ShadowColor = Color.Transparent;
            BtnInformations.ShadowOffsetX = 3;
            BtnInformations.ShadowOffsetY = 3;
            BtnInformations.Size = new Size(80, 73);
            BtnInformations.TabIndex = 21;
            BtnInformations.TextAlign = ContentAlignment.MiddleCenter;
            BtnInformations.TextPaddingBottom = 0;
            BtnInformations.TextPaddingLeft = 0;
            BtnInformations.TextPaddingRight = 0;
            BtnInformations.TextPaddingTop = 0;
            BtnInformations.TextShadowColor = Color.Transparent;
            BtnInformations.TextShadowOffsetX = 1;
            BtnInformations.TextShadowOffsetY = 1;
            BtnInformations.Click += BtnInformations_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(BtnInformations);
            Controls.Add(siticoneGroupBox4);
            Controls.Add(siticoneGroupBox3);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lblidentifiant);
            Controls.Add(siticoneGroupBox2);
            Controls.Add(siticoneGroupBox1);
            Controls.Add(LogoSupervisor);
            Controls.Add(grbox);
            Controls.Add(logo_rouge);
            Controls.Add(logo_bleu);
            Controls.Add(logo_jaune);
            Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supervisor";
            ((System.ComponentModel.ISupportInitialize)dgvlogs).EndInit();
            grbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_rouge).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoSupervisor).EndInit();
            siticoneGroupBox1.ResumeLayout(false);
            siticoneGroupBox1.PerformLayout();
            siticoneGroupBox2.ResumeLayout(false);
            siticoneGroupBox2.PerformLayout();
            siticoneGroupBox3.ResumeLayout(false);
            siticoneGroupBox3.PerformLayout();
            siticoneGroupBox4.ResumeLayout(false);
            siticoneGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_bleu).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_jaune).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvlogs;
        private GroupBox grbox;
        private PictureBox LogoSupervisor;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox1;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox2;
        private Label lblidentifiant;
        private Label label3;
        private Label label1;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox3;
        private Label label4;
        private Label label2;
        private TextBox txtRechercheUID;
        private Label lblAccesRefuses;
        private Label lblAccesAutorise;
        private Label lblTotalTentatives;
        private Label label7;
        private Label label6;
        private Label label5;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnRechercher;
        private ComboBox cbResultat;
        private Label label8;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnFiltrerDates;
        private Label label10;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpDebut;
        private Label label9;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnReset;
        private Label label11;
        private SiticoneNetCoreUI.SiticoneiOSSwitch switchCouleur;
        private SiticoneNetCoreUI.SiticoneGroupBox siticoneGroupBox4;
        private Label label13;
        private Label lblPorte;
        private Label label12;
        private Label lblPresence;
        private Label label14;
        private Label lblDernierUID;
        private Label label15;
        private Label label17;
        private Label lblDernierResultat;
        private Label lblDernierEvenement;
        private ProgressBar ProgressBar;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced AjouterLogAleatoire;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnImprimer;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnDéconnexion;
        private PictureBox logo_rouge;
        private PictureBox logo_bleu;
        private PictureBox logo_jaune;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnStatistiques;
        private Label lblEtatSysteme;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnRasberry;
        private Label label16;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnInformations;
    }
}