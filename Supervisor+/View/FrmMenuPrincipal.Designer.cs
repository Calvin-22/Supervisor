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
            lblEtatSysteme = new Label();
            lblAccesRefuses = new Label();
            lblAccesAutorise = new Label();
            lblTotalTentatives = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label16 = new Label();
            label4 = new Label();
            lblidentifiant = new Label();
            label3 = new Label();
            label1 = new Label();
            label11 = new Label();
            label10 = new Label();
            dtpFin = new DateTimePicker();
            dtpDebut = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            cbResultat = new ComboBox();
            label2 = new Label();
            txtRechercheUID = new TextBox();
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
            groupBox1 = new GroupBox();
            BtnStats = new ModernButton();
            BtnFiltrerParDates = new ModernButton();
            BtnRechercher = new ModernButton();
            BtnReset = new Button();
            BtnRadioNo = new RadioButton();
            BtnRadioYes = new RadioButton();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            BtnAjouterFauxLog = new ModernButton();
            BtnSeDeconnecter = new ModernButton();
            BtnRasberry = new ModernButton();
            BtnImprimer = new ModernButton();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvlogs).BeginInit();
            grbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_rouge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoSupervisor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_bleu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_jaune).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvlogs.DefaultCellStyle = dataGridViewCellStyle2;
            dgvlogs.EnableHeadersVisualStyles = false;
            dgvlogs.Location = new Point(6, 30);
            dgvlogs.MultiSelect = false;
            dgvlogs.Name = "dgvlogs";
            dgvlogs.ReadOnly = true;
            dgvlogs.RowHeadersVisible = false;
            dgvlogs.RowHeadersWidth = 62;
            dgvlogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlogs.Size = new Size(1353, 671);
            dgvlogs.TabIndex = 0;
            // 
            // grbox
            // 
            grbox.Controls.Add(dgvlogs);
            grbox.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbox.Location = new Point(12, 13);
            grbox.Name = "grbox";
            grbox.Size = new Size(1365, 710);
            grbox.TabIndex = 1;
            grbox.TabStop = false;
            grbox.Text = "Logs";
            // 
            // logo_rouge
            // 
            logo_rouge.Image = Properties.Resources.logo_rouge;
            logo_rouge.Location = new Point(1430, 13);
            logo_rouge.Name = "logo_rouge";
            logo_rouge.Size = new Size(409, 359);
            logo_rouge.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_rouge.TabIndex = 22;
            logo_rouge.TabStop = false;
            // 
            // LogoSupervisor
            // 
            LogoSupervisor.Image = Properties.Resources.logo_bleu;
            LogoSupervisor.Location = new Point(1430, 13);
            LogoSupervisor.Name = "LogoSupervisor";
            LogoSupervisor.Size = new Size(409, 359);
            LogoSupervisor.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoSupervisor.TabIndex = 2;
            LogoSupervisor.TabStop = false;
            // 
            // lblEtatSysteme
            // 
            lblEtatSysteme.AutoSize = true;
            lblEtatSysteme.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEtatSysteme.Location = new Point(6, 49);
            lblEtatSysteme.Name = "lblEtatSysteme";
            lblEtatSysteme.Size = new Size(23, 27);
            lblEtatSysteme.TabIndex = 25;
            lblEtatSysteme.Text = "a";
            // 
            // lblAccesRefuses
            // 
            lblAccesRefuses.AutoSize = true;
            lblAccesRefuses.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccesRefuses.Location = new Point(245, 186);
            lblAccesRefuses.Name = "lblAccesRefuses";
            lblAccesRefuses.Size = new Size(23, 27);
            lblAccesRefuses.TabIndex = 12;
            lblAccesRefuses.Text = "a";
            // 
            // lblAccesAutorise
            // 
            lblAccesAutorise.AutoSize = true;
            lblAccesAutorise.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccesAutorise.Location = new Point(262, 144);
            lblAccesAutorise.Name = "lblAccesAutorise";
            lblAccesAutorise.Size = new Size(23, 27);
            lblAccesAutorise.TabIndex = 11;
            lblAccesAutorise.Text = "a";
            // 
            // lblTotalTentatives
            // 
            lblTotalTentatives.AutoSize = true;
            lblTotalTentatives.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTentatives.Location = new Point(313, 102);
            lblTotalTentatives.Name = "lblTotalTentatives";
            lblTotalTentatives.Size = new Size(23, 27);
            lblTotalTentatives.TabIndex = 8;
            lblTotalTentatives.Text = "a";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 186);
            label7.Name = "label7";
            label7.Size = new Size(240, 27);
            label7.TabIndex = 10;
            label7.Text = "Nombre d'accès refusé :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 144);
            label6.Name = "label6";
            label6.Size = new Size(258, 27);
            label6.TabIndex = 9;
            label6.Text = "Nombre d'accès autorisé :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 102);
            label5.Name = "label5";
            label5.Size = new Size(311, 27);
            label5.TabIndex = 8;
            label5.Text = "Nombre de tentatives d'accès : ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(15, 123);
            label16.Name = "label16";
            label16.Size = new Size(252, 27);
            label16.TabIndex = 24;
            label16.Text = "Vérifier état du matériel :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 53);
            label4.Name = "label4";
            label4.Size = new Size(192, 27);
            label4.TabIndex = 10;
            label4.Text = "Exporter vers PDF :";
            // 
            // lblidentifiant
            // 
            lblidentifiant.AutoSize = true;
            lblidentifiant.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidentifiant.Location = new Point(1502, 383);
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
            label3.Location = new Point(1430, 414);
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
            label1.Location = new Point(1430, 441);
            label1.Name = "label1";
            label1.Size = new Size(427, 27);
            label1.TabIndex = 7;
            label1.Text = "et d’exploitation avancée du système CA25.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(15, 206);
            label11.Name = "label11";
            label11.Size = new Size(300, 27);
            label11.TabIndex = 20;
            label11.Text = "Activer les filtres de couleurs :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(307, 155);
            label10.Name = "label10";
            label10.Size = new Size(100, 27);
            label10.TabIndex = 16;
            label10.Text = "Date fin :";
            // 
            // dtpFin
            // 
            dtpFin.Font = new Font("Segoe UI Variable Text", 10F);
            dtpFin.Location = new Point(413, 152);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(150, 34);
            dtpFin.TabIndex = 15;
            // 
            // dtpDebut
            // 
            dtpDebut.Font = new Font("Segoe UI Variable Text", 10F);
            dtpDebut.Location = new Point(149, 152);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(150, 34);
            dtpDebut.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 152);
            label9.Name = "label9";
            label9.Size = new Size(129, 27);
            label9.TabIndex = 13;
            label9.Text = "Date début :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 100);
            label8.Name = "label8";
            label8.Size = new Size(117, 27);
            label8.TabIndex = 12;
            label8.Text = "Filtrer par :";
            // 
            // cbResultat
            // 
            cbResultat.Font = new Font("Segoe UI Variable Text", 10F);
            cbResultat.FormattingEnabled = true;
            cbResultat.Location = new Point(149, 99);
            cbResultat.Name = "cbResultat";
            cbResultat.Size = new Size(150, 35);
            cbResultat.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 50);
            label2.Name = "label2";
            label2.Size = new Size(315, 27);
            label2.TabIndex = 8;
            label2.Text = "Rechercher par identifiant NFC :";
            // 
            // txtRechercheUID
            // 
            txtRechercheUID.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRechercheUID.Location = new Point(336, 50);
            txtRechercheUID.Name = "txtRechercheUID";
            txtRechercheUID.Size = new Size(227, 34);
            txtRechercheUID.TabIndex = 2;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(244, 4);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(118, 20);
            ProgressBar.TabIndex = 20;
            // 
            // lblDernierEvenement
            // 
            lblDernierEvenement.AutoSize = true;
            lblDernierEvenement.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDernierEvenement.Location = new Point(251, 174);
            lblDernierEvenement.Name = "lblDernierEvenement";
            lblDernierEvenement.Size = new Size(23, 27);
            lblDernierEvenement.TabIndex = 19;
            lblDernierEvenement.Text = "a";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(6, 174);
            label17.Name = "label17";
            label17.Size = new Size(239, 27);
            label17.TabIndex = 18;
            label17.Text = "Plus récent évènement :";
            // 
            // lblDernierResultat
            // 
            lblDernierResultat.AutoSize = true;
            lblDernierResultat.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDernierResultat.Location = new Point(283, 140);
            lblDernierResultat.Name = "lblDernierResultat";
            lblDernierResultat.Size = new Size(23, 27);
            lblDernierResultat.TabIndex = 17;
            lblDernierResultat.Text = "a";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(5, 140);
            label15.Name = "label15";
            label15.Size = new Size(272, 27);
            label15.TabIndex = 16;
            label15.Text = "Dernière tentative d'accès :";
            // 
            // lblDernierUID
            // 
            lblDernierUID.AutoSize = true;
            lblDernierUID.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDernierUID.Location = new Point(223, 106);
            lblDernierUID.Name = "lblDernierUID";
            lblDernierUID.Size = new Size(23, 27);
            lblDernierUID.TabIndex = 15;
            lblDernierUID.Text = "a";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(5, 106);
            label14.Name = "label14";
            label14.Size = new Size(212, 27);
            label14.TabIndex = 14;
            label14.Text = "Dernier UID détecté :";
            // 
            // lblPresence
            // 
            lblPresence.AutoSize = true;
            lblPresence.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPresence.Location = new Point(119, 73);
            lblPresence.Name = "lblPresence";
            lblPresence.Size = new Size(23, 27);
            lblPresence.TabIndex = 13;
            lblPresence.Text = "a";
            // 
            // lblPorte
            // 
            lblPorte.AutoSize = true;
            lblPorte.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPorte.Location = new Point(129, 42);
            lblPorte.Name = "lblPorte";
            lblPorte.Size = new Size(23, 27);
            lblPorte.TabIndex = 12;
            lblPorte.Text = "a";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 73);
            label12.Name = "label12";
            label12.Size = new Size(107, 27);
            label12.TabIndex = 11;
            label12.Text = "Présence :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(5, 42);
            label13.Name = "label13";
            label13.Size = new Size(118, 27);
            label13.TabIndex = 10;
            label13.Text = "État porte :";
            // 
            // logo_bleu
            // 
            logo_bleu.Image = Properties.Resources.logo_bleu;
            logo_bleu.Location = new Point(1430, 13);
            logo_bleu.Name = "logo_bleu";
            logo_bleu.Size = new Size(409, 359);
            logo_bleu.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_bleu.TabIndex = 23;
            logo_bleu.TabStop = false;
            // 
            // logo_jaune
            // 
            logo_jaune.Image = Properties.Resources.logo_jaune;
            logo_jaune.Location = new Point(1430, 13);
            logo_jaune.Name = "logo_jaune";
            logo_jaune.Size = new Size(409, 359);
            logo_jaune.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_jaune.TabIndex = 24;
            logo_jaune.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnStats);
            groupBox1.Controls.Add(BtnFiltrerParDates);
            groupBox1.Controls.Add(BtnRechercher);
            groupBox1.Controls.Add(BtnReset);
            groupBox1.Controls.Add(BtnRadioNo);
            groupBox1.Controls.Add(BtnRadioYes);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtRechercheUID);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cbResultat);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpDebut);
            groupBox1.Controls.Add(dtpFin);
            groupBox1.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(491, 756);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(886, 251);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Interagir avec les logs";
            // 
            // BtnStats
            // 
            BtnStats.BorderRadius = 20;
            BtnStats.EndColor = Color.Indigo;
            BtnStats.FlatAppearance.BorderSize = 0;
            BtnStats.FlatAppearance.MouseDownBackColor = Color.White;
            BtnStats.FlatAppearance.MouseOverBackColor = Color.White;
            BtnStats.FlatStyle = FlatStyle.Flat;
            BtnStats.Font = new Font("Segoe UI Variable Text", 10F);
            BtnStats.ForeColor = Color.White;
            BtnStats.Location = new Point(581, 202);
            BtnStats.Name = "BtnStats";
            BtnStats.Size = new Size(191, 39);
            BtnStats.StartColor = Color.MediumOrchid;
            BtnStats.TabIndex = 38;
            BtnStats.Text = "Statistiques";
            BtnStats.UseVisualStyleBackColor = true;
            BtnStats.Click += BtnStatistiques_Click;
            // 
            // BtnFiltrerParDates
            // 
            BtnFiltrerParDates.BorderRadius = 20;
            BtnFiltrerParDates.EndColor = Color.DarkGreen;
            BtnFiltrerParDates.FlatAppearance.BorderSize = 0;
            BtnFiltrerParDates.FlatAppearance.MouseDownBackColor = Color.White;
            BtnFiltrerParDates.FlatAppearance.MouseOverBackColor = Color.White;
            BtnFiltrerParDates.FlatStyle = FlatStyle.Flat;
            BtnFiltrerParDates.Font = new Font("Segoe UI Variable Text", 10F);
            BtnFiltrerParDates.ForeColor = Color.White;
            BtnFiltrerParDates.Location = new Point(581, 150);
            BtnFiltrerParDates.Name = "BtnFiltrerParDates";
            BtnFiltrerParDates.Size = new Size(191, 39);
            BtnFiltrerParDates.StartColor = Color.LimeGreen;
            BtnFiltrerParDates.TabIndex = 37;
            BtnFiltrerParDates.Text = "Filtrer par dates";
            BtnFiltrerParDates.UseVisualStyleBackColor = true;
            BtnFiltrerParDates.Click += btnFiltrerDates_Click;
            // 
            // BtnRechercher
            // 
            BtnRechercher.BorderRadius = 20;
            BtnRechercher.EndColor = Color.MidnightBlue;
            BtnRechercher.FlatAppearance.BorderSize = 0;
            BtnRechercher.FlatAppearance.MouseDownBackColor = Color.White;
            BtnRechercher.FlatAppearance.MouseOverBackColor = Color.White;
            BtnRechercher.FlatStyle = FlatStyle.Flat;
            BtnRechercher.Font = new Font("Segoe UI Variable Text", 10F);
            BtnRechercher.ForeColor = Color.White;
            BtnRechercher.Location = new Point(581, 44);
            BtnRechercher.Name = "BtnRechercher";
            BtnRechercher.Size = new Size(191, 39);
            BtnRechercher.StartColor = Color.Blue;
            BtnRechercher.TabIndex = 36;
            BtnRechercher.Text = "Chercher";
            BtnRechercher.UseVisualStyleBackColor = true;
            BtnRechercher.Click += BtnRechercher_Click;
            // 
            // BtnReset
            // 
            BtnReset.BackgroundImage = Properties.Resources.flèchequitourne2;
            BtnReset.BackgroundImageLayout = ImageLayout.Stretch;
            BtnReset.FlatAppearance.BorderColor = Color.White;
            BtnReset.FlatAppearance.MouseDownBackColor = Color.White;
            BtnReset.FlatAppearance.MouseOverBackColor = Color.White;
            BtnReset.FlatStyle = FlatStyle.Flat;
            BtnReset.ForeColor = Color.White;
            BtnReset.Location = new Point(787, 142);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(81, 54);
            BtnReset.TabIndex = 35;
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // BtnRadioNo
            // 
            BtnRadioNo.AutoSize = true;
            BtnRadioNo.Checked = true;
            BtnRadioNo.Font = new Font("Segoe UI Variable Text", 10F);
            BtnRadioNo.Location = new Point(395, 206);
            BtnRadioNo.Name = "BtnRadioNo";
            BtnRadioNo.Size = new Size(75, 31);
            BtnRadioNo.TabIndex = 34;
            BtnRadioNo.TabStop = true;
            BtnRadioNo.Text = "Non";
            BtnRadioNo.UseVisualStyleBackColor = true;
            BtnRadioNo.CheckedChanged += BtnRadioNo_CheckedChanged;
            // 
            // BtnRadioYes
            // 
            BtnRadioYes.AutoSize = true;
            BtnRadioYes.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRadioYes.Location = new Point(321, 206);
            BtnRadioYes.Name = "BtnRadioYes";
            BtnRadioYes.Size = new Size(68, 31);
            BtnRadioYes.TabIndex = 33;
            BtnRadioYes.Text = "Oui";
            BtnRadioYes.UseVisualStyleBackColor = true;
            BtnRadioYes.CheckedChanged += BtnRadioYes_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblEtatSysteme);
            groupBox2.Controls.Add(lblAccesRefuses);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblAccesAutorise);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lblTotalTentatives);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 756);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 251);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informations générales";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnAjouterFauxLog);
            groupBox3.Controls.Add(BtnSeDeconnecter);
            groupBox3.Controls.Add(BtnRasberry);
            groupBox3.Controls.Add(BtnImprimer);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label16);
            groupBox3.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1383, 756);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(492, 251);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Outils système";
            // 
            // BtnAjouterFauxLog
            // 
            BtnAjouterFauxLog.BorderRadius = 20;
            BtnAjouterFauxLog.EndColor = Color.SlateGray;
            BtnAjouterFauxLog.FlatAppearance.BorderSize = 0;
            BtnAjouterFauxLog.FlatAppearance.MouseDownBackColor = Color.White;
            BtnAjouterFauxLog.FlatAppearance.MouseOverBackColor = Color.White;
            BtnAjouterFauxLog.FlatStyle = FlatStyle.Flat;
            BtnAjouterFauxLog.Font = new Font("Segoe UI Variable Text", 10F);
            BtnAjouterFauxLog.ForeColor = Color.White;
            BtnAjouterFauxLog.Location = new Point(15, 186);
            BtnAjouterFauxLog.Name = "BtnAjouterFauxLog";
            BtnAjouterFauxLog.Size = new Size(248, 39);
            BtnAjouterFauxLog.StartColor = Color.FromArgb(224, 224, 224);
            BtnAjouterFauxLog.TabIndex = 42;
            BtnAjouterFauxLog.Text = "Ajouter faux logs (test)";
            BtnAjouterFauxLog.UseVisualStyleBackColor = true;
            BtnAjouterFauxLog.Click += AjouterLogAleatoire_Click;
            // 
            // BtnSeDeconnecter
            // 
            BtnSeDeconnecter.BorderRadius = 20;
            BtnSeDeconnecter.EndColor = Color.DarkRed;
            BtnSeDeconnecter.FlatAppearance.BorderSize = 0;
            BtnSeDeconnecter.FlatAppearance.MouseDownBackColor = Color.White;
            BtnSeDeconnecter.FlatAppearance.MouseOverBackColor = Color.White;
            BtnSeDeconnecter.FlatStyle = FlatStyle.Flat;
            BtnSeDeconnecter.Font = new Font("Segoe UI Variable Text", 10F);
            BtnSeDeconnecter.ForeColor = Color.White;
            BtnSeDeconnecter.Location = new Point(283, 186);
            BtnSeDeconnecter.Name = "BtnSeDeconnecter";
            BtnSeDeconnecter.Size = new Size(191, 39);
            BtnSeDeconnecter.StartColor = Color.Red;
            BtnSeDeconnecter.TabIndex = 41;
            BtnSeDeconnecter.Text = "Se déconnecter";
            BtnSeDeconnecter.UseVisualStyleBackColor = true;
            BtnSeDeconnecter.Click += BtnDéconnexion_Click;
            // 
            // BtnRasberry
            // 
            BtnRasberry.BorderRadius = 20;
            BtnRasberry.EndColor = Color.Chocolate;
            BtnRasberry.FlatAppearance.BorderSize = 0;
            BtnRasberry.FlatAppearance.MouseDownBackColor = Color.White;
            BtnRasberry.FlatAppearance.MouseOverBackColor = Color.White;
            BtnRasberry.FlatStyle = FlatStyle.Flat;
            BtnRasberry.Font = new Font("Segoe UI Variable Text", 10F);
            BtnRasberry.ForeColor = Color.White;
            BtnRasberry.Location = new Point(279, 119);
            BtnRasberry.Name = "BtnRasberry";
            BtnRasberry.Size = new Size(191, 39);
            BtnRasberry.StartColor = Color.FromArgb(255, 128, 0);
            BtnRasberry.TabIndex = 40;
            BtnRasberry.Text = "État Rasberry Pi";
            BtnRasberry.UseVisualStyleBackColor = true;
            BtnRasberry.Click += BtnRasberry_Click;
            // 
            // BtnImprimer
            // 
            BtnImprimer.BorderRadius = 20;
            BtnImprimer.EndColor = Color.SlateGray;
            BtnImprimer.FlatAppearance.BorderSize = 0;
            BtnImprimer.FlatAppearance.MouseDownBackColor = Color.White;
            BtnImprimer.FlatAppearance.MouseOverBackColor = Color.White;
            BtnImprimer.FlatStyle = FlatStyle.Flat;
            BtnImprimer.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnImprimer.ForeColor = Color.White;
            BtnImprimer.Location = new Point(279, 47);
            BtnImprimer.Name = "BtnImprimer";
            BtnImprimer.Size = new Size(191, 39);
            BtnImprimer.StartColor = Color.FromArgb(224, 224, 224);
            BtnImprimer.TabIndex = 39;
            BtnImprimer.Text = "Imprimer";
            BtnImprimer.UseVisualStyleBackColor = true;
            BtnImprimer.Click += BtnImprimer_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ProgressBar);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(lblDernierEvenement);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(lblPorte);
            groupBox4.Controls.Add(lblDernierResultat);
            groupBox4.Controls.Add(lblPresence);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(lblDernierUID);
            groupBox4.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(1383, 499);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(492, 224);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "État du système (en live)";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lblidentifiant);
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
            Text = "Supervisor+";
            ((System.ComponentModel.ISupportInitialize)dgvlogs).EndInit();
            grbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_rouge).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoSupervisor).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_bleu).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_jaune).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvlogs;
        private GroupBox grbox;
        private PictureBox LogoSupervisor;
        private Label lblidentifiant;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox txtRechercheUID;
        private Label lblAccesRefuses;
        private Label lblAccesAutorise;
        private Label lblTotalTentatives;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cbResultat;
        private Label label8;
        private Label label10;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpDebut;
        private Label label9;
        private Label label11;
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
        private PictureBox logo_rouge;
        private PictureBox logo_bleu;
        private PictureBox logo_jaune;
        private Label lblEtatSysteme;
        private Label label16;
        private Button NBtnRechercher;
        private Button button1;
        private Button btnStatistiques;
        private Button btnImprimer;
        private Button btnAjouterFauxLog;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private RadioButton BtnRadioYes;
        private RadioButton BtnRadioNo;
        private Button BtnReset;
        private ModernButton BtnRechercher;
        private ModernButton BtnFiltrerParDates;
        private ModernButton BtnStats;
        private ModernButton BtnImprimer;
        private ModernButton BtnRasberry;
        private ModernButton BtnSeDeconnecter;
        private ModernButton BtnAjouterFauxLog;
    }
}