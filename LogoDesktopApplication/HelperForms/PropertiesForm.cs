using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LogoDesktopApplication.WS_Class;
using LogoDesktopApplication.LOGO_Class;

namespace LogoDesktopApplication.HelperForms
{
    public partial class PropertiesForm : UserControl
    {
        Serializer _ser;
        XmlProvider _xmlProv;
        OtoSenkron item;
        DialogResult dr;
        WSProvider _ws;
        kdSalesReceiptDataAllCevap kdSalesReceiptData;
        public bool senkronType { get; set; }
        CreatedQuery _CreatedQuery;
        LogoProviderClass _logoProvider;
        kdAcquirerInfoCevap _acquir;
        public PropertiesForm()
        {
            InitializeComponent();
            _acquir = new kdAcquirerInfoCevap();
            _logoProvider = new LogoProviderClass();
            kdSalesReceiptData = new kdSalesReceiptDataAllCevap();
            _CreatedQuery = new CreatedQuery();
            item = new OtoSenkron();
            _xmlProv = new XmlProvider();
            _ws = new WSProvider();
            OpenMenu();
        }

        private void chckBoxSenkronType_OnChange(object sender, EventArgs e)
        {
            if (chckBoxSenkronType.Checked)
            {
                lblSenkronBilgisi.Text = "Senkron Saati Seçiniz";
                dateTimePicker1.Enabled = true;
                comboPeriod.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                comboPeriod.Enabled = true;
                lblSenkronBilgisi.Text = "Senkron Periyodu Seçiniz";            
            }
        }

        int i = 1;
        private void btnSenkronOnOff_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                btnSenkronOnOff.Image = global::LogoDesktopApplication.Properties.Resources.ofswitch;
                panel2.Visible = false;
            }
            else
            {
                btnSenkronOnOff.Image = global::LogoDesktopApplication.Properties.Resources.onswitch;
                panel2.Visible = true;
            }
            i++;
        }

        void OpenMenu()
        {
            comboPeriod.SelectedIndex = 0;
            if (!File.Exists("CFG\\Config.xml"))
            {
                _xmlProv.XmlWriterMethod(item);
            }

            item = _xmlProv.XmlRead();

            if (item.Durum == "0" || item.Durum=="False")
            {
                panel2.Visible = false;
                btnSenkronOnOff.Image = global::LogoDesktopApplication.Properties.Resources.ofswitch;
            }

            else
            {
                panel2.Visible = true;
                chckBoxSenkronType.Visible = true;
                btnSenkronOnOff.Image = global::LogoDesktopApplication.Properties.Resources.onswitch;
            }
            if (item.SenkronType == 1)//1 ise aktif.yani saat
            {
                chckBoxSenkronType.Checked = true;
                lblSenkronBilgisi.Text = "Senkron Saati Seçiniz";
                dateTimePicker1.Enabled = true;
                comboPeriod.Enabled = false;
            }
            else// değilse, period
            {
                dateTimePicker1.Enabled = false;
                comboPeriod.Enabled = true;
                chckBoxSenkronType.Checked = false;
                lblSenkronBilgisi.Text = "Senkron Periyodu Seçiniz";
            }
        }

        public bool NetworkControl()
        {
            try
            {
                System.Net.Sockets.TcpClient png = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                png.Close();
                //BglntDurmuLabel.Text = "İnternet Bağlantısı Aktif";
                return true;
            }
            catch (Exception)
            {
                //BglntDurmuLabel.Text = "İnternet Bağlantısı Pasif";
                return false;
            }
        }

        private void PropertiesForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string WriteResult = "";
            OtoSenkron s = _xmlProv.XmlRead();
            if (i%2==0)
            {
                s.Durum = "True";
            }
            else
            {
                s.Durum = "False";
            }
            if (s.Durum == "false" || s.Durum == "False")
            {
                s.Saat = "0";
                s.Period = "0";
                s.SenkronType = 0;
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                    this,
                    "Oto Senkron Kapatılıyor",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                s.Durum = "False";
                WriteResult = _xmlProv.XmlWriterMethod(s);
            }
            else
            {
                if (chckBoxSenkronType.Checked)
                {
                    s.SenkronType = 1;
                    s.Saat = String.Format("{0:t}", dateTimePicker1.Value);
                    dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                    this,
                    "Saat: " + s.Saat + "'de Otomatik Senkron Yapılacaktır\nBilgisayarınız Açık Olmalı ve\nİnternet Bağlantısı Olması Gerekmektedir.",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    s.Period = comboPeriod.SelectedItem.ToString();
                    s.SenkronType = 0;
                    dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                    this,
                    s.Period + "'dk aralıklar ile\nSenkron yapılacaktır\nBilgisayarınız açık olmalı ve\nİnternet bağlantısı olması gerekmektedir.",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                s.Durum = "True";
            }
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                s.InfoLoginState = "True";
                WriteResult = _xmlProv.XmlWriterMethod(s);
                if (WriteResult == "0")
                {
                    dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                    this,
                    "İş emriniz alınmıştır.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            item = _xmlProv.XmlRead();
            item.InfoLoginState = "False";
            item.LogoLoginState = "False";
            _xmlProv.XmlWriterMethod(item);
            dr = DevExpress.XtraEditors.XtraMessageBox.Show(
            this,
            "Uygulamanız Yeniden Başlatılacaktır, Lütfen Tekrar Başlatınız.",
            "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr==DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnManuelSenkron_Click(object sender, EventArgs e)
        {
            if (NetworkControl())
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(null, typeof(waitForm));

                btnManuelSenkron.Enabled = false;
                otoSyncProgress.Visible = true;

                _acquir = _ws.Query_Method_kdAcquirerInfo();
                string Result = _logoProvider.bankCreat(_acquir);
                System.Threading.Thread.Sleep(500);


                item = _xmlProv.XmlRead();
                kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData(_CreatedQuery.CREATE_kdSalesReceiptAllData(item));
                if (kdSalesReceiptData.cevapKodu != "000")
                {
                    dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                    this,
                    "Senkron Yapılamaz.\n" + kdSalesReceiptData.cevapAciklama + "\nLütfen Infoteks ile iletişime geçiniz",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                for (int i = 0; i < kdSalesReceiptData.salesData.Count; i++)
                {
                    _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);
                }
                otoSyncProgress.Visible = false;
                btnManuelSenkron.Enabled = true;
                DevExpress.XtraSplashScreen.AboutSplashScreenManager.CloseForm(false, 0, null);

            }
            else
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                this,
                "Senkron Yapılamaz.\nInternet bağlantınızı kontrol ediniz ve tekrar deneyiniz",
                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void HoverLeaveColor(object sender,EventArgs e)
        {
            ToolTip tt = new ToolTip();
            string pictureBoxName = ((PictureBox)sender).Name;
            if (pictureBoxName == "btnManuelSenkron")
            {
                btnManuelSenkron.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            else if (pictureBoxName == "btnSenkronOnOff")
            {
                btnSenkronOnOff.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            else if (pictureBoxName == "BtnKaydet")
            {
                BtnKaydet.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            else if (pictureBoxName == "btnLogout")
            {
                btnLogout.BackColor = System.Drawing.Color.Transparent;
                return;
            }
        }
        void HoverColorPing(object sender,EventArgs e)
        {
            ToolTip tt = new ToolTip();
            string pictureBoxName = ((PictureBox)sender).Name;
            
            if (pictureBoxName == "btnManuelSenkron")
            {
                tt.SetToolTip(this.btnManuelSenkron, "Otomatik Senkron Ayarlarını Göster");
                btnManuelSenkron.BackColor = System.Drawing.Color.FromArgb(197, 141, 214);
                return;
            }
            else if (pictureBoxName == "btnSenkronOnOff")
            {
                tt.SetToolTip(this.btnSenkronOnOff, "Otomatik Senkron Ayarlarını Göster");
                btnSenkronOnOff.BackColor = System.Drawing.Color.FromArgb(197, 141, 214);
                return;
            }
            else if (pictureBoxName == "BtnKaydet")
            {
                tt.SetToolTip(this.BtnKaydet, "Ayarları Kayıt Et");
                BtnKaydet.BackColor = System.Drawing.Color.FromArgb(197, 141, 214);
                return;
            }
            else if (pictureBoxName == "btnLogout")
            {
                tt.SetToolTip(this.btnLogout, "Farklı bir kullanıcıya geçmek için kullanılır...");
                btnLogout.BackColor = System.Drawing.Color.FromArgb(197, 141, 214);
                return;
            }
            
        }
    }
}
