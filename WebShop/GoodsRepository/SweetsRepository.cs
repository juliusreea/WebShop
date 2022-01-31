using System;
using System.Collections.Generic;
using WebShop.ShopEngine;
namespace WebShop.GoodsRepository
{
    public class SweetsRepository
    {
        public List<Sweets> Sweets;

        public SweetsRepository()
        {
            Sweets = new List<Sweets>();
        }
        public List<Sweets> LoadSweets()
        {
            var sweet = new CsvEngine();
            Sweets = sweet.CsvReadFileSweets();
            return Sweets;
        }
    }
}
