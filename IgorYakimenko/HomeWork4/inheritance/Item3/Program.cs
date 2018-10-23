using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item3
{
    class Program
    {
        // 3 - Создать класс Vehicle. В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
        //Создайте 3 производных класса Plane, Саг и Ship. Для класса Plane должна быть определена высота и количество пассажиров.
        //Для класса Ship — количество пассажиров и порт приписки. 
        //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

        static void Main(string[] args)
        {
            Console.WriteLine("Самолёт");
            Console.WriteLine("Характеристики самолёта");
            Plane plane = new Plane {Cost = 2000000,Height=3000,NumberOfPassengers = 20,Speed=500 ,YearManufacture = 2017};
            Console.WriteLine("Год выпуска: {0}", plane.YearManufacture.ToString());
            Console.WriteLine("Стоимость самолёта {0}:", plane.Cost.ToString());
            Console.WriteLine("Высота полёта {0}:", plane.Height.ToString());
            Console.WriteLine("Число пассажиров {0}:", plane.NumberOfPassengers.ToString());
            Console.WriteLine("Скорость {0}:", plane.Speed.ToString());
            Console.WriteLine(new string('-',50));
            Console.WriteLine("Машина");
            Console.WriteLine("Характеристики Машина");
            var car = new Car { Cost = 500000, YearManufacture = 2016, Speed = 220 };
            car.Coordinate(40000, 30000);
            Console.WriteLine("Стоимость машины {0}:", car.Cost.ToString());
            Console.WriteLine("Координаты машины X:{0},Y: {1}", car.CoordinateX.ToString(), car.CoordinateY.ToString());
            Console.WriteLine("Год выпуска: {0}", car.YearManufacture.ToString());
            Console.WriteLine("Скорость {0}:", car.Speed.ToString());
            Console.WriteLine(new string('-', 50));
            var ship = new Ship { Cost = 7000000, YearManufacture = 2000, Speed = 85, DestinationPort = "Турция" };
            Console.WriteLine("Корабль");
            Console.WriteLine("Характеристики корабля");
            Console.WriteLine("Стоимость корабля {0}:", ship.Cost.ToString());
            Console.WriteLine("Координаты машины X:{0},Y: {1}", ship.CoordinateX.ToString(), car.CoordinateY.ToString());
            Console.WriteLine("Год выпуска: {0}", ship.YearManufacture.ToString());
            Console.WriteLine("Скорость {0}:", ship.Speed.ToString());
            Console.WriteLine("Порт приписки {0}:", ship.DestinationPort.ToString());
            Console.Read();
        }
    }
}
