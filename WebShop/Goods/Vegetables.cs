using System;
namespace WebShop
{
    public class Vegetables : Good
    {
        public string Name { get; set; }
        public double Fibers { get; set; }

        public Vegetables(string name , double fibers, decimal price, string barcode , double weight, int index) : base(price, barcode, weight, index)
        {
            Name = name;
            Fibers = fibers;
        }

        public Vegetables()
        {
        }
        public override string ToString()
        {
            return $"{Name},{Fibers},{Price},{Barcode},{Weight},{Index}";
        }
    }
}
