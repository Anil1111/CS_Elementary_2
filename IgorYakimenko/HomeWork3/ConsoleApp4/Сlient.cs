using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Сlient
    {
        private string fio;
        private string naim;
        private Int16 count;
        private Int16 idOrder;
        private double price;

        public Int16 IdOrder
        {
            get
            {
                return idOrder;
            }
        }
        
        public string Fio
        {
            get
            {
                return fio;
            }
        }

        public string Naim
        {
            get
            {
                return naim;
            }
        }

        public Int16 Count
        {
            get
            {
                try
                {
                    count = Convert.ToInt16(count / 1);
                    return count;
                }
                catch
                {
                    return 1;
                }
            }
        }

        public double Price
        {
            get
            {
                try
                {
                    price = Convert.ToDouble(price / 1);
                    return price;
                }
                catch
                {
                    return 0;
                }
            }
        }


        public Сlient(Int16 idOrder, string fio ,string naim, Int16 count, double price)
        {
            this.idOrder = idOrder;
            this.fio = fio;
            this.naim = naim;
            this.count = count;
            this.price = price;
        }
       
    }
}
