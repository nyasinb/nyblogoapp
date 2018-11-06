using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace LogoDesktopApplication.HelperForms
{
    public partial class LogoSenkronForm : UserControl
    {
        HelperItemCs _helperItem;
        Serializer _ser;
        public LogoSenkronForm()
        {
            InitializeComponent();
            _ser = new Serializer();
            OtoSenkron item = new OtoSenkron();
            ConfigXml(item);
            if (item.Durum=="0")
            {
                ConfigXml(item);
            }
            else
            {
                item = XmlRead();
                btnSenkronOnOf.Checked = Convert.ToBoolean(item.Durum);
            }
            if (item.Durum=="true" || item.Durum=="false")
            {

            }
        }

        public OtoSenkron XmlRead()
        {
            string path = Directory.GetCurrentDirectory() + @"\CFG\\Config.xml";
            string xmlInputData = File.ReadAllText(path);

            OtoSenkron OtoSenkronItem = _ser.Deserialize<OtoSenkron>(xmlInputData);
            return OtoSenkronItem;
        }

        public void ConfigXml(OtoSenkron s)
        {
            if (File.Exists("CFG\\Config.xml"))
            {
                File.Delete("CFG\\Config.xml");
            }
            if (!Directory.Exists("CFG"))
            {
                Directory.CreateDirectory("CFG");
            }
            
            if (!File.Exists("CFG\\Config.xml"))
            {
                using (XmlWriter writer = XmlWriter.Create("CFG\\Config.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("OtoSenkron");
                    if (s.Durum==null)
                    {
                        s.Durum = "0";
                    }
                    writer.WriteElementString("Saat", s.Saat);
                    writer.WriteElementString("Period", s.Saat);
                    writer.WriteElementString("Durum", s.Durum);
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
        }

        private void btnSenkronOnOf_Click(object sender, EventArgs e)
        {
            if (btnSenkronOnOf.Checked)
            {
                btnSenkronOnOf.Text = "Senkron Kapalı";
                midPanel.Visible = false;
                btnSenkronOnOf.ImageOptions.Image = global::LogoDesktopApplication.Properties.Resources.Toggle_Off_40;
            }
            else
            {
                btnSenkronOnOf.ImageOptions.Image = global::LogoDesktopApplication.Properties.Resources.Toggle_On_40;
                btnSenkronOnOf.Text = "Senkron Açık";
                midPanel.Visible = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OtoSenkron s = new OtoSenkron();
            s.Durum = btnSenkronOnOf.Checked.ToString();
            s.Saat = txtSaat.Text;
            s.Period = txtPeriod.Text;
            ConfigXml(s);
        }
    }
}
