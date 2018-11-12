using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.WS_Class
{
    public class kdAcquirerInfoCevap
    {
        public string cevapAciklama { get; set; }
        public string cevapKodu { get; set; }
        public List<acquirerInfo> acquirerData { get; set; }
    }
    public class acquirerInfo
    {
        public string bkmId { get; set; }
        public string name { get; set; }
    }
}
