using System;
namespace WebShop
{
    public class Good
    {
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public double Weight { get; set; }
        public int Index { get; set; }

        public Good(decimal price, string barcode, double weight, int index)
        {
            Price = price;
            Barcode = barcode;
            Weight = weight;
            Index = index;
        }

        public Good()
        {
        }
    }
}
