using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace LogoDesktopApplication.HelperForms
{
    public partial class LogoSenkronForm : UserControl
    {
        Serializer _ser;
        XmlProvider _xmlProv;
        OtoSenkron item;
        DialogResult dr;
        public bool senkronType { get; set; }
        public LogoSenkronForm()
        {
            InitializeComponent();
            _ser = new Serializer();
            item = new OtoSenkron();
            _xmlProv = new XmlProvider();

        }





        private void btnSenkronOnOf_Click(object sender, EventArgs e)
        {
            if (btnSenkronOnOf.Checked)
            {
                btnSenkronOnOf.Text = "Senkron Kapalı";
                midPanel.Visible = false;
                btnSenkronOnOf.ImageOptions.Image = global::LogoDesktopApplication.Properties.Resources.Toggle_Off_40;
                chckBoxSenkronType.Visible = false;
            }
            else
            {
                btnSenkronOnOf.ImageOptions.Image = global::LogoDesktopApplication.Properties.Resources.Toggle_On_40;
                btnSenkronOnOf.Text = "Senkron Açık";
                midPanel.Visible = true;
                chckBoxSenkronType.Visible = true;

                if (item.SenkronType == 1)//1 ise aktif.
                {
                    chckBoxSenkronType.Checked = true;
                }
                else
                    chckBoxSenkronType.Checked = false;

                SenkronTypeSettings();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string WriteResult = "";
            OtoSenkron s = new OtoSenkron();
            s.Durum = btnSenkronOnOf.Checked.ToString();
            if (s.Durum == "false" || s.Durum == "False")
            {
                s.Saat = "0";
                s.Period = "0";
                s.SenkronType = 0;
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                    this,
                    "Oto Senkron Kapatılıyor",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                    "Saat: "+s.Saat+"'de Otomatik Senkron Yapılacaktır\nBilgisayarınız Açık Olmalı ve\nİnternet Bağlantısı Olması Gerekmektedir.",
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
            }
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
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

        void OpenMenu()
        {
            comboPeriod.SelectedIndex = 0;
            if (File.Exists("CFG\\Config.xml"))
            {
                item = _xmlProv.XmlRead();
            }
            else
                _xmlProv.XmlWriterMethod(item);

            item = _xmlProv.XmlRead();

            if (item.Durum == "0")
            {
                btnSenkronOnOf.ImageOptions.Image = global::LogoDesktopApplication.Properties.Resources.Toggle_Off_40;
                midPanel.Visible = false;
                btnSenkronOnOf.Checked = false;
                chckBoxSenkronType.Checked = true;
                chckBoxSenkronType.Visible = false;
                SenkronTypeSettings();
                return;
            }

            if (item.Durum == "False")
            {
                btnSenkronOnOf.Checked = false;
                btnSenkronOnOf.ImageOptions.Image = global::LogoDesktopApplication.Properties.Resources.Toggle_Off_40;
                midPanel.Visible = false;
                chckBoxSenkronType.Visible = false;
            }
            else
            {
                btnSenkronOnOf.Checked = true;
                btnSenkronOnOf.ImageOptions.Image = global::LogoDesktopApplication.Properties.Resources.Toggle_On_40;
                midPanel.Visible = true;
                chckBoxSenkronType.Visible = true;

                if (item.SenkronType == 1)//1 ise aktif.yani saat
                {
                    chckBoxSenkronType.Checked = true;
                }
                else // değilse, period
                    chckBoxSenkronType.Checked = false;

                SenkronTypeSettings();

            }
        }


        private void LogoSenkronForm_Load(object sender, EventArgs e)
        {
            OpenMenu();
        }

        public void SenkronTypeSettings()
        {
            if (chckBoxSenkronType.Checked)
            {
                lblSenkronSaat.Visible = true;
                dateTimePicker1.Visible = true;
                lblSenkronPeriod.Visible = false;
                comboPeriod.Visible = false;
                chckBoxSenkronType.Text = "Senkron Saati Seçiniz";
            }
            else
            {
                lblSenkronSaat.Visible = false;
                dateTimePicker1.Visible = false;
                lblSenkronPeriod.Visible = true;
                comboPeriod.Visible = true;
                chckBoxSenkronType.Text = "Period Tekrar Süresi Seçiniz";
            }
        }

        private void chckBoxSenkronType_Click(object sender, EventArgs e)
        {
            SenkronTypeSettings();
        }

        private void btnSenkronOnOf_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
