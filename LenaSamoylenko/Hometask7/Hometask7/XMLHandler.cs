using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml;
using System.IO;


namespace Hometask7
{
    class XMLHandler : AbstractHandler
    {

        public override void Change(string fullName)
        {
            Console.WriteLine("Put added text");
            string value = Console.ReadLine();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(fullName, null);
            xmlTextWriter.WriteString(value);
            xmlTextWriter.Close();
        }

        public override void Create(string fullName)
        {
            XmlWriter.Create(fullName);
            //close
        }

        public override void Open(string fullName)
        {
            XmlReader xml = new XmlTextReader(fullName);
            //метод для считывания стринга с файла
            Console.WriteLine(xml);
            xml.Close();
        }

        public override void Save(string fullName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Save(fullName);
        }
    }
}
