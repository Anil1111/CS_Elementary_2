using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark_app
{
    class BaseBase
    {
        List<Driver> driverList;
        List<Car> carList;
        List<Deal> dealList;
        List<RepairBlank> repairBlanksList;

        public BaseBase()
        {
            driverList = new List<Driver>();
            carList = new List<Car>();
            dealList = new List<Deal>();
            repairBlanksList = new List<RepairBlank>();
        }

        public List<Driver> DriverList { get { return driverList; } set { driverList = value; } }
        public List<Car> CarList { get { return carList; }set{ carList = value; } }
        public List<Deal> DealList { get => dealList; set { dealList = value; } }
        public List<RepairBlank> RepairBlanksList { get { return repairBlanksList; }set { repairBlanksList = value; } }
    }
}
