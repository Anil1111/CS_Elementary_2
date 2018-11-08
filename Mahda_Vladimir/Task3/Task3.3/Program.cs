using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3._3.Classes;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck Daf = new Truck("DAF", "AE 1234 BD", 3000, isReady: true, isNeedRepair: false);
            Truck Man = new Truck("MAN", "CD 5678 ZX", 5000, isReady: true, isNeedRepair: false);
            Truck Zil = new Truck("ZIL", "ED 9012 ZZ", 3500, isReady: true, isNeedRepair: true);

            Driver Petrenko = new Driver("Petrenko");
            Driver Zagoruiko = new Driver("Zagoruiko");
            Driver Bibber = new Driver("Bibber", true);

            CargoTransfer ToysTransfer = new CargoTransfer(14, "Toys", "Dnipro", "Kyiv");
            CargoTransfer MonkeyTransfer = new CargoTransfer(25, "Monkey", "Kyiv", "Rivne");
            CargoTransfer ElephantTransfer = new CargoTransfer(54, "Elephant", "Kyiv", "Lviv");

            Dispatcher supervisor = new Dispatcher("King");

            Zil.TruckShow();
            Bibber.RepairRequest(Zil);
            Zil.TruckShow();
            Console.WriteLine(new string('-', 70));
            supervisor.SetCargoTransfer(ToysTransfer, Petrenko, Daf);           
            supervisor.AllTransfersRequestShow();
         
            supervisor.SetCargoTransfer(ToysTransfer, Bibber, Daf);         
            supervisor.SetCargoTransfer(MonkeyTransfer, Bibber, Zil);
            supervisor.SetDriverToWork(Bibber, false);
            supervisor.SetCargoTransfer(MonkeyTransfer, Bibber, Zil);
            supervisor.SetCargoTransfer(MonkeyTransfer, Zagoruiko, Daf);
            supervisor.SetCargoTransfer(MonkeyTransfer, Zagoruiko, Man);
            supervisor.AllTransfersRequestShow();

            Console.ReadKey();
        }
    }
}
