using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.WS_Class
{
    public class kdStatisticsDataCevap
    {

        public string cevapAciklama { get; set; }
        public string OKCSeriNo { get; set; }
        public string cevapKodu { get; set; }
        public statData statData { get; set; }
    }

    public class statData
    {
        public string statRespNum { get; set; }
        public string statFailNum { get; set; }
        public string statEthConn { get; set; }
        public string statDialConn { get; set; }
        public string statGPRSConn { get; set; }
        public string statGSMConn { get; set; }
        public string statEthFail { get; set; }
        public string statDialFail { get; set; }
        public string statGPRSFail { get; set; }
        public string statGSMFail { get; set; }
    }
}
