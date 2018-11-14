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
            this.txtFirmaToken = new ns1.BunifuMaterialTextbox();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.btnLogin = new ns1.BunifuThinButton2();
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse4 = new ns1.BunifuElipse(this.components);
            this.txtFirmaKodu = new ns1.BunifuMaterialTextbox();
            this.bunifuElipse3 = new ns1.BunifuElipse(this.components);
            this.lblBilgiMessage = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(83)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(22, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Firma Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(83)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(22, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Firma Token:";
            // 
            // txtFirmaToken
            // 
            this.txtFirmaToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmaToken.BackColor = System.Drawing.Color.White;
            this.txtFirmaToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirmaToken.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirmaToken.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtFirmaToken.HintText = "Firma Token";
            this.txtFirmaToken.isPassword = false;
            this.txtFirmaToken.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtFirmaToken.LineIdleColor = System.Drawing.Color.White;
            this.txtFirmaToken.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtFirmaToken.LineThickness = 2;
            this.txtFirmaToken.Location = new System.Drawing.Point(26, 220);
            this.txtFirmaToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirmaToken.Name = "txtFirmaToken";
            this.txtFirmaToken.Size = new System.Drawing.Size(315, 39);
            this.txtFirmaToken.TabIndex = 33;
            this.txtFirmaToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnLogin.Location = new System.Drawing.Point(83, 281);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(196, 46);
            this.btnLogin.TabIndex = 35;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.txtFirmaToken;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 45;
            this.bunifuElipse4.TargetControl = this.progressBarControl1;
            // 
            // txtFirmaKodu
            // 
            this.txtFirmaKodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmaKodu.BackColor = System.Drawing.Color.White;
            this.txtFirmaKodu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirmaKodu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirmaKodu.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtFirmaKodu.HintText = "Firma Kodu";
            this.txtFirmaKodu.isPassword = false;
            this.txtFirmaKodu.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtFirmaKodu.LineIdleColor = System.Drawing.Color.White;
            this.txtFirmaKodu.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtFirmaKodu.LineThickness = 2;
            this.txtFirmaKodu.Location = new System.Drawing.Point(26, 128);
            this.txtFirmaKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirmaKodu.Name = "txtFirmaKodu";
            this.txtFirmaKodu.Size = new System.Drawing.Size(315, 39);
            this.txtFirmaKodu.TabIndex = 36;
            this.txtFirmaKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.txtFirmaKodu;
            // 
            // lblBilgiMessage
            // 
            this.lblBilgiMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBilgiMessage.AutoEllipsis = true;
            this.lblBilgiMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBilgiMessage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgiMessage.Location = new System.Drawing.Point(26, 331);
            this.lblBilgiMessage.Name = "lblBilgiMessage";
            this.lblBilgiMessage.Size = new System.Drawing.Size(315, 72);
            this.lblBilgiMessage.TabIndex = 38;
            this.lblBilgiMessage.Text = "Şifrenizi Unuttuysanız\r\n0850 433 1414 nolu müşteri hizmetlerini \r\narayınız!";
            this.lblBilgiMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBilgiMessage.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // InfoteksLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblBilgiMessage);
            this.Controls.Add(this.txtFirmaKodu);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirmaToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarControl1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "InfoteksLogin";
            this.Size = new System.Drawing.Size(364, 442);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMaterialTextbox txtFirmaToken;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuThinButton2 btnLogin;
        private ns1.BunifuElipse bunifuElipse2;
        private ns1.BunifuElipse bunifuElipse4;
        private ns1.BunifuElipse bunifuElipse3;
        private ns1.BunifuCustomLabel lblBilgiMessage;
        private ns1.BunifuMaterialTextbox txtFirmaKodu;
    }
}
