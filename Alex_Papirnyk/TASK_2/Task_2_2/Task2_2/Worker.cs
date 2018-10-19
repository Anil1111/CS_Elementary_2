using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    /*
     фамилия и инициалы работника;
   название занимаемой должности;
  год поступления на работу. методы:
  ввод данных в массив из n элементов в типа Worker;
  упорядочить по алфавиту фамилии работников;
  вывод работников, чей стаж работы в фирме превышает значение, введенное пользователем.
     */
    class Worker
    {
        private string name;
        private string position;
        private int year;

        public string Name { get => name;}
        public string Position { get => position; }
        public int Year { get => year; }

        public Worker()
        {

        }
        public Worker(string name,string position,int year)
        {
            this.name = name;
            this.position = position;
            this.year = year;
        }
        
        
    }
}
