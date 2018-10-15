using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }


        public Time(int year, int month, int day, int hour, int minute, int second)
        {
            dateTime = new DateTime(year, month, day, hour, minute, second);
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
    }
}
