using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MotorDepot
    {
        private string motorDepotName;
        protected long requestNumber;


        public long RequestNumber => requestNumber;
        public MotorDepot()
        {

        }
        public MotorDepot(string motorDepotName)
        {
            this.motorDepotName = motorDepotName;
        }
      
    }
}
