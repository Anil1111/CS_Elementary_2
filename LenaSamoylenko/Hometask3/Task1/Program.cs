using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Time myDateTime = Program.Inizialization();
            helpClass.Print(myDateTime.DataTime);

            myDateTime.addDateTimeHour = 1;
            myDateTime.addDateTimeMinute = 1;
            myDateTime.addDateTimeSeconds = 1;
            helpClass.Print(myDateTime.DataTime);

            Console.ReadKey();
        }

        public static Time Inizialization()
        {
            Time myDateTime;
            int year = helpClass.inputData("Put the year please");
            int month = helpClass.inputData("Put the month please");
            int day = helpClass.inputData("Put the day please");

            int hours = helpClass.inputData("Put the hours please");
            int minutes = helpClass.inputData("Put the minutes please");
            int seconds = helpClass.inputData("Put the seconds please");

            try
            {
                myDateTime = new Time(year, month, day, hours, minutes, seconds);

            }
            catch
            {
                myDateTime = null;
                Console.WriteLine("Some error");
                Environment.Exit(0);
            }
            return myDateTime;

        }
    }
}
