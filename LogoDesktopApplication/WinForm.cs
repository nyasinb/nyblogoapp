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
        Thread _thiki;
        DialogResult dr;
        Thread _th;
        System.Windows.Forms.Timer _timer;
        int say = 0;
        OtoSenkron _otoSenkron;
        Log _log;
        #endregion

        public WinForm()
        {
            _log = new Log();
            InitializeComponent();
            _otoSenkron = new OtoSenkron();
            _ws = new WS_Class.WSProvider();
            _logoCon = new ConnectionGlobal();
            _logoConnection = _logoCon.Connection();
            _logoProvider = new LogoProviderClass();
            _sqlProvider = new SQLProvider();
            _xmlProv = new XmlProvider();
            item = new OtoSenkron();
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 60000;
            _timer.Tick += new EventHandler(otoSenkronMethod);
            _timer.Start();
            NetworkControl();
            thTimer.Start();
            thTimer.Interval = 5000;
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(StartingControlForm));
            System.Threading.Thread.Sleep(1500);
            Bank a = new Bank();
            _logoProvider.bankCreatAcc(a);
            if (_logoCon.networkState)
            {
                kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData();
                if (kdSalesReceiptData.cevapKodu!="000")
                {
                    dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                    this,
                    "Senkron Yapılamaz.\n" + kdSalesReceiptData.cevapAciklama + "\nLütfen Infoteks ile iletişime geçiniz",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);
            }
            else
            {
                DevExpress.XtraSplashScreen.AboutSplashScreenManager.CloseForm(false, 0, this);
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                this,
                "Internet bağlantısı sağlanamadı\nBağlantınızı kontrol ediniz",
                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //System.Diagnostics.Process.Start(@"E:\Program Files (x86)\LOGO\Logo Start\LOGOSTART.exe");
        }

        public void NetworkControl()
        {
            try
            {
                _logoCon.networkState = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                if (_logoCon.networkState == true)
                {
                    btnConnectionImage.Image = global::LogoDesktopApplication.Properties.Resources.ConnectedWıfı;
                }
                else
                {
                    btnConnectionImage.Image = global::LogoDesktopApplication.Properties.Resources.closed;
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


        private void btnSenkron_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraSplashScreen.AboutSplashScreenManager.ShowForm(this, typeof(waitForm));
            if (_logoCon.networkState)
            {
                kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData();
                if (kdSalesReceiptData.cevapKodu != "000")
                {
                    DevExpress.XtraSplashScreen.AboutSplashScreenManager.CloseForm(false, 0, this);
                    dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                    this,
                    "Senkron Yapılamaz.\n" + kdSalesReceiptData.cevapAciklama + "\nLütfen Infoteks ile iletişime geçiniz",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);
                DevExpress.XtraSplashScreen.AboutSplashScreenManager.CloseForm(false, 0, this);
            }
            else
            {
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                this,
                "Internet bağlantısı sağlanamadı\nBağlantınızı kontrol ediniz",
                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void OtoSync()
        {
            _otoSenkron = _xmlProv.XmlRead();
            if (_otoSenkron.Durum == "True" && _otoSenkron.SenkronType == 0)  //0 ise period, 1 ise saat.
            {
                int GO = Convert.ToInt16(_otoSenkron.Period) * 60;
                say += 60;
                if (say == GO)
                {
                    if (_logoCon.networkState)
                    {
                        kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData();
                        System.Threading.Thread.Sleep(1000);
                        if (kdSalesReceiptData.cevapKodu == "000")
                        {
                            string Result = _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);
                            if (Result == "0")
                            {
                                _log.Info("Oto senkron yapıldı. Aktarılan data: " + kdSalesReceiptData.salesData.Count);
                                say = 0;
                            }
                            else
                            {
                                _log.Warning("OtoSync  ::  " + Result);
                            }
                        }
                        else
                            _log.Warning("oto senkron yapılamadı " + kdSalesReceiptData.cevapAciklama);
                        say = 0;
                    }
                    else
                    {
                        _log.Warning("oto senkron yapılamadı " + kdSalesReceiptData.cevapAciklama);
                        say -= 10;
                    }
                }
            }
            else if (_otoSenkron.Durum == "True" && _otoSenkron.SenkronType == 1)
            {
                if (_logoCon.networkState)
                {
                    TimeSpan MaxTimeKontrol = DateTime.Parse(String.Format("{0:t}", DateTime.Now)) - DateTime.Parse(_otoSenkron.Saat);
                    string formTime = String.Format("{0:t}", DateTime.Now);
                    if (formTime == _otoSenkron.Saat || MaxTimeKontrol.Minutes<=5)
                    {
                        if (_logoCon.networkState)
                        {
                            kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData();
                            System.Threading.Thread.Sleep(1000);
                            if (kdSalesReceiptData.cevapKodu == "000")
                            {
                                string Result = _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);
                                if (Result == "0")
                                {
                                    _log.Info("Oto senkron yapıldı. Aktarılan data: " + kdSalesReceiptData.salesData.Count);
                                }
                                else
                                {
                                    _log.Warning("OtoSync  ::  " + Result);
                                }
                            }
                            else
                                _log.Warning("oto senkron yapılamadı " + kdSalesReceiptData.cevapAciklama);
                        }
                        else
                        {
                            _log.Warning("oto senkron yapılamadı " + kdSalesReceiptData.cevapAciklama);
                        }
                    }
                }
            }
            else if (_otoSenkron.Durum == "False" || _otoSenkron.Durum == "false")
            {
                _log.Warning("Oto Senkron Kapalı");
            }
            else
            {
                _log.Warning("OtoSync CONFİG Dosyasını kontrol ediniz...        ");
            }

        }

        public void otoSenkronMethod(object sender, EventArgs e)
        {
            _thiki = new Thread(new ThreadStart(OtoSync));
            _thiki.Start();

        }

    }
}