using System;
namespace WebShop
{
    public class Meat : Good
    {
        public string Name { get; set; }
        public double Protein { get; set; }

        public Meat(string name, double protein, decimal price, string barcode, double weight, int index) : base(price, barcode, weight, index)
        {
            Name = name;
            Protein = protein;
        }

        public Meat()
        {
        }
    }
}
