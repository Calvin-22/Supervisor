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
            btnAjouterFauxLog = new Button();
            btnSystem = new Button();
            btnImprimer = new Button();
            label16 = new Label();
            label4 = new Label();
            lblidentifiant = new Label();
            label3 = new Label();
            label1 = new Label();
            btnStatistiques = new Button();
            button1 = new Button();
            BtnRechercher = new Button();
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
            btnSeDéconnecter = new Button();
            groupBox1 = new GroupBox();
            BtnReset = new Button();
            BtnRadioNo = new RadioButton();
            BtnRadioYes = new RadioButton();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
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
            dgvlogs.Location = new Point(6, 33);
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
            grbox.Location = new Point(12, 27);
            grbox.Name = "grbox";
            grbox.Size = new Size(1365, 710);
            grbox.TabIndex = 1;
            grbox.TabStop = false;
            grbox.Text = "Logs";
            // 
            // logo_rouge
            // 
            logo_rouge.Image = Properties.Resources.logo_rouge;
            logo_rouge.Location = new Point(1430, 27);
            logo_rouge.Name = "logo_rouge";
            logo_rouge.Size = new Size(409, 359);
            logo_rouge.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_rouge.TabIndex = 22;
            logo_rouge.TabStop = false;
            // 
            // LogoSupervisor
            // 
            LogoSupervisor.Image = Properties.Resources.logo_bleu;
            LogoSupervisor.Location = new Point(1430, 27);
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
            lblEtatSysteme.Location = new Point(19, 51);
            lblEtatSysteme.Name = "lblEtatSysteme";
            lblEtatSysteme.Size = new Size(23, 27);
            lblEtatSysteme.TabIndex = 25;
            lblEtatSysteme.Text = "a";
            // 
            // lblAccesRefuses
            // 
            lblAccesRefuses.AutoSize = true;
            lblAccesRefuses.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccesRefuses.Location = new Point(258, 188);
            lblAccesRefuses.Name = "lblAccesRefuses";
            lblAccesRefuses.Size = new Size(23, 27);
            lblAccesRefuses.TabIndex = 12;
            lblAccesRefuses.Text = "a";
            // 
            // lblAccesAutorise
            // 
            lblAccesAutorise.AutoSize = true;
            lblAccesAutorise.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccesAutorise.Location = new Point(275, 146);
            lblAccesAutorise.Name = "lblAccesAutorise";
            lblAccesAutorise.Size = new Size(23, 27);
            lblAccesAutorise.TabIndex = 11;
            lblAccesAutorise.Text = "a";
            // 
            // lblTotalTentatives
            // 
            lblTotalTentatives.AutoSize = true;
            lblTotalTentatives.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTentatives.Location = new Point(326, 104);
            lblTotalTentatives.Name = "lblTotalTentatives";
            lblTotalTentatives.Size = new Size(23, 27);
            lblTotalTentatives.TabIndex = 8;
            lblTotalTentatives.Text = "a";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 188);
            label7.Name = "label7";
            label7.Size = new Size(240, 27);
            label7.TabIndex = 10;
            label7.Text = "Nombre d'accès refusé :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 146);
            label6.Name = "label6";
            label6.Size = new Size(258, 27);
            label6.TabIndex = 9;
            label6.Text = "Nombre d'accès autorisé :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 104);
            label5.Name = "label5";
            label5.Size = new Size(311, 27);
            label5.TabIndex = 8;
            label5.Text = "Nombre de tentatives d'accès : ";
            // 
            // btnAjouterFauxLog
            // 
            btnAjouterFauxLog.Font = new Font("Segoe UI Variable Text", 10F);
            btnAjouterFauxLog.Location = new Point(23, 190);
            btnAjouterFauxLog.Name = "btnAjouterFauxLog";
            btnAjouterFauxLog.Size = new Size(231, 34);
            btnAjouterFauxLog.TabIndex = 30;
            btnAjouterFauxLog.Text = "Ajouter un faux log (test)";
            btnAjouterFauxLog.UseVisualStyleBackColor = true;
            btnAjouterFauxLog.Click += AjouterLogAleatoire_Click;
            // 
            // btnSystem
            // 
            btnSystem.Font = new Font("Segoe UI Variable Text", 10F);
            btnSystem.Location = new Point(276, 128);
            btnSystem.Name = "btnSystem";
            btnSystem.Size = new Size(191, 34);
            btnSystem.TabIndex = 29;
            btnSystem.Text = "État Rasberry Pi";
            btnSystem.UseVisualStyleBackColor = true;
            btnSystem.Click += BtnRasberry_Click;
            // 
            // btnImprimer
            // 
            btnImprimer.Font = new Font("Segoe UI Variable Text", 10F);
            btnImprimer.Location = new Point(276, 61);
            btnImprimer.Name = "btnImprimer";
            btnImprimer.Size = new Size(191, 34);
            btnImprimer.TabIndex = 28;
            btnImprimer.Text = "Imprimer";
            btnImprimer.UseVisualStyleBackColor = true;
            btnImprimer.Click += BtnImprimer_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(22, 131);
            label16.Name = "label16";
            label16.Size = new Size(252, 27);
            label16.TabIndex = 24;
            label16.Text = "Vérifier état du matériel :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 65);
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
            // btnStatistiques
            // 
            btnStatistiques.Font = new Font("Segoe UI Variable Text", 10F);
            btnStatistiques.Location = new Point(581, 196);
            btnStatistiques.Name = "btnStatistiques";
            btnStatistiques.Size = new Size(191, 34);
            btnStatistiques.TabIndex = 27;
            btnStatistiques.Text = "Statistiques";
            btnStatistiques.UseVisualStyleBackColor = true;
            btnStatistiques.Click += BtnStatistiques_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Variable Text", 10F);
            button1.Location = new Point(581, 149);
            button1.Name = "button1";
            button1.Size = new Size(191, 34);
            button1.TabIndex = 26;
            button1.Text = "Filtrer par dates";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnFiltrerDates_Click;
            // 
            // BtnRechercher
            // 
            BtnRechercher.BackColor = Color.White;
            BtnRechercher.FlatAppearance.BorderColor = Color.White;
            BtnRechercher.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRechercher.ForeColor = Color.Black;
            BtnRechercher.Location = new Point(584, 47);
            BtnRechercher.Name = "BtnRechercher";
            BtnRechercher.Size = new Size(112, 34);
            BtnRechercher.TabIndex = 25;
            BtnRechercher.Text = "Chercher";
            BtnRechercher.UseVisualStyleBackColor = false;
            BtnRechercher.Click += BtnRechercher_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(15, 203);
            label11.Name = "label11";
            label11.Size = new Size(300, 27);
            label11.TabIndex = 20;
            label11.Text = "Activer les filtres de couleurs :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(307, 152);
            label10.Name = "label10";
            label10.Size = new Size(100, 27);
            label10.TabIndex = 16;
            label10.Text = "Date fin :";
            // 
            // dtpFin
            // 
            dtpFin.Font = new Font("Segoe UI Variable Text", 10F);
            dtpFin.Location = new Point(413, 149);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(150, 34);
            dtpFin.TabIndex = 15;
            // 
            // dtpDebut
            // 
            dtpDebut.Font = new Font("Segoe UI Variable Text", 10F);
            dtpDebut.Location = new Point(149, 149);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(150, 34);
            dtpDebut.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 149);
            label9.Name = "label9";
            label9.Size = new Size(129, 27);
            label9.TabIndex = 13;
            label9.Text = "Date début :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 97);
            label8.Name = "label8";
            label8.Size = new Size(117, 27);
            label8.TabIndex = 12;
            label8.Text = "Filtrer par :";
            // 
            // cbResultat
            // 
            cbResultat.Font = new Font("Segoe UI Variable Text", 10F);
            cbResultat.FormattingEnabled = true;
            cbResultat.Location = new Point(149, 96);
            cbResultat.Name = "cbResultat";
            cbResultat.Size = new Size(150, 35);
            cbResultat.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 47);
            label2.Name = "label2";
            label2.Size = new Size(315, 27);
            label2.TabIndex = 8;
            label2.Text = "Rechercher par identifiant NFC :";
            // 
            // txtRechercheUID
            // 
            txtRechercheUID.Location = new Point(336, 47);
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
            lblDernierEvenement.Location = new Point(253, 175);
            lblDernierEvenement.Name = "lblDernierEvenement";
            lblDernierEvenement.Size = new Size(23, 27);
            lblDernierEvenement.TabIndex = 19;
            lblDernierEvenement.Text = "a";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(8, 175);
            label17.Name = "label17";
            label17.Size = new Size(239, 27);
            label17.TabIndex = 18;
            label17.Text = "Plus récent évènement :";
            // 
            // lblDernierResultat
            // 
            lblDernierResultat.AutoSize = true;
            lblDernierResultat.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDernierResultat.Location = new Point(285, 141);
            lblDernierResultat.Name = "lblDernierResultat";
            lblDernierResultat.Size = new Size(23, 27);
            lblDernierResultat.TabIndex = 17;
            lblDernierResultat.Text = "a";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(7, 141);
            label15.Name = "label15";
            label15.Size = new Size(272, 27);
            label15.TabIndex = 16;
            label15.Text = "Dernière tentative d'accès :";
            // 
            // lblDernierUID
            // 
            lblDernierUID.AutoSize = true;
            lblDernierUID.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDernierUID.Location = new Point(225, 107);
            lblDernierUID.Name = "lblDernierUID";
            lblDernierUID.Size = new Size(23, 27);
            lblDernierUID.TabIndex = 15;
            lblDernierUID.Text = "a";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(7, 107);
            label14.Name = "label14";
            label14.Size = new Size(212, 27);
            label14.TabIndex = 14;
            label14.Text = "Dernier UID détecté :";
            // 
            // lblPresence
            // 
            lblPresence.AutoSize = true;
            lblPresence.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPresence.Location = new Point(121, 74);
            lblPresence.Name = "lblPresence";
            lblPresence.Size = new Size(23, 27);
            lblPresence.TabIndex = 13;
            lblPresence.Text = "a";
            // 
            // lblPorte
            // 
            lblPorte.AutoSize = true;
            lblPorte.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPorte.Location = new Point(131, 43);
            lblPorte.Name = "lblPorte";
            lblPorte.Size = new Size(23, 27);
            lblPorte.TabIndex = 12;
            lblPorte.Text = "a";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(8, 74);
            label12.Name = "label12";
            label12.Size = new Size(107, 27);
            label12.TabIndex = 11;
            label12.Text = "Présence :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(7, 43);
            label13.Name = "label13";
            label13.Size = new Size(118, 27);
            label13.TabIndex = 10;
            label13.Text = "État porte :";
            // 
            // logo_bleu
            // 
            logo_bleu.Image = Properties.Resources.logo_bleu;
            logo_bleu.Location = new Point(1430, 27);
            logo_bleu.Name = "logo_bleu";
            logo_bleu.Size = new Size(409, 359);
            logo_bleu.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_bleu.TabIndex = 23;
            logo_bleu.TabStop = false;
            // 
            // logo_jaune
            // 
            logo_jaune.Image = Properties.Resources.logo_jaune;
            logo_jaune.Location = new Point(1430, 27);
            logo_jaune.Name = "logo_jaune";
            logo_jaune.Size = new Size(409, 359);
            logo_jaune.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_jaune.TabIndex = 24;
            logo_jaune.TabStop = false;
            // 
            // btnSeDéconnecter
            // 
            btnSeDéconnecter.Font = new Font("Segoe UI Variable Text", 10F);
            btnSeDéconnecter.Location = new Point(276, 190);
            btnSeDéconnecter.Name = "btnSeDéconnecter";
            btnSeDéconnecter.Size = new Size(191, 34);
            btnSeDéconnecter.TabIndex = 31;
            btnSeDéconnecter.Text = "Se déconnecter";
            btnSeDéconnecter.UseVisualStyleBackColor = true;
            btnSeDéconnecter.Click += BtnDéconnexion_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnReset);
            groupBox1.Controls.Add(BtnRadioNo);
            groupBox1.Controls.Add(btnStatistiques);
            groupBox1.Controls.Add(BtnRadioYes);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnRechercher);
            groupBox1.Controls.Add(txtRechercheUID);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cbResultat);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpDebut);
            groupBox1.Controls.Add(dtpFin);
            groupBox1.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(491, 770);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(886, 251);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Interagir avec les logs";
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
            BtnReset.Location = new Point(787, 139);
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
            BtnRadioNo.Location = new Point(395, 203);
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
            BtnRadioYes.Location = new Point(321, 203);
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
            groupBox2.Location = new Point(12, 770);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 251);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informations générales";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSeDéconnecter);
            groupBox3.Controls.Add(btnSystem);
            groupBox3.Controls.Add(btnAjouterFauxLog);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(btnImprimer);
            groupBox3.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1383, 770);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(492, 251);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Outils système";
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
            groupBox4.Location = new Point(1383, 513);
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
        private Button BtnRechercher;
        private Button button1;
        private Button btnStatistiques;
        private Button btnImprimer;
        private Button btnSystem;
        private Button btnAjouterFauxLog;
        private Button btnSeDéconnecter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private RadioButton BtnRadioYes;
        private RadioButton BtnRadioNo;
        private Button BtnReset;
    }
}