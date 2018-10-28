using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
using System.IO;


namespace Hometask7
{
    class XMLHandler : AbstractHandler
    {
        XDocument xml = new XDocument();


        public override void Change(string fullName)
        {
            //не работает как хочу(
            bool continueAdd = true;
            var writerXML = xml.CreateWriter();
            XmlTextWriter XmlWriter = new XmlTextWriter(fullName, null);
            XmlWriter.WriteStartDocument();


            while (continueAdd)
            {
                Console.WriteLine("Put start element");
                //XmlWriter.WriteStartElement(Console.ReadLine());
                XmlWriter.WriteStartElement("Settings");

                Console.WriteLine("Put start element");
                //XmlWriter.WriteStartElement(Console.ReadLine());
                XmlWriter.WriteStartElement("TimeTrans");

                Console.WriteLine("Put start attribute");
                //XmlWriter.WriteStartAttribute(Console.ReadLine());
                XmlWriter.WriteStartAttribute("TransD", null);

                Console.WriteLine("Put write string");
                //XmlWriter.WriteString(Console.ReadLine());
                XmlWriter.WriteString("TransDSE");

                XmlWriter.WriteEndAttribute();

                Console.WriteLine("Put start attribute");
                //XmlWriter.WriteStartAttribute(Console.ReadLine());
                XmlWriter.WriteStartAttribute("TransH", null);

                Console.WriteLine("Put write string");
                //XmlWriter.WriteString(Console.ReadLine());
                XmlWriter.WriteString("TransHSE");

                XmlWriter.WriteEndAttribute();

                Console.WriteLine("Put start attribute");
                //XmlWriter.WriteStartAttribute(Console.ReadLine());
                XmlWriter.WriteStartAttribute("TransM", null);

                Console.WriteLine("Put write string");
                //XmlWriter.WriteString(Console.ReadLine());
                XmlWriter.WriteString("TransMSE");
                XmlWriter.WriteEndAttribute();
                XmlWriter.WriteEndElement();
                XmlWriter.WriteEndElement();

                continueAdd = WorkWithFile.ContinueAddText();
            }
            Console.WriteLine("------Changing was done------");
            XmlWriter.Close();

        }


        public override void Open(string fullName)
        {
            using (StreamReader oReader = new StreamReader(fullName, Encoding.GetEncoding("ISO-8859-1")))
            {
                xml = XDocument.Load(oReader);
            }
            var content = xml.Root;
            Console.WriteLine(content);
            Console.WriteLine("------Opening was done------");
        }

        public override void Save(string fullName)
        {
            Console.WriteLine("------Saving was done------");
            xml.Save(fullName);
        }


        //private static string AddPartOfText(string message)
        //{
        //    Console.WriteLine(message);
        //    string value1 = Console.ReadLine();
        //    return value1;
        //}

     
    }
}
