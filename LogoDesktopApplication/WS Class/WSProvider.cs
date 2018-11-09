using LogoDesktopApplication.HelperForms;
using LogoDesktopApplication.LOGO_Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml;

namespace LogoDesktopApplication.WS_Class
{
    public class WSProvider
    {

        public kdSalesReceiptDataCevap Query_Method_kdSalesReceiptData()
        {

            var _url = "http://94.103.42.156:8069/kdintegration/";
            var _action = _url + "kdSalesReceiptData";
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(SOAP_QUERY_kdSalesReceiptData.Replace("\n", ""));
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();
            string soapResult;
            kdSalesReceiptDataCevap kdSalesReceiptDataCevapItem = null;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(soapResult);

                    XmlNodeList receiptLine = xml.GetElementsByTagName("kdSalesReceiptDataCevap");
                    Serializer ser = new Serializer();
                    string path = string.Empty;
                    foreach (XmlNode xn in receiptLine)
                    {
                        path = xn.OuterXml;
                    }
                    kdSalesReceiptDataCevapItem = ser.Deserialize<kdSalesReceiptDataCevap>(path);
                }
            }
            return kdSalesReceiptDataCevapItem;
        }
                
        public kdContractInfoCevap Query_Method_kdContractInfo()
        {

            var _url = "http://94.103.42.156:8069/kdintegration/";
            var _action = _url + "kdContractInfo";
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(SOAP_QUERY_kdContractInfo);
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

        public kdEventsDataCevap Query_Method_kdEventsData()
        {

            var _url = "http://94.103.42.156:8069/kdintegration/";
            var _action = _url + "kdEventsData";
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(SOAP_QUERY_kdEventsData);
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();
            kdEventsDataCevap kdEventsDataCevapItem = null;
            string soapResult;

            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(soapResult);

                    XmlNodeList receiptLine = xml.GetElementsByTagName("kdEventsDataCevap");
                    Serializer ser = new Serializer();
                    string path = string.Empty;
                    foreach (XmlNode xn in receiptLine)
                    {
                        path = xn.OuterXml;
                    }
                    kdEventsDataCevapItem = ser.Deserialize<kdEventsDataCevap>(path);
                }
            }
            return kdEventsDataCevapItem;
        }

        public kdSalesReportDataCevap Query_Method_kdSalesReportData()
        {

            var _url = "http://94.103.42.156:8069/kdintegration/";
            var _action = _url + "kdSalesReportData";
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(SOAP_QUERY_kdSalesReportData);
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();
            string soapResult;
            kdSalesReportDataCevap kdSalesReportDataItem;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(soapResult);

                    XmlNodeList receiptLine = xml.GetElementsByTagName("kdSalesReportDataCevap");
                    Serializer ser = new Serializer();
                    string path = string.Empty;
                    foreach (XmlNode xn in receiptLine)
                    {
                        path = xn.OuterXml;
                    }
                    kdSalesReportDataItem = ser.Deserialize<kdSalesReportDataCevap>(path);
                }
            }
            return kdSalesReportDataItem;
        }

        public kdStatisticsDataCevap Query_Method_kdStatisticsData()
        {

            var _url = "http://94.103.42.156:8069/kdintegration/";
            var _action = _url + "kdStatisticsData";
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(SOAP_QUERY_kdStatisticsData);
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();
            string soapResult;
            kdStatisticsDataCevap kdStatisticsDataCevapItem;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(soapResult);

                    XmlNodeList receiptLine = xml.GetElementsByTagName("kdStatisticsDataCevap");
                    Serializer ser = new Serializer();
                    string path = string.Empty;
                    foreach (XmlNode xn in receiptLine)
                    {
                        path = xn.OuterXml;
                    }
                    kdStatisticsDataCevapItem = ser.Deserialize<kdStatisticsDataCevap>(path);
                }
            }
            return kdStatisticsDataCevapItem;
        }

        public kdZReportDataCevap Query_Method_kdZReportData()
        {

            var _url = "http://94.103.42.156:8069/kdintegration/";
            var _action = _url + "kdZReportData";
            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(SOAP_QUERY_kdZReportData);
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();
            string soapResult;
            kdZReportDataCevap kdStatisticsDataCevapItem;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(soapResult);

                    XmlNodeList receiptLine = xml.GetElementsByTagName("kdZReportDataCevap");
                    Serializer ser = new Serializer();
                    string path = string.Empty;
                    foreach (XmlNode xn in receiptLine)
                    {
                        path = xn.OuterXml;
                    }
                    kdStatisticsDataCevapItem = ser.Deserialize<kdZReportDataCevap>(path);
                }
            }
            return kdStatisticsDataCevapItem;
        }

        public  HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        public  XmlDocument CreateSoapEnvelope(string query)
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(query);
            return soapEnvelopeDocument;
        }

        public  void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }


        #region QUERY SOAP


        public static string SOAP_QUERY_kdSalesReceiptData = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdSalesReceiptData>" +
                                             "<kurumKodu>12345YSN</kurumKodu>" +
                                             "<kurumToken>12345BZT</kurumToken>" +
                                             "<OKCSeriNo>TEST00009995</OKCSeriNo>" +
                                             "<reportDateStart/>" +
                                             "<reportDateEnd/>" +
                                             "<reportZNo/>" +
                                             "</kdSalesReceiptData></soapenv:Body></soapenv:Envelope>";

        public static string SOAP_QUERY_kdContractInfo = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdContractInfo>" +
                                             "<kurumKodu>infoteks</kurumKodu>" +
                                             "<kurumToken>SD5S1DV5166SDSDVCSDVSV66DETRH</kurumToken>" +
                                             "<OKCSeriNo>TEST00009995</OKCSeriNo>" +
                                             "</kdContractInfo></soapenv:Body></soapenv:Envelope>";

        public static string SOAP_QUERY_kdEventsData = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdEventsData>" +
                                     "<kurumKodu>infoteks</kurumKodu>" +
                                     "<kurumToken>SD5S1DV5166SDSDVCSDVSV66DETRH</kurumToken>" +
                                     "<OKCSeriNo>TEST00009995</OKCSeriNo>" +
                                     "<reportDateStart/>" +
                                     "<reportDateEnd/>" +
                                     "</kdEventsData></soapenv:Body></soapenv:Envelope>";

        public static string SOAP_QUERY_kdSalesReportData = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdSalesReportData>" +
                             "<kurumKodu>infoteks</kurumKodu>" +
                             "<kurumToken>SD5S1DV5166SDSDVCSDVSV66DETRH</kurumToken>" +
                             "<OKCSeriNo>TEST00009995</OKCSeriNo>" +
                             "<reportDateStart/>" +
                             "<reportDateEnd/>" +
                             "<reportZNo/>" +
                             "</kdSalesReportData></soapenv:Body></soapenv:Envelope>";

        public static string SOAP_QUERY_kdStatisticsData = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdStatisticsData>" +
                     "<kurumKodu>infoteks</kurumKodu>" +
                     "<kurumToken>SD5S1DV5166SDSDVCSDVSV66DETRH</kurumToken>" +
                     "<OKCSeriNo>TEST00009995</OKCSeriNo>" +
                     "<reportDateStart/>" +
                     "<reportDateEnd/>" +
                     "</kdStatisticsData></soapenv:Body></soapenv:Envelope>";

        public static string SOAP_QUERY_kdZReportData = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdZReportData>" +
             "<kurumKodu>infoteks</kurumKodu>" +
             "<kurumToken>SD5S1DV5166SDSDVCSDVSV66DETRH</kurumToken>" +
             "<OKCSeriNo>TEST00009995</OKCSeriNo>" +
             "<reportDateStart/>" +
             "<reportDateEnd/>" +
             "<reportZNo/>" +
             "</kdZReportData></soapenv:Body></soapenv:Envelope>";

        #endregion
    }
}
