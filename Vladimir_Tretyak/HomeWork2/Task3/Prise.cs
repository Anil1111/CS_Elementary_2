

namespace Task3
{
    class Prise
    {
        private string productName;
        private string nameOfshop;
        private double costOfgoods;
        //Свойства для полей
        public string ProductName { get => productName; set => productName = value; }
        public string NameOfshop { get => nameOfshop; set => nameOfshop = value; }
        public double CostOfgoods { get => costOfgoods; set => costOfgoods = value; }
        //Конструктор 
        public Prise(string productName, string nameOfshop, double costOfgoods)
        {
            ProductName = productName;
            NameOfshop = nameOfshop;
            CostOfgoods = costOfgoods;
        }
    }
}
