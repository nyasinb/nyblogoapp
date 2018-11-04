using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.WS_Class
{
    public class kdSalesReportDataCevap
    {
        public string cevapAciklama { get; set; }
        public string OKCSeriNo { get; set; }
        public string cevapKodu { get; set; }
        public List<salesLine> reportData { get; set; }
    }

    public class salesLine
    {
        public string prdName { get; set; }
        public string prdUnitType { get; set; }
        public string prdSaleAmount { get; set; }
        public string salesReportZNo { get; set; }

        public string prdVatRate { get; set; }
        public string salesTotalVAT { get; set; }

        public string salesTotalCost { get; set; }
    }
}
