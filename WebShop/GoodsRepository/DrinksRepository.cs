using System;
using System.Linq;
using System.Collections.Generic;
using WebShop.ShopEngine;
namespace WebShop.GoodsRepository
{
    public class DrinksRepository
    {
        public List<Drinks> Drinks;

        public DrinksRepository()
        {
            Drinks = new List<Drinks>();
        }
        public List<Drinks> LoadDrinks()
        {
            var drink = new CsvEngine();
            Drinks = drink.CsvReadFileDrinks();
            return Drinks;
        }
    }
}
