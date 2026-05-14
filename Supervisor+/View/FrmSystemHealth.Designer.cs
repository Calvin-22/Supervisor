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
            BtnRefresh = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
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
            GrboxSystem = new SiticoneNetCoreUI.SiticoneGroupBox();
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
            label13.Location = new Point(21, 40);
            label13.Name = "label13";
            label13.Size = new Size(193, 27);
            label13.TabIndex = 11;
            label13.Text = "Température CPU : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 81);
            label1.Name = "label1";
            label1.Size = new Size(133, 27);
            label1.TabIndex = 12;
            label1.Text = "Charge CPU :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(150, 27);
            label2.TabIndex = 13;
            label2.Text = "RAM utilisée : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 165);
            label3.Name = "label3";
            label3.Size = new Size(155, 27);
            label3.TabIndex = 14;
            label3.Text = "Espace disque :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 208);
            label4.Name = "label4";
            label4.Size = new Size(129, 27);
            label4.TabIndex = 15;
            label4.Text = "État réseau :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 251);
            label5.Name = "label5";
            label5.Size = new Size(101, 27);
            label5.TabIndex = 16;
            label5.Text = "Tension : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 469);
            label6.Name = "label6";
            label6.Size = new Size(151, 32);
            label6.TabIndex = 17;
            label6.Text = "État global :";
            // 
            // BtnRefresh
            // 
            BtnRefresh.BackColor = Color.Transparent;
            BtnRefresh.BadgeBackColor = Color.Red;
            BtnRefresh.BadgeForeColor = Color.White;
            BtnRefresh.BadgeRadius = 8;
            BtnRefresh.BadgeRightMargin = 10;
            BtnRefresh.BadgeValue = 0;
            BtnRefresh.BorderColor = Color.FromArgb(150, 255, 255, 255);
            BtnRefresh.BorderColorEnd = Color.Gray;
            BtnRefresh.BorderColorStart = Color.White;
            BtnRefresh.BorderRadiusBottomLeft = 35;
            BtnRefresh.BorderRadiusBottomRight = 35;
            BtnRefresh.BorderRadiusTopLeft = 35;
            BtnRefresh.BorderRadiusTopRight = 35;
            BtnRefresh.BorderThickness = 1;
            BtnRefresh.ButtonColorEnd = Color.DarkGreen;
            BtnRefresh.ButtonColorStart = Color.LimeGreen;
            BtnRefresh.ButtonImage = null;
            BtnRefresh.CanBeep = false;
            BtnRefresh.CanShake = false;
            BtnRefresh.ClickSoundPath = null;
            BtnRefresh.DisabledOverlayOpacity = 0.5F;
            BtnRefresh.EnableBorderGradient = false;
            BtnRefresh.EnableClickSound = false;
            BtnRefresh.EnableFocusBorder = false;
            BtnRefresh.EnableHoverSound = false;
            BtnRefresh.EnablePressScale = false;
            BtnRefresh.EnableTextShadow = false;
            BtnRefresh.FocusBorderColor = Color.FromArgb(100, 150, 255);
            BtnRefresh.FocusBorderThickness = 2;
            BtnRefresh.Font = new Font("Segoe UI", 9F);
            BtnRefresh.ForeColor = Color.White;
            BtnRefresh.HoverColor = Color.FromArgb(20, 0, 0, 0);
            BtnRefresh.HoverSoundPath = null;
            BtnRefresh.HoverTransitionSpeed = 0.08F;
            BtnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRefresh.ImageLeftMargin = 5;
            BtnRefresh.ImageRightMargin = 8;
            BtnRefresh.ImageSize = 24;
            BtnRefresh.IsReadOnly = false;
            BtnRefresh.Location = new Point(296, 515);
            BtnRefresh.MakeRadial = false;
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.PressAnimationSpeed = 0.2F;
            BtnRefresh.PressDepth = 1;
            BtnRefresh.RippleColor = Color.FromArgb(60, 255, 255, 255);
            BtnRefresh.RippleExpandSpeedFactor = 0.05F;
            BtnRefresh.RippleFadeSpeedFactor = 0.03F;
            BtnRefresh.ShadowBlurFactor = 0.85F;
            BtnRefresh.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            BtnRefresh.ShadowOffsetX = 3;
            BtnRefresh.ShadowOffsetY = 3;
            BtnRefresh.Size = new Size(145, 52);
            BtnRefresh.TabIndex = 18;
            BtnRefresh.Text = "Rafraîchir";
            BtnRefresh.TextAlign = ContentAlignment.MiddleCenter;
            BtnRefresh.TextPaddingBottom = 0;
            BtnRefresh.TextPaddingLeft = 0;
            BtnRefresh.TextPaddingRight = 0;
            BtnRefresh.TextPaddingTop = 0;
            BtnRefresh.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            BtnRefresh.TextShadowOffsetX = 1;
            BtnRefresh.TextShadowOffsetY = 1;
            BtnRefresh.Click += btnRefresh_Click;
            // 
            // lblCpuTemp
            // 
            lblCpuTemp.AutoSize = true;
            lblCpuTemp.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpuTemp.Location = new Point(211, 40);
            lblCpuTemp.Name = "lblCpuTemp";
            lblCpuTemp.Size = new Size(23, 27);
            lblCpuTemp.TabIndex = 19;
            lblCpuTemp.Text = "a";
            // 
            // lblCpuLoad
            // 
            lblCpuLoad.AutoSize = true;
            lblCpuLoad.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpuLoad.Location = new Point(160, 81);
            lblCpuLoad.Name = "lblCpuLoad";
            lblCpuLoad.Size = new Size(23, 27);
            lblCpuLoad.TabIndex = 20;
            lblCpuLoad.Text = "a";
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRam.Location = new Point(177, 121);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(23, 27);
            lblRam.TabIndex = 21;
            lblRam.Text = "a";
            // 
            // lblDisk
            // 
            lblDisk.AutoSize = true;
            lblDisk.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisk.Location = new Point(182, 165);
            lblDisk.Name = "lblDisk";
            lblDisk.Size = new Size(23, 27);
            lblDisk.TabIndex = 22;
            lblDisk.Text = "a";
            // 
            // lblNetwork
            // 
            lblNetwork.AutoSize = true;
            lblNetwork.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNetwork.Location = new Point(156, 208);
            lblNetwork.Name = "lblNetwork";
            lblNetwork.Size = new Size(23, 27);
            lblNetwork.TabIndex = 23;
            lblNetwork.Text = "a";
            // 
            // lblVoltage
            // 
            lblVoltage.AutoSize = true;
            lblVoltage.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVoltage.Location = new Point(124, 251);
            lblVoltage.Name = "lblVoltage";
            lblVoltage.Size = new Size(23, 27);
            lblVoltage.TabIndex = 24;
            lblVoltage.Text = "a";
            // 
            // lblGlobalState
            // 
            lblGlobalState.AutoSize = true;
            lblGlobalState.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGlobalState.Location = new Point(182, 469);
            lblGlobalState.Name = "lblGlobalState";
            lblGlobalState.Size = new Size(26, 32);
            lblGlobalState.TabIndex = 25;
            lblGlobalState.Text = "a";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimestamp.Location = new Point(148, 335);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(23, 27);
            lblTimestamp.TabIndex = 27;
            lblTimestamp.Text = "a";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 335);
            label8.Name = "label8";
            label8.Size = new Size(134, 27);
            label8.TabIndex = 26;
            label8.Text = "Timestamp : ";
            // 
            // lblCaseTemp
            // 
            lblCaseTemp.AutoSize = true;
            lblCaseTemp.Font = new Font("Segoe UI Variable Small", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaseTemp.Location = new Point(275, 294);
            lblCaseTemp.Name = "lblCaseTemp";
            lblCaseTemp.Size = new Size(23, 27);
            lblCaseTemp.TabIndex = 29;
            lblCaseTemp.Text = "a";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 294);
            label10.Name = "label10";
            label10.Size = new Size(248, 27);
            label10.TabIndex = 28;
            label10.Text = "Température du boîtier : ";
            // 
            // GrboxSystem
            // 
            GrboxSystem.BackColor = Color.Transparent;
            GrboxSystem.BadgeColor = Color.Red;
            GrboxSystem.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            GrboxSystem.BadgeLeftPadding = 12;
            GrboxSystem.BadgeValue = 0;
            GrboxSystem.BadgeVisible = false;
            GrboxSystem.BlinkInterval = 500;
            GrboxSystem.BlinkMinOpacity = 0.3F;
            GrboxSystem.BlinkOpacityStep = 0.05F;
            GrboxSystem.BorderColor = Color.FromArgb(224, 224, 224);
            GrboxSystem.BorderWidth = 3F;
            GrboxSystem.ChevronColor = Color.FromArgb(90, 90, 90);
            GrboxSystem.ChevronLeftSpacing = 4F;
            GrboxSystem.ChevronSize = 5F;
            GrboxSystem.ChevronThickness = 2F;
            GrboxSystem.ContentPadding = 5;
            GrboxSystem.Controls.Add(label13);
            GrboxSystem.Controls.Add(lblCaseTemp);
            GrboxSystem.Controls.Add(label1);
            GrboxSystem.Controls.Add(label10);
            GrboxSystem.Controls.Add(label2);
            GrboxSystem.Controls.Add(lblTimestamp);
            GrboxSystem.Controls.Add(label3);
            GrboxSystem.Controls.Add(label8);
            GrboxSystem.Controls.Add(label4);
            GrboxSystem.Controls.Add(label5);
            GrboxSystem.Controls.Add(lblVoltage);
            GrboxSystem.Controls.Add(lblNetwork);
            GrboxSystem.Controls.Add(lblCpuTemp);
            GrboxSystem.Controls.Add(lblDisk);
            GrboxSystem.Controls.Add(lblCpuLoad);
            GrboxSystem.Controls.Add(lblRam);
            GrboxSystem.CornerRadius = 15;
            GrboxSystem.EnableBlinking = false;
            GrboxSystem.EnableHoverAnimation = true;
            GrboxSystem.EnableHoverHighlight = true;
            GrboxSystem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GrboxSystem.GradientEndColor = Color.LightGray;
            GrboxSystem.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            GrboxSystem.GradientStartColor = Color.White;
            GrboxSystem.GroupTitle = "";
            GrboxSystem.HoveredBorderColor = Color.Green;
            GrboxSystem.HoveredTitleColor = Color.Black;
            GrboxSystem.IsCollapsible = false;
            GrboxSystem.Location = new Point(21, 59);
            GrboxSystem.MaxBlinkCount = 3;
            GrboxSystem.Name = "GrboxSystem";
            GrboxSystem.PressedBorderColor = Color.FromArgb(0, 84, 153);
            GrboxSystem.ShadowColor = Color.FromArgb(20, 0, 0, 0);
            GrboxSystem.ShadowDepth = 1;
            GrboxSystem.ShowShadow = true;
            GrboxSystem.Size = new Size(423, 398);
            GrboxSystem.SolidFillColor = Color.White;
            GrboxSystem.StatusIcon = null;
            GrboxSystem.StatusText = "";
            GrboxSystem.TabIndex = 30;
            GrboxSystem.TitleBackColor = Color.Transparent;
            GrboxSystem.TitleColor = Color.FromArgb(30, 30, 30);
            GrboxSystem.TitlePadding = new Padding(10, 8, 10, 12);
            GrboxSystem.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft;
            GrboxSystem.UseGradient = false;
            // 
            // FrmSystemHealth
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(463, 588);
            Controls.Add(GrboxSystem);
            Controls.Add(BtnRefresh);
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
        private SiticoneNetCoreUI.SiticoneButtonAdvanced BtnRefresh;
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
        private SiticoneNetCoreUI.SiticoneGroupBox GrboxSystem;
    }
}