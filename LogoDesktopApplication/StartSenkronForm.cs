using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using LogoDesktopApplication.LOGO_Class;
using LogoDesktopApplication.WS_Class;
using static LogoDesktopApplication.LOGO_Class.LogoProviderClass;

namespace LogoDesktopApplication
{
    public partial class StartSenkronForm : SplashScreen
    {

        #region Global Variable
        WSProvider _ws;
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
        #endregion

        public StartSenkronForm()
        {        
            InitializeComponent();
            _ws = new WS_Class.WSProvider();
            _logoCon = new ConnectionGlobal();
            _logoConnection = _logoCon.Connection();
            _logoProvider = new LogoProviderClass();
            _sqlProvider = new SQLProvider();
        }
        public void HavuzCariOlustur()
        {
            TextFish("Havuz Cariler Oluşturuluyor");
            string sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.HavuzCari0, "Havuz Cari %0");
            if (sonuc == "8")
                TextFish(AccCode.HavuzCari0 + " Mevcut Cari Oluşturulmadı");
            else
                TextFish(AccCode.HavuzCari0 + " Oluştu");

            sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.HavuzCari1, "Havuz Cari %1");
            if (sonuc == "8")
            {
                TextFish(AccCode.HavuzCari0 + " Mevcut Cari Oluşturulmadı");
            }else
                TextFish(AccCode.HavuzCari1 + " Oluştu");


            sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.HavuzCari8, "Havuz Cari %8");
            if (sonuc == "8")
                TextFish(AccCode.HavuzCari8 + " Mevcut Cari Oluşturulmadı");
            else
                TextFish(AccCode.HavuzCari8 + " Oluştu");

            sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.HavuzCari18, "Havuz Cari %18");
            if (sonuc == "8")
                TextFish(AccCode.HavuzCari18 + " Mevcut Cari Oluşturulmadı");
            else
                TextFish(AccCode.HavuzCari18 + " Oluştu");

            sonuc = _logoProvider.CreateCurrentParametric((int)AccCode.ParcaliOdeme, "Parçalı Ödeme Cari");
            if (sonuc == "8")
                TextFish(AccCode.ParcaliOdeme + " Mevcut Cari Oluşturulmadı");
            else
                TextFish(AccCode.ParcaliOdeme + " Oluştu");

            TextFish("Cari İşlemleri Tamamlandı");
        }

        public void FisleriGetir()
        {
            //HavuzCariOlustur();
            TextFish("Servisten Fiş Verileri Alınıyor...");
            kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData();
            TextFish("Veriler Kontrol Ediliyor...");
            System.Threading.Thread.Sleep(1000);
            TextFish("Veriler Logoya Aktarılıyor");
            _logoProvider.transferVoucherNoCurrent(kdSalesReceiptData);
            TextFish("Aktarım Tamamlandı Uygulama Başlatılıyor...");
            System.Threading.Thread.Sleep(1000);
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        public void TextFish(string Text)
        {
            kontrolLabel.Text = Text;
            kontrolLabel.Refresh();
        }

        private void StartSenkronForm_Load(object sender, EventArgs e)
        {
            kontrolLabel.Visible = false;
            FisleriGetir();
            kontrolLabel.Visible = true;
        }
        int saniye = 0;
        string nokta = ".";

    }
}