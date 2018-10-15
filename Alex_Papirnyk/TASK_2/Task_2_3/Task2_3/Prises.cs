using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    class Prises
    {
        List<Prise> prises;
        public Prises()
        {
            prises = new List<Prise>();
        }
        public void InputData(Prise p)
        {
            prises.Add(p);
        }
        private void Show(Prise p)
        {
            Console.WriteLine($"{p.Name}--{p.Shop}--{p.Cash}");
        }
    
        private void Print(List<Prise> p)
        {

            foreach (var prise in p)
            {
                Show(prise);
            }
        }
        public void prisesSorting()
        {
            List<Prise> tempList = new List<Prise>();
            
                tempList = prises.OrderBy(x => x.Name).ToList();
           
            Print(tempList);
        }

        private void Show(string name, string shop, double cash)
        {
            Console.WriteLine("Name:{0} Shop:{1} Cash:{2}", name, shop, cash);
        }
        public void userConditionOrder()
        {
            Console.WriteLine("Put your type of product");

            string productType = Console.ReadLine();
            foreach (Prise price in prises)
            {
                if (price.Name == productType)
                { Show(price.Name, price.Shop, price.Cash); }
            }
        }
    }
}
