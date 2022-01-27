using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Class_Lib_XML
{
    public class DataStore
    {
        public XSD.Gunstore instans;
        public DataStore()
        {
            using (var reader = XmlReader.Create("my.xml"))
            {
                var serializer = new XmlSerializer(typeof(XSD.Gunstore));

                instans = (XSD.Gunstore)serializer.Deserialize(reader);
            }
        }
    }
}
