using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication
{
    public class kdSalesReceiptDataCevap
    {

        public string cevapAciklama { get; set; }
        public string OKCSeriNo { get; set; }
        public string cevapKodu { get; set; }

        public List<receiptLine> salesData { get; set; }              
    }
    public class receiptLine
    {
        public string salesCashAmount { get; set; }
        public string salesCurrAmount { get; set; }
        public string salesReceiptType { get; set; }
        public string salesEKUNo { get; set; }

        public string salesTotalVAT { get; set; }
        public string salesOtherAmount { get; set; }
        public string salesKKAmount { get; set; }
        public string salesReceiptNo { get; set; }
        public string salesTime { get; set; }
        public string salesTotalCost { get; set; }
        public string salesZNo { get; set; }

        public string salesFaturaTarihi { get; set; }
        public string salesType { get; set; }
        public string salesFaturaNo { get; set; }
        public List<salesLine> salesLines { get; set; }
        public List<bankLine> bankLines { get; set; }
    }

    public class salesLine
    {
        public string salesLineIncAmount { get; set; }
        public string salesLineTotCost { get; set; }
        public string salesLineAmount { get; set; }
        public string salesLineDecAmount { get; set; }
        public string salesLineName { get; set; }
        public string salesLineVAT { get; set; }
    }
    public class bankLine
    {
        public string batch_no { get; set; }
        public string terminal_no { get; set; }
        public string onay_no { get; set; }
        public string receipt_no { get; set; }
        public string account_no { get; set; }
        public string acquirer_id { get; set; }
        public string kk_number { get; set; }
        public float amount { get; set; }
    }
}
