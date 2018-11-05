namespace LogoDesktopApplication
{
    partial class Form1
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
            this.btnHavuzCari = new DevExpress.XtraEditors.SimpleButton();
            this.btnTransferVoucher = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnHavuzCari
            // 
            this.btnHavuzCari.Location = new System.Drawing.Point(76, 91);
            this.btnHavuzCari.Name = "btnHavuzCari";
            this.btnHavuzCari.Size = new System.Drawing.Size(224, 43);
            this.btnHavuzCari.TabIndex = 0;
            this.btnHavuzCari.Text = "Havuz Cari Oluştur";
            this.btnHavuzCari.Click += new System.EventHandler(this.btnHavuzCari_Click);
            // 
            // btnTransferVoucher
            // 
            this.btnTransferVoucher.Location = new System.Drawing.Point(76, 154);
            this.btnTransferVoucher.Name = "btnTransferVoucher";
            this.btnTransferVoucher.Size = new System.Drawing.Size(224, 43);
            this.btnTransferVoucher.TabIndex = 1;
            this.btnTransferVoucher.Text = "Fişleri Aktar";
            this.btnTransferVoucher.Click += new System.EventHandler(this.btnTransferVoucher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 617);
            this.Controls.Add(this.btnTransferVoucher);
            this.Controls.Add(this.btnHavuzCari);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHavuzCari;
        private DevExpress.XtraEditors.SimpleButton btnTransferVoucher;
    }
}

