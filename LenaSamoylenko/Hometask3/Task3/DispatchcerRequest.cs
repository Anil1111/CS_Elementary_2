using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DispatchcerRequest : MotorDepot
    {
        //чет не то(
        private string dispatcher;
        private string driver;
        private string car;
        private bool roadPermit = true;//разрешение на дорогу от диспетчера

        public string Driver => driver;


        //конструктор для создаия заявки от диспетчера
        public DispatchcerRequest(string dispatcher, string motorDepotName) : base(motorDepotName)
        {
            this.dispatcher = dispatcher;
        }
        public void AddRequest(long requestNumber, string driver, string car)
        {
            this.requestNumber = requestNumber;
            this.driver = driver;
            this.car = car;
        }

        //метод для диспетчера о допущении водителя к работе
        public void RoadPermitFromDispatcher(bool roadPermit)
        {
            this.roadPermit = roadPermit;
        }



    }
}
