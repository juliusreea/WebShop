using System;
namespace WebShop
{
    public class Vegetables : Good
    {
        public string Name { get; set; }
        public double Fibers { get; set; }

        public Vegetables() 
        {
            Name = "";
            Fibers = 0;
        }
    }
}
