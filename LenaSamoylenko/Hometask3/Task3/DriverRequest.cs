using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DriverRequest : MotorDepot
    {

        private string vehicleCondition;//состояние автомобиля от водителя после выполнения
        private bool applicationForRepair = false;//заявка на ремонт от водителя
        private bool acceptanceStamp;//отметка о принятии работы
        private bool completionMark = false;//отметка о завершении работы 
        public DriverRequest(DispatchcerRequest request, string driverName):base()
        {
            if (request.Driver == driverName)
            {
                base.requestNumber = request.RequestNumber;
                acceptanceStamp = true;
            }
            else Console.WriteLine("Error with {0}, request is not for this driver", driverName);
        }

        public void MarkComleteWork(bool completionMark, string vehicleCondition)
        {
            this.completionMark = completionMark;
            this.vehicleCondition = vehicleCondition;
        }


        //конструктор для дополнения заявки от водителя
        public void RepairCar()
        {
            applicationForRepair = true;
            acceptanceStamp = false;
        }
    }
}
