using System;

namespace WebShop
{
    public class Sweets :Good
    {
        public string Name { get; set; }
        public double Carbohydrates { get; set; }

        public Sweets(string name, double carbohydrates, decimal price, string barcode, double weight, int index) : base(price, barcode, weight, index)
        {
            Name = name;
            Carbohydrates = carbohydrates;
        }

        public Sweets()
        {
        }
    }
}
