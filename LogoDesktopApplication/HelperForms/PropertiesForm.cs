﻿using System;
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
        public PropertiesForm()
        {
            InitializeComponent();
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

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Black;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Transparent;
        }

        private void btnManuelSenkron_MouseHover(object sender, EventArgs e)
        {
            btnManuelSenkron.BackColor = Color.Black;
        }

        private void btnManuelSenkron_MouseLeave(object sender, EventArgs e)
        {
            btnManuelSenkron.BackColor = Color.Transparent;
        }
        int i = 1;
        private void btnSenkronOnOff_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                btnSenkronOnOff.Image = global::LogoDesktopApplication.Properties.Resources.off;
                panel2.Visible = false;
            }
            else
            {
                btnSenkronOnOff.Image = global::LogoDesktopApplication.Properties.Resources.On;
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
                btnSenkronOnOff.Image = global::LogoDesktopApplication.Properties.Resources.off;
            }

            else
            {
                panel2.Visible = true;
                chckBoxSenkronType.Visible = true;
                btnSenkronOnOff.Image = global::LogoDesktopApplication.Properties.Resources.On;
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
                s.LoginState = "True";
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
            item.LoginState = "False";
            _xmlProv.XmlWriterMethod(item);
            dr = DevExpress.XtraEditors.XtraMessageBox.Show(
            this,
            "Uygulamanız Sonlandırılacaktır, Lütfen Tekrar Başlatınız.",
            "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManuelSenkron_Click(object sender, EventArgs e)
        {
            if (NetworkControl())
            {
                item = _xmlProv.XmlRead();
                kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData(_CreatedQuery.CREATE_kdSalesReceiptAllData(item));
                if (kdSalesReceiptData.cevapKodu != "000")
                {
                    dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                    this,
                    "Senkron Yapılamaz.\n" + kdSalesReceiptData.cevapAciklama + "\nLütfen Infoteks ile iletişime geçiniz",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);

            }

        }
    }
}