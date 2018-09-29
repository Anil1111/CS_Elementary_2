using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prise
{
    class Prise
    {
        private string productName;
        private string shopName;
        private int productPrise;

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public string ShopName
        {
            get
            {
                return shopName;
            }
            set
            {
                shopName = value;
            }
        }

        public int ProductPrise
        {
            get
            {
                return productPrise;
            }
            set
            {
                productPrise = value;
            }
        }

        public Prise()
        {
            ProductName = "Default product name";
            ShopName = "Default shop name";
            ProductPrise = 0;
        }
        public Prise(string productName, string shopName, int productPrise)
        {
            ProductName = productName;
            ShopName = shopName;
            ProductPrise = productPrise;
        }

        public override string ToString()
        {
            return string.Format("Product name "+ this.ProductName + " Shop name " + this.ShopName + " product prise "+ this.ProductPrise);
        }
    }
}
