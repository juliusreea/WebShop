using System;
namespace WebShop
{
    public class Drinks : Good
    {
        public string Name { get; set; }
        public double Liters { get; set; }

        public Drinks(string name = "", double liters =0, decimal price=0, string barcode = "", double weight=0) : base(price, barcode, weight)
        {
            Name = name;
            Liters = liters;
        }
    }
}
