using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3.Classes
{
    public class Dispatcher
    {
        private string dispatcherName;
        List<CargoTransferRequest> listRequest;

        public string DispatcherName { get => dispatcherName; }

        public Dispatcher(string dispatcherName)
        {
            this.dispatcherName = dispatcherName;
            listRequest = new List<CargoTransferRequest>();
        }

        // устранение или допуск водителя к работе
        public void SetDriverToWork(Driver driver, bool state) => driver.DriverIsWork = state;

        // возможно ли выполнить данную заявку?
        public bool IsTransferPossible(CargoTransfer cargoTransfer, Driver driver, Truck truck)
        {
            if (cargoTransfer.TransferIsComplete == true)
            {
                Console.WriteLine($"Cargo transfer #{cargoTransfer.TransferNumber} already complete! Set another transfer");
                return false;
            }

            if (driver.DriverIsWork == true)
            {
                Console.WriteLine($"Driver {driver.DriverName} is busy now! Set another driver");
                return false;
            }

            if (truck.IsReady == false)
            {
                Console.WriteLine($"Truck {truck.TruckMark} {truck.TruckNumber} is busy now! Set another truck");
                return false;
            }

            if (truck.IsNeedRepair == true)
            {
                Console.WriteLine($"Truck {truck.TruckMark} {truck.TruckNumber} needs repairs! Set another truck");
                return false;
            }
            return true;
        }

        // Обработка заявки на перевозку груза
        public void SetCargoTransfer(CargoTransfer cargoTransfer, Driver driver, Truck truck)
        {
            if (IsTransferPossible(cargoTransfer, driver, truck))
            {
                Console.WriteLine($"Request transfer #{cargoTransfer.TransferNumber} successfully processed");
                driver.TruckCondition(truck, false);    //машина занята, она уезжает в рейс
                SetDriverToWork(driver, true);          //водитель отправляется в рейс
                cargoTransfer.TransferIsComplete = true;//трансфер обработан
                listRequest.Add(new CargoTransferRequest(cargoTransfer, driver, truck));
            }
        }

        public void DispatcherShow()
        {
            Console.WriteLine($"Dispatcher: {DispatcherName}");
        }

        public void AllTransfersRequestShow()
        {
            Console.WriteLine(new string('*', 70));
            Console.WriteLine("All requests");
            foreach (var item in listRequest)
            {
                Console.WriteLine(new string('-', 70));
                item.RequestShow();
            }
            Console.WriteLine(new string('*', 70));
        }
    }
}
