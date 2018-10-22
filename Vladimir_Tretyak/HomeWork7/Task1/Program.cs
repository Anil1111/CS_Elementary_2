using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

//Создайте класс AbstractHandler.В теле класса создать методы void Open(), 
//void Create(), void Chenge(), void Save(). Создать производные классы XMLHandler, TXTHandler, 
//DOCHandler от базового класса AbstractHandler.Написать программу, которая будет выполнять 
//определение документа и для каждого формата должны быть методы открытия, создания,
//редактирования, сохранения определенного формата документа.

namespace HW7Task1
{

    static class CreateFile//Создание файла
    {
        public static string createFile(string file, string content)
        {
            File.AppendAllText(file, content);
            return file;
        }
    }

    class Controller//Определяет какого формата файл получен и создаёт соответствующий объект для работы с ним
    {
        static public WorkWithFile downloadFile(string file)
        {
            string e = Path.GetExtension(file);

            switch (e)
            {
                case ".txt":
                    return new WorkWithFile(new TXTHandler(file));
                case ".xml":
                    return new WorkWithFile(new XMLHandler(file));
                case ".doc":
                    return new WorkWithFile(new DOCHandler(file));
                default:
                    Console.WriteLine("Файл не распознан");
                    return null;
            }
        }
    }

    class WorkWithFile//Работа с полученным от контроллера файлом
    {
        AbstractHandler FileHandler;
        public WorkWithFile(AbstractHandler fileHandler)
        {
            FileHandler = fileHandler;
        }

        public void OpenFile()
        {
            FileHandler.Open();
        }
        public void ChangeFile()
        {
            FileHandler.Change();
        }
        public void SaveFile()
        {
            FileHandler.Save();
        }
        public void CreateFile()
        {
            FileHandler.Create();
        }
    }

    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        string XmlFile;
        string tempText;
        public XMLHandler(string xmlFile)
        {
            XmlFile = xmlFile;
        }
        public override void Change()
        {
            tempText = Console.ReadLine();
        }

        public override void Create()
        {
           
        }

        public override void Open()
        {
            string text = File.ReadAllText(XmlFile);
            Console.WriteLine("Ваш текст :" + text);
        }

        public override void Save()
        {
            File.AppendAllText(XmlFile, Environment.NewLine + tempText);
        }
    }

    class TXTHandler : AbstractHandler
    {
        string TxtFile;
        string tempText;
        public TXTHandler(string txtFile)
        {
            TxtFile = txtFile;
        }
        public override void Change()
        {
           tempText = Console.ReadLine();            
        }
        public override void Create()
        {
           
        }
        public override void Open()
        {
            string text = File.ReadAllText(TxtFile);
            Console.WriteLine("Ваш текст :" + text);
        }
        public override void Save()
        {
            File.AppendAllText(TxtFile, Environment.NewLine + tempText);
        }
    }
    class DOCHandler : AbstractHandler
    {
        string DocFile;
        string tempText;
        public DOCHandler(string docFile)
        {
            DocFile = docFile;
        }
        public override void Change()
        {
            tempText = Console.ReadLine();
        }

        public override void Create()
        {
           
        }

        public override void Open()
        {
            string text = File.ReadAllText(DocFile);
            Console.WriteLine("Ваш текст :" + text);

        }

        public override void Save()
        {
            File.AppendAllText(DocFile, Environment.NewLine + tempText);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку типа F:\\MyFile.doc для создания своего файла: ");
            string file = Console.ReadLine();
            Console.WriteLine("Введите текст своего файла: ");
            string content = Console.ReadLine();
            WorkWithFile f = Controller.downloadFile(CreateFile.createFile(file, content));
            f.OpenFile();
            Console.WriteLine("Введите новый текст для добавления в файл");
            f.ChangeFile();
            Console.Write("Нажмите Enter для сохранения");
            Console.ReadLine();
            f.SaveFile();
            Console.WriteLine("Файл сохранён");
            Console.ReadLine();
        }
    }
}
