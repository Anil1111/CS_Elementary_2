using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DispatchcerRequest : MotorDepot
    {
        public DispatchcerRequest(long requestNumber, string driver, string car, string dispatcher) : base(requestNumber, driver, car, dispatcher)
        {

        }
        //метод для диспетчера о допущении водителя к работе
        public void RoadPermitFromDispatcher(bool roadPermit)
        {
            RoadPermit = roadPermit;
        }

    }
}
