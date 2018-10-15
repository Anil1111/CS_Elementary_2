using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4._3.Classes;

//Создать класс Vehicle.В теле класса создайте поля: координаты и параметры средств 
//передвижения(цена, скорость, год выпуска). Создайте 3 производных класса Plane, 
//Саг и Ship.Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.Написать программу,
//которая выводит на экран информацию о каждом средстве передвижения.

namespace Task4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane boing777 = new Plane(100,100, 1000000, 900, 2015, 10000, 350);
            Car bmw = new Car(50, 50, 50000, 200, 2017);
            Ship QueenElizabethII = new Ship(250, 250, 25000000, 30, 2000, 3000, "London");
            boing777.ShowVehicle();
            bmw.ShowVehicle();
            QueenElizabethII.ShowVehicle();
            Console.ReadKey();
        }
    }
}
