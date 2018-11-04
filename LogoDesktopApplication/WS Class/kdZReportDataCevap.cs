using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.WS_Class
{
    public class kdZReportDataCevap
    {
        public string cevapAciklama { get; set; }
        public string OKCSeriNo { get; set; }
        public string cevapKodu { get; set; }

        public List<zReportLine> zRepData { get; set; }

        public class zReportLine
        {
            public string zReportCancelRecNum { get; set; }
            public string zReportCancelAmount { get; set; }
            public string zReportTechNum { get; set; }
            public string zReportRestTrnNum { get; set; }
            public zReportKisimName zReportKisimName { get; set; }

            public string zReportRestAmount { get; set; }
            public zReportCurrToTL zReportCurrToTL { get; set; }
            public zReportCurrName zReportCurrName { get; set; }

            public string zReportOtherAmount { get; set; }

            public zReportVATRate zReportVATRate { get; set; }

            public string zReportUnfiscalRecNum { get; set; }
            public string zReportKKAmount { get; set; }
            
            public zReportKisimCost zReportKisimCost { get; set; }
            public zReportCurrAmount zReportCurrAmount { get; set; }
            public string zReportFixNum { get; set; }

            public string zReportCashAmount { get; set; }
            public string zReportDailyTotAmount { get; set; }
            public string zReportDecCost { get; set; }
            public string zReportBillRecNum { get; set; }
            public string zReportIncCost { get; set; }

            public string zReportIncNum { get; set; }

            public string zReportTime { get; set; }
            public string zReportReceiptNo { get; set; }

            public string zReportDecNum{ get; set; }

            public string zReportDailyVATAmount { get; set; }

            public string zReportCustRecNum { get; set; }

            public string zReportNo { get; set; }

            public string zReportAccVATAmount { get; set; }

            public zReportVATCost zReportVATCost { get; set; }

            public string zReportParkTrnNum { get; set; }

            public string zReportEKUNo { get; set; }

            public string zReportFixAmount { get; set; }


            public string zReportFiscalRecNum { get; set; }

            public zReportVATAmount zReportVATAmount { get; set; }
            public string zReportBillAmount { get; set; }
            public zReportKisimNum zReportKisimNum { get; set; }

            public string zReportAccTotAmount { get; set; }
        }
        public class zReportKisimName
        {
            public string kisim_adi8 { get; set; }
            public string kisim_adi9 { get; set; }
            public string kisim_adi6 { get; set; }
            public string kisim_adi7 { get; set; }
            public string kisim_adi4 { get; set; }
            public string kisim_adi5 { get; set; }
            public string kisim_adi2 { get; set; }
            public string kisim_adi3 { get; set; }
            public string kisim_adi1 { get; set; }
            public string kisim_adi10 { get; set; }
            public string kisim_adi11 { get; set; }
            public string kisim_adi12 { get; set; }

        }

        public class zReportCurrToTL
        {
            public string doviz_tl_karsiligi2 { get; set; }
            public string doviz_tl_karsiligi1 { get; set; }
            public string doviz_tl_karsiligi3 { get; set; }
            public string doviz_tl_karsiligi4 { get; set; }
            public string doviz_tl_karsiligi5 { get; set; }
            public string doviz_tl_karsiligi6 { get; set; }
        }

        public class zReportCurrName {
            public string doviz_adi1 { get; set; }
            public string doviz_adi2 { get; set; }
            public string doviz_adi3{ get; set; }
            public string doviz_adi4 { get; set; }
            public string doviz_adi5 { get; set; }
            public string doviz_adi6 { get; set; }
        }

        public class zReportVATRate
        {
            public string vergi_orani1 { get; set; }
            public string vergi_orani2 { get; set; }
            public string vergi_orani3 { get; set; }
            public string vergi_orani4 { get; set; }
            public string vergi_orani5 { get; set; }
            public string vergi_orani6 { get; set; }
            public string vergi_orani7 { get; set; }
            public string vergi_orani8 { get; set; }
        }

        public class zReportKisimCost
        {
            public string kisim_toplam_tutari1 { get; set; }
            public string kisim_toplam_tutari2 { get; set; }
            public string kisim_toplam_tutari3 { get; set; }
            public string kisim_toplam_tutari4 { get; set; }
            public string kisim_toplam_tutari5 { get; set; }
            public string kisim_toplam_tutari6 { get; set; }
            public string kisim_toplam_tutari7 { get; set; }
            public string kisim_toplam_tutari8 { get; set; }
            public string kisim_toplam_tutari9 { get; set; }
            public string kisim_toplam_tutari10 { get; set; }
            public string kisim_toplam_tutari11{ get; set; }
            public string kisim_toplam_tutari12 { get; set; }
        }

        public class zReportCurrAmount
        {
            public string doviz_toplam_tutar1 { get; set; }
            public string doviz_toplam_tutar2 { get; set; }
            public string doviz_toplam_tutar3 { get; set; }
            public string doviz_toplam_tutar4 { get; set; }
            public string doviz_toplam_tutar5 { get; set; }
            public string doviz_toplam_tutar6 { get; set; }
        }

        public class zReportVATCost
        {
            public string vergi_toplam_kdv1 { get; set; }
            public string vergi_toplam_kdv2 { get; set; }
            public string vergi_toplam_kdv3 { get; set; }
            public string vergi_toplam_kdv4 { get; set; }
            public string vergi_toplam_kdv5 { get; set; }
            public string vergi_toplam_kdv6 { get; set; }
            public string vergi_toplam_kdv7 { get; set; }
            public string vergi_toplam_kdv8 { get; set; }

        }

        public class zReportVATAmount
        {
            public string vergi_toplam_tutari1 { get; set; }
            public string vergi_toplam_tutari2 { get; set; }
            public string vergi_toplam_tutari3 { get; set; }
            public string vergi_toplam_tutari4 { get; set; }
            public string vergi_toplam_tutari5 { get; set; }
            public string vergi_toplam_tutari6 { get; set; }
            public string vergi_toplam_tutari7 { get; set; }
            public string vergi_toplam_tutari8 { get; set; }

        }

        public class zReportKisimNum
        {
            public string kisim_toplam_adedi1 { get; set; }
            public string kisim_toplam_adedi2 { get; set; }
            public string kisim_toplam_adedi3 { get; set; }
            public string kisim_toplam_adedi4 { get; set; }
            public string kisim_toplam_adedi5 { get; set; }
            public string kisim_toplam_adedi6 { get; set; }
            public string kisim_toplam_adedi7 { get; set; }
            public string kisim_toplam_adedi8 { get; set; }
            public string kisim_toplam_adedi9 { get; set; }
            public string kisim_toplam_adedi10 { get; set; }
            public string kisim_toplam_adedi11{ get; set; }
            public string kisim_toplam_adedi12 { get; set; }
        }
    }
}
