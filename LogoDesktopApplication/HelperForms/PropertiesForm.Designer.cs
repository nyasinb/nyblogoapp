namespace LogoDesktopApplication.HelperForms
{
    partial class PropertiesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesForm));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.midPanel = new System.Windows.Forms.Panel();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnManuelSenkron = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.otoSyncProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSenkronBilgisi = new ns1.BunifuCustomLabel();
            this.chckBoxSenkronType = new ns1.BunifuCheckbox();
            this.comboPeriod = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblsenkronSaat = new ns1.BunifuCustomLabel();
            this.lblSenkronPeriod = new ns1.BunifuCustomLabel();
            this.btnSenkronOnOff = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.btnLogout = new ns1.BunifuThinButton2();
            this.bunifuElipse3 = new ns1.BunifuElipse(this.components);
            this.midPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnManuelSenkron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoSyncProgress.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSenkronOnOff)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this.midPanel;
            // 
            // midPanel
            // 
            this.midPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("midPanel.BackgroundImage")));
            this.midPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.midPanel.Controls.Add(this.btnLogout);
            this.midPanel.Controls.Add(this.BtnKaydet);
            this.midPanel.Controls.Add(this.btnManuelSenkron);
            this.midPanel.Controls.Add(this.bunifuCustomLabel1);
            this.midPanel.Controls.Add(this.otoSyncProgress);
            this.midPanel.Controls.Add(this.panel2);
            this.midPanel.Controls.Add(this.btnSenkronOnOff);
            this.midPanel.Controls.Add(this.bunifuCustomLabel4);
            this.midPanel.Controls.Add(this.bunifuCustomLabel2);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 0);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(356, 475);
            this.midPanel.TabIndex = 0;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.BtnKaydet.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.BtnKaydet.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.BtnKaydet.Appearance.Options.UseBackColor = true;
            this.BtnKaydet.Appearance.Options.UseBorderColor = true;
            this.BtnKaydet.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.BtnKaydet.AppearanceDisabled.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.BtnKaydet.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.BtnKaydet.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnKaydet.AppearanceDisabled.Options.UseBorderColor = true;
            this.BtnKaydet.Location = new System.Drawing.Point(271, 162);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(60, 35);
            this.BtnKaydet.TabIndex = 30;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.ToolTipTitle = "Ayarları Kayıt Et";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnManuelSenkron
            // 
            this.btnManuelSenkron.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManuelSenkron.BackColor = System.Drawing.Color.Transparent;
            this.btnManuelSenkron.Image = global::LogoDesktopApplication.Properties.Resources.gprsoff;
            this.btnManuelSenkron.Location = new System.Drawing.Point(229, 108);
            this.btnManuelSenkron.Name = "btnManuelSenkron";
            this.btnManuelSenkron.Size = new System.Drawing.Size(36, 29);
            this.btnManuelSenkron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnManuelSenkron.TabIndex = 3;
            this.btnManuelSenkron.TabStop = false;
            this.btnManuelSenkron.Click += new System.EventHandler(this.btnManuelSenkron_Click);
            this.btnManuelSenkron.MouseLeave += new System.EventHandler(this.HoverLeaveColor);
            this.btnManuelSenkron.MouseHover += new System.EventHandler(this.HoverColorPing);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(96, 70);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(169, 19);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "SENKRON İŞLEMLERİ";
            // 
            // otoSyncProgress
            // 
            this.otoSyncProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.otoSyncProgress.Location = new System.Drawing.Point(0, 457);
            this.otoSyncProgress.Name = "otoSyncProgress";
            this.otoSyncProgress.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.otoSyncProgress.Size = new System.Drawing.Size(356, 18);
            this.otoSyncProgress.TabIndex = 29;
            this.otoSyncProgress.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblSenkronBilgisi);
            this.panel2.Controls.Add(this.chckBoxSenkronType);
            this.panel2.Controls.Add(this.comboPeriod);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblsenkronSaat);
            this.panel2.Controls.Add(this.lblSenkronPeriod);
            this.panel2.Location = new System.Drawing.Point(27, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 145);
            this.panel2.TabIndex = 6;
            // 
            // lblSenkronBilgisi
            // 
            this.lblSenkronBilgisi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSenkronBilgisi.AutoSize = true;
            this.lblSenkronBilgisi.BackColor = System.Drawing.Color.Transparent;
            this.lblSenkronBilgisi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenkronBilgisi.ForeColor = System.Drawing.Color.Black;
            this.lblSenkronBilgisi.Location = new System.Drawing.Point(33, 105);
            this.lblSenkronBilgisi.Name = "lblSenkronBilgisi";
            this.lblSenkronBilgisi.Size = new System.Drawing.Size(158, 20);
            this.lblSenkronBilgisi.TabIndex = 27;
            this.lblSenkronBilgisi.Text = "Senkron Saati Seçiniz";
            this.lblSenkronBilgisi.Click += new System.EventHandler(this.chckBoxSenkronType_OnChange);
            // 
            // chckBoxSenkronType
            // 
            this.chckBoxSenkronType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.chckBoxSenkronType.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.chckBoxSenkronType.Checked = true;
            this.chckBoxSenkronType.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.chckBoxSenkronType.ForeColor = System.Drawing.Color.White;
            this.chckBoxSenkronType.Location = new System.Drawing.Point(6, 105);
            this.chckBoxSenkronType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chckBoxSenkronType.Name = "chckBoxSenkronType";
            this.chckBoxSenkronType.Size = new System.Drawing.Size(20, 20);
            this.chckBoxSenkronType.TabIndex = 7;
            this.chckBoxSenkronType.Tag = "";
            this.chckBoxSenkronType.OnChange += new System.EventHandler(this.chckBoxSenkronType_OnChange);
            // 
            // comboPeriod
            // 
            this.comboPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPeriod.FormattingEnabled = true;
            this.comboPeriod.Items.AddRange(new object[] {
            "5 DK",
            "10 DK",
            "20 DK",
            "30 DK",
            "40 DK",
            "50 DK"});
            this.comboPeriod.Location = new System.Drawing.Point(156, 65);
            this.comboPeriod.Name = "comboPeriod";
            this.comboPeriod.Size = new System.Drawing.Size(132, 24);
            this.comboPeriod.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "H:mm";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2018, 11, 13, 18, 39, 0, 0);
            // 
            // lblsenkronSaat
            // 
            this.lblsenkronSaat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblsenkronSaat.AutoSize = true;
            this.lblsenkronSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblsenkronSaat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsenkronSaat.ForeColor = System.Drawing.Color.White;
            this.lblsenkronSaat.Location = new System.Drawing.Point(32, 21);
            this.lblsenkronSaat.Name = "lblsenkronSaat";
            this.lblsenkronSaat.Size = new System.Drawing.Size(112, 18);
            this.lblsenkronSaat.TabIndex = 6;
            this.lblsenkronSaat.Text = "Senkron Saati:";
            // 
            // lblSenkronPeriod
            // 
            this.lblSenkronPeriod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSenkronPeriod.AutoSize = true;
            this.lblSenkronPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblSenkronPeriod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenkronPeriod.ForeColor = System.Drawing.Color.White;
            this.lblSenkronPeriod.Location = new System.Drawing.Point(3, 66);
            this.lblSenkronPeriod.Name = "lblSenkronPeriod";
            this.lblSenkronPeriod.Size = new System.Drawing.Size(141, 18);
            this.lblSenkronPeriod.TabIndex = 5;
            this.lblSenkronPeriod.Text = "Senkron Periyodu:";
            // 
            // btnSenkronOnOff
            // 
            this.btnSenkronOnOff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSenkronOnOff.BackColor = System.Drawing.Color.Transparent;
            this.btnSenkronOnOff.Image = global::LogoDesktopApplication.Properties.Resources.ofswitch;
            this.btnSenkronOnOff.Location = new System.Drawing.Point(189, 162);
            this.btnSenkronOnOff.Name = "btnSenkronOnOff";
            this.btnSenkronOnOff.Size = new System.Drawing.Size(76, 35);
            this.btnSenkronOnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSenkronOnOff.TabIndex = 5;
            this.btnSenkronOnOff.TabStop = false;
            this.btnSenkronOnOff.Click += new System.EventHandler(this.btnSenkronOnOff_Click);
            this.btnSenkronOnOff.MouseLeave += new System.EventHandler(this.HoverLeaveColor);
            this.btnSenkronOnOff.MouseHover += new System.EventHandler(this.HoverColorPing);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(22, 168);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(148, 18);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Otomatik Senkron :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(24, 113);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(183, 18);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Manuel Senkron Başlat :";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 45;
            this.bunifuElipse2.TargetControl = this;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveBorderThickness = 1;
            this.btnLogout.ActiveCornerRadius = 20;
            this.btnLogout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.btnLogout.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogout.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.ButtonText = "Oturumu Sonlandır";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleCornerRadius = 20;
            this.btnLogout.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogout.IdleForecolor = System.Drawing.Color.White;
            this.btnLogout.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogout.Location = new System.Drawing.Point(81, 365);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(216, 37);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.btnLogout;
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.midPanel);
            this.Name = "PropertiesForm";
            this.Size = new System.Drawing.Size(356, 475);
            this.Load += new System.EventHandler(this.PropertiesForm_Load);
            this.midPanel.ResumeLayout(false);
            this.midPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnManuelSenkron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoSyncProgress.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSenkronOnOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.PictureBox btnManuelSenkron;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox btnSenkronOnOff;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuCustomLabel lblsenkronSaat;
        private ns1.BunifuCustomLabel lblSenkronPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboPeriod;
        private ns1.BunifuCustomLabel lblSenkronBilgisi;
        private ns1.BunifuCheckbox chckBoxSenkronType;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuElipse bunifuElipse2;
        private DevExpress.XtraEditors.ProgressBarControl otoSyncProgress;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private ns1.BunifuThinButton2 btnLogout;
        private ns1.BunifuElipse bunifuElipse3;
    }
}
