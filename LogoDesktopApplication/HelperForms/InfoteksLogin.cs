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

namespace LogoDesktopApplication.HelperForms
{
    public partial class InfoteksLogin : UserControl
    {
        public static XmlProvider _xmlProv;
        public static  OtoSenkron _item;
        public static  Login _login;
        public static kdContractInfoCevap kdContractResult;
        DialogResult dr;
        public InfoteksLogin()
        {
            kdContractResult = new kdContractInfoCevap();
            _login = new Login();
            _item = new OtoSenkron();
            _xmlProv = new XmlProvider();
            InitializeComponent();
        }

        public void btnKaydet_Click(object sender, EventArgs e)
        {
            _item = _xmlProv.XmlRead();
            _item.Login.userName = textBox1.Text;
            _item.Login.passWord = textBox2.Text;
            _xmlProv.XmlWriterMethod(_item);
            _item = _xmlProv.XmlRead();
            //tsm e connection yapıp logini doğrulayacağız
            kdContractResult = Query_Method_kdContractInfo(_item.Login.userName, _item.Login.passWord);
            if (kdContractResult.cevapKodu!="000")
            {
                _item.Login.State = "False";
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                this,
                kdContractResult.cevapAciklama,
                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _item.Login.State = "True";
                //_item.Login.Add(_login);
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                this,
                "Giriş Yapıldı, Senkron Ayarlarınızı Yapabilirsiniz",
                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _xmlProv.XmlWriterMethod(_item);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        public kdContractInfoCevap Query_Method_kdContractInfo(string ad,string soyad)
        {

            var _url = "http://94.103.42.156:8069/kdintegration/";
            var _action = _url + "kdContractInfo";
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(Query(ad,soyad));
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();
            string soapResult;
            kdContractInfoCevap kdContractInfoCevapItem;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(soapResult);

                    XmlNodeList receiptLine = xml.GetElementsByTagName("kdContractInfoCevap");
                    Serializer ser = new Serializer();
                    string path = string.Empty;
                    foreach (XmlNode xn in receiptLine)
                    {
                        path = xn.OuterXml;
                    }
                    kdContractInfoCevapItem = ser.Deserialize<kdContractInfoCevap>(path);
                }
            }
            return kdContractInfoCevapItem;
        }
        public void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }

        public string Query(string ad, string soyad)
        {
            string QUERY = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdContractInfo>" +
                             "<kurumKodu>" +ad+ "</kurumKodu>" +
                             "<kurumToken>" + soyad + "</kurumToken>" +
                             "<OKCSeriNo>TEST00009995</OKCSeriNo>" +
                             "</kdContractInfo></soapenv:Body></soapenv:Envelope>";
            return QUERY;
        }
        


    }
}
