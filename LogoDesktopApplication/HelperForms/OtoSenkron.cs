using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.HelperForms
{
    public class OtoSenkron
    {
        public string Durum { get; set; }
        public string Saat { get; set; }
        public string Period { get; set; }
        public int SenkronType { get; set; }
        public Login Login { get; set; }
    }

    public class Login
    {
        public string State { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
    }
}
