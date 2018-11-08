using System;

//Составить описание класса для представления времени.Предусмотреть возможности 
//установки времени и изменения его отдельных полей (час, минута, секунда) с
//проверкой допустимости вводимых значений. В случае недопустимых значений полей 
//выбрасываются исключения.Создать методы изменения времени на заданное количество 
//часов, минут и секунд.

namespace Task3._1
{
    public class MyTime
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour
        {
            get { return hour; }
            set
            {
                if (value >= 0 && value <= 24) hour = value;
                else throw new Exception("invalid hour value");
            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value >= 0 && value <= 60) minute = value;
                else throw new Exception("invalid minute value");
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value >= 0 && value <= 60) second = value;
                else throw new Exception("invalid second value");
            }
        }

        public MyTime()
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }

        public MyTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }


        public void SetMyTime()
        {
            bool isContinue = true;
            do
            {
                Console.WriteLine("What would you like to set?");
                Console.Write("1 - hour, 2 - minutes, 3 - seconds, 0 - exit : ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                switch (key.KeyChar)
                {
                    case '0':
                        isContinue = false;
                        break;
                    case '1':
                        Console.Write("set hours: ");
                        Hour = Int32.Parse(Console.ReadLine());
                        break;
                    case '2':
                        Console.Write("set minutes: ");
                        Minute = Int32.Parse(Console.ReadLine());
                        break;
                    case '3':
                        Console.Write("set seconds: ");
                        Second = Int32.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine();
                ShowMyTime();
            } while (isContinue);
        }

        public void Add3Hours()
        {
            if (Hour > 20)
            {
                Hour += 3 - 24;
            }
            else
            {
                Hour += 3;
            }
        }

        public void Add10Minutes()
        {
            if (Minute >= 50)
            {
                Minute += 10 - 60;
                Hour += 1;
                if (Hour == 24) Hour = 0;
            }
            else
            {
                Minute += 10;
            }
        }

        public void Add30Seconds()
        {
            if (Second >= 30)
            {
                Second += 30 - 60;
                if (Minute == 59)
                {
                    Minute = 0;
                    Hour += 1;
                }
                if (Hour == 24) Hour = 0;
            }
            else
            {
                Second += 30;
            }
        }

        public void ShowMyTime()
        {
            Console.WriteLine($"Time:: {Hour} hours : {Minute} minutes : {Second} seconds");
        }
    }
}
