using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Merchandiser
    {
        private string naim;
        private Int16 count;
        private Int16 id;
        private double unitPrice;

        public Int16 Id
        {
            get
            {
                return id;
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

        public float UnitPrice
        {
            get
            {
                try
                {
                    unitPrice = Convert.ToDouble(unitPrice / 1);
                    return count;
                }
                catch
                {
                    return 0;
                }
            }
        }


        public Merchandiser(Int16 id, string naim, Int16 count, double unitPrice)
        {
            this.id = id;
            this.naim = naim;
            this.count = count;
            this.unitPrice = unitPrice;
        }
       
    }
}
