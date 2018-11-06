namespace LogoDesktopApplication.HelperForms
{
    partial class LogoSenkronForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoSenkronForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSenkronSaat = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnSenkronOnOf = new DevExpress.XtraEditors.CheckButton();
            this.midPanel = new System.Windows.Forms.Panel();
            this.lblSenkronPeriod = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.midPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otomatik Senkron";
            // 
            // lblSenkronSaat
            // 
            this.lblSenkronSaat.AutoSize = true;
            this.lblSenkronSaat.Location = new System.Drawing.Point(56, 47);
            this.lblSenkronSaat.Name = "lblSenkronSaat";
            this.lblSenkronSaat.Size = new System.Drawing.Size(105, 17);
            this.lblSenkronSaat.TabIndex = 1;
            this.lblSenkronSaat.Text = "Senkron Saati :";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnSenkronOnOf);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(422, 68);
            this.topPanel.TabIndex = 3;
            // 
            // btnSenkronOnOf
            // 
            this.btnSenkronOnOf.Checked = true;
            this.btnSenkronOnOf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSenkronOnOf.ImageOptions.Image")));
            this.btnSenkronOnOf.Location = new System.Drawing.Point(173, 13);
            this.btnSenkronOnOf.Name = "btnSenkronOnOf";
            this.btnSenkronOnOf.Size = new System.Drawing.Size(182, 43);
            this.btnSenkronOnOf.TabIndex = 1;
            this.btnSenkronOnOf.Text = "Senkron Açık";
            this.btnSenkronOnOf.Click += new System.EventHandler(this.btnSenkronOnOf_Click);
            // 
            // midPanel
            // 
            this.midPanel.Controls.Add(this.txtPeriod);
            this.midPanel.Controls.Add(this.txtSaat);
            this.midPanel.Controls.Add(this.btnKaydet);
            this.midPanel.Controls.Add(this.btnClose);
            this.midPanel.Controls.Add(this.lblSenkronPeriod);
            this.midPanel.Controls.Add(this.lblSenkronSaat);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 68);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(422, 245);
            this.midPanel.TabIndex = 4;
            // 
            // lblSenkronPeriod
            // 
            this.lblSenkronPeriod.AutoSize = true;
            this.lblSenkronPeriod.Location = new System.Drawing.Point(39, 109);
            this.lblSenkronPeriod.Name = "lblSenkronPeriod";
            this.lblSenkronPeriod.Size = new System.Drawing.Size(122, 17);
            this.lblSenkronPeriod.TabIndex = 2;
            this.lblSenkronPeriod.Text = "Senkron Periodu :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaydet.Image = global::LogoDesktopApplication.Properties.Resources.tick;
            this.btnKaydet.Location = new System.Drawing.Point(251, 157);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 29);
            this.btnKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.TabStop = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Image = global::LogoDesktopApplication.Properties.Resources.backward;
            this.btnClose.Location = new System.Drawing.Point(111, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 22;
            this.btnClose.TabStop = false;
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(187, 44);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(143, 22);
            this.txtSaat.TabIndex = 24;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(187, 109);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(143, 22);
            this.txtPeriod.TabIndex = 25;
            // 
            // LogoSenkronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "LogoSenkronForm";
            this.Size = new System.Drawing.Size(422, 313);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.midPanel.ResumeLayout(false);
            this.midPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSenkronSaat;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Label lblSenkronPeriod;
        private DevExpress.XtraEditors.CheckButton btnSenkronOnOf;
        private System.Windows.Forms.PictureBox btnKaydet;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtSaat;
    }
}
