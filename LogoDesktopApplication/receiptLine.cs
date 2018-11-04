using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication
{
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
        public List<salesLine> salesLines { get; set; }
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
}
