using System;

namespace ElectronicCommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products1 = new Products();
            products1.ProductID = 1;
            products1.ProductName = "İphone 11";
            products1.ExchangeType = "USD";
            products1.Price = 1000;

            Products products2 = new Products();
            products2.ProductID = 2;
            products2.ProductName = "Samsung Note8";
            products2.ExchangeType = "EUR";
            products2.Price = 750;

            Products products3 = new Products();
            products3.ProductID = 3;
            products3.ProductName = "Casper Via3";
            products3.ExchangeType = "TL";
            products3.Price = 800;

            Products[] urunler = new Products[] { products1, products2, products3};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.ProductID + " " + urun.ProductName + " " + urun.ExchangeType + " " + urun.Price);
            }
        }

        class Products
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string ExchangeType { get; set; }
            public int Price { get; set; }
        }
    }
}
