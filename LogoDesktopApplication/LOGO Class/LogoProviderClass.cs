using LogoDesktopApplication.HelperForms;
using LogoDesktopApplication.WS_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoDesktopApplication.LOGO_Class
{
    public class LogoProviderClass
    {

        #region Değişken
        SQLProvider sqlProvider;
        Log _log;
        kdAcquirerInfoCevap _kdAcquirer;
        string Result = null;
        UnityObjects.Data arpvoucher = null;
        UnityObjects.Lines transactions_lines = null;
        WSProvider _ws;
        CreatedQuery _CreatQuery;
        OtoSenkron _xmlItem;
        XmlProvider _xmlProv;
        #endregion


        public LogoProviderClass()
        {
            sqlProvider = new SQLProvider();
            _xmlItem = new OtoSenkron();
            _xmlProv = new XmlProvider();
            _kdAcquirer = new kdAcquirerInfoCevap();
            _log = new Log();
            _ws = new WSProvider();
            _CreatQuery = new CreatedQuery();
        }

        /// <summary>
        /// Kontrollerde eksik olan cariler oluşacaksa, buraya codu ve ismi gönderilerek oluşturulur.
        /// </summary>
        /// <param name="cAriCode"></param>
        /// <param name="cariName"></param>
        /// <returns></returns>
        public string CreateCurrentParametric(int cAriCode, string cariName)
        {
            string goReturn = "";
            try
            {
                UnityObjects.Data arps = GMP3Infoteks.OKC.GlobalDll.unity.NewDataObject(UnityObjects.DataObjectType.doAccountsRP);
                arps.New();
                arps.DataFields.FieldByName("ACCOUNT_TYPE").Value = 3;
                arps.DataFields.FieldByName("CODE").Value = cAriCode;
                arps.DataFields.FieldByName("TITLE").Value = cariName + cAriCode;
                arps.DataFields.FieldByName("CORRESP_LANG").Value = 1;
                arps.DataFields.FieldByName("DATA_REFERENCE").Value = 6;
                arps.DataFields.FieldByName("CREATED_BY").Value = 1;
                arps.DataFields.FieldByName("DATE_CREATED").Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                arps.DataFields.FieldByName("HOUR_CREATED").Value = DateTime.Now.Hour;
                arps.DataFields.FieldByName("MIN_CREATED").Value = DateTime.Now.Minute;
                arps.DataFields.FieldByName("SEC_CREATED").Value = DateTime.Now.Second;
                arps.DataFields.FieldByName("CL_ORD_FREQ").Value = 1;
                arps.DataFields.FieldByName("INVOICE_PRNT_CNT").Value = 1;
                arps.DataFields.FieldByName("PURCHBRWS").Value = 1;
                arps.DataFields.FieldByName("SALESBRWS").Value = 1;
                arps.DataFields.FieldByName("IMPBRWS").Value = 1;
                arps.DataFields.FieldByName("EXPBRWS").Value = 1;
                arps.DataFields.FieldByName("FINBRWS").Value = 1;
                arps.DataFields.FieldByName("COLLATRLRISK_TYPE").Value = 1;
                arps.DataFields.FieldByName("RISK_TYPE1").Value = 1;
                arps.DataFields.FieldByName("RISK_TYPE2").Value = 1;
                arps.DataFields.FieldByName("RISK_TYPE3").Value = 1;
                arps.DataFields.FieldByName("PROFILE_ID").Value = 2;
                arps.DataFields.FieldByName("CREATE_WH_FICHE").Value = 1;
                arps.DataFields.FieldByName("PROFILEID_DESP").Value = 1;
                if (arps.Post() == true)
                {
                    _log.Info(cariName + cAriCode + " Cari Oluşturuldu");
                    return "0";
                }
                else
                {
                    if (arps.ErrorCode != 0)
                    {
                        goReturn = ("DBError(" + arps.ErrorCode.ToString() + ")-" + arps.ErrorDesc + arps.DBErrorDesc);
                        _log.Warning("CreateCurrentParametric ::" + arps.ErrorCode.ToString() + ")-" + arps.ErrorDesc + arps.DBErrorDesc);
                    }
                    else if (arps.ValidateErrors.Count > 0)
                    {
                        string result = "XML ErrorList:";
                        for (int j = 0; j < arps.ValidateErrors.Count; j++)
                        {
                            result += "(" + arps.ValidateErrors[j].ID.ToString() + ") - " + arps.ValidateErrors[j].Error;
                            _log.Warning("CreateCurrentParametric ::" + arps.ValidateErrors[j].ID.ToString() + ") - " + arps.ValidateErrors[j].Error);
                        }
                    }
                }
                return arps.ErrorCode.ToString();
            }
            catch (Exception ex)
            {
                _log.Warning("CreateCurrentParametric:: " + ex.Message);
                return (ex.Message);
            }
        }


        /// <summary>
        /// Logoya malzeme aktarılırken, kdv bilgisi ve ismi gönderilir
        /// </summary>
        /// <param name="kdv"></param>
        /// <param name="name"></param>
        public void HavuzMalzeme(int kdv, string name)
        {
            string Result = "";

            UnityObjects.Data item = GMP3Infoteks.OKC.GlobalDll.unity.NewDataObject(UnityObjects.DataObjectType.doMaterial);
            item.New();
            item.DataFields.FieldByName("CARD_TYPE").Value = 13;
            //item.DataFields.FieldByName("CODE").Value = 9996;
            item.DataFields.FieldByName("VAT").Value = kdv/100;
            item.DataFields.FieldByName("SELVAT").Value = kdv / 100;
            item.DataFields.FieldByName("RETURNVAT").Value = kdv / 100;
            item.DataFields.FieldByName("SELPRVAT").Value = kdv / 100;
            item.DataFields.FieldByName("RETURNPRVAT").Value = kdv / 100;
            item.DataFields.FieldByName("NAME").Value = name;
            item.DataFields.FieldByName("USEF_PURCHASING").Value = 1;
            //item.DataFields.FieldByName("TIME").Value = DateTime.Now.Millisecond + 256 * DateTime.Now.Second + 65536 * DateTime.Now.Minute + 16777216 * DateTime.Now.Hour;
            item.DataFields.FieldByName("USEF_SALES").Value = 1;
            item.DataFields.FieldByName("USEF_MM").Value = 1;
            item.DataFields.FieldByName("AUTOINCSL").Value = 1;
            item.DataFields.FieldByName("LOTS_DIVISIBLE").Value = 1;
            item.DataFields.FieldByName("UNITSET_CODE").Value = "05";
            item.DataFields.FieldByName("CREATED_BY").Value = 1;
            item.DataFields.FieldByName("DATE_CREATED").Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
            item.DataFields.FieldByName("HOUR_CREATED").Value = DateTime.Now.Hour.ToString();
            item.DataFields.FieldByName("MIN_CREATED").Value = DateTime.Now.Minute.ToString();
            item.DataFields.FieldByName("SEC_CREATED").Value = DateTime.Now.Second.ToString();
            item.DataFields.FieldByName("DATA_REFERENCE").Value = 6;
            item.DataFields.FieldByName("DIST_LOT_UNITS").Value = 1;
            item.DataFields.FieldByName("COMB_LOT_UNITS").Value = 1;
            item.DataFields.FieldByName("COMB_LOT_UNITS").Value = 1;


            UnityObjects.Lines units_lines = item.DataFields.FieldByName("UNITS").Lines;
            units_lines.AppendLine();
            units_lines[units_lines.Count - 1].FieldByName("UNIT_CODE").Value = "ADET";
            units_lines[units_lines.Count - 1].FieldByName("USEF_MTRLCLASS").Value = 1;
            units_lines[units_lines.Count - 1].FieldByName("USEF_PURCHCLAS").Value = 1;
            units_lines[units_lines.Count - 1].FieldByName("USEF_SALESCLAS").Value = 1;
            units_lines[units_lines.Count - 1].FieldByName("CONV_FACT1").Value = 1;
            units_lines[units_lines.Count - 1].FieldByName("CONV_FACT2").Value = 1;
            units_lines[units_lines.Count - 1].FieldByName("DATA_REFERENCE").Value = 6;

            UnityObjects.Lines barcode_list0 = units_lines[units_lines.Count - 1].FieldByName("BARCODE_LIST").Lines;
            barcode_list0.AppendLine();
            barcode_list0[barcode_list0.Count - 1].FieldByName("BARCODE").Value = 9999999;



            item.DataFields.FieldByName("EXT_ACC_FLAGS").Value = 3;
            item.DataFields.FieldByName("PACKET").Value = 0;
            item.DataFields.FieldByName("EXTCRD_FLAGS").Value = 63;
            item.DataFields.FieldByName("UPDATECHILDS").Value = 1;
            item.DataFields.FieldByName("SALE_DEDUCTION_PART1").Value = 2;
            item.DataFields.FieldByName("SALE_DEDUCTION_PART2").Value = 3;
            item.DataFields.FieldByName("PURCH_DEDUCTION_PART1").Value = 2;
            item.DataFields.FieldByName("PURCH_DEDUCTION_PART2").Value = 3;
            if (item.Post() == true)
            {
                Result += ("Fatura Urunu % " + name + " İsimli Fatura Oluştu");
            }
            else
            {
                if (item.ErrorCode != 0)
                {
                    if (item.ErrorCode == 8)
                    {
                        _log.Info("Fatura Urunu % " + name + " İsimli Fatura Mevcut Oluşmadı");
                    }
                    else
                        Result += ("DBError(" + item.ErrorCode.ToString() + ")-" + item.ErrorDesc + item.DBErrorDesc);
                }
                else if (item.ValidateErrors.Count > 0)
                {
                    string result = "XML ErrorList:";
                    for (int j = 0; j < item.ValidateErrors.Count; j++)
                    {
                        result += "(" + item.ValidateErrors[j].ID.ToString() + ") - " + item.ValidateErrors[j].Error;
                    }
                    Result += (result);
                }
            }
        }


        /// <summary>
        /// Banka Tanımlama İşlemi Yapar
        /// </summary>
        /// <param name="bank"></param>
        /// <returns></returns>
        public string bankCreat(kdAcquirerInfoCevap kdAcquirer)
        {
            for (int i = 0; i < kdAcquirer.acquirerData.Count; i++)
            {
                var result = "";
                UnityObjects.Data bank = GMP3Infoteks.OKC.GlobalDll.unity.NewDataObject(UnityObjects.DataObjectType.doBank);
                bank.New();
                bank.DataFields.FieldByName("CODE").Value = kdAcquirer.acquirerData[i].bkmId;
                bank.DataFields.FieldByName("TITLE").Value = "HAVUZ BANK " + kdAcquirer.acquirerData[i].name;
                bank.DataFields.FieldByName("ADDRESS1").Value = "HAVUZ BANK " + kdAcquirer.acquirerData[i].name;
                bank.DataFields.FieldByName("CREATED_BY").Value = 1;
                //bank.DataFields.FieldByName("TIME").Value = DateTime.Now.Millisecond + 256 * DateTime.Now.Second + 65536 * DateTime.Now.Minute + 16777216 * DateTime.Now.Hour;
                bank.DataFields.FieldByName("DATE_CREATED").Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                bank.DataFields.FieldByName("HOUR_CREATED").Value = DateTime.Now.Hour.ToString();
                bank.DataFields.FieldByName("MIN_CREATED").Value = DateTime.Now.Minute.ToString();
                bank.DataFields.FieldByName("SEC_CREATED").Value = DateTime.Now.Second.ToString();
                bank.DataFields.FieldByName("DATA_REFERENCE").Value = 1;
                if (bank.Post() == true)
                {
                    result = "0";
                }
                else
                {
                    if (bank.ErrorCode != 0)
                    {
                        result = ("DBError(" + bank.ErrorCode.ToString() + ")-" + bank.ErrorDesc + bank.DBErrorDesc);
                    }
                    else if (bank.ValidateErrors.Count > 0)
                    {
                        result = "XML ErrorList:";
                        for (int j = 0; j < bank.ValidateErrors.Count; j++)
                        {
                            result += "(" + bank.ValidateErrors[j].ID.ToString() + ") - " + bank.ValidateErrors[j].Error;
                        }
                        return (result);
                    }
                }
            }
            return "-99";
        }


        /// <summary>
        /// Banka Hesap Tanımlama İşlemi Yapar
        /// </summary>
        /// <param name="kdSalesReceiptData"></param>
        /// <param name="i"></param>
        /// <param name="bankName"></param>
        /// <returns></returns>
        public void bankCreatAcc(kdSalesReceiptDataAllCevap kdSalesReceiptData, int j, int i, string bankName)
        {
            var result = "";
            UnityObjects.Data bankac = GMP3Infoteks.OKC.GlobalDll.unity.NewDataObject(UnityObjects.DataObjectType.doBankAccount);
            bankac.New();
            bankac.DataFields.FieldByName("ACCOUNT_TYPE").Value = 1;
            bankac.DataFields.FieldByName("CODE").Value = kdSalesReceiptData.salesData[j].bankLines[i].acquirer_id; // Unique olan terminal numarası buraya verilir Code = Hesap Codu. Bu numara sistemde var ise hesap oluşmaz.
            bankac.DataFields.FieldByName("DESCRIPTION").Value = bankName;
            bankac.DataFields.FieldByName("CREATED_BY").Value = 1;
            bankac.DataFields.FieldByName("DATE_CREATED").Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
            bankac.DataFields.FieldByName("HOUR_CREATED").Value = DateTime.Now.Hour.ToString();
            bankac.DataFields.FieldByName("MIN_CREATED").Value = DateTime.Now.Minute.ToString();
            bankac.DataFields.FieldByName("SEC_CREATED").Value = DateTime.Now.Second.ToString();
            bankac.DataFields.FieldByName("ACCOUNT_NR").Value = kdSalesReceiptData.salesData[j].bankLines[i].account_no; //Hesap Numarası
            bankac.DataFields.FieldByName("DATA_REFERENCE").Value = 1;
            bankac.DataFields.FieldByName("KKUSAGE").Value = 1; // Hesabın kredi kartı fişlerinde kullanılması için onay verir.
            bankac.DataFields.FieldByName("BANK_CODE").Value = kdSalesReceiptData.salesData[j].bankLines[i].acquirer_id; //hangi bankaya aitse onun acquırerid si
            bankac.DataFields.FieldByName("POS_TERMINAL_NO").Value = kdSalesReceiptData.salesData[j].bankLines[i].terminal_no; //Terminal Numarası
            if (bankac.Post() == true)
            {
                Result = "0";
            }
            else
            {
                if (bankac.ErrorCode != 0)
                {
                    result = ("DBError(" + bankac.ErrorCode.ToString() + ")-" + bankac.ErrorDesc + bankac.DBErrorDesc);
                }
                else if (bankac.ValidateErrors.Count > 0)
                {
                    result = "XML ErrorList:";
                    for (int k = 0; k < bankac.ValidateErrors.Count; k++)
                    {
                        result += "(" + bankac.ValidateErrors[k].ID.ToString() + ") - " + bankac.ValidateErrors[k].Error;
                    }
                    Result += (result);
                }
            }
        }

        private void CreateInvoiceCurrent(kdSalesReceiptDataAllCevap kdSalesReceiptData, int j,string fisno)
        {

            UnityObjects.Lines transactions_lines = null;
            UnityObjects.Data invoice = null;
            var sonuc = "";

            for (int i = 0; i < kdSalesReceiptData.salesData[j].salesLines.Count; i++)
            {

                string sqlQuery = "SELECT * FROM LG_001_ITEMS where NAME='"+kdSalesReceiptData.salesData[j].salesLines[i].salesLineName.Trim()+"'";
                string sqlResult = sqlProvider.DataReadCardCodeControl(sqlQuery);
                if (sqlResult == "-1") // -1 ise malzeme yok git oluştur. 
                {
                    HavuzMalzeme(Convert.ToInt16(kdSalesReceiptData.salesData[j].salesLines[i].salesLineVAT), kdSalesReceiptData.salesData[j].salesLines[i].salesLineName.Trim());
                }

                string arpCode = sqlProvider.DataReadCardCodeControl(sqlQuery);

                if (i == 0)
                {
                    invoice = GMP3Infoteks.OKC.GlobalDll.unity.NewDataObject(UnityObjects.DataObjectType.doSalesInvoice);
                    invoice.New();
                    invoice.DataFields.FieldByName("TYPE").Value = 7;
                    invoice.DataFields.FieldByName("NUMBER").Value = fisno;
                    DateTime dt = Convert.ToDateTime(kdSalesReceiptData.salesData[j].salesFaturaTarihi);
                    invoice.DataFields.FieldByName("DATE").Value = String.Format("{0:dd.MM.yyyy}", dt);
                    invoice.DataFields.FieldByName("TIME").Value = dt.Millisecond + 256 * dt.Second + 65536 * dt.Minute + 16777216 * dt.Hour;
                    invoice.DataFields.FieldByName("DOC_NUMBER").Value = kdSalesReceiptData.salesData[j].salesFaturaNo;//A5510;
                    //invoice.DataFields.FieldByName("ARP_CODE").Value = cariCode;
                    invoice.DataFields.FieldByName("POST_FLAGS").Value = 244;
                    invoice.DataFields.FieldByName("VAT_RATE").Value = kdSalesReceiptData.salesData[j].salesLines[i].salesLineVAT;
                    invoice.DataFields.FieldByName("VAT_INCLUDED_GRS").Value = 1;
                    invoice.DataFields.FieldByName("CURRSEL_TOTALS").Value = 1;

                    DateTime hour = Convert.ToDateTime(kdSalesReceiptData.salesData[j].salesFaturaTarihi);
                    DateTime Minute = Convert.ToDateTime(kdSalesReceiptData.salesData[j].salesFaturaTarihi);
                    DateTime Second = Convert.ToDateTime(kdSalesReceiptData.salesData[j].salesFaturaTarihi);
                    invoice.DataFields.FieldByName("CREATED_BY").Value = 1;
                    DateTime dtCreated = DateTime.Now;
                    invoice.DataFields.FieldByName("DATE_CREATED").Value = String.Format("{0:dd.MM.yyyy}", dtCreated);//String.Format("{0:dd/MM/yyyy}", salesInfo.InvoiceInfo.InvoiceDate);
                    invoice.DataFields.FieldByName("HOUR_CREATED").Value = hour; //DateTime.Now.Hour.ToString();
                    invoice.DataFields.FieldByName("MIN_CREATED").Value = Minute;
                    invoice.DataFields.FieldByName("SEC_CREATED").Value = Second;
                    invoice.DataFields.FieldByName("MODIFIED_BY").Value = 1;
                    invoice.DataFields.FieldByName("DATE_MODIFIED").Value = String.Format("{0:dd.MM.yyyy}", dtCreated);
                    invoice.DataFields.FieldByName("HOUR_MODIFIED").Value = DateTime.Now.Hour;
                    invoice.DataFields.FieldByName("MIN_MODIFIED").Value = DateTime.Now.Minute;
                    invoice.DataFields.FieldByName("SEC_MODIFIED").Value = DateTime.Now.Second;

                    transactions_lines = invoice.DataFields.FieldByName("TRANSACTIONS").Lines;
                    transactions_lines.AppendLine();
                    transactions_lines[i].FieldByName("TYPE").Value = 0;
                    transactions_lines[i].FieldByName("MASTER_CODE").Value = arpCode; //malzeme kodu
                    transactions_lines[i].FieldByName("QUANTITY").Value = kdSalesReceiptData.salesData[j].salesLines[i].salesLineAmount; //malzeme adeti gelecek buraya.
                    transactions_lines[i].FieldByName("PRICE").Value = float.Parse(kdSalesReceiptData.salesData[j].salesLines[i].salesLineTotCost);
                    transactions_lines[i].FieldByName("UNIT_CODE").Value = "ADET";
                    transactions_lines[i].FieldByName("UNIT_CONV1").Value = 1;
                    transactions_lines[i].FieldByName("UNIT_CONV2").Value = 1;
                    transactions_lines[i].FieldByName("VAT_INCLUDED").Value = 1;
                    transactions_lines[i].FieldByName("VAT_RATE").Value = kdSalesReceiptData.salesData[j].salesLines[i].salesLineVAT;
                }
                else
                {
                    transactions_lines = invoice.DataFields.FieldByName("TRANSACTIONS").Lines;
                    transactions_lines.AppendLine();
                    transactions_lines[i].FieldByName("TYPE").Value = 0;
                    transactions_lines[i].FieldByName("MASTER_CODE").Value = arpCode;
                    transactions_lines[i].FieldByName("QUANTITY").Value = kdSalesReceiptData.salesData[j].salesLines[i].salesLineAmount;
                    transactions_lines[i].FieldByName("PRICE").Value = float.Parse(kdSalesReceiptData.salesData[j].salesLines[i].salesLineTotCost);
                    transactions_lines[i].FieldByName("UNIT_CODE").Value = "ADET";
                    transactions_lines[i].FieldByName("UNIT_CONV1").Value = 1;
                    transactions_lines[i].FieldByName("UNIT_CONV2").Value = 1;
                    transactions_lines[i].FieldByName("VAT_INCLUDED").Value = 1;
                    transactions_lines[i].FieldByName("VAT_RATE").Value = kdSalesReceiptData.salesData[j].salesLines[i].salesLineVAT;
                }

            } 
            try
            {
                if (invoice.Post() == true)
                {
                    sonuc = ("POST OK ! Fat No : " + invoice.DataFields.FieldByName("NUMBER").Value.ToString());
                }
                else
                {
                    if (invoice.ErrorCode != 0)
                    {
                        sonuc = ("DBError(" + invoice.ErrorCode.ToString() + ")-" + invoice.ErrorDesc + invoice.DBErrorDesc);
                    }
                    else if (invoice.ValidateErrors.Count > 0)
                    {
                        string result = "XML ErrorList:";
                        for (int i = 0; i < invoice.ValidateErrors.Count; i++)
                        {
                            result += "(" + invoice.ValidateErrors[i].ID.ToString() + ") - " + invoice.ValidateErrors[i].Error;
                        }
                        sonuc = (result);
                    }
                }
                _log.Info(sonuc);
            }
            catch (Exception ex)
            {
                _log.Warning(ex.Message);
            }

        }

        private void KKOdemeAktar(kdSalesReceiptDataAllCevap kdSalesReceiptData, string fisNo, int j, bool parcali)
        {
            //burası sadece kredi kartlı satışlarda iş yapacaz.
            for (int i = 0; i < kdSalesReceiptData.salesData[j].bankLines.Count; i++)
            {
                string Query = "select Code from LG_001_BNCARD where CODE='" + Convert.ToInt16(kdSalesReceiptData.salesData[j].bankLines[i].acquirer_id) + "'";
                string QueryResult = sqlProvider.DataReadCardCodeControl(Query);
                if (QueryResult == "-1") // banka tanımlı değil gir oluştur.
                {
                    //hepsi program açılışta servisten çekilip otomatik oluşturuluyor. 
                }
                //Bankası tanımlıysa banka hesabı varmı gir ona bak hele.
                Query = "select ACCOUNTNO,POSTERMINALNUM from LG_001_BANKACC where CODE='" + Convert.ToInt16(kdSalesReceiptData.salesData[j].bankLines[i].acquirer_id) + "'";
                QueryResult = sqlProvider.DataReadCardBankAccControl(Query);
                if (QueryResult == "-1")
                {
                    //tanımlı acc yok gir oluştur.
                    for (int z = 0; z < kdSalesReceiptData.salesData[j].bankLines.Count; z++)
                    {
                        Query = "select DEFINITION_,LOGICALREF from LG_001_BNCARD where CODE='" + Convert.ToInt16(kdSalesReceiptData.salesData[j].bankLines[z].acquirer_id) + "'";
                        QueryResult = sqlProvider.DataReadReturnBankNameWhereAcqID(Query);
                        bankCreatAcc(kdSalesReceiptData, j, z, QueryResult);
                    }
                    if (Result == "0")
                    {
                        _log.Info("Banka Acc Oluşturuldu Bank Name :: " + QueryResult);
                    }
                    //kk li fiş aktarımı başlar
                }

                if (i == 0)
                {
                    arpvoucher = GMP3Infoteks.OKC.GlobalDll.unity.NewDataObject(UnityObjects.DataObjectType.doARAPVoucher);
                    arpvoucher.New();
                    arpvoucher.DataFields.FieldByName("NUMBER").Value = fisNo;
                    arpvoucher.DataFields.FieldByName("DATE").Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                    arpvoucher.DataFields.FieldByName("TYPE").Value = 70; // Kredi Kartı Fişi
                    arpvoucher.DataFields.FieldByName("TOTAL_CREDIT").Value = float.Parse(kdSalesReceiptData.salesData[j].salesKKAmount);
                    arpvoucher.DataFields.FieldByName("RC_TOTAL_CREDIT").Value = float.Parse(kdSalesReceiptData.salesData[j].salesKKAmount);
                    arpvoucher.DataFields.FieldByName("CREATED_BY").Value = 1;
                    arpvoucher.DataFields.FieldByName("DATE_CREATED").Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                    arpvoucher.DataFields.FieldByName("HOUR_CREATED").Value = DateTime.Now.Hour.ToString();
                    arpvoucher.DataFields.FieldByName("MIN_CREATED").Value = DateTime.Now.Minute.ToString();
                    arpvoucher.DataFields.FieldByName("TIME").Value = DateTime.Now.Millisecond + 256 * DateTime.Now.Second + 65536 * DateTime.Now.Minute + 16777216 * DateTime.Now.Hour;
                    arpvoucher.DataFields.FieldByName("SEC_CREATED").Value = DateTime.Now.Second.ToString();
                    arpvoucher.DataFields.FieldByName("CURRSEL_TOTALS").Value = 3;
                    arpvoucher.DataFields.FieldByName("DATA_REFERENCE").Value = 1;
                    arpvoucher.DataFields.FieldByName("NOTES1").Value = "Fis No: " + kdSalesReceiptData.salesData[j].salesReceiptNo + " Z No: " + kdSalesReceiptData.salesData[j].salesZNo + " Eku No: " + kdSalesReceiptData.salesData[j].salesEKUNo;
                    if (parcali == true)
                    {
                        arpvoucher.DataFields.FieldByName("NOTES2").Value = float.Parse(kdSalesReceiptData.salesData[j].salesKKAmount) + "TL kredi karti, " +
                            float.Parse(kdSalesReceiptData.salesData[j].salesCashAmount) + "TL nakit ödeme alınmıştır.";
                    }
                    else
                    {
                        arpvoucher.DataFields.FieldByName("NOTES2").Value = float.Parse(kdSalesReceiptData.salesData[j].salesKKAmount) + "TL kredi karti ile ödeme alınmıştır.";
                    }
                    string note = "a";
                    for (int c = 0; c < kdSalesReceiptData.salesData[j].salesLines.Count; c++)
                    {
                        int res = 3;                        
                        note = c + 1 + ".Fiş Kalemi :" + kdSalesReceiptData.salesData[j].salesLines[c].salesLineName.Trim();
                        res += res;
                    }
                    arpvoucher.DataFields.FieldByName("NOTES3").Value = note;
                    arpvoucher.DataFields.FieldByName("NOTES4").Value = note;
                    //Maks 4 adet alan girilebiliyor. Logoya sorduk dönüş bekliyoruz.

                    transactions_lines = arpvoucher.DataFields.FieldByName("TRANSACTIONS").Lines;
                    transactions_lines.AppendLine();
                    transactions_lines[i].FieldByName("ARP_CODE").Value = 1000; // Cari Kodu
                    transactions_lines[i].FieldByName("DOC_NUMBER").Value = kdSalesReceiptData.salesData[j].bankLines[i].receipt_no;
                    transactions_lines[i].FieldByName("CREDIT").Value = kdSalesReceiptData.salesData[j].bankLines[i].amount;
                    transactions_lines[i].FieldByName("TC_XRATE").Value = 1;
                    transactions_lines[i].FieldByName("TC_AMOUNT").Value = kdSalesReceiptData.salesData[j].bankLines[i].amount;
                    transactions_lines[i].FieldByName("RC_XRATE").Value = 1;
                    transactions_lines[i].FieldByName("RC_AMOUNT").Value = kdSalesReceiptData.salesData[j].bankLines[i].amount;
                    transactions_lines[i].FieldByName("BNLN_TC_XRATE").Value = 1;
                    transactions_lines[i].FieldByName("BNLN_TC_AMOUNT").Value = kdSalesReceiptData.salesData[j].bankLines[i].amount;
                    transactions_lines[i].FieldByName("CREDIT_CARD_NO").Value = kdSalesReceiptData.salesData[j].bankLines[i].kk_number;
                    transactions_lines[i].FieldByName("MONTH").Value = DateTime.Now.Month.ToString();
                    transactions_lines[i].FieldByName("YEAR").Value = DateTime.Now.Year.ToString();
                    transactions_lines[i].FieldByName("AFFECT_RISK").Value = 0;
                    transactions_lines[i].FieldByName("BATCH_NR").Value = kdSalesReceiptData.salesData[j].bankLines[i].batch_no;
                    transactions_lines[i].FieldByName("APPROVE_NR").Value = kdSalesReceiptData.salesData[j].bankLines[i].onay_no;
                    transactions_lines[i].FieldByName("DESCRIPTION").Value = " ";
                    transactions_lines[i].FieldByName("BANKACC_CODE").Value = kdSalesReceiptData.salesData[j].bankLines[i].acquirer_id;
                    transactions_lines[i].FieldByName("DISTRIBUTION_TYPE_FNO").Value = 0;
                    arpvoucher.DataFields.FieldByName("ARP_CODE").Value = 1000;
                    arpvoucher.DataFields.FieldByName("AFFECT_RISK").Value = 0;
                }
                else
                {
                    transactions_lines = arpvoucher.DataFields.FieldByName("TRANSACTIONS").Lines;
                    transactions_lines.AppendLine();
                    transactions_lines[i].FieldByName("ARP_CODE").Value = 1000; // Cari Kodu
                    transactions_lines[i].FieldByName("DOC_NUMBER").Value = kdSalesReceiptData.salesData[j].bankLines[i].receipt_no;
                    transactions_lines[i].FieldByName("CREDIT").Value = kdSalesReceiptData.salesData[j].bankLines[i].amount;
                    transactions_lines[i].FieldByName("TC_XRATE").Value = 1;
                    transactions_lines[i].FieldByName("TC_AMOUNT").Value = kdSalesReceiptData.salesData[j].bankLines[i].amount;
                    transactions_lines[i].FieldByName("RC_XRATE").Value = 1;
                    transactions_lines[i].FieldByName("RC_AMOUNT").Value = kdSalesReceiptData.salesData[j].bankLines[i].amount;
                    transactions_lines[i].FieldByName("BNLN_TC_XRATE").Value = 1;
                    transactions_lines[i].FieldByName("BNLN_TC_AMOUNT").Value = kdSalesReceiptData.salesData[j].bankLines[i].amount;
                    transactions_lines[i].FieldByName("CREDIT_CARD_NO").Value = kdSalesReceiptData.salesData[j].bankLines[i].kk_number;
                    transactions_lines[i].FieldByName("MONTH").Value = DateTime.Now.Month.ToString();
                    transactions_lines[i].FieldByName("YEAR").Value = DateTime.Now.Year.ToString();
                    transactions_lines[i].FieldByName("AFFECT_RISK").Value = 0;
                    transactions_lines[i].FieldByName("BATCH_NR").Value = kdSalesReceiptData.salesData[j].bankLines[i].batch_no;
                    transactions_lines[i].FieldByName("APPROVE_NR").Value = kdSalesReceiptData.salesData[j].bankLines[i].onay_no;
                    transactions_lines[i].FieldByName("DESCRIPTION").Value = " ";
                    transactions_lines[i].FieldByName("BANKACC_CODE").Value = kdSalesReceiptData.salesData[j].bankLines[i].acquirer_id;
                    transactions_lines[i].FieldByName("DISTRIBUTION_TYPE_FNO").Value = 0;
                }
            }
            if (arpvoucher.Post() == true)
            {
                Result = Result + ("0");
            }
            else
            {
                if (arpvoucher.ErrorCode != 0)
                {
                    Result = "DBError(" + arpvoucher.ErrorCode.ToString() + ")-" + arpvoucher.ErrorDesc + arpvoucher.DBErrorDesc;
                }
                else if (arpvoucher.ValidateErrors.Count > 0)
                {
                    string result = "XML ErrorList:";
                    for (int m = 0; m < arpvoucher.ValidateErrors.Count; m++)
                    {
                        result += "(" + arpvoucher.ValidateErrors[m].ID.ToString() + ") - " + arpvoucher.ValidateErrors[m].Error;
                    }
                    Result = (result);
                }
            }
        }

        private void KKNakitAktar(kdSalesReceiptDataAllCevap kdSalesReceiptData, string fisNo, int j)
        {
            for (int i = 0; i < kdSalesReceiptData.salesData[j].salesLines.Count; i++)
            {
                string QuerycariNo = "select CODE from LG_001_CLCARD where DEFINITION_='Havuz Cari %" +
                    Convert.ToInt16(kdSalesReceiptData.salesData[j].salesLines[i].salesLineVAT) / 100 + "'";
                string arpcode = sqlProvider.DataReadCardCodeControl(QuerycariNo);
                if (arpcode == "-1") // Cariler yok ise gider oluşturur.
                {
                    Result = CreateCurrentParametric(Convert.ToInt16(kdSalesReceiptData.salesData[j].salesLines[i].salesLineVAT) / 100, "Havuz Cari %");
                    if (Result == "0") // Eğer cariyi oluşturabildiyse gidip codunu alır.
                    {
                        QuerycariNo = "select CODE from LG_001_CLCARD where DEFINITION_='Havuz Cari %" +
                                            Convert.ToInt16(kdSalesReceiptData.salesData[j].salesLines[i].salesLineVAT) / 100 + "'";
                        arpcode = sqlProvider.DataReadCardCodeControl(QuerycariNo);
                    }
                }
                if (i == 0)
                {
                    arpvoucher = GMP3Infoteks.OKC.GlobalDll.unity.NewDataObject(UnityObjects.DataObjectType.doARAPVoucher);
                    arpvoucher.New();
                    arpvoucher.DataFields.FieldByName("NUMBER").Value = fisNo;
                    arpvoucher.DataFields.FieldByName("DATE").Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                    arpvoucher.DataFields.FieldByName("TYPE").Value = 1;
                    arpvoucher.DataFields.FieldByName("NOTES1").Value = "Fis No: " + kdSalesReceiptData.salesData[j].salesReceiptNo + " Z No: " + kdSalesReceiptData.salesData[j].salesZNo + " Eku No: " + kdSalesReceiptData.salesData[j].salesEKUNo;
                    arpvoucher.DataFields.FieldByName("TIME").Value = DateTime.Now.Millisecond + 256 * DateTime.Now.Second + 65536 * DateTime.Now.Minute + 16777216 * DateTime.Now.Hour;
                    arpvoucher.DataFields.FieldByName("CREATED_BY").Value = 1;
                    arpvoucher.DataFields.FieldByName("DATE_CREATED").Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                    arpvoucher.DataFields.FieldByName("HOUR_CREATED").Value = DateTime.Now.Hour.ToString();
                    arpvoucher.DataFields.FieldByName("MIN_CREATED").Value = DateTime.Now.Minute.ToString();
                    arpvoucher.DataFields.FieldByName("SEC_CREATED").Value = DateTime.Now.Second.ToString();
                    arpvoucher.DataFields.FieldByName("CURRSEL_TOTALS").Value = 3;
                    arpvoucher.DataFields.FieldByName("DATA_REFERENCE").Value = 5;
                    transactions_lines = arpvoucher.DataFields.FieldByName("TRANSACTIONS").Lines;
                    transactions_lines.AppendLine();
                    transactions_lines[i].FieldByName("ARP_CODE").Value = arpcode;
                    transactions_lines[i].FieldByName("DESCRIPTION").Value = kdSalesReceiptData.salesData[j].salesLines[i].salesLineName.Trim();
                    transactions_lines[i].FieldByName("CREDIT").Value = (float)float.Parse(kdSalesReceiptData.salesData[j].salesLines[i].salesLineTotCost);
                    transactions_lines[i].FieldByName("TC_AMOUNT").Value = (float)float.Parse(kdSalesReceiptData.salesData[j].salesLines[i].salesLineTotCost);
                    transactions_lines[i].FieldByName("RC_XRATE").Value = 1;
                    transactions_lines[i].FieldByName("RC_AMOUNT").Value = (float)float.Parse(kdSalesReceiptData.salesData[j].salesLines[i].salesLineTotCost);
                    transactions_lines[i].FieldByName("DATA_REFERENCE").Value = 59;
                    transactions_lines[i].FieldByName("MONTH").Value = DateTime.Now.Month.ToString();
                    transactions_lines[i].FieldByName("YEAR").Value = DateTime.Now.Year.ToString();
                    transactions_lines[i].FieldByName("AFFECT_RISK").Value = 1;
                    transactions_lines[i].FieldByName("DISCOUNTED").Value = 5;
                    transactions_lines[i].FieldByName("DISTRIBUTION_TYPE_FNO").Value = 0;
                    arpvoucher.DataFields.FieldByName("AFFECT_RISK").Value = 1;
                }
                else
                {
                    transactions_lines = arpvoucher.DataFields.FieldByName("TRANSACTIONS").Lines;
                    transactions_lines.AppendLine();
                    transactions_lines[i].FieldByName("ARP_CODE").Value = arpcode;
                    transactions_lines[i].FieldByName("DESCRIPTION").Value = kdSalesReceiptData.salesData[j].salesLines[i].salesLineName.Trim();
                    transactions_lines[i].FieldByName("CREDIT").Value = (float)float.Parse(kdSalesReceiptData.salesData[j].salesLines[i].salesLineTotCost);
                    transactions_lines[i].FieldByName("TC_AMOUNT").Value = (float)float.Parse(kdSalesReceiptData.salesData[j].salesLines[i].salesLineTotCost);
                    transactions_lines[i].FieldByName("RC_XRATE").Value = 1;
                    transactions_lines[i].FieldByName("RC_AMOUNT").Value = (float)float.Parse(kdSalesReceiptData.salesData[j].salesLines[i].salesLineTotCost);
                    transactions_lines[i].FieldByName("DATA_REFERENCE").Value = 59;
                    transactions_lines[i].FieldByName("MONTH").Value = DateTime.Now.Month.ToString();
                    transactions_lines[i].FieldByName("YEAR").Value = DateTime.Now.Year.ToString();
                    transactions_lines[i].FieldByName("AFFECT_RISK").Value = 1;
                    transactions_lines[i].FieldByName("DISCOUNTED").Value = 5;
                    transactions_lines[i].FieldByName("DISTRIBUTION_TYPE_FNO").Value = 0;
                    arpvoucher.DataFields.FieldByName("AFFECT_RISK").Value = 1;
                }
            }
            if (arpvoucher.Post() == true)
            {
                Result = Result + ("0");
            }
            else
            {
                if (arpvoucher.ErrorCode != 0)
                {
                    Result = "DBError(" + arpvoucher.ErrorCode.ToString() + ")-" + arpvoucher.ErrorDesc + arpvoucher.DBErrorDesc;
                }
                else if (arpvoucher.ValidateErrors.Count > 0)
                {
                    string result = "XML ErrorList:";
                    for (int m = 0; m < arpvoucher.ValidateErrors.Count; m++)
                    {
                        result += "(" + arpvoucher.ValidateErrors[m].ID.ToString() + ") - " + arpvoucher.ValidateErrors[m].Error;
                    }
                    Result = (result);
                }
            }
        }

        /// <summary>
        /// kdSalesReceiptData İçerisinde gelen datayı logonun ilgili alanlarına sevk eder. Fiş.. Fatura v.s
        /// </summary>
        /// <param name="kdSalesReceiptData"></param>
        /// <returns></returns>
        public string transferVoucherNoCurrent(kdSalesReceiptDataAllCevap kdSalesReceiptData)
        {
            _xmlItem = _xmlProv.XmlRead();
            CreateCurrentParametric(1000, "Havuz Cari %");
            try
            {
                for (int j = 0; j < kdSalesReceiptData.salesData.Count; j++)
                {
                    var zNo = kdSalesReceiptData.salesData[j].salesZNo.ToString().PadLeft(5, '0');
                    var sRetfisNo = kdSalesReceiptData.salesData[j].salesReceiptNo.ToString().PadLeft(5, '0');
                    var ekuNo = kdSalesReceiptData.salesData[j].salesEKUNo.ToString().PadLeft(5, '0');
                    var fisNo = ekuNo + zNo + sRetfisNo;
                    //k.k ve nakit aynı anda varsa buraya giriyor orada patlıyor oraya bir bakacaz

                    if (kdSalesReceiptData.salesData[j].salesType == "fis")
                    {
                        if (Convert.ToInt16(kdSalesReceiptData.salesData[j].salesCashAmount) > 0 && Convert.ToInt16(kdSalesReceiptData.salesData[j].salesKKAmount) > 0)
                        {
                            KKOdemeAktar(kdSalesReceiptData, fisNo, j, true);
                        }
                        if (kdSalesReceiptData.salesData[j].salesCashAmount == "0" && Convert.ToInt16(kdSalesReceiptData.salesData[j].salesKKAmount) > 0)
                        {
                            KKOdemeAktar(kdSalesReceiptData, fisNo, j, false);
                        }

                        ///Buraya sadece nakit fişlerde girecek.
                        if (kdSalesReceiptData.salesData[j].salesKKAmount == "0" && Convert.ToInt16(kdSalesReceiptData.salesData[j].salesCashAmount) > 0)
                        {
                            KKNakitAktar(kdSalesReceiptData, fisNo, j);
                        }
                    }
                    else if (kdSalesReceiptData.salesData[j].salesType == "fatura")
                    {
                        CreateInvoiceCurrent(kdSalesReceiptData, j, fisNo);
                    }
                    _ws.Query_Method_kdUpdateReceiptLogoStatus(_CreatQuery.CREATE_ServerIdResponse(_xmlItem, kdSalesReceiptData.salesData[j].salesServerId));

                }
            }
            catch (Exception ex)
            {
                _log.Warning("transferVoucherNoCurrent  :: " + ex.Message);
            }
            return "";
        }


        /// <summary>
        /// Cari lerin Statik Kod Numaraları
        /// </summary>
        public enum AccCode
        {
            HavuzCari0 = 996,
            HavuzCari1 = 997,
            HavuzCari8 = 998,
            HavuzCari18 = 999,
            ParcaliOdeme = 1000,
        }

        /// <summary>
        /// Banka Acquirer Idler Globaldir.
        /// </summary>
        public enum BankAcquirerID
        {
            MerkezBankasi = 1,
            HalkBankasi = 12,
            VakıflarBankasi = 15,
            TurkEkonomiBankasi = 32,
            AkBank = 46,
            SekerBank = 59,
            GarantiBankasi = 62,
            İşBankası = 64,
            YapıveKrediBankası = 67,
            Citibank = 92,
            TurkishBank = 96,
            INGBank = 103,
            Fibabanka = 108,
            TurklandBank = 109,
            TekstilBank = 111,
            QNBFinansbank = 123,
            HSBC = 124,
            AlternatifBank = 125,
            BurgerBank = 134,
            Denizbank = 135,
            AnadoluBank = 143,
            AktifYatırımBankası = 146,
            OdeaBank = 203,
            AlbarakaTürkKatılımBankası = 205,
            KuveyTürkKatılımBankası = 206,
            ZiraatBankası = 10,
        }
    }
}


