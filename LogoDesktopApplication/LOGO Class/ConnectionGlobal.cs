using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogoDesktopApplication.LOGO_Class
{
    public class ConnectionGlobal
    {

        public ConnectionGlobal()
        {
            LobObject();
        }
        public static void LobObject()
        {
            try
            {
                bool kontrol;
                Mutex mutex = new Mutex(true, "LOBJECTS", out kontrol);
                if (kontrol)
                {
                    Process[] process = Process.GetProcessesByName("LOBJECTS");
                    foreach (Process p in process)
                    {
                        p.Kill();
                    }
                }
                GC.KeepAlive(mutex);
            }
            catch (Exception ex)
            {

            }
        }
        public bool Connection()
        {
            return GMP3Infoteks.OKC.logoConnection.Connection("LOGO", "LOGO");
        }
        

    }
}
