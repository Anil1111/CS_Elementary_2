using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hometask3
{
    class Time
    {
        private DateTime dateTime;
        public int addDateTimeHour { set { dateTime = dateTime.AddHours(value); } }
        public int addDateTimeMinute { set { dateTime = dateTime.AddMinutes(value); } }
        public int addDateTimeSeconds { set { dateTime = dateTime.AddSeconds(value); } }
        public DateTime DataTime => dateTime;

        public Time(int year, int month, int day)
        {
            dateTime = new DateTime(year, month, day);
            helpClass.CreateFileForExceptions();
        }


        public Time(int year, int month, int day, int hour, int minute, int second)
        {
            dateTime = new DateTime(year, month, day, hour, minute, second);
            helpClass.CreateFileForExceptions();
        }

        public void ChangeData()
        {
            bool inProcces = true;
            while (inProcces)
            {
                Console.WriteLine("Chose what you want to change: '1' - hours...'3'-seconds");
                int helpVar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Put delta");
                int delta = Convert.ToInt32(Console.ReadLine());
                switch (helpVar)
                {
                    case 1:
                        dateTime = dateTime.AddHours(delta);
                        break;
                    case 2:
                        dateTime = dateTime.AddMinutes(delta);
                        break;
                    case 3:
                        dateTime = dateTime.AddSeconds(delta);
                        break;
                    default:
                        break;
                }
                helpClass.Print(dateTime);
                Console.WriteLine("Put 'true' if you want to repead changing or 'false' to stop");
                inProcces = Convert.ToBoolean(Console.ReadLine());
            }
        }
    }

    static class helpClass
    {
        public static void Print(DateTime datetime)
        {

            Console.WriteLine(datetime);
        }
        public static int inputData(string message)
        {
            Console.WriteLine(message);
            int res = Convert.ToInt32(Console.ReadLine());
            return res;
        }

        public static void CreateFileForExceptions()
        {
            string path = @"D:\Exception";
            string all = path + @"\Exception.txt";
            DirectoryInfo dirInf = new DirectoryInfo(path);
            if (!dirInf.Exists)
            {
                dirInf.Create();
                if (!File.Exists(all))
                {
                    var fileExc = System.IO.File.Create(path + @"\Exception.txt");
                    fileExc.Close();
                }
            }
        }
    }
}


