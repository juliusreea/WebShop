using System;
using WebShop.GoodsRepository;
using WebShop.ShopEngine;

namespace WebShop.ShopEngine
{
    public class Printer
    {
        public void DrinksPrinter()
        {
            var drinks = new DrinksRepository();
            var drinkList = drinks.LoadDrinks();
            foreach(var drink in drinkList)
            {
                Console.WriteLine($"{drink.Name}, \nVolume: {drink.Liters} ,\nPrice: {drink.Price},\nBarcode: {drink.Barcode},\nWeight: {drink.Weight}");
            }
        }
        public void SweetsPrinter()
        {
            var sweets = new SweetsRepository();
            var sweetsList = sweets.LoadSweets();
            foreach (var sweet in sweetsList)
            {
                Console.WriteLine($"{sweet.Name}, \nAmount of Sugars: {sweet.Carbohydrates} ,\nPrice: {sweet.Price},\nBarcode: {sweet.Barcode},\nWeight: {sweet.Weight}");
            }
        }
        public void VegetablePrinter()
        {
            var vegetable = new VegetablesRepository();
            var veggieList = vegetable.LoadVegetables();
            foreach (var veggie in veggieList)
            {
                Console.WriteLine($"{veggie.Name}, \nFibers: {veggie.Fibers} ,\nPrice: {veggie.Price},\nBarcode: {veggie.Barcode},\nWeight: {veggie.Weight}");
            }
        }
        public void MeatPrinter()
        {
            var meats = new MeatRepository();
            var meatList = meats.LoadMeats();
            foreach (var meat in meatList)
            {
                Console.WriteLine($"{meat.Name}, \nProteins: {meat.Protein} ,\nPrice: {meat.Price},\nBarcode: {meat.Barcode},\nWeight: {meat.Weight}");
            }
        }
        public void AllGoodsPrinter()
        {
            DrinksPrinter();
            SweetsPrinter();
            VegetablePrinter();
            MeatPrinter();
        }
    }
}
