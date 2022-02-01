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
                Console.WriteLine($"{drink.Name}, Volume: {drink.Liters}, Price: {drink.Price}, Barcode: {drink.Barcode}, Weight: {drink.Weight}");
            }
        }
        public void SweetsPrinter()
        {
            var sweets = new SweetsRepository();
            var sweetsList = sweets.LoadSweets();
            foreach (var sweet in sweetsList)
            {
                Console.WriteLine($"{sweet.Name}, Amount of Sugars: {sweet.Carbohydrates}, Price: {sweet.Price}, Barcode: {sweet.Barcode}, Weight: {sweet.Weight}");
            }
        }
        public void VegetablesPrinter()
        {
            var vegetable = new VegetablesRepository();
            var veggieList = vegetable.LoadVegetables();
            foreach (var veggie in veggieList)
            {
                Console.WriteLine($"{veggie.Name}, Fibers: {veggie.Fibers}, Price: {veggie.Price}, Barcode: {veggie.Barcode}, Weight: {veggie.Weight}");
            }
        }
        public void MeatPrinter()
        {
            var meats = new MeatRepository();
            var meatList = meats.LoadMeats();
            foreach (var meat in meatList)
            {
                Console.WriteLine($"{meat.Name}, Proteins: {meat.Protein}, Price: {meat.Price}, Barcode: {meat.Barcode}, Weight: {meat.Weight}");
            }
        }
        public void AllGoodsPrinter()
        {
            DrinksPrinter();
            SweetsPrinter();
            VegetablesPrinter();
            MeatPrinter();
        }
    }
}
