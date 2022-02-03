using System;
using System.Collections.Generic;
using WebShop.ShopEngine;
using WebShop.GoodsRepository;

namespace WebShop.ShopEngine
{
    public class Cart : Good
    {
        public string Name;
        public Cart(string name, decimal price, string barcode, double weight, int index) : base(price, barcode, weight, index)
        {
            Name = name;
        }
        public Cart()
        {
        }
        
        public override string ToString()
        {
            return $"{Name},{Price},{Barcode},{Weight},{Index}";
        }
    }
}
