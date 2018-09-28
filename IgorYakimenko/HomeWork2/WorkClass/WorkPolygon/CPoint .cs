using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPolygon
{
    class CPoint
    {       
        private int pole1;
        private int pole2;
        private string pole3;

        public int Pole1 
        {
            get 
            {
                return pole1;
            }
        }
        
        public int Pole2 
        {
            get 
            {
                return pole2;
            }
        }
        
        public string Pole3
        {
            get 
            {
                return pole3;
            }
        }

        public CPoint(int pole1, int pole2, string pole3)
        {            
            this.pole1 = pole1;
            this.pole2 = pole2;
            this.pole3 = pole3;
        }
    }
}
