using System;
namespace WebShop
{
    public class Drinks : Good
    {
        public string Name { get; set; }
        public double Liters { get; set; }

        public Drinks(string name, double liters, decimal price, string barcode, double weight, int index) : base(price, barcode, weight, index)
        {
            Name = name;
            Liters = liters;
        }

        public Drinks()
        {
        }
    }
}
