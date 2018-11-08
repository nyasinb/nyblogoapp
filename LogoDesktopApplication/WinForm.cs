using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LogoDesktopApplication.LOGO_Class;
using LogoDesktopApplication.WS_Class;
using static LogoDesktopApplication.LOGO_Class.LogoProviderClass;
using LogoDesktopApplication.HelperForms;
using System.IO;
using System.Threading;

namespace LogoDesktopApplication
{
    public partial class WinForm : DevExpress.XtraEditors.XtraForm
    {

        #region Global Variable
        WS_Class.WSProvider _ws;
        ConnectionGlobal _logoCon;
        kdContractInfoCevap kdContractInfo;
        kdEventsDataCevap kdEventsData;
        kdSalesReceiptDataCevap kdSalesReceiptData;
        kdSalesReportDataCevap kdSalesReportData;
        kdStatisticsDataCevap kdStatisticsData;
        kdZReportDataCevap kdZReportData;
        bool _logoConnection = false;
        LogoProviderClass _logoProvider;
        SQLProvider _sqlProvider;
        public bool networkState = false;
        Thread _th;
        #endregion

        public WinForm()
        {
            InitializeComponent();

            _ws = new WS_Class.WSProvider();
            _logoCon = new ConnectionGlobal();
            _logoConnection = _logoCon.Connection();
            _logoProvider = new LogoProviderClass();
            _sqlProvider = new SQLProvider();
            _xmlProv = new XmlProvider();
            item = new OtoSenkron();
            thTimer.Start();
            thTimer.Interval = 5000;
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(StartingControlForm));
            System.Threading.Thread.Sleep(1500);
            if (networkState)
            {
                kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData();
                _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);
            }
            else
            {

            }
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            System.Diagnostics.Process.Start(@"E:\Program Files (x86)\LOGO\Logo Start\LOGOSTART.exe");
        }

        public void NetworkControl()
        {
            try
            {
                networkState = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                if (networkState==true)
                {
                    btnConnectionImage.Image = global::LogoDesktopApplication.Properties.Resources.ConnectedWıfı;
                }
                else
                {
                    btnConnectionImage.Image = global::LogoDesktopApplication.Properties.Resources.ClosedWıfı;
                }

            }
            catch (Exception ex)
            {
                //BglntDurmuLabel.Text = "İnternet Bağlantısı Pasif";

            }
        }


        #region Metods

        void MethodTest()
        {

            kdContractInfo = _ws.Query_Method_kdContractInfo();
            kdEventsData = _ws.Query_Method_kdEventsData();
            kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData();
            kdSalesReportData = _ws.Query_Method_kdSalesReportData();
            kdStatisticsData = _ws.Query_Method_kdStatisticsData();
            kdZReportData = _ws.Query_Method_kdZReportData();
        }

        public void HavuzCariCreated()
        {
            string sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.HavuzCari0, "Havuz Cari %0");
            if (sonuc == "8")
            {
                //Mevcut Cari
                return;
            }
            sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.HavuzCari1, "Havuz Cari %1");
            sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.HavuzCari8, "Havuz Cari %8");
            sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.HavuzCari18, "Havuz Cari %18");
            sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.ParcaliOdeme, "Parçalı Ödeme Cari");

        }

        public void FisAktar()
        {
            kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData();
            _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);

        }

        public void BankaHesapOlustur()
        {
            Bank b = new Bank();
            string Result = _logoProvider.bankCreat(b);
            Result = _logoProvider.bankCreatAcc(b);

        }

        #endregion

        private void BtninfoteksProc_ItemClick(object sender, ItemClickEventArgs e)
        {
            midPanel.Controls.Clear();
            InfoteksLogin f = new InfoteksLogin();
            midPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
        }

        XmlProvider _xmlProv;
        OtoSenkron item;
        private void BtnlogoProc_ItemClick(object sender, ItemClickEventArgs e)
        {
            midPanel.Controls.Clear();
            LogoSenkronForm f = new LogoSenkronForm();
            midPanel.Controls.Add(f);
            f.Refresh();
            f.Dock = DockStyle.Fill;

        }

        public void thTimer_Tick(object sender, EventArgs e)
        {
            int sayac = 0;
            _th = new Thread(new ThreadStart(NetworkControl));
            _th.Start();
        }
    }
}