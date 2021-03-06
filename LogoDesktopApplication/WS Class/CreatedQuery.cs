﻿using LogoDesktopApplication.HelperForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.WS_Class
{
    public class CreatedQuery
    {

        public string CREATE_kdContractInfo(OtoSenkron o)
        {
            string SOAP_QUERY_kdContractInfo = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdContractInfo>" +
                             "<kurumKodu>" + o.InfoKurumKodu + "</kurumKodu>" +
                             "<kurumToken>" + o.InfoKurumToken + "</kurumToken>" +
                             "<OKCSeriNo>TEST00009995</OKCSeriNo>" +
                             "</kdContractInfo></soapenv:Body></soapenv:Envelope>";
            return SOAP_QUERY_kdContractInfo;
        }
        public string CREATE_kdSalesReceiptAllData(OtoSenkron o)
        {

         string SOAP_QUERY_kdSalesReceiptAllData = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdSalesReceiptAllData>" +
                                     "<kurumKodu>" + o.InfoKurumKodu + "</kurumKodu>" +
                                     "<kurumToken>" + o.InfoKurumToken + "</kurumToken>" +
                                     "<reportDateStart/>" +
                                     "<reportDateEnd/>" +
                                     "</kdSalesReceiptAllData></soapenv:Body></soapenv:Envelope>";
            return SOAP_QUERY_kdSalesReceiptAllData;
        }

        public string CREATE_ServerIdResponse(OtoSenkron o,string id)
        {

            string SOAP_QUERY_kdSalesReceiptAllData = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdUpdateReceiptLogoStatus>" +
                                        "<kurumKodu>" + o.InfoKurumKodu + "</kurumKodu>" +
                                        "<kurumToken>" + o.InfoKurumToken + "</kurumToken>" +
                                        "<serverId>"+id+"</serverId>"+
                                        "</kdUpdateReceiptLogoStatus></soapenv:Body></soapenv:Envelope>";
            return SOAP_QUERY_kdSalesReceiptAllData;
        }

        public string CREATE_kdgetSozlesmeStatus(OtoSenkron o)
        {

            string SOAP_QUERY_kdgetSozlesmeStatus = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ws=""http://schemas.xmlsoap.org/wsdl/""><soapenv:Header/><soapenv:Body><kdgetSozlesmeStatus>" +
                                        "<kurumKodu>" + o.InfoKurumKodu + "</kurumKodu>" +
                                        "<kurumToken>" + o.InfoKurumToken + "</kurumToken>" +
                                        "</kdgetSozlesmeStatus></soapenv:Body></soapenv:Envelope>";
            return SOAP_QUERY_kdgetSozlesmeStatus;
        }


    }
}
