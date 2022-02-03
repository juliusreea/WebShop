using System;
using System.Collections.Generic;
using WebShop.ShopEngine;
using WebShop.GoodsRepository;

namespace WebShop.ShopEngine
{
    public class Cart : Good
    {
        public string Name;
        public string Specific;
        public Cart(string name, string specific, decimal price, string barcode, double weight, int index) : base(price, barcode, weight, index)
        {
            Name = name;
            Specific = specific;
        }
        public Cart()
        {
        }
        
        public override string ToString()
        {
            return $"{Name}{Price}{Barcode}{Weight}{Index}";
        }
    }
}
