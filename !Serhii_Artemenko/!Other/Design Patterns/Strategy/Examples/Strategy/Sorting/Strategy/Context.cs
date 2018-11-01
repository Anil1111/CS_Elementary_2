using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Strategy
{
   class Context
    {
        Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void Sort(ref int[] array)
        {
            strategy.Sort(ref array);
        }

        public void Print(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
