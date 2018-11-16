using LogoDesktopApplication.WS_Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static LogoDesktopApplication.HelperForms.HelperItemCs;

namespace LogoDesktopApplication.HelperForms
{
   public class XmlProvider
    {
        Serializer _ser;        
        public XmlProvider()
        {
            _ser = new Serializer();
        }
        public string XmlWriterMethod(OtoSenkron s)
        {
            try
            {

                if (!Directory.Exists("CFG"))
                {
                    Directory.CreateDirectory("CFG");
                }
                if (File.Exists("CFG\\Config.xml"))
                {
                    File.Delete("CFG\\Config.xml");
                }
                if (!File.Exists("CFG\\Config.xml"))
                {
                    using (XmlWriter writer = XmlWriter.Create("CFG\\Config.xml"))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("OtoSenkron");
                        if (s.Durum == null)
                        {
                            s.Durum = "0";
                        }
                        writer.WriteElementString("SenkronType", s.SenkronType.ToString());
                        writer.WriteElementString("Saat", s.Saat);
                        if (s.Period == null)
                        {
                            s.Period = "";
                        }
                        writer.WriteElementString("Period", s.Period.Replace("DK", " ").Trim());
                        writer.WriteElementString("Durum", s.Durum);
                        writer.WriteElementString("InfoLisances", s.InfoLisances);
                        writer.WriteElementString("InfoKurumKodu", s.InfoKurumKodu);
                        writer.WriteElementString("InfoKurumToken", s.InfoKurumToken);
                        writer.WriteElementString("InfoLoginState", Convert.ToString(s.InfoLoginState));
                        writer.WriteElementString("LogoLoginState", Convert.ToString(s.LogoLoginState));
                        writer.WriteElementString("LogoUserName", s.LogoUserName);
                        writer.WriteElementString("LogoPassword", s.LogoPassword);
                        writer.WriteElementString("INFOTEKSSozlesmeZamani", s.INFOTEKSSozlesmeZamani);
                        writer.WriteEndElement();
                        writer.WriteEndDocument();

                    }
                }
                return "0";
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        public OtoSenkron XmlRead()
        {
            OtoSenkron OtoSenkronItem = new OtoSenkron();
            if (!Directory.Exists("CFG"))
            {
                Directory.CreateDirectory("CFG");
            }
            if (!File.Exists("CFG\\Config.xml"))
            {
                XmlWriterMethod(OtoSenkronItem);
            }

            string path = Directory.GetCurrentDirectory() + @"\CFG\\Config.xml";
            string xmlInputData = File.ReadAllText(path);

            OtoSenkronItem = _ser.Deserialize<OtoSenkron>(xmlInputData);
            return OtoSenkronItem;
        }


    }
}
