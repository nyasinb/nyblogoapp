using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            string path = Directory.GetCurrentDirectory() + @"\CFG\\Config.xml";
            string xmlInputData = File.ReadAllText(path);

            OtoSenkron OtoSenkronItem = _ser.Deserialize<OtoSenkron>(xmlInputData);
            return OtoSenkronItem;
        }
    }
}
