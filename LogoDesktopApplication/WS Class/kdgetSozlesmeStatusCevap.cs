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
        public registeredOKC registeredOKC { get; set; }
        public unregisteredOKC unregisteredOKC { get; set; }

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
