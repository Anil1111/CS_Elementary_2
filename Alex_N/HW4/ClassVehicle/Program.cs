using System;
using System.Collections.Generic;

namespace ClassVehicle
{
    class ProcessT
    {
        public List<Ship> shipList;
        public List<Car> carList;
        public List<Plane> planeList;


        public void AddVehicle(Ship s)//рас перегруз
        {
            shipList.Add(s);
        }
        public void AddVehicle(Car s)//два перегруз
        {
            carList.Add(s);
        }
        public void AddVehicle(Plane s)//три перегруз
        {
            planeList.Add(s);
        }

        public void ShowRules()
        {
            Console.WriteLine("\nShould input:\n1_Coordinate X.\n2_Cotdinate Y.\n3_Price.\n4_Speed\n5_Year of creation\n6_Is driver a dork(Only for Cars(0 or 1))\nPassengers(for Plane or Ship)\n7_Height(for Plane only) or Port(for Ship only)\n");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ProcessT p = new ProcessT();

            p.shipList = new List<Ship>();
            p.carList = new List<Car>();
            p.planeList = new List<Plane>();
            do
            {
                Console.Clear();
                Console.WriteLine("\nOptions:\n1: Add new Car...\n2: Add new Plane...\n3: Add new Ship...\n4: Show All infos");                
                switch (Console.ReadLine())

                {

                    case "1":
                        Console.Clear();
                        p.ShowRules();
                        p.AddVehicle(new Car(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
                        break;
                    case "2":
                        Console.Clear();
                        p.ShowRules();
                        p.AddVehicle(new Plane(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
                        break;
                    case "3":
                        Console.Clear();
                        p.ShowRules();
                        p.AddVehicle(new Ship(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Console.ReadLine()));
                        break;
                    case "4":
                        Console.Clear();
                        try
                        {
                            foreach (Ship s in p.shipList)
                            {
                                Console.WriteLine(s.info);
                            }
                        }
                        catch (Exception) { Console.WriteLine("Soorry. Have no Ships"); }
                        try
                        {
                            foreach (Car c in p.carList)
                            {
                                Console.WriteLine(c.info);
                            }
                        }
                        catch (Exception) { Console.WriteLine("Soorry. Have no Cars"); }
                        try
                        {
                            foreach (Plane pl in p.planeList)
                            {
                                Console.WriteLine(pl.info);
                            }
                        }
                        catch (Exception) { Console.WriteLine("Soorry. Have no Planes"); }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("ESC - EXIT...anyKey - Continue");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
