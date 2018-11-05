using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;


namespace LogoDesktopApplication
{
    public partial class Form1 : Form
    {
        #region Global Variable
        WS_Class.WSProvider _ws;
        object kdContractInfo;
        object kdEventsData;
        object kdSalesReceiptData;
        object kdSalesReportData;
        object kdStatisticsData;
        object kdZReportData;
      #endregion

        

        //Yasin deneme iki
        //Yasin deneme
        //Yasin deneme uc
        public Form1()
        {
            InitializeComponent();
            _ws = new WS_Class.WSProvider();
            MethodTest();
        }

        void MethodTest()
        {
            kdContractInfo = _ws.Query_Method_kdContractInfo();
            kdEventsData = _ws.Query_Method_kdEventsData();
            kdSalesReceiptData = _ws.Query_Method_kdSalesReceiptData();
            kdSalesReportData = _ws.Query_Method_kdSalesReportData();
            kdStatisticsData = _ws.Query_Method_kdStatisticsData();
            kdZReportData = _ws.Query_Method_kdZReportData();
        }
    }
}
