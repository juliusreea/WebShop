using System;
namespace WebShop
{
    public class Meat : Good
    {
        public string Name { get; set; }
        public double Protein { get; set; }

        public Meat()
        {
            Name = "";
            Protein = 0;
        }
    }
}
