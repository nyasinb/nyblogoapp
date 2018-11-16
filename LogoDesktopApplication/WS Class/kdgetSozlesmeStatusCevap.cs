using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.WS_Class
{
    public class kdgetSozlesmeStatusCevap
    {
        public string cevapAciklama { get; set; }
        public string cevapKodu { get; set; }
        public List<terminalSerial> registeredOKC { get; set; }
        public List<terminalSerial> unregisteredOKC { get; set; }

    }
    public class terminalSerial
    {
        public string sozlesmeBit { get; set; }
        public string name { get; set; }
        public string sozlesmeBas { get; set; }
    }
    public class registeredOKC
    {
        public string terminalSerial { get; set; }
    }

    public class unregisteredOKC
    {
        public string terminalSerial { get; set; }
    }
}
