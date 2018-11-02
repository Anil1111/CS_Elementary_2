using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4.Classes
{
    public class Products
    {
        public List<Product> listProducts;

        public Products() => listProducts = new List<Product>();

        public static void ShowProducts(string message, List<Product> listProducts)
        {
            Console.WriteLine(message);
            Console.WriteLine(new string('-', 70));
            foreach (Product product in listProducts)
            {
                product.ShowProduct();
                Console.WriteLine(new string('-', 70));
            }
        }
    }
}
