using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Check
    {
        public bool IsNumeric(string Symbol)
        {
            bool rezult = false;
            for (int i = 0; i < Symbol.Length; i++) //Для каждого символа в входной строке
            {
                if (("0123456789".IndexOf(Symbol[i]) != -1)) rezult = true;
                else break;
            }

            return rezult;
        }
    }


        class GetSetTime
    {
        private string hh;
        private string mi;
        private string si;

        const string Error = "Введено не Интовое значение !!!";
        const string Error1 = " не могут быть больше ";
        const int Chas = 12;
        const int MinSec = 59;

        public string HH
        {
            get
            {
                if (new Check().IsNumeric(hh))
                {
                    if (Convert.ToInt16(hh) <= Chas) return hh;
                    else
                    {
                        Console.WriteLine(@"Часы {0} 12 !!!",Error1);
                        return "00";
                    }
                }
                else
                {
                    Console.WriteLine(Error);
                    return "00";
                }
            }
            set { }
        }

        public string MI
        {
            get
            {
                if (new Check().IsNumeric(mi))
                {
                    if (Convert.ToInt16(mi) <= MinSec) return mi;
                    else
                    {
                        Console.WriteLine(@"Минуты {0} 60 !!!",Error1);
                        return "00";
                    }
                }
                else
                {
                    Console.WriteLine(Error);
                    return "00";
                }
            }
            set { }
        }

        public string SI
        {
            get
            {
                if (new Check().IsNumeric(si))
                {
                    if (Convert.ToInt16(si) <= MinSec) return si;
                    else
                    {
                        Console.WriteLine(@"Секунды {0} 60 !!!",Error1);
                        return "00";
                    }
                }
                else
                {
                    Console.WriteLine(Error);
                    return "00";
                }
            }
            set { }
        }

        public GetSetTime(string hh, string mi, string si)
        {
            this.hh = hh;
            this.mi = mi;
            this.si = si;
        }

        public void ShowTime()
        {            
            Console.Write(@"Текущее время: {0}:{1}:{2}",System.DateTime.Now.Hour,System.DateTime.Now.Minute,System.DateTime.Now.Second);
        }

        

        public void ShowTime(string hh, string mi, string si)
        {
            Console.Write(@"Измененное время: {0}:{1}:{2}", hh, mi, si);
        }

        public void TimeAdd()
        {
            DateTime timeAdd = System.DateTime.Now;
            timeAdd = timeAdd.AddHours(Convert.ToDouble(HH));
            timeAdd = timeAdd.AddMinutes(Convert.ToDouble(MI));
            timeAdd = timeAdd.AddSeconds(Convert.ToDouble(SI));

            Console.Write(@"Изменения времени на заданное количество часов, минут и секунд.: {0}", timeAdd.ToLongTimeString());
        }
    }
}
