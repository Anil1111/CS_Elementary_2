using System;


namespace Autopark_app
{
    class Driver
    {
        private bool dismiss;
        private string name;
        private bool repairRequest;
        Car officialCar;

        public Car GetCar {get { return officialCar; } }

        public bool RepairRequest { get { return repairRequest; } set { repairRequest = value; } }

        public string Name { get { return name; } }
        //
        //КОНСТРУКТОР
        //
        public Driver(string name)
        {
            this.name = name;
            repairRequest = false;
            officialCar = null;
        }

        public Car SetCar { set { officialCar = value; } }

        public bool Dismiss
        {

            get
            {               
                return dismiss;
            }
            set
            {

                dismiss = !dismiss;

            }

        }        

        public string Info()
        {
            string i = $"ФИО водителя: {name}";
            if (dismiss)
            {
               i=i+"\nСостояние: Отстранен";
            }
            else
            {
                i = i + "\nСостояние: Активен";
            }

            if (officialCar == null)
            {
                i = i + "\nСтатус: Не загружен";
            }
            else
            {
                i = i + "\nСтатус: В работе";
            }
            return i;
        }        

        public void CarCheck()
        {
            if (officialCar != null)
            {
                if (officialCar.Health < 20 & !officialCar.IsOnRepair)
                {
                    repairRequest = true;
                }
                else
                {
                    repairRequest = false;
                }
            }
        }

        


    }
}
