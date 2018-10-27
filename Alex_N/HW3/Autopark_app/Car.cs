using System;


namespace Autopark_app
{
    class Car
    {
        private bool broken;
        private bool onRepair;//тригер на ремонт 
        private string carType;//тип авто
        private string id;//номер авто...нехер не надо, я пошутил 
        private double health;//жизня
        private int kmToMaintenance;//ремонт и проверка каждые...
        private double healCoef;
        private int averageKmPH;//средняя скорость по трассе 
        private double wearOutMinus;//коефициент умнажения. для получения хп 

        private Driver driverOwner;

        public Driver SetDriver { set { driverOwner = value; } }

        public bool IsOnRepair { get { return onRepair; } set { onRepair = value; } }       

        public double Health { get { return health; } }

        public bool IsBroken { get { return broken; } }

        public int KMPH { get { return averageKmPH; } }

        public string ID { get => id; }


        public Car(string carType, string id, int kmToTO, int commonKmPH)//конструктор пользовательский
        {
            this.carType = carType;
            this.id = id;
            health = (double)100;
            kmToMaintenance = kmToTO;
            averageKmPH = commonKmPH;
            onRepair = false;
            wearOutMinus = health / kmToMaintenance;
            healCoef = kmToMaintenance / 100;
        }        
                
        public void Condition()
        {
            if (driverOwner != null)
            {
                if (broken)
                {

                }
                else
                {
                    if (onRepair)
                    {
                        kmToMaintenance = (int)(kmToMaintenance + healCoef);
                        health = kmToMaintenance * wearOutMinus;
                    }
                    else
                    {
                        kmToMaintenance -= averageKmPH;
                        health = kmToMaintenance * wearOutMinus;
                    }
                }
                if (health <= 0)
                {
                    broken = true;
                }
                if (health >= 100)
                {
                    health = 100;
                    onRepair = false;
                }
            }
                        
        }        

        public string Info()
        {
            string i = $"Тип авто: {carType}\nНомер авто: {id}\nСтатус: ";

            if (onRepair)
            {
                i = i +"На ремонте";
            }
            else
            {
                i = i +"В работе";
            }

            i +="\n" + health.ToString();
            i += "\n" + kmToMaintenance.ToString();
            i += "\n" + wearOutMinus.ToString();
            i += "\n" + healCoef.ToString();
            return i;
        }
    }
}
