using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoDesktopApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool acikmi = false;
            Mutex mtex = new Mutex(true, "LogoDesktopApplication", out acikmi);
            if (acikmi)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new WinForm());
            }
            else
            {
                MessageBox.Show("Program Çalışıyor\nAynı anda birden fazla çalıştırılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SkinManager.EnableFormSkins();


        }
    }
}
