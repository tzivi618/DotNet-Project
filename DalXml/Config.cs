using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{

   

internal static class Config
    {
        private static string fileName = "../xml/data-config.xml";

        public static int nextProductId
        {
            get
            {
                // קריאה מהקובץ XML
                XElement xml = XElement.Load(fileName);
                int nextId= (int)xml.Element("NextProductId");
                xml.Element("NextProductId").Value = (nextId+1).ToString();
                xml.Save(fileName);
                return nextId;
            }
        }

        public static int nextSaleId
        {
            get
            {
                // קריאה מהקובץ XML
                XElement xml = XElement.Load(fileName);
                int nextId = (int)xml.Element("NextSaleId");
                xml.Element("NextSaleId").Value = (nextId + 1).ToString();
                xml.Save(fileName);
                return nextId;
            }
        }
    }

    

}
