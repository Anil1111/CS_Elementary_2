namespace ConsoleApp8
{
    class Beyblade : Product
    {
        public double Power { get; set; }

        public Beyblade(string name, double price, string manufacturer, double power)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Power = power;
        }
    }
}
