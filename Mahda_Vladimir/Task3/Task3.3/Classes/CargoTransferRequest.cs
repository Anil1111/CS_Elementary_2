using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3.Classes
{
    //заявка на перевозку груза
    public class CargoTransferRequest
    {
        public CargoTransfer cargoTransfer;
        public Driver driver;
        public Truck truck;
        //private bool requestIsProcessed = false; //обработана ли заявка

        public CargoTransferRequest(CargoTransfer cargoTransfer, Driver driver, Truck truck)
        {
            this.cargoTransfer = cargoTransfer;
            this.driver = driver;
            this.truck = truck;
        }

        public void RequestShow()
        {
            cargoTransfer.CargoTransferShow();
            driver.DriverShow();
            truck.TruckShow();
        }
        //public bool RequestIsProcessed { get => requestIsProcessed; set => requestIsProcessed = value; }
    }
}
