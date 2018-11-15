using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogoDesktopApplication.WS_Class;
using System.Xml;
using System.Net;
using System.IO;
using LogoDesktopApplication.LOGO_Class;

namespace LogoDesktopApplication.HelperForms
{
    public partial class InfoteksLogin : UserControl
    {

        #region Variable
        public static XmlProvider _xmlProv;
        public static OtoSenkron _item;
        public static kdgetSozlesmeStatusCevap kdgetSozlesmeStatusResult;
        public WSProvider _ws;
        public CreatedQuery _cQuery;
        public kdSalesReceiptDataAllCevap kdSalesReceiptData;
        public LogoProviderClass _logoProvider;
        public OtoSenkron _otoSenkron;
        DialogResult dr;
        #endregion


        public InfoteksLogin()
        {
            _ws = new WSProvider();
            _logoProvider = new LogoProviderClass();
            kdSalesReceiptData = new kdSalesReceiptDataAllCevap();
            _cQuery = new CreatedQuery();
            kdgetSozlesmeStatusResult = new kdgetSozlesmeStatusCevap();
            _item = new OtoSenkron();
            _xmlProv = new XmlProvider();
            InitializeComponent();
        }
        
        public void btnKaydet_Click(object sender, EventArgs e)
        {
            _item = _xmlProv.XmlRead();
            if (_item.InfoLoginState == "True")
                LogoLoginMethod();
            else
                InfoteksLoginMethod();
        }
        private void InfoteksLogin_Load(object sender, EventArgs e)
        {
            ShowScreen();
        }
        void ShowScreen()
        {
            _item = _xmlProv.XmlRead();

            if (_item.InfoLoginState == "True" && _item.LogoLoginState == "False")
            {
                txtFirmaKodu.Text=_item.InfoLisances;
                txtFirmaKodu.isPassword = true;
                infoPanel.Enabled = false;
                logoPanel.Enabled = true;

            }
            else if (_item.InfoLoginState=="" && _item.LogoLoginState=="")
            {
                infoPanel.Enabled = true;
                logoPanel.Enabled = false;
            }
            else if (_item.InfoLoginState == "True" && _item.LogoLoginState == "")
            {
                txtFirmaKodu.Text = _item.InfoLisances;
                txtFirmaKodu.isPassword = true;

                infoPanel.Enabled = false;
                logoPanel.Enabled = true;
            }
            else
            {
                infoPanel.Enabled = false;
                logoPanel.Enabled = true;
            }
        }

        void InfoteksLoginMethod()
        {
            //if (txtFirmaKodu.Text=="" || txtFirmaToken.Text=="")
            //{
            //    dr = DevExpress.XtraEditors.XtraMessageBox.Show(
            //    this,
            //    "Lütfen ilgili alanları doldurunuz",
            //    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            kdgetSozlesmeStatusResult = Query_Method_kdgetSozlesmeStatus();
            if (kdgetSozlesmeStatusResult.cevapKodu != "000")
            {
                _item.LogoLoginState = "False";
                _xmlProv.XmlWriterMethod(_item);
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                this,
                kdgetSozlesmeStatusResult.cevapAciklama,
                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _item.LogoLoginState = "True";
                logoPanel.Enabled = true;
                _item.InfoLisances = txtFirmaKodu.Text;
                _xmlProv.XmlWriterMethod(_item);
                ShowScreen();
            }
        }

        ConnectionGlobal glob;
        void LogoLoginMethod()
        {
            _item = _xmlProv.XmlRead();
            _item.LogoUserName = txtLogoUser.Text;
            _item.LogoPassword= txtLogoPass.Text;
            _xmlProv.XmlWriterMethod(_item);
            _item = _xmlProv.XmlRead();
            bool LogoconnectionState = LogoConnection();
            if (LogoconnectionState)
            {
                _item = _xmlProv.XmlRead();
                _item.LogoLoginState = "True";
                _item = _xmlProv.XmlRead();
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                this,
                "Giriş Yapıldı, Veri Senkronu Sağlanacak\nBu işlem uzun sürebilir\nDevam etmek istiyor musunuz ?",
                "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    btnLogin.Enabled = false;
                    progressBarControl1.Visible = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker1.WorkerReportsProgress = true;
                }
                else
                {
                    Application.Restart();
                }
            }
            else
            {
                _item.LogoLoginState = "False";
                _item = _xmlProv.XmlRead();
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                this,
                "Logo Giriş Bilgileri Hatalı Tekrar Deneyiniz.",
                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool LogoConnection()
        {
            _item = _xmlProv.XmlRead();
            return GMP3Infoteks.OKC.logoConnection.Connection(_item.LogoUserName, _item.LogoPassword);
        }

        public HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        public XmlDocument CreateSoapEnvelope(string query)
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(query);
            return soapEnvelopeDocument;
        }

        public kdgetSozlesmeStatusCevap Query_Method_kdgetSozlesmeStatus()
        {

            var _url = "http://94.103.42.156:8069/kdintegration/";
            var _action = _url + "kdgetSozlesmeStatus";
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(ResultQuery());
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();
            string soapResult;
            kdgetSozlesmeStatusCevap kdgetSozlesmeStatusCevapItem;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(soapResult);

                    XmlNodeList receiptLine = xml.GetElementsByTagName("kdgetSozlesmeStatusCevap");
                    Serializer ser = new Serializer();
                    string path = string.Empty;
                    foreach (XmlNode xn in receiptLine)
                    {
                        path = xn.OuterXml;
                    }
                    kdgetSozlesmeStatusCevapItem = ser.Deserialize<kdgetSozlesmeStatusCevap>(path);
                }
            }
            return kdgetSozlesmeStatusCevapItem;
        }
        public void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }

        public string ResultQuery()
        {
            string QUERY = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdgetSozlesmeStatus>" +
                             "<kurumKodu>" +_item.InfoLisances+ "</kurumKodu>" +
                             "</kdgetSozlesmeStatus></soapenv:Body></soapenv:Envelope>";
            return QUERY;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _otoSenkron = _xmlProv.XmlRead();
            kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData(_cQuery.CREATE_kdSalesReceiptAllData(_otoSenkron));
            for (int i = 0; i < kdSalesReceiptData.salesData.Count; i++)
            {
                _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);
                _xmlProv.XmlWriterMethod(_otoSenkron);
                backgroundWorker1.ReportProgress(i, e.Result);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarControl1.EditValue = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarControl1.Visible = false;
            btnLogin.Enabled = true;
            Application.Restart();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.infoteks.com.tr/");
        }

        void KeyEvents(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InfoteksLoginMethod();
            }
            else if (e.KeyCode==Keys.Escape)
            {
                txtLogoUser.Text = "";
                txtFirmaKodu.Text = "";
                txtLogoPass.Text = "";
            }

        }


    }
}
