﻿using System;
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
                        writer.WriteElementString("userName",s.userName);
                        writer.WriteElementString("passWord", s.passWord);
                        writer.WriteElementString("LoginState", Convert.ToString(s.LoginState));
                        if (Convert.ToInt16(s.zNo) > 1)
                        {
                            writer.WriteElementString("zNo", s.zNo);
                        }else
                            writer.WriteElementString("zNo", "1");

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
