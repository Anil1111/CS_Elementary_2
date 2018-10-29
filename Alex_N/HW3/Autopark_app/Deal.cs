using System;

namespace Autopark_app
{
    class Deal
    {
        private string dealNumber;
        private Driver currentDriver;
        private Car currentCar;
        private int distance;
        private bool done;

        public bool IsDone {get{ return done; } }

        public Deal(Driver d, Car c, string dealNumber, int distance) //пользовательский конструкттор
        {

            if (d.Dismiss)
            {

            }
            else
            {
                currentDriver = d;
            }
            if (c.IsOnRepair)
            {

            }
            else
            {
                currentCar = c;
            }

            this.dealNumber = dealNumber;
            this.distance = distance;
            done = false;

            d.SetCar = c;
            c.SetDriver = d;
        }

        public string DealNumber { get { return dealNumber; } }

        public void Process()
        {
            if (!done & !currentDriver.Dismiss & !currentCar.IsOnRepair & !currentCar.IsBroken)
            {
                distance -= currentCar.KMPH;

                if (distance <= 0)
                {
                    currentDriver.SetCar = null;
                    currentCar.SetDriver = null;
                    done = true;
                }
            }
        }     

        public string Info()
        {
            string result = $"\nСДЕЛКА №: {dealNumber}.\nВЫПОЛНЯЕТ: {currentDriver.Name}.\nНОМЕР АВТО: {currentCar.ID}.\nСТАТУС: ";
            if (currentDriver.Dismiss)
            {
                result += "Не выполняется(Водитель отстранен)";
            }
            else
            {
                if (currentCar.IsOnRepair)
                {
                    result += "Не выполняется(Поломка авто)";
                }
                else
                {
                    result += "Выполняется";
                }
            }

            result += $"\nКМ. ДО ЗАВЕРШЕНИЯ: {distance}";

            return result;

        }

    }
}
