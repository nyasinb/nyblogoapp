using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.WS_Class
{
    public class kdEventsDataCevap
    {
        public string cevapAciklama { get; set; }
        public string OKCSeriNo { get; set; }
        public string cevapKodu { get; set; }
        public eventsData eventsData { get;set;}
    }

    public class eventsData
    {
        public string eventsSource { get; set; }
        public string eventsCrtLevel { get; set; }
        public string eventsType { get; set; }
        public string eventsTime { get; set; }
        public string eventsUserName { get; set; }
        public string eventsTermState { get; set; }
    }
}
