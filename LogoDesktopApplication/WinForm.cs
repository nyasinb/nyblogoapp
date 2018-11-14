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
        WSProvider _ws;
        ConnectionGlobal _logoCon;
        kdContractInfoCevap kdContractInfo;
        kdEventsDataCevap kdEventsData;
        kdSalesReceiptDataAllCevap kdSalesReceiptData;
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
        kdAcquirerInfoCevap _acquir;
        XmlProvider _xmlProv;
        OtoSenkron item;
        CreatedQuery _CreatedQuery;
        PropertiesForm fform;
        #endregion

        public WinForm()
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2016 Black";
            _log = new Log();
            InitializeComponent();
            _acquir = new kdAcquirerInfoCevap();
            _otoSenkron = new OtoSenkron();
            _CreatedQuery = new CreatedQuery();
            _ws = new WSProvider();
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
            Control.CheckForIllegalCrossThreadCalls = false;
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(StartingControlForm));
            System.Threading.Thread.Sleep(1500);
            CreatBank();
            control();
            //if (_logoCon.networkState)
            //{
            //    _otoSenkron = _xmlProv.XmlRead();
            //    kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData(_CreatedQuery.CREATE_kdSalesReceiptData(_otoSenkron));
            //    if (kdSalesReceiptData.cevapKodu!="000")
            //    {
            //        dr = DevExpress.XtraEditors.XtraMessageBox.Show(
            //        this,
            //        "Senkron Yapılamaz.\n" + kdSalesReceiptData.cevapAciklama + "\nLütfen Infoteks ile iletişime geçiniz",
            //        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //        _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);
            //}
            //else
            //{
            //    DevExpress.XtraSplashScreen.AboutSplashScreenManager.CloseForm(false, 0, this);
            //    dr = DevExpress.XtraEditors.XtraMessageBox.Show(
            //    this,
            //    "Internet bağlantısı sağlanamadı\nBağlantınızı kontrol ediniz",
            //    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            DevExpress.XtraSplashScreen.AboutSplashScreenManager.CloseForm(false, 0, this);
            //System.Diagnostics.Process.Start(@"E:\Program Files (x86)\LOGO\Logo Start\LOGOSTART.exe");
        }


        public void control()
        {
            item = _xmlProv.XmlRead();
            if (item.LoginState=="True")
            {
                midPanel.Controls.Clear();
                PropertiesForm f = new PropertiesForm();                
                midPanel.Controls.Add(f);
                f.Show();
                f.Dock = DockStyle.Fill;
                f.BringToFront();
            }
            else
            {
                midPanel.Controls.Clear();
                InfoteksLogin f = new InfoteksLogin();
                midPanel.Controls.Add(f);
                f.Dock = DockStyle.Fill;
            }
        }
        private void BtninfoteksProc_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void BtnlogoProc_ItemClick(object sender, ItemClickEventArgs e)
        {

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
            _otoSenkron = _xmlProv.XmlRead();
            kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData(_CreatedQuery.CREATE_kdSalesReceiptAllData(_otoSenkron));
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
            _otoSenkron = _xmlProv.XmlRead();
            kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData(_CreatedQuery.CREATE_kdSalesReceiptAllData(_otoSenkron));
            _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);

        }

        public void CreatBank()
        {
            _acquir = _ws.Query_Method_kdAcquirerInfo();
            string Result = _logoProvider.bankCreat(_acquir);
            System.Threading.Thread.Sleep(500);
        }

        #endregion


        public void thTimer_Tick(object sender, EventArgs e)
        {
            _th = new Thread(new ThreadStart(NetworkControl));
            _th.Start();
        }


        private void btnSenkron_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(waitForm));
            backGorundProc.RunWorkerAsync();
            backGorundProc.WorkerReportsProgress = true;
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
                        _otoSenkron = _xmlProv.XmlRead();
                        kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData(_CreatedQuery.CREATE_kdSalesReceiptAllData(_otoSenkron));
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
                            _otoSenkron = _xmlProv.XmlRead();
                            kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData(_CreatedQuery.CREATE_kdSalesReceiptAllData(_otoSenkron));
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
                _log.Warning("OtoSync CONFİG Dosyasını kontrol ediniz...");
            }

        }

        public void otoSenkronMethod(object sender, EventArgs e)
        {
            _thiki = new Thread(new ThreadStart(OtoSync));
            _thiki.Start();

        }

        private void backGorundProc_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_logoCon.networkState)
            {
                _otoSenkron = _xmlProv.XmlRead();
                kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData(_CreatedQuery.CREATE_kdSalesReceiptAllData(_otoSenkron));
                if (kdSalesReceiptData.cevapKodu != "000")
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
                dr = DevExpress.XtraEditors.XtraMessageBox.Show(
                this,
                "Internet bağlantısı sağlanamadı\nBağlantınızı kontrol ediniz",
                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backGorundProc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DevExpress.XtraSplashScreen.AboutSplashScreenManager.CloseForm(false, 0, this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}