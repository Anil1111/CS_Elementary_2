using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Strategy
{
    abstract class Strategy
    {
        public abstract void Sort(ref int[] array); 
    }
}
