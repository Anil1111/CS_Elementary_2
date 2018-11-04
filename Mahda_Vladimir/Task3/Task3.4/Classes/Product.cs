using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4.Classes
{
    public class Product
    {
        private string productTitle;
        private double productPrice;
        private string productDescription;
        private double productQuantity;

        public Product(string productTitle, double productPrice, string productDescription, double productQuantity)
        {
            this.productTitle = productTitle;
            this.productPrice = productPrice;
            this.productDescription = productDescription;
            this.productQuantity = productQuantity;
        }

        public string ProductTitle { get => productTitle; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
        public string ProductDescription { get => productDescription; }
        public double ProductQuantity { get => productQuantity; set => productQuantity = value; }

        public void ShowProduct()
        {
            Console.WriteLine($"Product: {ProductTitle} | Price: {ProductPrice} | Description: {ProductDescription} | Quantity: {ProductQuantity}");
        }
    }
}
