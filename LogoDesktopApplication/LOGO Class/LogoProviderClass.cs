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
        #endregion
        

        public LogoProviderClass()
        {
            sqlProvider = new SQLProvider();
            _log = new Log();
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
                arps.DataFields.FieldByName("TITLE").Value = cariName+cAriCode;
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
                        _log.Warning("CreateCurrentParametric ::"+arps.ErrorCode.ToString() + ")-" + arps.ErrorDesc + arps.DBErrorDesc);
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


        //public void HavuzMalzeme()
        //{
        //    string Result = "";
        //    for (int i = 0; i < kisimList.Count; i++)
        //    {
        //        if (!kisimList[i].KISIMName.Contains("KISIM"))
        //        {
        //            UnityObjects.Data item = GMP3Infoteks.OKC.GlobalDll.unity.NewDataObject(UnityObjects.DataObjectType.doMaterial);
        //            item.New();
        //            item.DataFields.FieldByName("CARD_TYPE").Value = 13;
        //            if (kisimList[i].VatRate == 0)
        //            {
        //                item.DataFields.FieldByName("CODE").Value = 9996;
        //                item.DataFields.FieldByName("VAT").Value = 0;
        //                item.DataFields.FieldByName("SELVAT").Value = 0;
        //                item.DataFields.FieldByName("RETURNVAT").Value = 0;
        //                item.DataFields.FieldByName("SELPRVAT").Value = 0;
        //                item.DataFields.FieldByName("RETURNPRVAT").Value = 0;
        //            }
        //            if (kisimList[i].VatRate == 1)
        //            {
        //                item.DataFields.FieldByName("CODE").Value = 9997;
        //                item.DataFields.FieldByName("VAT").Value = 1;
        //                item.DataFields.FieldByName("SELVAT").Value = 1;
        //                item.DataFields.FieldByName("RETURNVAT").Value = 1;
        //                item.DataFields.FieldByName("SELPRVAT").Value = 1;
        //                item.DataFields.FieldByName("RETURNPRVAT").Value = 1;
        //            }
        //            if (kisimList[i].VatRate == 8)
        //            {
        //                item.DataFields.FieldByName("CODE").Value = 9998;
        //                item.DataFields.FieldByName("VAT").Value = 8;
        //                item.DataFields.FieldByName("SELVAT").Value = 8;
        //                item.DataFields.FieldByName("RETURNVAT").Value = 8;
        //                item.DataFields.FieldByName("SELPRVAT").Value = 8;
        //                item.DataFields.FieldByName("RETURNPRVAT").Value = 8;
        //            }
        //            if (kisimList[i].VatRate == 18)
        //            {
        //                item.DataFields.FieldByName("CODE").Value = 9999;
        //                item.DataFields.FieldByName("VAT").Value = 18;
        //                item.DataFields.FieldByName("SELVAT").Value = 18;
        //                item.DataFields.FieldByName("RETURNVAT").Value = 18;
        //                item.DataFields.FieldByName("SELPRVAT").Value = 18;
        //                item.DataFields.FieldByName("RETURNPRVAT").Value = 18;
        //            }
        //            item.DataFields.FieldByName("NAME").Value = "Fatura Urunu %" + kisimList[i].VatRate;
        //            item.DataFields.FieldByName("USEF_PURCHASING").Value = 1;
        //            //item.DataFields.FieldByName("TIME").Value = DateTime.Now.Millisecond + 256 * DateTime.Now.Second + 65536 * DateTime.Now.Minute + 16777216 * DateTime.Now.Hour;
        //            item.DataFields.FieldByName("USEF_SALES").Value = 1;
        //            item.DataFields.FieldByName("USEF_MM").Value = 1;
        //            item.DataFields.FieldByName("AUTOINCSL").Value = 1;
        //            item.DataFields.FieldByName("LOTS_DIVISIBLE").Value = 1;
        //            item.DataFields.FieldByName("UNITSET_CODE").Value = "05";
        //            item.DataFields.FieldByName("CREATED_BY").Value = 1;
        //            item.DataFields.FieldByName("DATE_CREATED").Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
        //            item.DataFields.FieldByName("HOUR_CREATED").Value = DateTime.Now.Hour.ToString();
        //            item.DataFields.FieldByName("MIN_CREATED").Value = DateTime.Now.Minute.ToString();
        //            item.DataFields.FieldByName("SEC_CREATED").Value = DateTime.Now.Second.ToString();
        //            item.DataFields.FieldByName("DATA_REFERENCE").Value = 6;
        //            item.DataFields.FieldByName("DIST_LOT_UNITS").Value = 1;
        //            item.DataFields.FieldByName("COMB_LOT_UNITS").Value = 1;

        //            UnityObjects.Lines units_lines = item.DataFields.FieldByName("UNITS").Lines;
        //            units_lines.AppendLine();
        //            units_lines[units_lines.Count - 1].FieldByName("UNIT_CODE").Value = "ADET";
        //            units_lines[units_lines.Count - 1].FieldByName("USEF_MTRLCLASS").Value = 1;
        //            units_lines[units_lines.Count - 1].FieldByName("USEF_PURCHCLAS").Value = 1;
        //            units_lines[units_lines.Count - 1].FieldByName("USEF_SALESCLAS").Value = 1;
        //            units_lines[units_lines.Count - 1].FieldByName("CONV_FACT1").Value = 1;
        //            units_lines[units_lines.Count - 1].FieldByName("CONV_FACT2").Value = 1;
        //            units_lines[units_lines.Count - 1].FieldByName("DATA_REFERENCE").Value = 6;
        //            item.DataFields.FieldByName("EXT_ACC_FLAGS").Value = 3;
        //            item.DataFields.FieldByName("PACKET").Value = 0;
        //            item.DataFields.FieldByName("EXTCRD_FLAGS").Value = 63;
        //            item.DataFields.FieldByName("UPDATECHILDS").Value = 1;
        //            item.DataFields.FieldByName("SALE_DEDUCTION_PART1").Value = 2;
        //            item.DataFields.FieldByName("SALE_DEDUCTION_PART2").Value = 3;
        //            item.DataFields.FieldByName("PURCH_DEDUCTION_PART1").Value = 2;
        //            item.DataFields.FieldByName("PURCH_DEDUCTION_PART2").Value = 3;
        //            if (item.Post() == true)
        //            {
        //                Result+=("Fatura Urunu % " + kisimList[i].VatRate + " İsimli Fatura Oluştu");
        //            }
        //            else
        //            {
        //                if (item.ErrorCode != 0)
        //                {
        //                    if (item.ErrorCode == 8)
        //                    {
        //                        Result+=("Fatura Urunu % " + kisimList[i].VatRate + " İsimli Fatura Mevcut Oluşmadı");
        //                    }
        //                    else
        //                        Result+=("DBError(" + item.ErrorCode.ToString() + ")-" + item.ErrorDesc + item.DBErrorDesc);
        //                }
        //                else if (item.ValidateErrors.Count > 0)
        //                {
        //                    string result = "XML ErrorList:";
        //                    for (int j = 0; j < item.ValidateErrors.Count; j++)
        //                    {
        //                        result += "(" + item.ValidateErrors[j].ID.ToString() + ") - " + item.ValidateErrors[j].Error;
        //                    }
        //                    Result+=(result);
        //                }
        //            }
        //        }
        //    }            
        //}



        /// <summary>
        /// kdSalesReceiptData İçerisinde gelen fiş verilerini logoya sevk eder.
        /// </summary>
        /// <param name="kdSalesReceiptData"></param>
        /// <returns></returns>
        public string transferVoucherNoCurrent(kdSalesReceiptDataCevap kdSalesReceiptData)
        {
            string Result = null;


            UnityObjects.Data arpvoucher = null;
            UnityObjects.Lines transactions_lines = null;

            try
            {
                for (int j = 0; j < kdSalesReceiptData.salesData.Count; j++)
                {
                    var zNo = kdSalesReceiptData.salesData[j].salesZNo.ToString().PadLeft(5, '0');
                    var sRetfisNo = kdSalesReceiptData.salesData[j].salesReceiptNo.ToString().PadLeft(5, '0');
                    var ekuNo = kdSalesReceiptData.salesData[j].salesEKUNo.ToString().PadLeft(5, '0');
                    var fisNo = ekuNo + zNo + sRetfisNo;

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
                        Result = Result + (": POST OK !");
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
                return Result;
            }
            catch (Exception ex) 
            {
                _log.Warning("transferVoucherNoCurrent  :: " + ex.Message);
                return ex.Message;
            }

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
    }
}
    

