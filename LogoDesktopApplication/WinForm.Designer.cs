
namespace LogoDesktopApplication
{
    partial class WinForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.BtninfoteksProc = new DevExpress.XtraBars.BarButtonItem();
            this.BtnlogoProc = new DevExpress.XtraBars.BarButtonItem();
            this.btnNowSenkron = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnSenkron = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelProcces = new DevExpress.XtraBars.BarButtonItem();
            this.midPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.PictureBox();
            this.btnConnectionImage = new System.Windows.Forms.PictureBox();
            this.thTimer = new System.Windows.Forms.Timer(this.components);
            this.backGorundProc = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConnectionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.BtninfoteksProc,
            this.BtnlogoProc,
            this.btnNowSenkron,
            this.btnSenkron,
            this.barButtonItem1,
            this.barEditItem1,
            this.barButtonItem2,
            this.btnExcelProcces});
            this.barManager1.MaxItemId = 13;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(370, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 445);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(370, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 445);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(370, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 445);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Tema";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // BtninfoteksProc
            // 
            this.BtninfoteksProc.Id = 9;
            this.BtninfoteksProc.Name = "BtninfoteksProc";
            // 
            // BtnlogoProc
            // 
            this.BtnlogoProc.Id = 10;
            this.BtnlogoProc.Name = "BtnlogoProc";
            // 
            // btnNowSenkron
            // 
            this.btnNowSenkron.Caption = "btnNotSenkron";
            this.btnNowSenkron.Edit = this.repositoryItemPictureEdit1;
            this.btnNowSenkron.Id = 3;
            this.btnNowSenkron.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNowSenkron.ImageOptions.Image")));
            this.btnNowSenkron.ImageOptions.ImageUri.Uri = "Refresh;Size32x32;Office2013";
            this.btnNowSenkron.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNowSenkron.ImageOptions.LargeImage")));
            this.btnNowSenkron.Name = "btnNowSenkron";
            this.btnNowSenkron.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            toolTipTitleItem1.Text = "Senkron";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Senkron İşlemine Başlar";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnNowSenkron.SuperTip = superToolTip1;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // btnSenkron
            // 
            this.btnSenkron.Caption = "Senkron\r\n";
            this.btnSenkron.Id = 4;
            this.btnSenkron.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSenkron.ImageOptions.Image")));
            this.btnSenkron.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSenkron.ImageOptions.LargeImage")));
            this.btnSenkron.Name = "btnSenkron";
            toolTipTitleItem2.Text = "Senkron";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Hemen Senkrona Başla.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnSenkron.SuperTip = superToolTip2;
            this.btnSenkron.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSenkron_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 6;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnExcelProcces
            // 
            this.btnExcelProcces.Id = 12;
            this.btnExcelProcces.Name = "btnExcelProcces";
            // 
            // midPanel
            // 
            this.midPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("midPanel.BackgroundImage")));
            this.midPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 0);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(370, 445);
            this.midPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseApp);
            this.panel1.Controls.Add(this.btnConnectionImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 36);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHide.Image = global::LogoDesktopApplication.Properties.Resources.minimizeicon;
            this.btnHide.Location = new System.Drawing.Point(285, 8);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(31, 24);
            this.btnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHide.TabIndex = 1;
            this.btnHide.TabStop = false;
            this.btnHide.Tag = "";
            this.btnHide.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnHide.MouseHover += new System.EventHandler(this.btnConnectionImage_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(148, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "INFOTEKS";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseApp.Image = global::LogoDesktopApplication.Properties.Resources.closedicon;
            this.btnCloseApp.Location = new System.Drawing.Point(322, 8);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(31, 24);
            this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseApp.TabIndex = 2;
            this.btnCloseApp.TabStop = false;
            this.btnCloseApp.Tag = "";
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            this.btnCloseApp.MouseHover += new System.EventHandler(this.btnConnectionImage_MouseHover);
            // 
            // btnConnectionImage
            // 
            this.btnConnectionImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnectionImage.Image = global::LogoDesktopApplication.Properties.Resources.gprsoff1;
            this.btnConnectionImage.Location = new System.Drawing.Point(250, 8);
            this.btnConnectionImage.Name = "btnConnectionImage";
            this.btnConnectionImage.Size = new System.Drawing.Size(31, 24);
            this.btnConnectionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConnectionImage.TabIndex = 0;
            this.btnConnectionImage.TabStop = false;
            this.btnConnectionImage.Tag = "";
            this.btnConnectionImage.MouseHover += new System.EventHandler(this.btnConnectionImage_MouseHover);
            // 
            // thTimer
            // 
            this.thTimer.Tick += new System.EventHandler(this.thTimer_Tick);
            // 
            // backGorundProc
            // 
            this.backGorundProc.WorkerReportsProgress = true;
            this.backGorundProc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backGorundProc_DoWork);
            this.backGorundProc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backGorundProc_RunWorkerCompleted);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // WinForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(370, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HtmlText = "INFOTEKS";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConnectionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BtninfoteksProc;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarButtonItem BtnlogoProc;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Timer thTimer;
        private System.Windows.Forms.PictureBox btnConnectionImage;
        private DevExpress.XtraBars.BarEditItem btnNowSenkron;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.BarButtonItem btnSenkron;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btnExcelProcces;
        private System.ComponentModel.BackgroundWorker backGorundProc;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCloseApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHide;
    }
}