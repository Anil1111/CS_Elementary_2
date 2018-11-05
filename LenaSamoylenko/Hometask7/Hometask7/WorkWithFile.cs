using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Hometask7
{
    class WorkWithFile
    {
        private AbstractHandler _abstractHandler;
        private string fullName;
        public string FullName => fullName;

        public AbstractHandler AbstractHandler => _abstractHandler;

        public WorkWithFile()
        {
            Dictionary<int, string> allFormats = new Dictionary<int, string>(3)
            { { 1, "doc" },  { 2, "txt" },  { 3, "xml" } };
            Console.WriteLine("Put full file name");
            //fullName = Console.ReadLine();

            fullName = "C:\\Users\\Admin\\Documents\\Test\\1.txt";
            string fileFormat = fullName.Split('.').Last();
            int fileFormatInDictionary = ((allFormats.Where(f => f.Value == fileFormat)).Select(f => f.Key)).First();
            
            //операции с классом в соответствии с выбранным форматом 

            switch (fileFormatInDictionary)
            {
                case 1:
                    _abstractHandler = new DOCHandler();
                    break;
                case 2:
                    _abstractHandler = new TXTHandler();
                    break;
                case 3:
                    _abstractHandler = new XMLHandler();
                    break;
                default:
                    Console.WriteLine("Error with put file, don`t known format");
                    break;
            }
        }
        //типовой для выбора пользователем способа реализации
        //public WorkWithFile(AbstractHandler abstractHandler)
        //{
        //    _abstractHandler = abstractHandler;
        //}

        //public void SetStrategy(AbstractHandler abstractHandler)
        //{
        //    _abstractHandler = abstractHandler;
        //}

        public void ExecuteOperationOpen()
        {
            _abstractHandler.Open(fullName);
        }

        public void ExecuteOperationSave()
        {
            _abstractHandler.Save(fullName);
        }
        public void ExecuteOperationCreate()
        {
            _abstractHandler.Create(fullName);
        }
        public void ExecuteOperationChange()
        {
            _abstractHandler.Change(fullName);

        }

        public static bool ContinueAddText()
        {
            Console.WriteLine("Do you wan to continue changing (true/false)");
            bool continueAdd = Convert.ToBoolean(Console.ReadLine());
            return continueAdd;
        }
    }
}
