namespace LogoDesktopApplication.HelperForms
{
    partial class InfoteksLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoteksLogin));
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogoUser = new ns1.BunifuMaterialTextbox();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.btnLogin = new ns1.BunifuThinButton2();
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse4 = new ns1.BunifuElipse(this.components);
            this.txtLisansKoduText = new ns1.BunifuMaterialTextbox();
            this.bunifuElipse3 = new ns1.BunifuElipse(this.components);
            this.lblBilgiMessage = new ns1.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogoPass = new ns1.BunifuMaterialTextbox();
            this.bunifuElipse5 = new ns1.BunifuElipse(this.components);
            this.logoPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.logoPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 420);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(364, 22);
            this.progressBarControl1.TabIndex = 23;
            this.progressBarControl1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(83)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Infoteks Lisans Kodu :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(83)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Logo Kullanıcı Adı :";
            // 
            // txtLogoUser
            // 
            this.txtLogoUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogoUser.BackColor = System.Drawing.Color.White;
            this.txtLogoUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogoUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogoUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogoUser.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLogoUser.HintText = "Kullanıcı Adı";
            this.txtLogoUser.isPassword = false;
            this.txtLogoUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLogoUser.LineIdleColor = System.Drawing.Color.White;
            this.txtLogoUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLogoUser.LineThickness = 2;
            this.txtLogoUser.Location = new System.Drawing.Point(23, 37);
            this.txtLogoUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogoUser.Name = "txtLogoUser";
            this.txtLogoUser.Size = new System.Drawing.Size(315, 39);
            this.txtLogoUser.TabIndex = 34;
            this.txtLogoUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogoUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvents);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Giriş Yap";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(83, 302);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(196, 46);
            this.btnLogin.TabIndex = 36;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvents);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.txtLogoUser;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 45;
            this.bunifuElipse4.TargetControl = this.progressBarControl1;
            // 
            // txtLisansKoduText
            // 
            this.txtLisansKoduText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLisansKoduText.BackColor = System.Drawing.Color.White;
            this.txtLisansKoduText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLisansKoduText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLisansKoduText.ForeColor = System.Drawing.Color.Black;
            this.txtLisansKoduText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLisansKoduText.HintText = "Lisans Kodunuz";
            this.txtLisansKoduText.isPassword = false;
            this.txtLisansKoduText.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLisansKoduText.LineIdleColor = System.Drawing.Color.White;
            this.txtLisansKoduText.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLisansKoduText.LineThickness = 2;
            this.txtLisansKoduText.Location = new System.Drawing.Point(18, 43);
            this.txtLisansKoduText.Margin = new System.Windows.Forms.Padding(4);
            this.txtLisansKoduText.Name = "txtLisansKoduText";
            this.txtLisansKoduText.Size = new System.Drawing.Size(315, 39);
            this.txtLisansKoduText.TabIndex = 33;
            this.txtLisansKoduText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLisansKoduText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvents);
            this.txtLisansKoduText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLisansKoduText_KeyPress);
            this.txtLisansKoduText.MouseHover += new System.EventHandler(this.MouserHover);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.txtLisansKoduText;
            // 
            // lblBilgiMessage
            // 
            this.lblBilgiMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBilgiMessage.AutoEllipsis = true;
            this.lblBilgiMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBilgiMessage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgiMessage.Location = new System.Drawing.Point(26, 352);
            this.lblBilgiMessage.Name = "lblBilgiMessage";
            this.lblBilgiMessage.Size = new System.Drawing.Size(315, 72);
            this.lblBilgiMessage.TabIndex = 38;
            this.lblBilgiMessage.Text = "Şifrenizi Unuttuysanız\r\n0850 433 1414 nolu müşteri hizmetlerini \r\narayınız!";
            this.lblBilgiMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBilgiMessage.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(83)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Logo Kullanıcı Şifre:";
            // 
            // txtLogoPass
            // 
            this.txtLogoPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogoPass.BackColor = System.Drawing.Color.White;
            this.txtLogoPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogoPass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogoPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogoPass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLogoPass.HintText = "Kullanıcı Şifreniz";
            this.txtLogoPass.isPassword = false;
            this.txtLogoPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLogoPass.LineIdleColor = System.Drawing.Color.White;
            this.txtLogoPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtLogoPass.LineThickness = 2;
            this.txtLogoPass.Location = new System.Drawing.Point(23, 121);
            this.txtLogoPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogoPass.Name = "txtLogoPass";
            this.txtLogoPass.Size = new System.Drawing.Size(315, 39);
            this.txtLogoPass.TabIndex = 35;
            this.txtLogoPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogoPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvents);
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 25;
            this.bunifuElipse5.TargetControl = this.txtLogoPass;
            // 
            // logoPanel
            // 
            this.logoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPanel.Controls.Add(this.label2);
            this.logoPanel.Controls.Add(this.label3);
            this.logoPanel.Controls.Add(this.txtLogoUser);
            this.logoPanel.Controls.Add(this.txtLogoPass);
            this.logoPanel.Location = new System.Drawing.Point(3, 124);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(358, 171);
            this.logoPanel.TabIndex = 40;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.txtLisansKoduText);
            this.infoPanel.Location = new System.Drawing.Point(8, 18);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(353, 100);
            this.infoPanel.TabIndex = 41;
            // 
            // InfoteksLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.lblBilgiMessage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.progressBarControl1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "InfoteksLogin";
            this.Size = new System.Drawing.Size(364, 442);
            this.Load += new System.EventHandler(this.InfoteksLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMaterialTextbox txtLogoUser;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuThinButton2 btnLogin;
        private ns1.BunifuElipse bunifuElipse2;
        private ns1.BunifuElipse bunifuElipse4;
        private ns1.BunifuElipse bunifuElipse3;
        private ns1.BunifuCustomLabel lblBilgiMessage;
        private ns1.BunifuMaterialTextbox txtLisansKoduText;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuMaterialTextbox txtLogoPass;
        private ns1.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel infoPanel;
    }
}
