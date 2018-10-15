using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MotorDepot
    {
        private long requestNumber;
        private string dispatcher;
        private string driver;
        private string car;
        private bool completedWork;//отметка о выполнении рейса от водителя после выполнения
        private string vehicleCondition;//состояние автомобиля от водителя после выполнения
        private bool applicationForRepair;//заявка на ремонт от водителя
        private bool roadPermit;//разрешение на дорогу от диспетчера

        public long RequestNumber { get; set; }
        public bool RoadPermit { get; set; }
        //конструктор для создаия заявки от диспетчера
        public MotorDepot(long requestNumber, string driver, string car, string dispatcher)
        {
            this.requestNumber = requestNumber;
            this.driver = driver;
            this.car = car;
            this.dispatcher = dispatcher;
        }

        //конструктор для дополнения заявки от водителя
        public MotorDepot(DispatchcerRequest request, bool completedWork, string vehicleCondition)
        {
            this.completedWork = completedWork;
            this.vehicleCondition = vehicleCondition;
        }
    }
}
