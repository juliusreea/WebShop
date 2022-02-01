using System;
namespace WebShop
{
    public class Meat : Good
    {
        public string Name { get; set; }
        public double Protein { get; set; }

        public Meat(string name = "", double protein = 0, decimal price = 0, string barcode = "", double weight = 0, int index=0) : base(price, barcode, weight, index)
        {
            Name = name;
            Protein = 0;
        }
    }
}
