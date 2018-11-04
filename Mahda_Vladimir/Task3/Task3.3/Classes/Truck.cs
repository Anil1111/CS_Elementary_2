using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    public class Truck
    {
        private string truckMark;
        private string truckNumber;
        private double truckCapasity;       // грузоподъемность авто
        private bool isReady = true;        // авто готово к рейсу?
        private bool isNeedRepair = false;  // авто нуждается в ремонте?

        public string TruckMark { get => truckMark;}
        public string TruckNumber { get => truckNumber;}
        public double TruckCapasity { get => truckCapasity;}
        public bool IsReady { get => isReady; set => isReady = value; }
        public bool IsNeedRepair { get => isNeedRepair; set => isNeedRepair = value; }

        public Truck(string truckMark, string truckNumber, double truckCapasity, bool isReady, bool isNeedRepair)
        {
            this.truckMark = truckMark;
            this.truckNumber = truckNumber;
            this.truckCapasity = truckCapasity;
            this.isReady = isReady;
            this.isNeedRepair = isNeedRepair;
        }

        public void TruckShow()
        {
            Console.WriteLine($"Truck: {TruckMark}; number: {TruckNumber}; Cargo transfer ready: {IsReady}; Need repair: {IsNeedRepair}");
        }
    }
}
