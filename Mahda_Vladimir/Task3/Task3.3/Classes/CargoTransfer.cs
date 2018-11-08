using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3.Classes
{
    //Рейс
    public class CargoTransfer
    {
        private int transferNumber;                 //номер рейса
        private string transferType;                //тип перевозимого груза
        private string transferDeparturePoint;      //откуда
        private string transferDeliveryPoint;       //куда
        private bool transferIsComplete;            //рейс выполнен?

        public CargoTransfer(int transferNumber, string transferType, string transferDeparturePoint, string transferDeliveryPoint, bool transferIsComplete = false)
        {
            this.transferNumber = transferNumber;
            this.transferType = transferType;
            this.transferDeparturePoint = transferDeparturePoint;
            this.transferDeliveryPoint = transferDeliveryPoint;
            this.transferIsComplete = transferIsComplete;
        }

        public int TransferNumber { get => transferNumber; }
        public string TransferType { get => transferType; }
        public string TransferDeparturePoint { get => transferDeparturePoint; }
        public string TransferDeliveryPoint { get => transferDeliveryPoint; }
        public bool TransferIsComplete { get => transferIsComplete; set => transferIsComplete = value; }

        public void CargoTransferShow()
        {
            Console.WriteLine($"transfer number: {TransferNumber}; type: {TransferType}; from: {TransferDeparturePoint}; to: {TransferDeliveryPoint}; complete: {TransferIsComplete}");
        }
    }
}
