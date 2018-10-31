using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3.Classes
{
    public class Driver
    {
        private string driverName;
        private bool driverIsWork;  //водитель занят?

        public string DriverName { get => driverName; }
        public bool DriverIsWork { get => driverIsWork; set => driverIsWork = value; }

        public Driver(string driverName, bool driverIsWork = false)
        {
            this.driverName = driverName;
            this.driverIsWork = driverIsWork;
        }

        /// <summary>
        /// Запрос на ремонт автомоиля
        /// </summary>
        /// <param name="track"></param>
        public void RepairRequest(Truck truck)
        {
            if (truck.IsNeedRepair != true)
            {
                truck.IsNeedRepair = true;
                TruckCondition(truck, false);
            }
        }

        // отметка о выполнении рейса
        public void CargoTransferMark(CargoTransferRequest request)
        {
            request.cargoTransfer.TransferIsComplete = true;    //рейс выполнен
            request.truck.IsReady = true;                       //авто свободно

        }

        //отметка о состоянии автомобиля
        public void TruckCondition(Truck truck, bool state) => truck.IsReady = state;

        public void DriverShow()
        {
            Console.WriteLine($"Driver: {DriverName}; is busy: {DriverIsWork}");
        }
    }
}
