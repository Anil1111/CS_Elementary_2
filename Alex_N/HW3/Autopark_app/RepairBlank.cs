using System;


namespace Autopark_app
{
    class RepairBlank
    {
        private string blankNumber;
        private Driver driver;
        private Car car;
        private bool done;
        private bool adminApprove;

        public bool Approve { set { adminApprove = value;} }

        public Car GetCar {get{ return car; } }

        public Driver GetDriver { get { return driver; } }

        public RepairBlank(Driver driver, Car car, string number)
        {
            blankNumber = number;
            this.driver = driver;
            this.car = car;
            done = false;
            adminApprove = false;
        }
        public string BlankNumber { get { return blankNumber; } }
        public bool IsDone { get { return done; } }

        public void statusChange()
        {
            if (!car.IsOnRepair & adminApprove)
            {
                done = true;                
            }
        }
                

        public string Info()
        {
            return String.Format($"Имя водителя:{driver.Name}\nНомер авто: {car.ID}");
        }

    }
}
