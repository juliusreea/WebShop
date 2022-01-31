using System;
using WebShop.ShopEngine;
using System.Collections.Generic;

namespace WebShop.GoodsRepository
{
    public class MeatRepository
    {
        public List<Meat> Meats;

        public MeatRepository()
        {
            Meats = new List<Meat>();
        }
        public List<Meat> LoadMeats()
        {
            var meat = new CsvEngine();
            Meats = meat.CsvReadFileMeat();
            return Meats;
        }
    }
}
