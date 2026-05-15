namespace Supervisor.View
{
    partial class FrmSystemHealth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystemHealth));
            lblidentifiant = new Label();
            label13 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblCpuTemp = new Label();
            lblCpuLoad = new Label();
            lblRam = new Label();
            lblDisk = new Label();
            lblNetwork = new Label();
            lblVoltage = new Label();
            lblGlobalState = new Label();
            lblTimestamp = new Label();
            label8 = new Label();
            lblCaseTemp = new Label();
            label10 = new Label();
            GrboxSystem = new GroupBox();
            BtnRechercher = new ModernButton();
            GrboxSystem.SuspendLayout();
            SuspendLayout();
            // 
            // lblidentifiant
            // 
            lblidentifiant.AutoSize = true;
            lblidentifiant.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidentifiant.Location = new Point(90, 19);
            lblidentifiant.Name = "lblidentifiant";
            lblidentifiant.Size = new Size(288, 37);
            lblidentifiant.TabIndex = 6;
            lblidentifiant.Text = "Santé du Rasberry Pi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 30);
            label13.Name = "label13";
            label13.Size = new Size(193, 27);
            label13.TabIndex = 11;
            label13.Text = "Température CPU : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 71);
            label1.Name = "label1";
            label1.Size = new Size(133, 27);
            label1.TabIndex = 12;
            label1.Text = "Charge CPU :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 111);
            label2.Name = "label2";
            label2.Size = new Size(150, 27);
            label2.TabIndex = 13;
            label2.Text = "RAM utilisée : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 155);
            label3.Name = "label3";
            label3.Size = new Size(155, 27);
            label3.TabIndex = 14;
            label3.Text = "Espace disque :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 198);
            label4.Name = "label4";
            label4.Size = new Size(129, 27);
            label4.TabIndex = 15;
            label4.Text = "État réseau :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 241);
            label5.Name = "label5";
            label5.Size = new Size(101, 27);
            label5.TabIndex = 16;
            label5.Text = "Tension : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 461);
            label6.Name = "label6";
            label6.Size = new Size(151, 32);
            label6.TabIndex = 17;
            label6.Text = "État global :";
            // 
            // lblCpuTemp
            // 
            lblCpuTemp.AutoSize = true;
            lblCpuTemp.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpuTemp.Location = new Point(207, 30);
            lblCpuTemp.Name = "lblCpuTemp";
            lblCpuTemp.Size = new Size(23, 27);
            lblCpuTemp.TabIndex = 19;
            lblCpuTemp.Text = "a";
            // 
            // lblCpuLoad
            // 
            lblCpuLoad.AutoSize = true;
            lblCpuLoad.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpuLoad.Location = new Point(156, 71);
            lblCpuLoad.Name = "lblCpuLoad";
            lblCpuLoad.Size = new Size(23, 27);
            lblCpuLoad.TabIndex = 20;
            lblCpuLoad.Text = "a";
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRam.Location = new Point(173, 111);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(23, 27);
            lblRam.TabIndex = 21;
            lblRam.Text = "a";
            // 
            // lblDisk
            // 
            lblDisk.AutoSize = true;
            lblDisk.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisk.Location = new Point(178, 155);
            lblDisk.Name = "lblDisk";
            lblDisk.Size = new Size(23, 27);
            lblDisk.TabIndex = 22;
            lblDisk.Text = "a";
            // 
            // lblNetwork
            // 
            lblNetwork.AutoSize = true;
            lblNetwork.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNetwork.Location = new Point(152, 198);
            lblNetwork.Name = "lblNetwork";
            lblNetwork.Size = new Size(23, 27);
            lblNetwork.TabIndex = 23;
            lblNetwork.Text = "a";
            // 
            // lblVoltage
            // 
            lblVoltage.AutoSize = true;
            lblVoltage.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVoltage.Location = new Point(120, 241);
            lblVoltage.Name = "lblVoltage";
            lblVoltage.Size = new Size(23, 27);
            lblVoltage.TabIndex = 24;
            lblVoltage.Text = "a";
            // 
            // lblGlobalState
            // 
            lblGlobalState.AutoSize = true;
            lblGlobalState.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGlobalState.Location = new Point(182, 461);
            lblGlobalState.Name = "lblGlobalState";
            lblGlobalState.Size = new Size(26, 32);
            lblGlobalState.TabIndex = 25;
            lblGlobalState.Text = "a";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimestamp.Location = new Point(144, 325);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(23, 27);
            lblTimestamp.TabIndex = 27;
            lblTimestamp.Text = "a";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 325);
            label8.Name = "label8";
            label8.Size = new Size(134, 27);
            label8.TabIndex = 26;
            label8.Text = "Timestamp : ";
            // 
            // lblCaseTemp
            // 
            lblCaseTemp.AutoSize = true;
            lblCaseTemp.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaseTemp.Location = new Point(271, 284);
            lblCaseTemp.Name = "lblCaseTemp";
            lblCaseTemp.Size = new Size(23, 27);
            lblCaseTemp.TabIndex = 29;
            lblCaseTemp.Text = "a";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 284);
            label10.Name = "label10";
            label10.Size = new Size(248, 27);
            label10.TabIndex = 28;
            label10.Text = "Température du boîtier : ";
            // 
            // GrboxSystem
            // 
            GrboxSystem.Controls.Add(label13);
            GrboxSystem.Controls.Add(lblCaseTemp);
            GrboxSystem.Controls.Add(lblRam);
            GrboxSystem.Controls.Add(label1);
            GrboxSystem.Controls.Add(lblCpuLoad);
            GrboxSystem.Controls.Add(label10);
            GrboxSystem.Controls.Add(lblDisk);
            GrboxSystem.Controls.Add(label2);
            GrboxSystem.Controls.Add(lblCpuTemp);
            GrboxSystem.Controls.Add(lblTimestamp);
            GrboxSystem.Controls.Add(lblNetwork);
            GrboxSystem.Controls.Add(label3);
            GrboxSystem.Controls.Add(lblVoltage);
            GrboxSystem.Controls.Add(label8);
            GrboxSystem.Controls.Add(label5);
            GrboxSystem.Controls.Add(label4);
            GrboxSystem.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrboxSystem.Location = new Point(25, 59);
            GrboxSystem.Name = "GrboxSystem";
            GrboxSystem.Size = new Size(414, 377);
            GrboxSystem.TabIndex = 32;
            GrboxSystem.TabStop = false;
            // 
            // BtnRechercher
            // 
            BtnRechercher.BorderRadius = 20;
            BtnRechercher.EndColor = Color.DarkGreen;
            BtnRechercher.FlatAppearance.BorderSize = 0;
            BtnRechercher.FlatAppearance.MouseDownBackColor = Color.White;
            BtnRechercher.FlatAppearance.MouseOverBackColor = Color.White;
            BtnRechercher.FlatStyle = FlatStyle.Flat;
            BtnRechercher.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRechercher.ForeColor = Color.White;
            BtnRechercher.Location = new Point(248, 506);
            BtnRechercher.Name = "BtnRechercher";
            BtnRechercher.Size = new Size(191, 39);
            BtnRechercher.StartColor = Color.LimeGreen;
            BtnRechercher.TabIndex = 37;
            BtnRechercher.Text = "Rafraîchir";
            BtnRechercher.UseVisualStyleBackColor = true;
            BtnRechercher.Click += btnRefresh_Click;
            // 
            // FrmSystemHealth
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 568);
            Controls.Add(BtnRechercher);
            Controls.Add(GrboxSystem);
            Controls.Add(lblidentifiant);
            Controls.Add(label6);
            Controls.Add(lblGlobalState);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSystemHealth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "État de santé du système";
            GrboxSystem.ResumeLayout(false);
            GrboxSystem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblidentifiant;
        private Label label13;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblCpuTemp;
        private Label lblCpuLoad;
        private Label lblRam;
        private Label lblDisk;
        private Label lblNetwork;
        private Label lblVoltage;
        private Label lblGlobalState;
        private Label lblTimestamp;
        private Label label8;
        private Label lblCaseTemp;
        private Label label10;
        private GroupBox GrboxSystem;
        private ModernButton BtnRechercher;
    }
}