using System;
namespace WebShop
{
    public class Good
    {
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public double Weight { get; set; }

        public Good(decimal price =0, string barcode = "", double weight = 0)
        {
            Price = price;
            Barcode = barcode;
            Weight = weight;
        }
    }
}
