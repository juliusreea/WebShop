using System;
using WebShop.ShopEngine;
using System.Collections.Generic;

namespace WebShop.GoodsRepository
{
    public class VegetablesRepository
    {
        public List<Vegetables> Veggies;

        public VegetablesRepository()
        {
            Veggies = new List<Vegetables>();
        }
        public List<Vegetables> LoadVegetables()
        {
            var veggie = new CsvEngine();
            Veggies = veggie.CsvReadFileVegetables();
            return Veggies;
        }
    }
}
