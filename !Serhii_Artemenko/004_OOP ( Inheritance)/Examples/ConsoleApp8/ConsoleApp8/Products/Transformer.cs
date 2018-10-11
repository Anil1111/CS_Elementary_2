namespace ConsoleApp8
{
    class Transformer : Product
    {
        public string ClassOfFighter { get; set; }

        public Transformer(string name, double price, string manufacturer, string classOfFighter)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            ClassOfFighter = classOfFighter;
        }
    }
}
