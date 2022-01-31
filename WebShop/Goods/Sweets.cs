using System;

namespace WebShop
{
    public class Sweets :Good
    {
        public string Name { get; set; }
        public double Carbohydrates { get; set; }

        public Sweets()
        {
            Name = "";
            Carbohydrates = 0;
        }
    }
}
