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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtninfoteksProc = new DevExpress.XtraBars.BarButtonItem();
            this.BtnlogoProc = new DevExpress.XtraBars.BarButtonItem();
            this.btnSenkron = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.btnExcelProcces = new DevExpress.XtraBars.BarButtonItem();
            this.popUpExcel = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnNowSenkron = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.midPanel = new System.Windows.Forms.Panel();
            this.thTimer = new System.Windows.Forms.Timer(this.components);
            this.btnConnectionImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpExcel)).BeginInit();
            this.popUpExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConnectionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtninfoteksProc),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnlogoProc),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSenkron)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // BtninfoteksProc
            // 
            this.BtninfoteksProc.Caption = "Infoteks İşlemleri";
            this.BtninfoteksProc.Id = 1;
            this.BtninfoteksProc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtninfoteksProc.ImageOptions.Image")));
            this.BtninfoteksProc.Name = "BtninfoteksProc";
            this.BtninfoteksProc.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtninfoteksProc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtninfoteksProc_ItemClick);
            // 
            // BtnlogoProc
            // 
            this.BtnlogoProc.Caption = "Ayarlar";
            this.BtnlogoProc.Id = 2;
            this.BtnlogoProc.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.BtnlogoProc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnlogoProc.ImageOptions.Image")));
            this.BtnlogoProc.Name = "BtnlogoProc";
            this.BtnlogoProc.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnlogoProc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnlogoProc_ItemClick);
            // 
            // btnSenkron
            // 
            this.btnSenkron.Caption = "Senkron\r\n";
            this.btnSenkron.Id = 4;
            this.btnSenkron.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSenkron.ImageOptions.Image")));
            this.btnSenkron.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSenkron.ImageOptions.LargeImage")));
            this.btnSenkron.Name = "btnSenkron";
            toolTipTitleItem1.Text = "Senkron";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Hemen Senkrona Başla.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnSenkron.SuperTip = superToolTip1;
            this.btnSenkron.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSenkron_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelProcces)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Tema";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // btnExcelProcces
            // 
            this.btnExcelProcces.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnExcelProcces.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnExcelProcces.Caption = "Excel İslemleri";
            this.btnExcelProcces.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnExcelProcces.DropDownControl = this.popUpExcel;
            this.btnExcelProcces.Id = 8;
            this.btnExcelProcces.Name = "btnExcelProcces";
            this.btnExcelProcces.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // popUpExcel
            // 
            this.popUpExcel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popUpExcel.Controls.Add(this.simpleButton1);
            this.popUpExcel.Location = new System.Drawing.Point(248, 315);
            this.popUpExcel.Manager = this.barManager1;
            this.popUpExcel.Name = "popUpExcel";
            this.popUpExcel.Size = new System.Drawing.Size(250, 130);
            this.popUpExcel.TabIndex = 0;
            this.popUpExcel.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(38, 37);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(420, 70);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 306);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(420, 36);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 70);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 236);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(420, 70);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 236);
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
            toolTipTitleItem2.Text = "Senkron";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Senkron İşlemine Başlar";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnNowSenkron.SuperTip = superToolTip2;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
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
            this.barButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem2.Caption = "Excel İslemleri";
            this.barButtonItem2.DropDownControl = this.popUpExcel;
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // midPanel
            // 
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 70);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(420, 236);
            this.midPanel.TabIndex = 4;
            // 
            // thTimer
            // 
            this.thTimer.Tick += new System.EventHandler(this.thTimer_Tick);
            // 
            // btnConnectionImage
            // 
            this.btnConnectionImage.Image = global::LogoDesktopApplication.Properties.Resources.closed;
            this.btnConnectionImage.Location = new System.Drawing.Point(384, 315);
            this.btnConnectionImage.Name = "btnConnectionImage";
            this.btnConnectionImage.Size = new System.Drawing.Size(38, 22);
            this.btnConnectionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConnectionImage.TabIndex = 0;
            this.btnConnectionImage.TabStop = false;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 342);
            this.Controls.Add(this.popUpExcel);
            this.Controls.Add(this.btnConnectionImage);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForm";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpExcel)).EndInit();
            this.popUpExcel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConnectionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
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
        private DevExpress.XtraBars.PopupControlContainer popUpExcel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btnExcelProcces;
    }
}