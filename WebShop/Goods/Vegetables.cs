using System;
namespace WebShop
{
    public class Vegetables : Good
    {
        public string Name { get; set; }
        public double Fibers { get; set; }

        public Vegetables(string name = "", double fibers = 0, decimal price = 0, string barcode = "", double weight = 0, int index = 0) : base(price, barcode, weight, index)
        {
            Name = name;
            Fibers = fibers;
        }
    }
}
