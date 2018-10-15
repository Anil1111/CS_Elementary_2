using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DispatchcerRequest> request = new List<DispatchcerRequest>();

            AddRequestToList(request, "Masha", "MotorBase Dnepr", 1235, "Vasya", "АЕ 9797 НС");
            AddRequestToList(request, "Masha", "MotorBase Dnepr", 1234, "Misha", "АЕ 9787 НС");


            DriverRequest driver1 = new DriverRequest(request[0], "Vasya");
            DriverRequest driver2 = new DriverRequest(request[1], "IVasyaa");
            DriverRequest driver3 = new DriverRequest(request[1], "Misha");

            driver1.MarkComleteWork(true, "always ok");
            driver3.RepairCar();
            Console.ReadKey();
        }

        static void AddRequestToList(List<DispatchcerRequest> list, string dispatcherName, string motorName, long requestNumber, string driverName, string carName)
        {
            DispatchcerRequest dr1 = new DispatchcerRequest(dispatcherName, motorName);
            dr1.AddRequest(requestNumber, driverName, carName);
            list.Add(dr1);
        }
    }
}
