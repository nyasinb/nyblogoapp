using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.WS_Class
{
    public class kdContractInfoCevap
    {
        public string cevapAciklama { get; set; }
        public string OKCSeriNo { get; set; }
        public string cevapKodu { get; set; }

        public contractInfo contractInfo { get; set; }

    }

    public class contractInfo
    {
        public string zReportEnd { get; set; }
        public string statisticActive { get; set; }
        public string salesStart { get; set; }
        public string salesEnd { get; set; }
        public string zReportActive { get; set; }
        public string eventsActive { get; set; }
        public string statisticEnd { get; set; }
        public string statisticStart { get; set; }
        public string eventsStart { get; set; }
        public string eventsEnd { get; set; }
        public string zReportStart { get; set; }

        public string salesActive { get; set; }
    }

}
