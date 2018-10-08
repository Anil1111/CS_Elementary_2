namespace ConsoleApp8
{
    class Dolls : Product
    {
        public string Material { get; private set; }

        public Dolls(string name, double price, string manufacturer, string material)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Material = material;
        }
    }
}
