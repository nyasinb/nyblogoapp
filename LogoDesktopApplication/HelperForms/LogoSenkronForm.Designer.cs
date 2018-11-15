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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboPeriod = new System.Windows.Forms.ComboBox();
            this.lblSenkronPeriod = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.chckBoxSenkronType = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.midPanel.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).BeginInit();
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
            this.lblSenkronSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenkronSaat.AutoSize = true;
            this.lblSenkronSaat.Location = new System.Drawing.Point(55, 173);
            this.lblSenkronSaat.Name = "lblSenkronSaat";
            this.lblSenkronSaat.Size = new System.Drawing.Size(105, 17);
            this.lblSenkronSaat.TabIndex = 1;
            this.lblSenkronSaat.Text = "Senkron Saati :";
            this.lblSenkronSaat.Visible = false;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnSenkronOnOf);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(527, 68);
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
            this.btnSenkronOnOf.CheckedChanged += new System.EventHandler(this.btnSenkronOnOf_CheckedChanged);
            this.btnSenkronOnOf.Click += new System.EventHandler(this.btnSenkronOnOf_Click);
            // 
            // midPanel
            // 
            this.midPanel.Controls.Add(this.dateTimePicker1);
            this.midPanel.Controls.Add(this.comboPeriod);
            this.midPanel.Controls.Add(this.lblSenkronPeriod);
            this.midPanel.Controls.Add(this.lblSenkronSaat);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 68);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(527, 496);
            this.midPanel.TabIndex = 4;
            this.midPanel.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "H:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Visible = false;
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
            this.comboPeriod.Location = new System.Drawing.Point(212, 221);
            this.comboPeriod.Name = "comboPeriod";
            this.comboPeriod.Size = new System.Drawing.Size(248, 24);
            this.comboPeriod.TabIndex = 25;
            this.comboPeriod.Visible = false;
            // 
            // lblSenkronPeriod
            // 
            this.lblSenkronPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenkronPeriod.AutoSize = true;
            this.lblSenkronPeriod.Location = new System.Drawing.Point(38, 221);
            this.lblSenkronPeriod.Name = "lblSenkronPeriod";
            this.lblSenkronPeriod.Size = new System.Drawing.Size(122, 17);
            this.lblSenkronPeriod.TabIndex = 2;
            this.lblSenkronPeriod.Text = "Senkron Periodu :";
            this.lblSenkronPeriod.Visible = false;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.chckBoxSenkronType);
            this.panelBottom.Controls.Add(this.btnKaydet);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 493);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(527, 71);
            this.panelBottom.TabIndex = 5;
            // 
            // chckBoxSenkronType
            // 
            this.chckBoxSenkronType.AutoSize = true;
            this.chckBoxSenkronType.Location = new System.Drawing.Point(33, 21);
            this.chckBoxSenkronType.Name = "chckBoxSenkronType";
            this.chckBoxSenkronType.Size = new System.Drawing.Size(18, 17);
            this.chckBoxSenkronType.TabIndex = 28;
            this.chckBoxSenkronType.UseVisualStyleBackColor = true;
            this.chckBoxSenkronType.Click += new System.EventHandler(this.chckBoxSenkronType_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            //this.btnKaydet.Image = global::LogoDesktopApplication.Properties.Resources.tick;
            this.btnKaydet.Location = new System.Drawing.Point(369, 21);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 29);
            this.btnKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKaydet.TabIndex = 27;
            this.btnKaydet.TabStop = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // LogoSenkronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "LogoSenkronForm";
            this.Size = new System.Drawing.Size(527, 564);
            this.Load += new System.EventHandler(this.LogoSenkronForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.midPanel.ResumeLayout(false);
            this.midPanel.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSenkronSaat;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblSenkronPeriod;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox btnKaydet;
        public DevExpress.XtraEditors.CheckButton btnSenkronOnOf;
        public System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.CheckBox chckBoxSenkronType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboPeriod;
    }
}
